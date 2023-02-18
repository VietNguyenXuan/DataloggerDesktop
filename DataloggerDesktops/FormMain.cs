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
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    // funstion off boading buttons
    private void OffButtonBord(Button button)
    {
      button.TabStop = false;
      button.FlatStyle = FlatStyle.Flat;
      button.FlatAppearance.BorderSize = 0;
      button.TextAlign = ContentAlignment.MiddleLeft;
    }

    // transfer forms
    private Form currentFormChild;
    private void openFormChild(Form formChild)
    {
      if (currentFormChild != null)
      {
        currentFormChild.Close();
      }
      currentFormChild = formChild;
      formChild.TopLevel = false;
      formChild.FormBorderStyle = FormBorderStyle.None;
      formChild.Dock = DockStyle.Fill;
      panelBody.Controls.Add(formChild);
      panelBody.Tag = formChild;
      formChild.BringToFront();
      formChild.Show();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      FormBorderStyle = FormBorderStyle.Sizable;
      WindowState = FormWindowState.Maximized;

      // Tắt đường viền nút nhấn
      OffButtonBord(btnDashBoard);
      OffButtonBord(btnHistorical);
      OffButtonBord(btnStatistics);
      OffButtonBord(btnSetting);


      OffButtonBord(btnSetting);
      OffButtonBord(btnSetting);
      OffButtonBord(btnSetting);
      OffButtonBord(btnSetting);

      //OffButtonBord(btn_parametter);
      //OffButtonBord(btn_device);
      //OffButtonBord(btn_user);

      //OffButtonBord(button_tab);

      //btn_parametter.Visible = false;
      //btn_device.Visible = false;
      //btn_user.Visible = false;

      //// Thiết lập màu cho panel mode
      //panel_control.BackColor = Color.FromArgb(4, 25, 61);
      //panel_heading.BackColor = Color.FromArgb(12, 21, 53);
      ////panel_full_body.BackColor = Color.FromArgb(4, 25, 61);
      //panel_tab.BackColor = Color.FromArgb(4, 25, 61);

      //button_tab.BackColor = Color.FromArgb(8, 46, 112);

      //// Thiết lập màu chữ
      //button_tab.ForeColor = Color.FromArgb(255, 255, 255);

      //btn_dashboard.ForeColor = Color.FromArgb(255, 255, 255);
      //btn_historical.ForeColor = Color.FromArgb(255, 255, 255);
      //btn_statistics.ForeColor = Color.FromArgb(255, 255, 255);
      //btn_setting.ForeColor = Color.FromArgb(255, 255, 255);
      //btn_parametter.ForeColor = Color.FromArgb(255, 255, 255);
      //btn_device.ForeColor = Color.FromArgb(255, 255, 255);
      //btn_user.ForeColor = Color.FromArgb(255, 255, 255);




      // Khi chạy mặc định vào form dashboard
      //btn_dashboard.PerformClick();

      // load image
      //pictureBox_tab.Image = new Bitmap(Application.StartupPath + "\\Resources\\collapse_icon.png");
      //pictureBox_tab.SizeMode = PictureBoxSizeMode.StretchImage;


      // Minh Khùng
      // Đức báo đời 
    }
  }
}
