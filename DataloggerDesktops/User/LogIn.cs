using DataloggerDesktops.Models;
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

namespace DataloggerDesktops.User
{
  public partial class LogIn : Form
  {
    public LogIn()
    {
      InitializeComponent();
    }

    
    private void btnLogIn_Click(object sender, EventArgs e)
    {
      try
      {
        RepositoryUser _managerUsers = new RepositoryUser();
        var NameLogIn = _managerUsers.GetNameUsers();

        if (NameLogIn != null)
        {
          


          foreach (var User in NameLogIn)
          {
            if (User == txbLogInName.Text)
            {
              if (_managerUsers.GetPassByName(User.ToString())[0].ToString() != txbPass.Text)
              {
                MessageBox.Show("Mật khẩu sai");
                txbPass.Text = string.Empty;
              }
              else
              {
                // Thêm dữ liệu xuống db đã đăng nhập vào hệ thống
                RepositoryUserHisrorical _managerUserHisrorical = new RepositoryUserHisrorical();
                UserHistorical user = new UserHistorical();
                user.NameLogIn = txbLogInName.Text;
                user.DateLogIn = DateTime.Now;
                _managerUserHisrorical.Add(user);


                //this.Hide();

                FormMain frmMain = new FormMain();
                frmMain.Show();

                //frmMain=null;
                //this.Show();





                return;
              }

            }
          }
          MessageBox.Show("Tên đăng nhập sai"); return;
        }
        else return;
      }
      catch (Exception)
      {
        throw;
      }


    }

    private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }

    private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
    {
      
    }
  }
}
