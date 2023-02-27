using DataloggerDesktops.Manager;
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

    RegisterManager _registerManager = new RegisterManager();



    private void DashBoard_Load(object sender, EventArgs e)
    {

    }

    private void tmrDashBoard_Tick(object sender, EventArgs e)
    {
      try
      {
        var db = _registerManager.GetData("Temperature");
        circularProgressBarTemp.Text = db[0].registerValue.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
