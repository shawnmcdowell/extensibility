using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DdpiVstoAddinExcel
{
    public class ParentWndProc : NativeWindow
    {
        public ParentWndProc(UserControl myControl)
        {
            var controlHandle = myControl.FindForm().Handle;
            this.AssignHandle(controlHandle);
        }

        public ParentWndProc()
        {
            var mainHandle = Process.GetCurrentProcess().MainWindowHandle;
            this.AssignHandle(mainHandle);
        }

        private const int WM_DPICHANGED = 0x02E0;

        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DPICHANGED:
                    Debug.WriteLine("DPI Changed - parentform");
                    break;
            }
            // do stuff
            try
            {
                base.WndProc(ref m);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception in WndProd " + e.Message);
            }
        }
    }
}
