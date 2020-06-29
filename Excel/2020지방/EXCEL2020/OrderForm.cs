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
    public partial class OrderForm : Form
    {
        OrderData _orderData;

        public OrderForm(OrderData orderData, List<RoomData> selectedRoomList)
        {
            InitializeComponent();

            _orderData = orderData;

            SubmitButton.Enabled = false;
            CancelButton.Enabled = false;

            InitRoomNoSelect(selectedRoomList);
            InitOrderData();
        }

        private void InitRoomNoSelect(List<RoomData> selectedRoomList)
        {
            RoomNoSelect.Items.AddRange(selectedRoomList
                .Select(x => x.RoomNumber.ToString())
                .ToArray());

            RoomNoSelect.SelectedIndexChanged += (_, __) =>
            {
                var room = selectedRoomList[RoomNoSelect.SelectedIndex];
                RoomTypeLabel.Text = room.RoomType;
                RoomUnitPriceLabel.Text = room.UnitPrice.ToString("#,#") + "원";
                RoomMaximumLabel.Text = room.MaximumCount + "명";
            };
        }

        private void InitOrderData()
        {
            CheckInLabel.Text = _orderData.CheckInDate.ToString("yyyy-MM-dd");
            CheckOutLabel.Text = _orderData.CheckOutDate.ToString("yyyy-MM-dd");
            UserPointLabel.Text = _orderData.User.Point.ToString("#,#") + "원";
        }

        private void UserCount_ValueChanged(object sender, EventArgs e)
        {
            var roomNo = RoomNoSelect.Text;
            var room = Globals.RoomListSheet.GetRoomList().FirstOrDefault(x => x.RoomNumber == roomNo);
            if (room == null)
                return;

            if (UserCount.Value > room.MaximumCount)
            {
                MessageBox.Show("선택 가능한 인원수를 초과했습니다.");
                UserCount.Value = room.MaximumCount;
                return;
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
        }
    }
}
