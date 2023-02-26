namespace DataloggerDesktops
{
  partial class FormMain
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.panelMain = new System.Windows.Forms.Panel();
      this.panelBody = new System.Windows.Forms.Panel();
      this.panelControl = new System.Windows.Forms.Panel();
      this.btnUser = new System.Windows.Forms.Button();
      this.btnDevice = new System.Windows.Forms.Button();
      this.btnParameter = new System.Windows.Forms.Button();
      this.btnSetting = new System.Windows.Forms.Button();
      this.btnStatistics = new System.Windows.Forms.Button();
      this.btnHistorical = new System.Windows.Forms.Button();
      this.btnDashBoard = new System.Windows.Forms.Button();
      this.panelHeading = new System.Windows.Forms.Panel();
      this.txb = new System.Windows.Forms.TextBox();
      this.panelTab = new System.Windows.Forms.Panel();
      this.btnTab = new System.Windows.Forms.Button();
      this.tmrUpdateMQTT = new System.Windows.Forms.Timer(this.components);
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.panelMain.SuspendLayout();
      this.panelBody.SuspendLayout();
      this.panelControl.SuspendLayout();
      this.panelHeading.SuspendLayout();
      this.panelTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panelMain
      // 
      this.panelMain.Controls.Add(this.panelBody);
      this.panelMain.Controls.Add(this.panelHeading);
      this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMain.Location = new System.Drawing.Point(0, 0);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(1314, 682);
      this.panelMain.TabIndex = 0;
      // 
      // panelBody
      // 
      this.panelBody.Controls.Add(this.dataGridView1);
      this.panelBody.Controls.Add(this.panelControl);
      this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelBody.Location = new System.Drawing.Point(0, 50);
      this.panelBody.Name = "panelBody";
      this.panelBody.Size = new System.Drawing.Size(1314, 632);
      this.panelBody.TabIndex = 2;
      // 
      // panelControl
      // 
      this.panelControl.Controls.Add(this.btnUser);
      this.panelControl.Controls.Add(this.btnDevice);
      this.panelControl.Controls.Add(this.btnParameter);
      this.panelControl.Controls.Add(this.btnSetting);
      this.panelControl.Controls.Add(this.btnStatistics);
      this.panelControl.Controls.Add(this.btnHistorical);
      this.panelControl.Controls.Add(this.btnDashBoard);
      this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelControl.Location = new System.Drawing.Point(0, 0);
      this.panelControl.Name = "panelControl";
      this.panelControl.Size = new System.Drawing.Size(155, 632);
      this.panelControl.TabIndex = 1;
      // 
      // btnUser
      // 
      this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnUser.ForeColor = System.Drawing.Color.Transparent;
      this.btnUser.Location = new System.Drawing.Point(0, 290);
      this.btnUser.Name = "btnUser";
      this.btnUser.Size = new System.Drawing.Size(155, 37);
      this.btnUser.TabIndex = 8;
      this.btnUser.Text = "   User";
      this.btnUser.UseVisualStyleBackColor = false;
      this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
      // 
      // btnDevice
      // 
      this.btnDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnDevice.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDevice.ForeColor = System.Drawing.Color.Transparent;
      this.btnDevice.Location = new System.Drawing.Point(0, 253);
      this.btnDevice.Name = "btnDevice";
      this.btnDevice.Size = new System.Drawing.Size(155, 37);
      this.btnDevice.TabIndex = 7;
      this.btnDevice.Text = "   Device";
      this.btnDevice.UseVisualStyleBackColor = false;
      this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
      // 
      // btnParameter
      // 
      this.btnParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnParameter.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnParameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnParameter.ForeColor = System.Drawing.Color.Transparent;
      this.btnParameter.Location = new System.Drawing.Point(0, 216);
      this.btnParameter.Name = "btnParameter";
      this.btnParameter.Size = new System.Drawing.Size(155, 37);
      this.btnParameter.TabIndex = 6;
      this.btnParameter.Text = "   Parameter";
      this.btnParameter.UseVisualStyleBackColor = false;
      this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
      // 
      // btnSetting
      // 
      this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnSetting.ForeColor = System.Drawing.Color.Transparent;
      this.btnSetting.Location = new System.Drawing.Point(0, 162);
      this.btnSetting.Name = "btnSetting";
      this.btnSetting.Size = new System.Drawing.Size(155, 54);
      this.btnSetting.TabIndex = 5;
      this.btnSetting.Text = "Setting";
      this.btnSetting.UseVisualStyleBackColor = false;
      this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
      // 
      // btnStatistics
      // 
      this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStatistics.ForeColor = System.Drawing.Color.Transparent;
      this.btnStatistics.Location = new System.Drawing.Point(0, 108);
      this.btnStatistics.Name = "btnStatistics";
      this.btnStatistics.Size = new System.Drawing.Size(155, 54);
      this.btnStatistics.TabIndex = 4;
      this.btnStatistics.Text = "Statistics";
      this.btnStatistics.UseVisualStyleBackColor = false;
      this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
      // 
      // btnHistorical
      // 
      this.btnHistorical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnHistorical.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnHistorical.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnHistorical.ForeColor = System.Drawing.Color.Transparent;
      this.btnHistorical.Location = new System.Drawing.Point(0, 54);
      this.btnHistorical.Name = "btnHistorical";
      this.btnHistorical.Size = new System.Drawing.Size(155, 54);
      this.btnHistorical.TabIndex = 3;
      this.btnHistorical.Text = "Historical";
      this.btnHistorical.UseVisualStyleBackColor = false;
      this.btnHistorical.Click += new System.EventHandler(this.btnHistorical_Click);
      // 
      // btnDashBoard
      // 
      this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
      this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDashBoard.ForeColor = System.Drawing.Color.Transparent;
      this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
      this.btnDashBoard.Name = "btnDashBoard";
      this.btnDashBoard.Size = new System.Drawing.Size(155, 54);
      this.btnDashBoard.TabIndex = 2;
      this.btnDashBoard.Text = "DashBoard";
      this.btnDashBoard.UseVisualStyleBackColor = false;
      this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
      // 
      // panelHeading
      // 
      this.panelHeading.Controls.Add(this.txb);
      this.panelHeading.Controls.Add(this.panelTab);
      this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeading.Location = new System.Drawing.Point(0, 0);
      this.panelHeading.Name = "panelHeading";
      this.panelHeading.Size = new System.Drawing.Size(1314, 50);
      this.panelHeading.TabIndex = 0;
      // 
      // txb
      // 
      this.txb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txb.Enabled = false;
      this.txb.Location = new System.Drawing.Point(155, 0);
      this.txb.Multiline = true;
      this.txb.Name = "txb";
      this.txb.Size = new System.Drawing.Size(1159, 50);
      this.txb.TabIndex = 2;
      // 
      // panelTab
      // 
      this.panelTab.Controls.Add(this.btnTab);
      this.panelTab.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelTab.Location = new System.Drawing.Point(0, 0);
      this.panelTab.Name = "panelTab";
      this.panelTab.Size = new System.Drawing.Size(155, 50);
      this.panelTab.TabIndex = 1;
      // 
      // btnTab
      // 
      this.btnTab.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnTab.Location = new System.Drawing.Point(110, 0);
      this.btnTab.Name = "btnTab";
      this.btnTab.Size = new System.Drawing.Size(45, 45);
      this.btnTab.TabIndex = 0;
      this.btnTab.Text = "<";
      this.btnTab.UseVisualStyleBackColor = true;
      this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
      // 
      // tmrUpdateMQTT
      // 
      this.tmrUpdateMQTT.Interval = 5000;
      this.tmrUpdateMQTT.Tick += new System.EventHandler(this.tmrUpdateMQTT_Tick);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(346, 83);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 29;
      this.dataGridView1.Size = new System.Drawing.Size(659, 333);
      this.dataGridView1.TabIndex = 2;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1314, 682);
      this.Controls.Add(this.panelMain);
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.panelMain.ResumeLayout(false);
      this.panelBody.ResumeLayout(false);
      this.panelControl.ResumeLayout(false);
      this.panelHeading.ResumeLayout(false);
      this.panelHeading.PerformLayout();
      this.panelTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Panel panelHeading;
    private System.Windows.Forms.Panel panelTab;
    private System.Windows.Forms.Button btnTab;
    private System.Windows.Forms.Timer tmrUpdateMQTT;
    private System.Windows.Forms.TextBox txb;
    private System.Windows.Forms.Panel panelBody;
    private System.Windows.Forms.Panel panelControl;
    private System.Windows.Forms.Button btnUser;
    private System.Windows.Forms.Button btnDevice;
    private System.Windows.Forms.Button btnParameter;
    private System.Windows.Forms.Button btnSetting;
    private System.Windows.Forms.Button btnStatistics;
    private System.Windows.Forms.Button btnHistorical;
    private System.Windows.Forms.Button btnDashBoard;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}