using System.Diagnostics;
using System.Windows.Forms;

namespace DdpiVstoAddinExcel
{
    partial class WinForm
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
                    Debug.WriteLine("DPI Changed - winform");
                    break;
            }
            base.WndProc(ref m);

        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDpiAwareness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DdpiVstoAddinExcel.Properties.Resources.TestPattern;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblDpiAwareness
            // 
            this.lblDpiAwareness.Location = new System.Drawing.Point(0, 0);
            this.lblDpiAwareness.Name = "lblDpiAwareness";
            this.lblDpiAwareness.Size = new System.Drawing.Size(619, 45);
            this.lblDpiAwareness.TabIndex = 11;
            this.lblDpiAwareness.Text = "DPI Awareness";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 516);
            this.Controls.Add(this.lblDpiAwareness);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WinForm";
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load);
            this.Resize += new System.EventHandler(this.WinForm_OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDpiAwareness;
    }
}