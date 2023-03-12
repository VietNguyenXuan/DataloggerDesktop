
using DataloggerDesktops.Models;
using DataloggerDesktops.Repository;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataloggerDesktops
{
  public partial class Historical : Form
  {
    public Historical()
    {
      InitializeComponent();
    }
    RepositoryParametterLog _managerParalog = new RepositoryParametterLog();
    RepositoryFactory _managerFactory = new RepositoryFactory();
    RepositoryLine _managerLine = new RepositoryLine();
    RepositoryDevice _managerDevice = new RepositoryDevice();

    public int statusPage = 1;
    private void Historical_Load(object sender, EventArgs e)
    {
      var nameFactory = _managerFactory.GetNameFactory();
      if (nameFactory != null) cbFactory.DataSource = nameFactory;
      LoadData();
    }
    private void tmrHistorical_Tick(object sender, EventArgs e)
    {
      LoadData();
    }

    public void LoadData()
    {
      // Load từ database
      //Temp Data | Dữ liệu nhiệt độ | 10
      //Speed Data | Dữ liệu tốc độ | 4
      //Vibration Data | Dữ liệu độ rung | 7
      //Acoustic Data | Dữ liệu âm thanh | 11
      // Magnetic Field Data | Dữ liệu từ trường | 1
      dgvUp.Columns[2].Width = 100;
      dgvDown.Columns[2].Width = 100;
      switch (statusPage)
      {
        case 1:
          tlpDown.Visible = true; tlbHearderDown.Visible = true;
          FormatLoadData(dgvUp, "Nhiệt độ", 10, chartUp, "Up");
          lbUp.Text = "Nhiệt độ";
          lbChartUp.Text = "Biểu đồ nhiệt độ";
          FormatLoadData(dgvDown, "Tốc độ", 4, chartDown, "Down");
          lbDown.Text = "Tốc độ";
          lbChartDown.Text = "Biểu đồ tốc độ";
          break; 
        case 2:
          tlpDown.Visible = true; tlbHearderDown.Visible = true;
          FormatLoadData(dgvUp, "Độ rung", 7, chartUp, "Up");
          lbUp.Text = "Độ rung";
          lbChartUp.Text = "Biểu đồ độ rung";
          FormatLoadData(dgvDown, "Âm thanh", 11, chartDown, "Down");
          lbDown.Text = "Âm thanh";
          lbChartDown.Text = "Biểu đồ âm thanh";
          break;
        case 3:
          FormatLoadData(dgvUp, "Từ trường", 1, chartUp, "Up");
          lbUp.Text = "Từ trường";
          lbChartUp.Text = "Biểu đồ từ trường";

          tlpDown.Visible= false; tlbHearderDown.Visible = false;

          break;
      }
    }

    public void FormatLoadData(DataGridView dgv, string name, int address, Chart chart, string nameSeries)
    {
      try
      {
        // Load lên datagridview
        var dgvValues = _managerParalog.GetValuesByIdParametter(address);
        if (dgvValues != null)
        {
          dgv.Columns[2].HeaderText = name;
          dgv.Rows.Clear();
          for (int i = 0; i < 10; i++) dgv.Rows.Add(i + 1, dgvValues[i].DateCreate, dgvValues[i].Value);
        }

        // Load lên chart
        chart.Series[nameSeries].Points.Clear();
        for (int i = 1; i <= 24; i++)
        {
          var chartValues = _managerParalog.iChart(address, i);
          if (chartValues != null)
          {
            chart.Series[nameSeries].Points.AddXY(chartValues.DateCreate.Hour.ToString() + ":00", chartValues.Value);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      
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

    private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
    {

    }

    private void picBack_Click(object sender, EventArgs e)
    {
      if (statusPage > 1) statusPage --;
    }

    private void picNext_Click(object sender, EventArgs e)
    {
      if (statusPage < 3) statusPage ++;
    }
  }
}
