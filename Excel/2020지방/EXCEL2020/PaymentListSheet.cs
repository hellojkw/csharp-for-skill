using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public class PaymentData
    {
        public int Row;
        public int PaymentNumber;
        public int UserNumber;
        public List<(string RoomNo, int VisitorCount)> RoomList;
        public DateTime ReserveDate;
        public DateTime CheckInDate;
        public DateTime CheckOutDate;
        public string UsedCurrencyType;
        public long TotalPrice;
    }

    public partial class PaymentListSheet
    {
        private void Sheet4_Startup(object sender, System.EventArgs e)
        {
            UpdateTotalPrice();

            this.CreateButton("메인으로", Range["K1"], () =>
            {
                Globals.MainSheet.Activate();
            });
        }

        private void UpdateTotalPrice()
        {
            var paymentList = GetPaymentDataList().ToList();
            var userList = Globals.UserListSheet.GetUserList().ToList();
            var roomList = Globals.RoomListSheet.GetRoomList().ToList();

            paymentList.ForEach(paymentData =>
            {
                var user = userList.FirstOrDefault(x => x.UserNumber == paymentData.UserNumber);

                if (user != null)
                {
                    var usedDays = (int)(paymentData.CheckOutDate.Subtract(paymentData.CheckInDate).TotalDays);
                    paymentData.TotalPrice = paymentData.RoomList
                        .Select(room => roomList.FirstOrDefault(x => x.RoomNumber == room.RoomNo))
                        .Where(room => room != null)
                        .Select(room => (long)(usedDays * room.UnitPrice * (1 - user.Discount)))
                        .Sum();

                    this.GetCell(paymentData.Row, 9).Value2 = paymentData.TotalPrice;
                }
            });
        }

        public IEnumerable<PaymentData> GetPaymentDataList()
        {
            var lastRow = UsedRange.Row + UsedRange.Rows.Count - 1;
            for (var row = 2; row <= lastRow; row++)
            {
                var paymentNo = this.GetCell(row, 1).AsInteger();
                var userNo = this.GetCell(row, 2).AsInteger();
                var roomList = this.GetCell(row, 3).AsString()
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToList();
                var visitorCount = this.GetCell(row, 4).AsString()
                    .Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToList();
                var reserveDate = this.GetCell(row, 5).AsDateTime();
                var checkInDate = this.GetCell(row, 6).AsDateTime();
                var checkOutDate = this.GetCell(row, 7).AsDateTime();
                var currencyType = this.GetCell(row, 8).AsString();
                var totalPrice = this.GetCell(row, 9).AsLong();

                yield return new PaymentData
                {
                    Row = row,
                    PaymentNumber = paymentNo,
                    UserNumber = userNo,
                    RoomList = roomList.Zip(visitorCount, (a, b) => (a, b)).ToList(),
                    ReserveDate = reserveDate,
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    UsedCurrencyType = currencyType,
                    TotalPrice = totalPrice,
                };
            }
        }

        public void AddPaymentData(PaymentData data)
        {
            var row = UsedRange.Row + UsedRange.Rows.Count;
            var list = GetPaymentDataList().Select(x => x.PaymentNumber);
            this.GetCell(row, 1).Value2 = list.Any() ? list.Max() + 1 : 1;
            this.GetCell(row, 2).Value2 = data.UserNumber;
            this.GetCell(row, 3).Value2 = data.RoomList.Select(x => x.RoomNo).StringJoin(",");
            this.GetCell(row, 4).Value2 = data.RoomList.Select(x => x.VisitorCount.ToString()).StringJoin(",");
            this.GetCell(row, 5).Value2 = data.ReserveDate;
            this.GetCell(row, 6).Value2 = data.CheckInDate;
            this.GetCell(row, 7).Value2 = data.CheckOutDate;
            this.GetCell(row, 8).Value2 = data.UsedCurrencyType;
            this.GetCell(row, 9).Value2 = data.TotalPrice;

            UpdateTotalPrice();
        }

        private void Sheet4_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet4_Startup);
            this.Shutdown += new System.EventHandler(Sheet4_Shutdown);
        }

        #endregion

    }
}
