using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Tools;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace EXCEL2020
{
    public class ReviewData
    {
        public int Row;
        public int ReviewNumber;
        public int PaymentNumber;
        public int UserNumber;
        public bool Public;
        public string RoomNumber;
        public double Grade;
        public string Comment;
    }

    public partial class ReviewSheet
    {
        private void Sheet5_Startup(object sender, System.EventArgs e)
        {
            HidePrivateReview();

            this.CreateButton("메인으로", Range["I1"], () =>
            {
                Globals.MainSheet.Activate();
            });
        }

        private void Sheet5_Shutdown(object sender, System.EventArgs e)
        {
        }

        public IEnumerable<ReviewData> GetReviewList()
        {
            var lastRow = UsedRange.Row + UsedRange.Rows.Count - 1;

            for (var row = 2; row <= lastRow; row++)
            {
                yield return new ReviewData
                {
                    Row = row,
                    ReviewNumber = this.GetCell(row, 1).AsInteger(),
                    PaymentNumber = this.GetCell(row, 2).AsInteger(),
                    UserNumber = this.GetCell(row, 3).AsInteger(),
                    Public = this.GetCell(row, 4).AsBoolean(str => str == "O"),
                    RoomNumber = this.GetCell(row, 5).AsString(),
                    Grade = this.GetCell(row, 6).Value2,
                    Comment = this.GetCell(row, 7).AsString(),
                };
            }
        }

        public void AddOrUpdateReview(ReviewData reviewData)
        {
            var existReview = GetReviewList()
                .Where(x => x.UserNumber == reviewData.UserNumber)
                .Where(x => x.PaymentNumber == reviewData.PaymentNumber)
                .Where(x => x.RoomNumber == reviewData.RoomNumber)
                .FirstOrDefault();

            if (existReview != null)
            {
                reviewData.Row = existReview.Row;
                reviewData.ReviewNumber = existReview.ReviewNumber;
            }
            else
            {
                reviewData.Row = UsedRange.Row + UsedRange.Rows.Count;
                reviewData.ReviewNumber = GetReviewList().Any() ? GetReviewList().Max(x => x.ReviewNumber) + 1 : 1;
            }

            this.GetCell(reviewData.Row, 1).Value2 = reviewData.ReviewNumber;
            this.GetCell(reviewData.Row, 2).Value2 = reviewData.PaymentNumber;
            this.GetCell(reviewData.Row, 3).Value2 = reviewData.UserNumber;
            this.GetCell(reviewData.Row, 4).Value2 = reviewData.Public;
            this.GetCell(reviewData.Row, 5).Value2 = reviewData.RoomNumber;
            this.GetCell(reviewData.Row, 6).Value2 = reviewData.Grade;
            this.GetCell(reviewData.Row, 7).Value2 = reviewData.Comment;

            Globals.ReviewSheet.Activate();
        }

        private void HidePrivateReview()
        {
            var reviewList = GetReviewList().ToList();

            var isLogin = Globals.MainSheet.IsLogin;
            var loginUser = Globals.MainSheet.LoginUser;

            Globals.ThisWorkbook.Application.ScreenUpdating = false;
            reviewList.ForEach(review =>
            {
                this.GetCell(review.Row, 1).EntireRow.Hidden = false;
                if (isLogin)
                {
                    if (review.UserNumber != loginUser.UserNumber && !review.Public)
                    {
                        this.GetCell(review.Row, 1).EntireRow.Hidden = true;
                    }

                }
                else if (!review.Public)
                {
                    this.GetCell(review.Row, 1).EntireRow.Hidden = true;
                }
            });
            Globals.ThisWorkbook.Application.ScreenUpdating = true;
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet5_Startup);
            this.Shutdown += new System.EventHandler(Sheet5_Shutdown);

            this.ActivateEvent += ReviewSheet_ActivateEvent;
        }

        private void ReviewSheet_ActivateEvent()
        {
            HidePrivateReview();
        }

        #endregion

    }
}
