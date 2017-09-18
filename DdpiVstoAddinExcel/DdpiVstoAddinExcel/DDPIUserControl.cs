using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DdpiVstoAddinExcel
{
    public partial class DDPIUserControl : UserControl
    {
        internal DPIHelper.DPI_AWARENESS_CONTEXT DpiAwarenessRadio
        {
            get; set;
        }

        public DDPIUserControl()
        {
            InitializeComponent();
        }

        public bool ShowFormAsModal
        {
            get { return chkShowFormModal.Checked; }
        }

        private void RefreshDpiAwareness()
        {
            lblDDPIAwareness.Text = DPIHelper.DPIAwarenessText("UserControl");

            DpiAwarenessRadio = DPIHelper.GetThreadDpi();

            radioUnaware.Checked = false;
            radioSystem.Checked = false;
            radioPerMonitor.Checked = false;
            radioPerMonitorV2.Checked = false;
            switch (DpiAwarenessRadio)
            {
                case DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_UNAWARE:
                    radioUnaware.Checked = true;
                    break;
                case DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE:
                    radioSystem.Checked = true;
                    break;
                case DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE:
                    radioPerMonitor.Checked = true;
                    break;
                case DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2:
                    radioPerMonitorV2.Checked = true;
                    break;
            }
        }
        private void DDPIUserControl_Load(object sender, EventArgs e)
        {
            RefreshDpiAwareness();
        }

        private void btnSetSystemAware_Click(object sender, EventArgs e)
        {
            DPIHelper.SetThreadDpi(DpiAwarenessRadio);
            ThisAddIn.ShowForm();
        }

        private void radioUnaware_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                DpiAwarenessRadio = DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_UNAWARE;
            }
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                DpiAwarenessRadio = DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_SYSTEM_AWARE;
            }
        }

        private void radioPerMonitor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                DpiAwarenessRadio = DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE;
            }
        }

        private void radioPerMonitorV2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                DpiAwarenessRadio = DPIHelper.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDpiAwareness();
        }
    }
}
