using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DdpiVstoAddinExcel
{
    static class DPIHelper
    {
        [DllImport("SHCore.dll", SetLastError = true)]
        private static extern bool SetProcessDpiAwareness(PROCESS_DPI_AWARENESS awareness);

        [DllImport("SHCore.dll", SetLastError = true)]
        private static extern void GetProcessDpiAwareness(IntPtr hprocess, out PROCESS_DPI_AWARENESS awareness);

        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_AWARENESS_CONTEXT SetThreadDpiAwarenessContext(DPI_AWARENESS_CONTEXT awareness);

        [DllImport("User32.dll", SetLastError = true)]
        private static extern DPI_AWARENESS_CONTEXT GetThreadDpiAwarenessContext();

        public enum PROCESS_DPI_AWARENESS
        {
            Process_DPI_Unaware = 0,
            Process_System_DPI_Aware = 1,
            Process_Per_Monitor_DPI_Aware = 2
        }

        public enum DPI_AWARENESS_CONTEXT
        {
            DPI_AWARENESS_CONTEXT_UNAWARE = 16,
            DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = 17,
            DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = 18,
            DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = 34
        }

        public static bool SetProcessDpi(PROCESS_DPI_AWARENESS awareness)
        {
            return SetProcessDpiAwareness(awareness);
        }

        public static DPI_AWARENESS_CONTEXT SetThreadDpi(DPI_AWARENESS_CONTEXT awareness)
        {
            return SetThreadDpiAwarenessContext(awareness);
        }

        public static PROCESS_DPI_AWARENESS GetProcessDpi()
        {
            return GetProcessDpi(Process.GetCurrentProcess().Handle);
        }

        public static PROCESS_DPI_AWARENESS GetProcessDpi(IntPtr hprocess)
        {
            PROCESS_DPI_AWARENESS awareness;
            GetProcessDpiAwareness(hprocess, out awareness);
            return awareness;
        }

        public static DPI_AWARENESS_CONTEXT GetThreadDpi()
        {
            return GetThreadDpiAwarenessContext();
        }

        public static void DebugPrintDPIAwareness(IntPtr hprocess, string message)
        {
            Debug.WriteLine(DPIAwarenessText(hprocess, message));
        }
        public static void DebugPrintDPIAwareness(string message)
        {
            Debug.WriteLine(DPIAwarenessText(message));
        }

        public static string DPIAwarenessText(IntPtr hprocess, string message)
        {
            return String.Format("DPI Awareness {0}: {1}, Thread Awareness: {2}", message, GetProcessDpi(hprocess), GetThreadDpi());
        }

        public static string DPIAwarenessText(string message)
        {
            return String.Format("DPI Awareness {0}: {1}, Thread Awareness: {2}", message, GetProcessDpi(), GetThreadDpi());
        }

    }
}
