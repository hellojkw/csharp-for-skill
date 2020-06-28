using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL2020
{
    public partial class ReservationForm : Form
    {
        DateTime _checkInDate = DateTime.MinValue;
        DateTime _checkOutDate = DateTime.MinValue;

        List<RoomData> _freeRoomList;

        public ReservationForm()
        {
            InitializeComponent();

            GradeSelect.Items.AddRange(new[]
            {
                "상관없음",
                "Standard",
                "Superior",
                "Deluxe",
                "Suite",
            });
            GradeSelect.SelectedIndexChanged += (_, __) =>
            {
                CalcRemainRoomCount();
            };
        }

        private void CheckInText_Click(object sender, EventArgs e)
        {
            new CalendarForm(date =>
            {
                CheckInText.Text = date.ToString("yyyy-MM-dd");
                _checkInDate = date;
                if (_checkOutDate != DateTime.MinValue && _checkInDate >= _checkOutDate)
                {
                    _checkOutDate = DateTime.MinValue;
                    CheckOutText.Text = "";
                }
                CalcRemainRoomCount();
            }).ShowDialog();
        }

        private void CheckOutText_Click(object sender, EventArgs e)
        {
            new CalendarForm(date =>
            {
                CheckOutText.Text = date.ToString("yyyy-MM-dd");
                _checkOutDate = date;
                CalcRemainRoomCount();
            }, date => _checkInDate == DateTime.MinValue ? false : date < _checkInDate).ShowDialog();
        }

        private void CalcRemainRoomCount()
        {
            CommentLabel.Visible = false;
            if (string.IsNullOrWhiteSpace(GradeSelect.Text))
                return;
            if (_checkInDate == DateTime.MinValue)
                return;
            if (_checkOutDate == DateTime.MaxValue)
                return;

            var grade = GradeSelect.Text;
            var targetRoomList = Globals.RoomListSheet.GetRoomList()
                .Where(x => grade == "상관없음" ? true : x.RoomType == grade)
                .ToList();

            var reserveList = Globals.PaymentListSheet.GetPaymentDataList()
                .SelectMany(x => x.RoomList.Select(e => new { e.RoomNo, x.CheckInDate, x.CheckOutDate }))
                .ToList();

            var freeRoomList = targetRoomList
                .Where(room =>
                {
                    var conflictList = reserveList
                        .Where(r => r.RoomNo == room.RoomNumber)
                        .Where(r => Utils.IsConflict(_checkInDate, _checkOutDate, r.CheckInDate, r.CheckOutDate))
                        .ToList();
                    return !conflictList.Any();
                })
                .ToList();

            RoomCount.Items.Clear();
            RoomCount.Items.AddRange(Enumerable.Range(1, freeRoomList.Count)
                .Select(x => x.ToString())
                .ToArray());

            _freeRoomList = freeRoomList;
            if (freeRoomList.Any())
            {
                CommentLabel.Text = $"현재 사용가능한 객실이 {freeRoomList.Count}개 있습니다.";
                CommentLabel.ForeColor = Color.Black;
            }
            else
            {
                CommentLabel.Text = $"사용 가능한 객실이 없습니다.";
                CommentLabel.ForeColor = Color.Red;
            }
            CommentLabel.Visible = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var orderData = new OrderData
            {
                User = Globals.MainSheet.LoginUser,
                CheckInDate = _checkInDate,
                CheckOutDate = _checkOutDate,
            };
            new SelectRoomForm(orderData, int.Parse(RoomCount.Text), _freeRoomList).Show();
        }
    }
}
