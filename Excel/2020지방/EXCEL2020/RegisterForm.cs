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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            var years = Enumerable.Range(1900, DateTime.Today.Year - 1900 + 1)
                .Select(x => x.ToString())
                .ToArray();
            YearSelect.Items.AddRange(years);
            MonthSelect.Items.AddRange(Enumerable.Range(1, 12).Select(x => x.ToString()).ToArray());

            YearSelect.SelectedIndexChanged += (s, ee) =>
            {
                MonthSelect.Text = "";
                DaySelect.Text = "";
            };

            MonthSelect.SelectedIndexChanged += (s, ee) =>
            {
                DaySelect.Text = "";
                DaySelect.Items.Clear();
                if (int.TryParse(YearSelect.Text, out var year)
                    && int.TryParse(MonthSelect.Text, out var month))
                {
                    var date = new DateTime(year, month, 1);

                    while (date.Month == month)
                    {
                        DaySelect.Items.Add(date.Day);
                        date = date.AddDays(1);
                    }
                }
            };
        }
    }
}
