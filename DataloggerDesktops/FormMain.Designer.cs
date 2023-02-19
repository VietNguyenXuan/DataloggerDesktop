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
      this.panelTab = new System.Windows.Forms.Panel();
      this.btnTab = new System.Windows.Forms.Button();
      this.panelMain.SuspendLayout();
      this.panelBody.SuspendLayout();
      this.panelControl.SuspendLayout();
      this.panelHeading.SuspendLayout();
      this.panelTab.SuspendLayout();
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
      this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnUser.Location = new System.Drawing.Point(0, 290);
      this.btnUser.Name = "btnUser";
      this.btnUser.Size = new System.Drawing.Size(155, 37);
      this.btnUser.TabIndex = 8;
      this.btnUser.Text = "   User";
      this.btnUser.UseVisualStyleBackColor = true;
      this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
      // 
      // btnDevice
      // 
      this.btnDevice.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDevice.Location = new System.Drawing.Point(0, 253);
      this.btnDevice.Name = "btnDevice";
      this.btnDevice.Size = new System.Drawing.Size(155, 37);
      this.btnDevice.TabIndex = 7;
      this.btnDevice.Text = "   Device";
      this.btnDevice.UseVisualStyleBackColor = true;
      this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
      // 
      // btnParameter
      // 
      this.btnParameter.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnParameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnParameter.Location = new System.Drawing.Point(0, 216);
      this.btnParameter.Name = "btnParameter";
      this.btnParameter.Size = new System.Drawing.Size(155, 37);
      this.btnParameter.TabIndex = 6;
      this.btnParameter.Text = "   Parameter";
      this.btnParameter.UseVisualStyleBackColor = true;
      this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
      // 
      // btnSetting
      // 
      this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnSetting.Location = new System.Drawing.Point(0, 162);
      this.btnSetting.Name = "btnSetting";
      this.btnSetting.Size = new System.Drawing.Size(155, 54);
      this.btnSetting.TabIndex = 5;
      this.btnSetting.Text = "Setting";
      this.btnSetting.UseVisualStyleBackColor = true;
      this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
      // 
      // btnStatistics
      // 
      this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStatistics.Location = new System.Drawing.Point(0, 108);
      this.btnStatistics.Name = "btnStatistics";
      this.btnStatistics.Size = new System.Drawing.Size(155, 54);
      this.btnStatistics.TabIndex = 4;
      this.btnStatistics.Text = "Statistics";
      this.btnStatistics.UseVisualStyleBackColor = true;
      this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
      // 
      // btnHistorical
      // 
      this.btnHistorical.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnHistorical.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnHistorical.Location = new System.Drawing.Point(0, 54);
      this.btnHistorical.Name = "btnHistorical";
      this.btnHistorical.Size = new System.Drawing.Size(155, 54);
      this.btnHistorical.TabIndex = 3;
      this.btnHistorical.Text = "Historical";
      this.btnHistorical.UseVisualStyleBackColor = true;
      this.btnHistorical.Click += new System.EventHandler(this.btnHistorical_Click);
      // 
      // btnDashBoard
      // 
      this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
      this.btnDashBoard.Name = "btnDashBoard";
      this.btnDashBoard.Size = new System.Drawing.Size(155, 54);
      this.btnDashBoard.TabIndex = 2;
      this.btnDashBoard.Text = "DashBoard";
      this.btnDashBoard.UseVisualStyleBackColor = true;
      this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
      // 
      // panelHeading
      // 
      this.panelHeading.Controls.Add(this.panelTab);
      this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeading.Location = new System.Drawing.Point(0, 0);
      this.panelHeading.Name = "panelHeading";
      this.panelHeading.Size = new System.Drawing.Size(1314, 50);
      this.panelHeading.TabIndex = 0;
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
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1314, 682);
      this.Controls.Add(this.panelMain);
      this.Name = "FormMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.panelMain.ResumeLayout(false);
      this.panelBody.ResumeLayout(false);
      this.panelControl.ResumeLayout(false);
      this.panelHeading.ResumeLayout(false);
      this.panelTab.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Panel panelControl;
    private System.Windows.Forms.Panel panelHeading;
    private System.Windows.Forms.Button btnSetting;
    private System.Windows.Forms.Button btnStatistics;
    private System.Windows.Forms.Button btnHistorical;
    private System.Windows.Forms.Button btnDashBoard;
    private System.Windows.Forms.Panel panelTab;
    private System.Windows.Forms.Panel panelBody;
    private System.Windows.Forms.Button btnTab;
    private System.Windows.Forms.Button btnUser;
    private System.Windows.Forms.Button btnDevice;
    private System.Windows.Forms.Button btnParameter;
  }
}