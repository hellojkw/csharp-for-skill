using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
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
            ChartSelect.SelectedIndex = 0;
            ChartSelect_SelectedIndexChanged(null, null);
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
            this.ChartSelect.SelectedIndexChanged += new System.EventHandler(this.ChartSelect_SelectedIndexChanged);
            this.GotoMainButton.Click += new System.EventHandler(this.GotoMainButton_Click);
            this.Startup += new System.EventHandler(this.Sheet6_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet6_Shutdown);

        }

        #endregion

        private void GotoMainButton_Click(object sender, EventArgs e)
        {
            Globals.MainSheet.Activate();
        }

        private void ChartSelect_SelectedIndexChanged(object sender, EventArgs _)
        {
            var beginRow = 2;
            var lastRow = 0;
            var maximumIndex = 1;
            if (ChartSelect.Text == "월별")
            {
                var list = Globals.PaymentListSheet.GetPaymentDataList()
                    .GroupBy(x => x.CheckInDate.Month)
                    .Select((x, i) => new { Index = i, Month = x.Key, Total = x.Sum(e => e.TotalPrice) })
                    .OrderBy(x => x.Month)
                    .ToList();

                list.ForEach(x =>
                {
                    this.GetCell(beginRow + x.Index, 8).Value2 = x.Month + "월";
                    this.GetCell(beginRow + x.Index, 9).Value2 = x.Total;
                });

                lastRow = beginRow + list.Count;
                maximumIndex = list.OrderByDescending(x => x.Total).First().Index;
            }
            else if (ChartSelect.Text == "회원별")
            {
                var users = Globals.UserListSheet.GetUserList().ToDictionary(x => x.UserNumber, x => x);

                var list = Globals.PaymentListSheet.GetPaymentDataList()
                    .GroupBy(x => x.UserNumber)
                    .Select((x, i) => new { Index = i, UserName = users.ContainsKey(x.Key) ? users[x.Key].Name : $"User#{x.Key}", Total = x.Sum(e => e.TotalPrice) })
                    .OrderBy(x => x.UserName)
                    .ToList();

                list.ForEach(x =>
                {
                    this.GetCell(beginRow + x.Index, 8).Value2 = x.UserName;
                    this.GetCell(beginRow + x.Index, 9).Value2 = x.Total;
                });

                lastRow = beginRow + list.Count;
                maximumIndex = list.OrderByDescending(x => x.Total).First().Index;
            }
            else if (ChartSelect.Text == "객실번호별")
            {
                var userList = Globals.UserListSheet.GetUserList().ToList();
                var roomList = Globals.RoomListSheet.GetRoomList().ToList();

                var list = Globals.PaymentListSheet.GetPaymentDataList()
                    .SelectMany(x => x.RoomList.Select(e => new
                    {
                        e.RoomNo,
                        Total = Globals.PaymentListSheet.CalcTotal(x.UserNumber, new List<string>{ e.RoomNo }, x.CheckInDate, x.CheckOutDate, userList, roomList)
                    }))
                    .GroupBy(x => x.RoomNo)
                    .Select((x, i) => new { Index = i, RoomNo = x.Key, Total = x.Sum(e => e.Total) })
                    .OrderBy(x => x.RoomNo)
                    .ToList();

                list.ForEach(x =>
                {
                    this.GetCell(beginRow + x.Index, 8).Value2 = "'" + x.RoomNo;
                    this.GetCell(beginRow + x.Index, 9).Value2 = x.Total;
                });

                lastRow = beginRow + list.Count;
                maximumIndex = list.OrderByDescending(x => x.Total).First().Index;
            }

            var row = lastRow;
            while (this.GetCell(row, 8).Value2 != null)
            {
                this.GetCell(row, 8).Value2 = null;
                this.GetCell(row, 9).Value2 = null;
                row++;
            }

            this.Chart_1.SetSourceData(this.Range["H1", this.GetCell(lastRow - 1, 9)]);

            Chart_1.ClearToMatchStyle();
            Chart_1.ChartStyle = 293;
            var series = (Excel.Series)this.Chart_1.SeriesCollection(1);
            var point = (Excel.Point)series.Points(maximumIndex + 1);
            point.Format.Fill.ForeColor.RGB = (int)XlRgbColor.rgbRed;
            point.Format.Fill.Transparency = 0;
            point.Format.Fill.Solid();
        }
    }
}
