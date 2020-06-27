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
    public partial class LoginForm : Form
    {
        public event EventHandler<UserData> LoginSuccess;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdText.Text)
                || string.IsNullOrWhiteSpace(PasswordText.Text))
            {
                MessageBox.Show("누락된 항목이 있습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var userList = Globals.UserListSheet.GetUserList().ToList();

            var id = IdText.Text;
            var pw = PasswordText.Text;

            var user = userList
                .Where(x => x.Id == id)
                .Where(x => x.Password == pw)
                .FirstOrDefault();

            if (user != null)
            {
                LoginSuccess?.Invoke(this, user);
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
