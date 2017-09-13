using System.Windows.Forms;
using System.Diagnostics;

namespace DdpiVstoAddinExcel
{
    partial class DDPIUserControl
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

        private const int WM_DPICHANGED = 0x02E0;
        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case WM_DPICHANGED:
                    Debug.WriteLine("DPI Changed");
                    break;
            }
            base.WndProc(ref m);

        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDDPIAwareness = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSetAndOpen = new System.Windows.Forms.Button();
            this.chkShowFormModal = new System.Windows.Forms.CheckBox();
            this.radioSystem = new System.Windows.Forms.RadioButton();
            this.radioPerMonitor = new System.Windows.Forms.RadioButton();
            this.radioPerMonitorV2 = new System.Windows.Forms.RadioButton();
            this.groupAwareness = new System.Windows.Forms.GroupBox();
            this.radioUnaware = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupAwareness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDDPIAwareness
            // 
            this.lblDDPIAwareness.Location = new System.Drawing.Point(6, 31);
            this.lblDDPIAwareness.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDDPIAwareness.Name = "lblDDPIAwareness";
            this.lblDDPIAwareness.Size = new System.Drawing.Size(630, 92);
            this.lblDDPIAwareness.TabIndex = 0;
            this.lblDDPIAwareness.Text = "DDPI Awareness";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 483);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(652, 56);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Get DPI Awareness";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSetAndOpen
            // 
            this.btnSetAndOpen.Location = new System.Drawing.Point(6, 31);
            this.btnSetAndOpen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSetAndOpen.Name = "btnSetAndOpen";
            this.btnSetAndOpen.Size = new System.Drawing.Size(648, 58);
            this.btnSetAndOpen.TabIndex = 2;
            this.btnSetAndOpen.Text = "Set DPI Awareness && Open Form";
            this.btnSetAndOpen.UseVisualStyleBackColor = true;
            this.btnSetAndOpen.Click += new System.EventHandler(this.btnSetSystemAware_Click);
            // 
            // chkShowFormModal
            // 
            this.chkShowFormModal.AutoSize = true;
            this.chkShowFormModal.Checked = true;
            this.chkShowFormModal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowFormModal.Location = new System.Drawing.Point(6, 100);
            this.chkShowFormModal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkShowFormModal.Name = "chkShowFormModal";
            this.chkShowFormModal.Size = new System.Drawing.Size(239, 29);
            this.chkShowFormModal.TabIndex = 3;
            this.chkShowFormModal.Text = "&Show form as Modal";
            this.chkShowFormModal.UseVisualStyleBackColor = true;
            // 
            // radioSystem
            // 
            this.radioSystem.Location = new System.Drawing.Point(12, 173);
            this.radioSystem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioSystem.Name = "radioSystem";
            this.radioSystem.Size = new System.Drawing.Size(228, 56);
            this.radioSystem.TabIndex = 5;
            this.radioSystem.TabStop = true;
            this.radioSystem.Text = "System";
            this.radioSystem.UseVisualStyleBackColor = true;
            this.radioSystem.CheckedChanged += new System.EventHandler(this.radioSystem_CheckedChanged);
            // 
            // radioPerMonitor
            // 
            this.radioPerMonitor.Location = new System.Drawing.Point(12, 217);
            this.radioPerMonitor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioPerMonitor.Name = "radioPerMonitor";
            this.radioPerMonitor.Size = new System.Drawing.Size(308, 56);
            this.radioPerMonitor.TabIndex = 6;
            this.radioPerMonitor.TabStop = true;
            this.radioPerMonitor.Text = "Per Monitor";
            this.radioPerMonitor.UseVisualStyleBackColor = true;
            this.radioPerMonitor.CheckedChanged += new System.EventHandler(this.radioPerMonitor_CheckedChanged);
            // 
            // radioPerMonitorV2
            // 
            this.radioPerMonitorV2.Location = new System.Drawing.Point(12, 262);
            this.radioPerMonitorV2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioPerMonitorV2.Name = "radioPerMonitorV2";
            this.radioPerMonitorV2.Size = new System.Drawing.Size(366, 70);
            this.radioPerMonitorV2.TabIndex = 7;
            this.radioPerMonitorV2.TabStop = true;
            this.radioPerMonitorV2.Text = "Per Monitor v2";
            this.radioPerMonitorV2.UseVisualStyleBackColor = true;
            this.radioPerMonitorV2.CheckedChanged += new System.EventHandler(this.radioPerMonitorV2_CheckedChanged);
            // 
            // groupAwareness
            // 
            this.groupAwareness.Controls.Add(this.radioUnaware);
            this.groupAwareness.Controls.Add(this.lblDDPIAwareness);
            this.groupAwareness.Controls.Add(this.radioPerMonitorV2);
            this.groupAwareness.Controls.Add(this.radioSystem);
            this.groupAwareness.Controls.Add(this.radioPerMonitor);
            this.groupAwareness.Location = new System.Drawing.Point(6, 150);
            this.groupAwareness.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupAwareness.Name = "groupAwareness";
            this.groupAwareness.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupAwareness.Size = new System.Drawing.Size(648, 332);
            this.groupAwareness.TabIndex = 8;
            this.groupAwareness.TabStop = false;
            this.groupAwareness.Text = "DDPI Awareness";
            // 
            // radioUnaware
            // 
            this.radioUnaware.Location = new System.Drawing.Point(12, 129);
            this.radioUnaware.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioUnaware.Name = "radioUnaware";
            this.radioUnaware.Size = new System.Drawing.Size(256, 56);
            this.radioUnaware.TabIndex = 8;
            this.radioUnaware.TabStop = true;
            this.radioUnaware.Text = "Unaware";
            this.radioUnaware.UseVisualStyleBackColor = true;
            this.radioUnaware.CheckedChanged += new System.EventHandler(this.radioUnaware_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DdpiVstoAddinExcel.Properties.Resources.TestPattern;
            this.pictureBox1.Location = new System.Drawing.Point(0, 563);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DDPIUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupAwareness);
            this.Controls.Add(this.chkShowFormModal);
            this.Controls.Add(this.btnSetAndOpen);
            this.Controls.Add(this.btnRefresh);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DDPIUserControl";
            this.Size = new System.Drawing.Size(1070, 1206);
            this.Load += new System.EventHandler(this.DDPIUserControl_Load);
            this.groupAwareness.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDDPIAwareness;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSetAndOpen;
        private System.Windows.Forms.CheckBox chkShowFormModal;
        private System.Windows.Forms.RadioButton radioSystem;
        private System.Windows.Forms.RadioButton radioPerMonitor;
        private System.Windows.Forms.RadioButton radioPerMonitorV2;
        private System.Windows.Forms.GroupBox groupAwareness;
        private System.Windows.Forms.RadioButton radioUnaware;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
