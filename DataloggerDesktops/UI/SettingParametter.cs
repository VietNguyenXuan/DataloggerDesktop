using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataloggerDesktops
{
  public partial class SettingParametter : Form
  {
    public SettingParametter()
    {
      InitializeComponent();
    }

    private void SettingParametter_Load(object sender, EventArgs e)
    {
      // tắt hiển thị dòng cuối datagridview
      dgvTemp.AllowUserToAddRows = false;
      dgvAcoustic.AllowUserToAddRows = false;
      dgvMagneticField.AllowUserToAddRows = false;
      dgvSpeed.AllowUserToAddRows = false;
      dgvVibration.AllowUserToAddRows = false;

      string[] status = { "switch_off_48px", "switch_off_48px" };

      //Dgv temp
      AddColId_StatusName(dgvTemp, "ID", "StatusName", "High temperature");    // Thêm cột ID và status name
      AddColActive(dgvTemp, "Kích hoạt", "ActiveTemp", status[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvTemp, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvTemp, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvTemp, "Item", "itemCol");                                 // Thêm cột Item
      dgvTemp.Columns["ID"].Width = 30;
      dgvTemp.Columns["StatusName"].Width = 120;

      //Acoustic Data | Dữ liệu âm thanh
      AddColId_StatusName(dgvAcoustic, "ID", "StatusName", "High Acoustic");    // Thêm cột ID và status name
      AddColActive(dgvAcoustic, "Kích hoạt", "Active", status[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvAcoustic, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvAcoustic, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvAcoustic, "Item", "itemCol");                                 // Thêm cột Item
      dgvAcoustic.Columns["ID"].Width = 30;
      dgvAcoustic.Columns["StatusName"].Width = 120;


      // Vibration Data | Dữ liệu độ rung
      AddColId_StatusName(dgvVibration, "ID", "StatusName", "High Vibration");    // Thêm cột ID và status name
      AddColActive(dgvVibration, "Kích hoạt", "Active", status[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvVibration, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvVibration, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvVibration, "Item", "itemCol");                                 // Thêm cột Item
      dgvVibration.Columns["ID"].Width = 30;
      dgvVibration.Columns["StatusName"].Width = 120;

      // Magnetic Field Data | Dữ liệu từ trường
      AddColId_StatusName(dgvMagneticField, "ID", "StatusName", "High Field Data");    // Thêm cột ID và status name
      AddColActive(dgvMagneticField, "Kích hoạt", "Active", status[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvMagneticField, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvMagneticField, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvMagneticField, "Item", "itemCol");                                 // Thêm cột Item
      dgvMagneticField.Columns["ID"].Width = 30;
      dgvMagneticField.Columns["StatusName"].Width = 120;

      // Magnetic Speed | Dữ liệu tốc độ
      AddColId_StatusName(dgvSpeed, "ID", "StatusName", "High Speed");    // Thêm cột ID và status name
      AddColActive(dgvSpeed, "Kích hoạt", "Active", status[0]);             // Thêm cột kích hoạt
      AddColCondition(dgvSpeed, "Điều kiện", "conditionCol");                   // Thêm cột điều kiện
      AddColThreshold(dgvSpeed, "Ngưỡng", "thresholdCol");                     // Thêm cột ngưỡng
      AddColItem(dgvSpeed, "Item", "itemCol");                                 // Thêm cột Item
      dgvSpeed.Columns["ID"].Width = 30;
      dgvSpeed.Columns["StatusName"].Width = 120;

    }





    void AddColId_StatusName(DataGridView dgv,string col1Name, string col2Name, string status)
    {
      DataTable dt = new DataTable();
      dt.Columns.Add(col1Name, typeof(int));
      dt.Columns.Add(col2Name, typeof(string));
      DataRow row;
      row = dt.NewRow();
      row[col1Name] = 1;
      row[col2Name] = status;
      dt.Rows.Add(row);
      dgv.DataSource = dt;
    }
    void AddColActive(DataGridView dgv, string headerCol, string NameCol, string linkPic)
    {
      DataGridViewImageColumn ImgCol = new DataGridViewImageColumn();
      Image image = Image.FromFile(Application.StartupPath + $"\\Resources\\{linkPic}.png");
      ImgCol.Image = image;
      ImgCol.HeaderText = headerCol;
      ImgCol.Name = NameCol;
      dgv.Columns.Add(ImgCol);
      ImgCol.Width = 150;
    }

    void AddColCondition(DataGridView dgv, string headerCol, string NameCol)
    {
      DataGridViewComboBoxColumn CbCol = new DataGridViewComboBoxColumn();
      CbCol.HeaderText = headerCol;
      CbCol.Name = NameCol;
      CbCol.Items.Add(">");
      CbCol.Items.Add("<");
      CbCol.Items.Add(">=");
      CbCol.Items.Add("<=");
      dgv.Columns.Add(CbCol);
      CbCol.Width = 150;
    }
    void AddColThreshold(DataGridView dgv, string headerCol, string NameCol)
    {
      DataGridViewTextBoxColumn thresholdCol = new DataGridViewTextBoxColumn();
      thresholdCol.HeaderText = headerCol;
      thresholdCol.Name = NameCol;
      dgv.Columns.Add(thresholdCol);
    }
    void AddColItem(DataGridView dgv, string headerCol, string NameCol)
    {
      DataGridViewTextBoxColumn itemCol = new DataGridViewTextBoxColumn();
      itemCol.HeaderText = headerCol;
      itemCol.Name = NameCol;
      dgv.Columns.Add(itemCol);
    }


  }
}
