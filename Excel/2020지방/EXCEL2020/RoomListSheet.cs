using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public class RoomData
    {
        public int Row;
        public string RoomNumber;
        public string RoomType;
        public int MaximumCount;
        public long UnitPrice;
    }

    public partial class RoomListSheet
    {
        private void Sheet3_Startup(object sender, System.EventArgs e)
        {
        }

        private void Sheet3_Shutdown(object sender, System.EventArgs e)
        {
        }

        public IEnumerable<RoomData> GetRoomList()
        {
            var lastRow = UsedRange.Row + UsedRange.Rows.Count - 1;
            for (var row = 2; row <= lastRow; row++)
            {
                yield return new RoomData
                {
                    Row = row,
                    RoomNumber = this.GetCell(row, 1).AsString(),
                    RoomType = this.GetCell(row, 2).AsString(),
                    MaximumCount = this.GetCell(row, 3).AsInteger(str => int.Parse(str.Replace("명", ""))),
                    UnitPrice = this.GetCell(row, 4).AsLong(),
                };
            }
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet3_Startup);
            this.Shutdown += new System.EventHandler(Sheet3_Shutdown);
        }

        #endregion

    }
}
