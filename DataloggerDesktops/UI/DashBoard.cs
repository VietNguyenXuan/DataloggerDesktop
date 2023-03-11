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
  public partial class DashBoard : Form
  {
    public DashBoard()
    {
      InitializeComponent();
    }

    RepositoryParametterLog _managerParalog=new RepositoryParametterLog();

    private void DashBoard_Load(object sender, EventArgs e)
    {
      LoadValueTemp();
    }

    private void tmrDashBoard_Tick(object sender, EventArgs e)
    {
      LoadValueTemp();
    }


    public void LoadValueTemp()
    {
      try
      {
        cpbTemp.Text = _managerParalog.GetValuesByIdParametter(9)[0].Value.ToString();
        cpbSpeed.Text = _managerParalog.GetValuesByIdParametter(3)[0].Value.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
