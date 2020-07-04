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
    public partial class ReviewForm : Form
    {
        PaymentData _paymentData;
        RoomData _roomData;

        public ReviewForm(PaymentData paymentData)
        {
            InitializeComponent();

            UpdateData(paymentData);

            RoomNoSelect.SelectedIndexChanged += RoomNoSelect_SelectedIndexChanged;
        }

        private void RoomNoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roomNo = RoomNoSelect.Text;
            _roomData = Globals.RoomListSheet.GetRoomList()
                .FirstOrDefault(x => x.RoomNumber == roomNo);

            if (_roomData != null)
            {
                RoomTypeLabel.Text = _roomData.RoomType;
                UpdateAddButtonText();
            }
        }

        private void UpdateData(PaymentData paymentData)
        {
            _paymentData = paymentData;
            RoomNoSelect.Items.Clear();
            RoomNoSelect.Items.AddRange(paymentData.RoomList.Select(x => x.RoomNo).ToArray());
            RoomTypeLabel.Text = "";
            RoomGradeNumber.Value = 0;
            RoomNoSelect.SelectedIndex = 0;
            RoomNoSelect_SelectedIndexChanged(null, null);
        }

        private void UpdateAddButtonText()
        {
            var existReview = Globals.ReviewSheet.GetReviewList()
                .Where(x => x.UserNumber == _paymentData.UserNumber)
                .Where(x => x.PaymentNumber == _paymentData.PaymentNumber)
                .Where(x => x.RoomNumber == _roomData?.RoomNumber)
                .Any();

            AddOrUpdateButton.Text = existReview ? "수정" : "등록";
        }
    }
}
