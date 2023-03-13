using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using MQTTnet.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataloggerDesktops
{
  public partial class DashBoard : Form
  {
    public DashBoard()
    {
      InitializeComponent();
    }

    RepositoryParametterLog _managerParalog=new RepositoryParametterLog();
    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    private void DashBoard_Load(object sender, EventArgs e)
    {
      var nameFactory = _managerFactory.GetNameFactory();
      if (nameFactory != null) cbFactory.DataSource = nameFactory;

      LoadData();
    }
    private void cbFactory_SelectedValueChanged(object sender, EventArgs e)
    {
      // Lấy ra id Factory và hiển thị cb Line
      if (cbFactory.SelectedItem != null)
      {
        int idFactory = _managerFactory.GetIdFactoryByName(cbFactory.SelectedItem.ToString())[0];
        var nameLine = _managerLine.GetNameLineByIdFactory(cbFactory.SelectedItem.ToString(), idFactory);

        cbLine.DataSource = null;
        if (nameLine != null) cbLine.DataSource = nameLine;
      }
    }

    private void cbLine_SelectedValueChanged(object sender, EventArgs e)
    {
      // Lấy ra id Line và hiển thị cb Device
      if (cbLine.SelectedItem != null)
      {
        int idLine = _managerLine.GetIdLineByName(cbLine.SelectedItem.ToString())[0];
        var nameDevice = _managerDevice.GetNameDeviceByIdLine(cbLine.SelectedItem.ToString(), idLine);
        cbDevice.DataSource = null;
        if (nameDevice != null) cbDevice.DataSource = nameDevice;
      }
    }

    private void tmrDashBoard_Tick(object sender, EventArgs e)
    {
      LoadData();
    }


    public void LoadData()
    {
      try
      {
        // Hiển thị temp và speed
        cpbTemp.Text = _managerParalog.GetValuesByIdParametter(10)[0].Value.ToString();
        cpbSpeed.Text = _managerParalog.GetValuesByIdParametter(4)[0].Value.ToString();

        // Clear các điểm trên chart trước khi load
        chartVibration.Series["Dữ liệu độ rung"].Points.Clear();
        chartAccoustic.Series["Dữ liệu âm thanh"].Points.Clear();
        chartMagFd.Series["Dữ liệu từ trường"].Points.Clear();

        for (int i = 1; i <= 24; i++)
        {
          // Vibration Data | Dữ liệu độ rung
          var dataVibration = _managerParalog.GetDataChart(7, i);
          if (dataVibration != null)
          {
            chartVibration.Series["Dữ liệu độ rung"].Points.AddXY(dataVibration.DateCreate.Hour.ToString() + ":00", dataVibration.Value);
          }

          //Acoustic Data | Dữ liệu âm thanh
          var dataAcoustic = _managerParalog.GetDataChart(11, i);
          if (dataAcoustic != null)
          {
            chartAccoustic.Series["Dữ liệu âm thanh"].Points.AddXY(dataAcoustic.DateCreate.Hour.ToString() + ":00", dataAcoustic.Value);
          }

          // Magnetic Field Data | Dữ liệu từ trường
          var dataMagFd = _managerParalog.GetDataChart(1, i);
          if (dataMagFd != null)
          {
            chartMagFd.Series["Dữ liệu từ trường"].Points.AddXY(dataMagFd.DateCreate.Hour.ToString() + ":00", dataMagFd.Value);
          }
        }
        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
