using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            Globals.MainSheet.Name = "Main";
            Globals.UserListSheet.Name = "회원정보";
            Globals.RoomListSheet.Name = "객실정보";
            Globals.PaymentListSheet.Name = "결제내역";
            Globals.ReviewSheet.Name = "리뷰";
            Globals.ChartSheet.Name = "차트";

            Globals.MainSheet.Activate();
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
            this.SheetActivate += (sheet) =>
            {
                this.Application.CommandBars["Cell"]?.Reset();
            };
        }

        #endregion

    }
}
