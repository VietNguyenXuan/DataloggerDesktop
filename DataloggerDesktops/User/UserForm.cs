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
using static System.Windows.Forms.DataFormats;

namespace DataloggerDesktops.User
{
  public partial class UserForm : Form
  {
    public UserForm()
    {
      InitializeComponent();
    }

    RepositoryUserHisrorical _managerUserHisrorical=new RepositoryUserHisrorical();
    private void UserForm_Load(object sender, EventArgs e)
    {
      lbNameLogIn.Text= _managerUserHisrorical.GetNameLogInCurrent()[0];
    }

    
    private void btnLogOut_Click(object sender, EventArgs e)
    {
      //this.Close();
      //this.Hide();

      //FormMain frmMain=new FormMain();
      //frmMain.Closed += (s, args) => this.Close();
      //frmMain.Close();


      //LogIn frmLogIn = new LogIn();

      //frmLogIn.ShowDialog();

      //this.Hide();
      //Form1 a = new Form1();
      //a.Closed += (s, args) => this.Close();
      //a.Show();
    }
  }
}
