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
    }
}
