using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public class UserData
    {
        public int Row;
        public int UserNumber;
        public string Id;
        public string Password;
        public string Name;
        public DateTime Birthday;
        public long Point;
        public string Grade;

        public double Discount =>
            Grade == "최우수" ? 0.1 :
            Grade == "우수" ? 0.05 : 0;
    }

    public partial class UserListSheet
    {
        private void Sheet2_Startup(object sender, System.EventArgs e)
        {
            this.CreateButton("메인으로", Range["I1"], () => Globals.MainSheet.Activate());
        }

        private void Sheet2_Shutdown(object sender, System.EventArgs e)
        {
        }

        public IEnumerable<UserData> GetUserList()
        {
            var lastRow = UsedRange.Row + UsedRange.Rows.Count - 1;

            for (var row = 2; row <= lastRow; row++)
            {
                var userNo = this.GetCell(row, 1).AsInteger();
                var id = this.GetCell(row, 2).AsString();
                var pw = this.GetCell(row, 3).AsString();
                var name = this.GetCell(row, 4).AsString();
                var birthday = this.GetCell(row, 5).AsDateTime();
                var point = this.GetCell(row, 6).AsLong();
                var grade = this.GetCell(row, 7).AsString();

                yield return new UserData
                {
                    Row = row,
                    UserNumber = userNo,
                    Id = id,
                    Password = pw,
                    Name = name,
                    Birthday = birthday,
                    Point = point,
                    Grade = grade,
                };
            }
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet2_Startup);
            this.Shutdown += new System.EventHandler(Sheet2_Shutdown);
        }

        #endregion

    }
}
