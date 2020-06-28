using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public partial class ChartSheet
    {
        private void Sheet6_Startup(object sender, System.EventArgs e)
        {
            ChartSelect.Items.AddRange(new[]
            {
                "월별",
                "회원별",
                "객실번호별",
            });
            ChartSelect.Text = "";
        }

        private void Sheet6_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.GotoMainButton.Click += new System.EventHandler(this.GotoMainButton_Click);
            this.Startup += new System.EventHandler(this.Sheet6_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet6_Shutdown);

        }

        #endregion

        private void GotoMainButton_Click(object sender, EventArgs e)
        {
            Globals.MainSheet.Activate();
        }
    }
}
