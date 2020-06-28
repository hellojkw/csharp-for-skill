using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public partial class ReviewSheet
    {
        private void Sheet5_Startup(object sender, System.EventArgs e)
        {
            this.CreateButton("메인으로", Range["H1"], () =>
            {
                Globals.MainSheet.Activate();
            });
        }

        private void Sheet5_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet5_Startup);
            this.Shutdown += new System.EventHandler(Sheet5_Shutdown);
        }

        #endregion

    }
}
