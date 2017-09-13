using System;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Diagnostics;

namespace DdpiVstoAddinExcel
{

    // Creates a  message filter.
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
    public class TestMessageFilter : IMessageFilter
    {
        private const long WM_DPICHANGED = 0x02E0;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_DPICHANGED)
            {
                Debug.WriteLine("Processing the message : " + m.Msg);
                return true;
            }
            return false;
        }
    }
}
