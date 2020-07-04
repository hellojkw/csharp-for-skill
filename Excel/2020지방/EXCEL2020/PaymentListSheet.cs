using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public enum Status
    {
        CheckOut,
        CheckIn,
        NotYet,
    }
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

        public Status Status => CheckOutDate <= DateTime.Today ? Status.CheckOut
            : CheckInDate <= DateTime.Today ? Status.CheckIn
            : Status.NotYet;
    }

    public partial class PaymentListSheet
    {
        private void Sheet4_Startup(object sender, System.EventArgs e)
        {
            HideOtherUserData();

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
                var total = CalcTotal(paymentData.UserNumber, paymentData.RoomList.Select(x => x.RoomNo).ToList(), paymentData.CheckInDate, paymentData.CheckOutDate, userList, roomList);

                this.GetCell(paymentData.Row, 9).Value2 = total;
            });
        }

        public long CalcTotal(int userNo, List<string> roomNoList, DateTime checkInDate, DateTime checkOutDate, List<UserData> userList = null, List<RoomData> roomList = null)
        {
            if (userList == null)
                userList = Globals.UserListSheet.GetUserList().ToList();
            if (roomList == null)
                roomList = Globals.RoomListSheet.GetRoomList().ToList();

            var user = userList.FirstOrDefault(x => x.UserNumber == userNo);

            if (user == null)
                return 0;

            var usedDays = (int)(checkOutDate.Subtract(checkInDate).TotalDays);

            return roomNoList
                .Select(roomNo => roomList.FirstOrDefault(x => x.RoomNumber == roomNo))
                .Where(room => room != null)
                .Select(room => (long)(usedDays * room.UnitPrice * (1 - user.Discount)))
                .Sum();
        }

        private void HideOtherUserData()
        {
            var list = GetPaymentDataList().ToList();

            Globals.ThisWorkbook.ThisApplication.ScreenUpdating = false;

            list.ForEach(data =>
            {
                this.GetCell(data.Row, 1).EntireRow.Hidden = false;
            });

            var loginUser = Globals.MainSheet.LoginUser;

            if (loginUser != null)
            {
                list
                    .Where(x => x.UserNumber != loginUser.UserNumber)
                    .ToList()
                    .ForEach(data =>
                    {
                        this.GetCell(data.Row, 1).EntireRow.Hidden = true;
                    });
            }

            Globals.ThisWorkbook.ThisApplication.ScreenUpdating = true;
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
            this.ActivateEvent += () =>
            {
                HideOtherUserData();
            };
            this.BeforeRightClick += PaymentListSheet_BeforeRightClick;
        }

        private void PaymentListSheet_BeforeRightClick(Excel.Range Target, ref bool Cancel)
        {
            Office.CommandBar cellCommandBar = Globals.ThisWorkbook.Application.CommandBars["Cell"];

            if (cellCommandBar == null)
                return;

            cellCommandBar.Reset();

            var list = GetPaymentDataList().ToList();

            if (Target.Count != 1)
                return;
            if (Target.Column != 2)
                return;
            if (list.Empty(x => x.Row == Target.Row))
                return;

            while (cellCommandBar.Controls.Count > 0)
            {
                cellCommandBar.Controls[1].Delete(true);
            }

            var targetPaymentData = list.FirstOrDefault(x => x.Row == Target.Row);

            Office.CommandBarButton button = (CommandBarButton)cellCommandBar.Controls.Add(
                MsoControlType.msoControlButton,
                Temporary: true
                );
            if (button != null && targetPaymentData != null)
            {
                switch (targetPaymentData.Status)
                {
                    case Status.CheckOut:
                        button.Caption = "리뷰";
                        button.FaceId = 1087;
                        button.Click += (Office.CommandBarButton control, ref bool cancel) =>
                        {
                            new ReviewForm(targetPaymentData).ShowDialog();
                        };
                        break;
                    case Status.CheckIn:
                        button.Caption = "투숙중";
                        button.FaceId = 487;
                        button.Click += (Office.CommandBarButton control, ref bool cancel) =>
                        {
                            MessageBox.Show("투숙중인 고객입니다.");
                        };
                        break;
                    case Status.NotYet:
                        button.Caption = "삭제";
                        button.FaceId = 1088;
                        button.Click += (Office.CommandBarButton control, ref bool cancel) =>
                        {
                            var result = MessageBox.Show("예약을 삭제하시겠습니까?", "", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                this.GetCell(targetPaymentData.Row, 1).EntireRow.Delete();
                            }
                        };
                        break;
                    default:
                        cellCommandBar.Reset();
                        break;
                }
            }
            else
            {
                cellCommandBar.Reset();
            }
        }

        private void Button_Click(CommandBarButton Ctrl, ref bool CancelDefault)
        {
            MessageBox.Show("test");
        }

        #endregion

    }
}
