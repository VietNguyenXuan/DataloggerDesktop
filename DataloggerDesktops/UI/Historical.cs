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

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    ///*RegisterM*/anager _registerManager = new RegisterManager();
    private void Historical_Load(object sender, EventArgs e)
    {

      //try
      //{
      //  var db = _registerManager.GetData("Temperature");
      //  for (int i = 0;i < db.Count; i++)
      //  {
      //    dataGridViewTemp.Rows.Add(i+1 , db[i].dateTime, db[i].registerValue);
      //  }
        
      //}
      //catch (Exception ex)
      //{
      //  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      //}
    }
  }
}
