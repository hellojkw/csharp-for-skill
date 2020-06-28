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

            SubmitButton.Enabled = false;
            CancelButton.Enabled = false;

            InitRoomNoSelect(selectedRoomList);
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
    }
}
