using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;

namespace DdpiVstoAddinExcel
{
    public partial class ThisAddIn
    {
        private CustomTaskPane ThisCustomTaskPane;
        private static DDPIUserControl ThisUserControl = new DDPIUserControl();

        TestMessageFilter filter = new TestMessageFilter();

        // Parent WndProc override using process main window
        ParentWndProc parentProc;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            DPIHelper.DebugPrintDPIAwareness("startup");
            this.Application.WorkbookOpen += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookOpenEventHandler(Workbook_Open);
            this.Application.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);

            ThisCustomTaskPane = this.CustomTaskPanes.Add(ThisUserControl, "WinForm");
            ThisCustomTaskPane.Width = 325;
            ThisCustomTaskPane.Visible = true;

            // IMessageFilter
            System.Windows.Forms.Application.AddMessageFilter(filter);
        }

        private void Workbook_Open(Microsoft.Office.Interop.Excel.Workbook Wb)
        {
            parentProc = new ParentWndProc();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
            newFirstRow.Value2 = String.Format("Save triggered at {0}, {1}", DateTime.Now, DPIHelper.DPIAwarenessText("BeforeSave"));
            DPIHelper.DebugPrintDPIAwareness("BeforeSave");

            ShowForm();
        }

        public static void ShowForm()
        {
            bool modal = ThisUserControl.ShowFormAsModal;

            WinForm form = new WinForm();
            if (modal)
            {
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }

        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
