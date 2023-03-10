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
using CodeBeautify;

using MQTTChanel;
using CodeBeautify;
using System.Runtime.Intrinsics.X86;
using DataloggerDesktops.Models;
using DataloggerDesktops.User;

namespace DataloggerDesktops
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }
    


    MQTTClass mqttClass = new MQTTClass();

   


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
      //mqttClass.Connect();
      //tmrUpdateMQTT.Start();

      //FormBorderStyle = FormBorderStyle.Sizable;
      //WindowState = FormWindowState.Maximized;

      // Tắt đường viền nút nhấn
      OffButtonBord(btnDashBoard);
      OffButtonBord(btnHistorical);
      OffButtonBord(btnStatistics);
      OffButtonBord(btnSetting);

      OffButtonBord(btnParameter);
      OffButtonBord(btnDevice);
      OffButtonBord(btnUser);

      OffButtonBord(btnTab);

      btnParameter.Visible = false;
      btnDevice.Visible = false;
      btnUser.Visible = false;

      btnTab.BackColor = Color.FromArgb(8, 46, 112);

      // Khi chạy mặc định vào form dashboard
      //btnDashBoard.PerformClick();

      //btnSetting.PerformClick();
      //btnDevice.PerformClick();

      btnSetting.PerformClick();
      btnUser.PerformClick();

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
      //_isStatusTab = !_isStatusTab;

      //if (_isStatusTab)
      //{
      //  panelControl.Size = new Size(155, 667);
      //  panelTab.Size = new Size(155, 50);
      //  btnTab.Location = new Point(115, 0);

      //  btnTab.Text = "<";
      //  //pictureBox_tab.Image = new Bitmap(Application.StartupPath + "\\Resources\\collapse_icon.png");
      //}
      //else
      //{
      //  panelControl.Size = new Size(0, 667);
      //  panelTab.Size = new Size(100, 50);
      //  btnTab.Location = new Point(0, 0);

      //  btnTab.Text = ">";
      //}
    }

    //string[] Name =
    //{
    //  "Magnetometer - X (Avg)",
    //  "Magnetometer - X(Std)",
    //  "Magnetometer - X(RMS)",
    //  "Accelerometer(Secondary) - X(Avg)",
    //  "Accelerometer(Secondary) - X(Std)",
    //  "Accelerometer(Secondary) - X(RMS)",
    //  "Accelerometer(Primary) - X(Avg)",
    //  "Accelerometer(Primary) - X(Std)",
    //  "Accelerometer(Primary) - X(RMS)",
    //  "Temperature",
    //  "Microphone - Avg",
    //  "Microphone - Std",
    //  "Microphone - RMS"
    //};


    //string[] Name = new string[13];
    //string[] Description = new string[13];
    //string[] Value = new string[13];


    //string stringJson;
    //string pl = "[{\"sensors\":[{\"Name\":\"Magnetometer\",\"registers\":[{\"Name\":\"Magnetometer - X (Avg)\",\"Description\":\"ac\",\"Value\":8960},{\"Name\":\"Magnetometer - X (Std)\",\"Description\":\"ac\",\"Value\":256},{\"Name\":\"Magnetometer - X (RMS)\",\"Description\":\"ac\",\"Value\":8960}],\"Description\":null},{\"Name\":\"Accelerometer\",\"registers\":[{\"Name\":\"Accelerometer (Secondary) - X (Avg)\",\"Description\":\"ac\",\"Value\":7936},{\"Name\":\"Accelerometer (Secondary) - X (Std)\",\"Description\":\"ac\",\"Value\":512},{\"Name\":\"Accelerometer (Secondary) - X (RMS)\",\"Description\":\"ac\",\"Value\":7936}],\"Description\":null},{\"Name\":\"Accelerometer (Primary)\",\"registers\":[{\"Name\":\"Accelerometer (Primary) - X (Avg)\",\"Description\":\"ac\",\"Value\":0},{\"Name\":\"Accelerometer (Primary) - X (Std)\",\"Description\":\"ac\",\"Value\":0},{\"Name\":\"Accelerometer (Primary) - X (RMS)\",\"Description\":\"ac\",\"Value\":1280}],\"Description\":null},{\"Name\":\"Temperature\",\"registers\":[{\"Name\":\"Temperature\",\"Description\":\"ac\",\"Value\":192}],\"Description\":null},{\"Name\":\"Microphone\",\"registers\":[{\"Name\":\"Microphone - Avg\",\"Description\":\"ac\",\"Value\":256},{\"Name\":\"Microphone - Std\",\"Description\":\"ac\",\"Value\":6912},{\"Name\":\"Microphone - RMS\",\"Description\":\"ac\",\"Value\":6912}],\"Description\":null}],\"Id\":\"00000000-0000-0000-0000-000000000000\",\"CreateDate\":\"0001-01-01T00:00:00Z\",\"UpdateDate\":\"0001-01-01T00:00:00Z\",\"Name\":null}]";
    
    private void tmrUpdateMQTT_Tick(object sender, EventArgs e)
    {
      //ReadMQTT();

      //WriteDB();

      //ReadMQTT_WriteDB();

      //ReadDb();

    }


    public void ReadMQTT_WriteDB()
    {
      //mqttClass.publish("A", pl);
      //mqttClass.subcribe("A");
      //stringJson = mqttClass.payloadResult();
      //txb.Text = stringJson;

      //if (string.IsNullOrWhiteSpace(stringJson)) return;
      //var dataMQTT = Welcome2.FromJson(stringJson);
      //var listObj = dataMQTT.FirstOrDefault().Sensors.SelectMany(s => s.Registers);


      //this.dataGridView1.DataSource = listObj.ToList();
      
      //var arrlistObj = listObj.ToArray();

      
      //for (int i = 0; i < 13; i++)
      //{
      //  try
      //  {


      //    Name[i] = arrlistObj[i].Name.ToString();
      //    //Description[i] = arrlistObj[i].Description.ToString();
      //    //Value[i] = arrlistObj[i].Value.ToString();

      //    // Send DB
      //    //Line dBiComox = new Line();
      //    //dBiComox.registerAddress = arrlistObj[i].Name.ToString();
      //    //dBiComox.registerDescription = arrlistObj[i].Description.ToString();
      //    //dBiComox.registerValue = arrlistObj[i].Value.ToString();
      //    //dBiComox.dateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");



      //    if (_registerManager.AddData(dBiComox))
      //    {
      //      //MessageBox.Show("Data has been saved database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //    }
      //    else
      //    {
      //      MessageBox.Show("Data saved database failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //    }
      //  }
      //  catch (Exception ex)
      //  {
      //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      //  }

      //}
    }

    public void ReadDb()
    {
      //dataGridView1.Rows.Clear();

      //for (int i = 0; i < 13; i++)
      //{
      //  try
      //  {
      //    var db = _registerManager.GetData(Name[i]);
      //    dataGridView1.Rows.Add(db[0].registerAddress, db[0].registerValue);
      //  }
      //  catch (Exception ex)
      //  {
      //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      //  }
      //}

      ////try
      ////{
      ////  var db = _registerManager.GetData(Name[0]);
      ////  dataGridView1.Rows.Add(db[0].registerAddress, db[0].registerValue);
      ////  //dataGridView1.DataSource= db.ToList();

      ////}
      ////catch (Exception ex)
      ////{
      ////  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      ////}
    }

    private void picUser_Click(object sender, EventArgs e)
    {
      UserForm frmUser = new UserForm();
      frmUser.ShowDialog();
    }
  }
}
