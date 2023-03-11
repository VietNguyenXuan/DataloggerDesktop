
using DataloggerDesktops.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataloggerDesktops
{
  public partial class Historical : Form
  {
    public Historical()
    {
      InitializeComponent();
    }
    RepositoryParametterLog _managerParalog = new RepositoryParametterLog();

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Historical_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    public void LoadData()
    {
      try
      {
        var valuesTemp = _managerParalog.GetValuesByIdParametter(9);
        var valuesSpeed = _managerParalog.GetValuesByIdParametter(3);

        
        for (int i = 0; i < 10; i++)
        {
          // temp
          dgvTemp.Rows.Add(i + 1, valuesTemp[i].DateCreate, valuesTemp[i].Value);

          // speed
          dgvSpeed.Rows.Add(i + 1, valuesSpeed[i].DateCreate, valuesSpeed[i].Value);
        }

        for (int i = 1; i <= 24; i++)
        {
          // temp
          var dataTemp = _managerParalog.iChart(9,i);
          if (dataTemp != null)
          {
            chartTemp.Series["Nhiệt độ"].Points.AddXY(dataTemp.DateCreate.Hour.ToString()+":00", dataTemp.Value);
          }
          // speed
          var dataSpeed = _managerParalog.iChart(3, i);
          if (dataSpeed != null)
          {
            chartSpeed.Series["Tốc độ"].Points.AddXY(dataSpeed.DateCreate.Hour.ToString() + ":00", dataSpeed.Value);
          }
        }


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      

    }



  }
}
