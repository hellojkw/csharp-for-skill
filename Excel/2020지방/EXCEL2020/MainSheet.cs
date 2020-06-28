using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;

namespace EXCEL2020
{
    public partial class MainSheet
    {
        Tools.Controls.Button _loginButton;
        Tools.Controls.Button _logoutButton;
        Tools.Controls.Button _reservationButton;
        Tools.Controls.Button _paymentListButton;

        public UserData LoginUser;

        public bool IsLogin => LoginUser != null;

        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            CreateButtons();
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void CreateLoginButton()
        {
            _loginButton = this.CreateButton("로그인", Range["J3"], () =>
            {
                var loginForm = new LoginForm();
                loginForm.LoginSuccess += LoginForm_LoginSuccess;
                loginForm.ShowDialog();
            });
        }

        private void CreateButtons()
        {
            #region 로그인 버튼

            CreateLoginButton();

            #endregion

            #region 예약 버튼

            _reservationButton = new Tools.Controls.Button();
            _reservationButton.Text = "예약";
            _reservationButton.Enabled = false;
            _reservationButton.Click += (_, __) => new ReservationForm().ShowDialog();
            Controls.AddControl(_reservationButton, Range["C7"], "예약");

            #endregion

            #region 결제내역 버튼

            _paymentListButton = new Tools.Controls.Button();
            _paymentListButton.Text = "결제내역";
            _paymentListButton.Enabled = false;
            _paymentListButton.Click += (_, __) => Globals.PaymentListSheet.Activate();
            Controls.AddControl(_paymentListButton, Range["E7"], "결제내역");

            #endregion

            #region 집계차트 버튼

            var summaryButton = new Tools.Controls.Button();
            summaryButton.Text = "집계차트";
            summaryButton.Click += (_, __) => Globals.ChartSheet.Activate();
            Controls.AddControl(summaryButton, Range["G7"], "집계차트");

            #endregion

            #region 리뷰 버튼

            var reviewButton = new Tools.Controls.Button();
            reviewButton.Text = "리뷰";
            reviewButton.Click += (_, __) => Globals.ReviewSheet.Activate();
            Controls.AddControl(reviewButton, Range["D10"], "리뷰");

            #endregion

            #region 종료

            var closeButton = new Tools.Controls.Button();
            closeButton.Click += (_, __) =>
            {
                Globals.ThisWorkbook.Save();
                Globals.ThisWorkbook.Close();
            };
            closeButton.Text = "종료";
            Controls.AddControl(closeButton, Range["F10"], "종료");

            #endregion
        }

        private void LoginForm_LoginSuccess(object sender, UserData loginUser)
        {
            LoginUser = loginUser;
            MessageBox.Show($"{loginUser.Name}님 로그인 하셨습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ((LoginForm)sender).Close();

            Controls.Remove(_loginButton);

            _logoutButton = this.CreateButton("로그아웃", Range["J3"], () =>
            {
                LoginUser = null;
                Controls.Remove(_logoutButton);

                CreateLoginButton();

                _reservationButton.Enabled = false;
                _paymentListButton.Enabled = false;
            });

            _reservationButton.Enabled = true;
            _paymentListButton.Enabled = true;
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
