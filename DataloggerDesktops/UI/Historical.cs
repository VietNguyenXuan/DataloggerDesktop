
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

   

    private void Historical_Load(object sender, EventArgs e)
    {
      LoadData();
    }
    private void tmrHistorical_Tick(object sender, EventArgs e)
    {
      LoadData();
    }

    public void LoadData()
    {
      try
      {
        // Load từ database lên gồm temp và speed
        var valuesTemp = _managerParalog.GetValuesByIdParametter(10);
        var valuesSpeed = _managerParalog.GetValuesByIdParametter(4);

        // Load lên datagridview
        for (int i = 0; i < 10; i++)
        {
          // temp
          dgvTemp.Rows.Add(i + 1, valuesTemp[i].DateCreate, valuesTemp[i].Value);

          // speed
          dgvSpeed.Rows.Add(i + 1, valuesSpeed[i].DateCreate, valuesSpeed[i].Value);
        }


        // Load lên chart
        chartTemp.Series["Nhiệt độ"].Points.Clear();
        chartSpeed.Series["Tốc độ"].Points.Clear();
        for (int i = 1; i <= 24; i++)
        {
          // temp
          var dataTemp = _managerParalog.iChart(10,i);
          if (dataTemp != null)
          {
            chartTemp.Series["Nhiệt độ"].Points.AddXY(dataTemp.DateCreate.Hour.ToString()+":00", dataTemp.Value);
          }
          // speed
          var dataSpeed = _managerParalog.iChart(4, i);
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
