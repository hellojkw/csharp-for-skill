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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var texts = new[]
            {
                UserNameText.Text,
                IdText.Text,
                PwText.Text,
                YearSelect.Text,
                MonthSelect.Text,
                DaySelect.Text,
            };

            if (texts.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                MessageBox.Show("누락된 항목이 존재합니다.");
                return;
            }

            var userList = Globals.UserListSheet.GetUserList();
            if (userList.Any(x => x.Id == UserNameText.Text))
            {
                MessageBox.Show("아이디가 중복되었습니다.");
                return;
            }

            var specialChar = "!@#$";
            if (!specialChar.Any(chr => PwText.Text.Contains(chr)))
            {
                MessageBox.Show("비밀번호 형식이 틀립니다.");
                return;
            }
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (!alphabet.Any(chr => PwText.Text.Contains(chr)))
            {
                MessageBox.Show("비밀번호 형식이 틀립니다.");
                return;
            }
            var numbers = "0123456789";
            if (!numbers.Any(chr => PwText.Text.Contains(chr)))
            {
                MessageBox.Show("비밀번호 형식이 틀립니다.");
                return;
            }
            if (PwText.Text.Length < 6)
            {
                MessageBox.Show("비밀번호 형식이 틀립니다.");
                return;
            }

            var birthday = new DateTime(
                int.Parse(YearSelect.Text),
                int.Parse(MonthSelect.Text),
                int.Parse(DaySelect.Text)
                );

            var user = new UserData
            {
                Id = IdText.Text,
                Password = PwText.Text,
                Name = UserNameText.Text,
                Birthday = birthday,
                Point = 0,
                Grade = "일반",
            };

            Globals.UserListSheet.AddUser(user);

            MessageBox.Show("회원가입이 완료되었습니다.");
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
