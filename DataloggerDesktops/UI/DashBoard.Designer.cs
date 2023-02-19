namespace DataloggerDesktops
{
  partial class DashBoard
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.panelDashBoardFull = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDevice = new System.Windows.Forms.Panel();
            this.panelMon = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelSpeech = new System.Windows.Forms.Panel();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.panelDashBoardFull.SuspendLayout();
            this.panelMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashBoardFull
            // 
            this.panelDashBoardFull.Controls.Add(this.monthCalendar2);
            this.panelDashBoardFull.Controls.Add(this.panel2);
            this.panelDashBoardFull.Controls.Add(this.panel1);
            this.panelDashBoardFull.Controls.Add(this.panelDevice);
            this.panelDashBoardFull.Controls.Add(this.panelMon);
            this.panelDashBoardFull.Controls.Add(this.panelSpeech);
            this.panelDashBoardFull.Controls.Add(this.panelTemp);
            this.panelDashBoardFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoardFull.Location = new System.Drawing.Point(0, 0);
            this.panelDashBoardFull.Name = "panelDashBoardFull";
            this.panelDashBoardFull.Size = new System.Drawing.Size(1148, 633);
            this.panelDashBoardFull.TabIndex = 1;
            this.panelDashBoardFull.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashBoardFull_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(316, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 177);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 177);
            this.panel1.TabIndex = 3;
            // 
            // panelDevice
            // 
            this.panelDevice.Location = new System.Drawing.Point(36, 23);
            this.panelDevice.Name = "panelDevice";
            this.panelDevice.Size = new System.Drawing.Size(250, 177);
            this.panelDevice.TabIndex = 3;
            // 
            // panelMon
            // 
            this.panelMon.Controls.Add(this.monthCalendar1);
            this.panelMon.Location = new System.Drawing.Point(868, 23);
            this.panelMon.Name = "panelMon";
            this.panelMon.Size = new System.Drawing.Size(250, 177);
            this.panelMon.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, -5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelSpeech
            // 
            this.panelSpeech.Location = new System.Drawing.Point(592, 23);
            this.panelSpeech.Name = "panelSpeech";
            this.panelSpeech.Size = new System.Drawing.Size(250, 177);
            this.panelSpeech.TabIndex = 1;
            // 
            // panelTemp
            // 
            this.panelTemp.Location = new System.Drawing.Point(316, 23);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(250, 177);
            this.panelTemp.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(627, 243);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 633);
            this.Controls.Add(this.panelDashBoardFull);
            this.Name = "DashBoard";
            this.Text = "FormDashBoard";
            this.panelDashBoardFull.ResumeLayout(false);
            this.panelMon.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelDashBoardFull;
    private System.Windows.Forms.Panel panelDevice;
    private System.Windows.Forms.Panel panelMon;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.Panel panelSpeech;
    private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}