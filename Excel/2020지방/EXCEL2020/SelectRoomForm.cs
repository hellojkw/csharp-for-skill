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
    public partial class SelectRoomForm : Form
    {
        int _roomCount;

        public SelectRoomForm(int roomCount, List<RoomData> freeRoomList = null)
        {
            InitializeComponent();

            _roomCount = roomCount;
            FreeRoomCountLabel.Text = $"{_roomCount}개";

            InitRoomListView(freeRoomList);
        }

        private void InitRoomListView(List<RoomData> freeRoomList)
        {
            RoomListView.View = View.Details;
            RoomListView.GridLines = true;
            RoomListView.FullRowSelect = true;
            RoomListView.CheckBoxes = true;

            RoomListView.Columns.Add("객실번호", 100, HorizontalAlignment.Left);
            RoomListView.Columns.Add("객실구분", 100, HorizontalAlignment.Center);
            RoomListView.Columns.Add("최대인원", 100, HorizontalAlignment.Center);
            RoomListView.Columns.Add("1박요금", 100, HorizontalAlignment.Center);

            if (freeRoomList == null)
                freeRoomList = Globals.RoomListSheet.GetRoomList().ToList();

            freeRoomList.ForEach(room =>
            {
                RoomListView.Items.Add(new ListViewItem(new string[]
                {
                    room.RoomNumber,
                    room.RoomType,
                    room.MaximumCount + "명",
                    room.UnitPrice.ToString("#,#"),
                }));
            });

            RoomListView.ItemChecked += (_, __) =>
            {
                var selectedCount = 0;
                foreach (ListViewItem item in RoomListView.Items)
                {
                    if (item.Checked)
                    {
                        selectedCount++;
                    }
                }
                SelectedRoomCountLabel.Text = $"{selectedCount}개";

                if (selectedCount > _roomCount)
                {
                    MessageBox.Show("선택 가능한 방 개수를 초과 했습니다.");
                    foreach (ListViewItem item in RoomListView.Items)
                    {
                        item.Checked = false;
                    }
                    return;
                }

                NextButton.Enabled = selectedCount > 0;
            };
        }
    }
}
