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
        public SelectRoomForm()
        {
            InitializeComponent();
            RoomListBox.DataSource = new object[]
            {
                new { A = 1, B = 2 },
                new { A = 1, B = 2 },
                new { A = 1, B = 2 },
                new { A = 1, B = 2 },
            };
        }
    }
}
