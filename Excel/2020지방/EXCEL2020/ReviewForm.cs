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

        bool ExistReview => Globals.ReviewSheet.GetReviewList()
                .Where(x => x.UserNumber == _paymentData.UserNumber)
                .Where(x => x.PaymentNumber == _paymentData.PaymentNumber)
                .Where(x => x.RoomNumber == _roomData?.RoomNumber)
                .Any();

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

            AddOrUpdateButton.Text = ExistReview ? "수정" : "등록";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrUpdateButton_Click(object sender, EventArgs e)
        {
            var reviewData = new ReviewData
            {
                PaymentNumber = _paymentData.PaymentNumber,
                RoomNumber = _roomData.RoomNumber,
                UserNumber = _paymentData.UserNumber,
                Public = PublicOption.Checked,
                Grade = (double)RoomGradeNumber.Value,
                Comment = ReviewText.Text,
            };

            Globals.ReviewSheet.AddOrUpdateReview(reviewData);

            if (ExistReview)
            {
                MessageBox.Show("수정되었습니다.");
            }
            else
            {
                MessageBox.Show("리뷰를 등록했습니다.");
            }
        }
    }
}
