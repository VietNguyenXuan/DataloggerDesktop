using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using DataloggerDesktops.UI;
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
  public partial class SettingDevice : Form
  {
    public SettingDevice()
    {
      InitializeComponent();
    }

    private void SettingDevice_Load(object sender, EventArgs e)
    {
      cbDisplay.SelectedIndex= 0;

      tmrUpdateData.Start();
    }

    private void lbAddFactory_Click(object sender, EventArgs e)
    {
      AddFactoryForm frm = new AddFactoryForm();
      frm.ShowDialog();
    }
    private void lbAddLine_Click(object sender, EventArgs e)
    {
      AddLineForm frm = new AddLineForm();
      frm.ShowDialog();
    }
    private void lbAddDevice_Click(object sender, EventArgs e)
    {
      AddDeviceForm frm = new AddDeviceForm();
      frm.ShowDialog();
    }


    //public int viewSettingDevice;
   
    public void lbSeeMoreFatory_Click(object sender, EventArgs e)
    {
      ViewSettingDeviceForm frm = new ViewSettingDeviceForm("1");
      frm.ShowDialog();

    }

    public void lbSeeMoreLine_Click(object sender, EventArgs e)
    {
      ViewSettingDeviceForm frm = new ViewSettingDeviceForm("2");
      frm.ShowDialog();
    }

    public void lbSeeMoreDevice_Click(object sender, EventArgs e)
    {
      ViewSettingDeviceForm frm = new ViewSettingDeviceForm("3");
      frm.ShowDialog();
    }

    private void cbDisplay_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateData();
    }

    private void tmrUpdateData_Tick(object sender, EventArgs e)
    {
      UpdateData();

      //MessageBox.Show("A");
    }
    public void LoadImage(string filename)
    {
      //load image
      picDisplay.Image = new Bitmap(Application.StartupPath + $"\\Resources\\{filename}.png");
      picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    public void UpdateData()
    {
      RepositoryFactory _managerFactory = new RepositoryFactory();
      RepositoryLine _managerLine = new RepositoryLine();
      RepositoryDevice _managerDevice = new RepositoryDevice();

      var factory = _managerFactory.GetAll();
      var line = _managerLine.GetAll();
      var device= _managerDevice.GetAll();

      lbNumbersFactory.Text = factory.Count.ToString();
      lbNumbersLine.Text = line.Count.ToString();
      lbNumbersDevice.Text = device.Count.ToString();

      switch (cbDisplay.SelectedIndex)
      {
        case 0:
          dgvSettingDevice.DataSource = factory;
          LoadImage("factory");

          break;
        case 1:
          dgvSettingDevice.DataSource = line;
          LoadImage("line");
          break;
        case 2:
          dgvSettingDevice.DataSource = device;
          LoadImage("device");
          break;
      }

    }

    
  }
}
