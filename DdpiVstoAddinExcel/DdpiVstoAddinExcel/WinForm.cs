using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DdpiVstoAddinExcel
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void resize()
        {
            lblDpiAwareness.Text = DPIHelper.DPIAwarenessText("WinForm");
            lblDpiAwareness.Width = this.Width;
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height - lblDpiAwareness.Height;
        }

        private void WinForm_OnResize(object sender, EventArgs e)
        {
            resize();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            resize();
        }
    }
}
