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
  public partial class DashBoard : Form
  {
    public DashBoard()
    {
      InitializeComponent();
    }

    private void DashBoard_Load(object sender, EventArgs e)
    {
      // Thiết lập màu cho panel mode
      panelDashBoardFull.BackColor = Color.FromArgb(12, 17, 44);

      panelDevice.BackColor = Color.FromArgb(19, 33, 73);
      panelTemp.BackColor = Color.FromArgb(19, 33, 73);
      panelSpeech.BackColor = Color.FromArgb(19, 33, 73);

      panelStatus.BackColor = Color.FromArgb(19, 33, 73);
      panelTrend.BackColor = Color.FromArgb(19, 33, 73);
      panelVibrationData.BackColor = Color.FromArgb(19, 33, 73);
      panelScatter.BackColor = Color.FromArgb(19, 33, 73);
      panelMFD.BackColor = Color.FromArgb(19, 33, 73);
      panelAcousticData.BackColor = Color.FromArgb(19, 33, 73);
    }
  }
}
