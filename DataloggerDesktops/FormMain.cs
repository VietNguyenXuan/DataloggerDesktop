using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
      //FormBorderStyle = FormBorderStyle.Sizable;
      //WindowState = FormWindowState.Maximized;

      // Tắt đường viền nút nhấn
      OffButtonBord(btnDashBoard);
      OffButtonBord(btnHistorical);
      OffButtonBord(btnStatistics);
      OffButtonBord(btnSetting);


      OffButtonBord(btnSetting);
      OffButtonBord(btnSetting);
      OffButtonBord(btnSetting);
      OffButtonBord(btnSetting);

      OffButtonBord(btnParameter);
      OffButtonBord(btnDevice);
      OffButtonBord(btnUser);

      OffButtonBord(btnTab);

      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;

      // Thiết lập màu cho panel mode
      panelControl.BackColor = Color.FromArgb(4, 25, 61);
      panelHeading.BackColor = Color.FromArgb(12, 21, 53);
      panelTab.BackColor = Color.FromArgb(4, 25, 61);
      panelBody.BackColor = Color.FromArgb(4, 25, 61);

      btnTab.BackColor = Color.FromArgb(8, 46, 112);

      // Thiết lập màu chữ
      btnTab.ForeColor = Color.FromArgb(255, 255, 255);

      btnDashBoard.ForeColor = Color.FromArgb(255, 255, 255);
      btnHistorical.ForeColor = Color.FromArgb(255, 255, 255);
      btnStatistics.ForeColor = Color.FromArgb(255, 255, 255);
      btnSetting.ForeColor = Color.FromArgb(255, 255, 255);
      btnParameter.ForeColor = Color.FromArgb(255, 255, 255);
      btnDevice.ForeColor = Color.FromArgb(255, 255, 255);
      btnUser.ForeColor = Color.FromArgb(255, 255, 255);

      // Khi chạy mặc định vào form dashboard
      btnDashBoard.PerformClick();

      // load image
      //pictureBox_tab.Image = new Bitmap(Application.StartupPath + "\\Resources\\collapse_icon.png");
      //pictureBox_tab.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void btnDashBoard_Click(object sender, EventArgs e)
    {
      openFormChild(new DashBoard());

      btnDashBoard.BackColor = Color.FromArgb(8, 46, 112);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(4, 25, 61);

      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;
    }

    private void btnHistorical_Click(object sender, EventArgs e)
    {
      openFormChild(new Historical());

      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(8, 46, 112);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(4, 25, 61);

      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;
    }

    private void btnStatistics_Click(object sender, EventArgs e)
    {
      openFormChild(new Statistics());

      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(8, 46, 112);
      btnSetting.BackColor = Color.FromArgb(4, 25, 61);

      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;
    }

    private void btnSetting_Click(object sender, EventArgs e)
    {
      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(8, 46, 112);

      btnParameter.Visible = true;
      btnDevice.Visible = true;
      btnUser.Visible = true;
    }

    private void btnParameter_Click(object sender, EventArgs e)
    {
      openFormChild(new SettingParametter());

      btnDashBoard.BackColor = Color.FromArgb(4, 25, 61);
      btnHistorical.BackColor = Color.FromArgb(4, 25, 61);
      btnStatistics.BackColor = Color.FromArgb(4, 25, 61);
      btnSetting.BackColor = Color.FromArgb(8, 46, 112);

      btnParameter.BackColor = Color.FromArgb(8, 46, 112);
      btnDevice.BackColor = Color.FromArgb(4, 25, 61);
      btnUser.BackColor = Color.FromArgb(4, 25, 61);
    }

    private void btnDevice_Click(object sender, EventArgs e)
    {
      openFormChild(new SettingDevice());

      btnParameter.BackColor = Color.FromArgb(4, 25, 61);
      btnDevice.BackColor = Color.FromArgb(8, 46, 112);
      btnUser.BackColor = Color.FromArgb(4, 25, 61);
    }

    private void btnUser_Click(object sender, EventArgs e)
    {
      openFormChild(new SettingUser());

      btnParameter.BackColor = Color.FromArgb(4, 25, 61);
      btnDevice.BackColor = Color.FromArgb(4, 25, 61);
      btnUser.BackColor = Color.FromArgb(8, 46, 112);
    }

    bool _isStatusTab = true;
    private void btnTab_Click(object sender, EventArgs e)
    {
      _isStatusTab = !_isStatusTab;

      if (_isStatusTab)
      {
        panelControl.Size = new Size(155, 667);
        panelTab.Size = new Size(155, 50);
        btnTab.Location = new Point(115, 0);

        btnTab.Text = "<";
        //pictureBox_tab.Image = new Bitmap(Application.StartupPath + "\\Resources\\collapse_icon.png");
      }
      else
      {
        panelControl.Size = new Size(0, 667);
        panelTab.Size = new Size(100, 50);
        btnTab.Location = new Point(0, 0);

        btnTab.Text = ">";
      }
    }
  }
}
