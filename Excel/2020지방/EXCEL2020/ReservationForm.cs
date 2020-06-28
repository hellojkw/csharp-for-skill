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
        DateTime _checkInDate;
        DateTime _checkOutDate;

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
        }

        private void CheckInText_Click(object sender, EventArgs e)
        {
            new CalendarForm(date =>
            {
                CheckInText.Text = date.ToString("yyyy-MM-dd");
                _checkInDate = date;
            }).ShowDialog();
        }

        private void CheckOutText_Click(object sender, EventArgs e)
        {
            new CalendarForm(date =>
            {
                CheckOutText.Text = date.ToString("yyyy-MM-dd");
                _checkOutDate = date;
            }, date => _checkInDate == null ? false : date < _checkInDate).ShowDialog();
        }
    }
}
