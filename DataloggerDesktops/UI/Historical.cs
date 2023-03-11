using DataloggerDesktops.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
          dgvTemp.Rows.Add(i + 1, valuesTemp[i].DateCreate, valuesTemp[i].Value);
          dgvSpeed.Rows.Add(i + 1, valuesSpeed[i].DateCreate, valuesSpeed[i].Value);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }



  }
}
