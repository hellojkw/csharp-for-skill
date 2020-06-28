namespace EXCEL2020
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CheckInText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckOutText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GradeSelect = new System.Windows.Forms.ComboBox();
            this.RoomCount = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜";
            // 
            // CheckInText
            // 
            this.CheckInText.Location = new System.Drawing.Point(150, 41);
            this.CheckInText.Name = "CheckInText";
            this.CheckInText.Size = new System.Drawing.Size(121, 27);
            this.CheckInText.TabIndex = 1;
            this.CheckInText.Click += new System.EventHandler(this.CheckInText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "체크인";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "체크아웃";
            // 
            // CheckOutText
            // 
            this.CheckOutText.Location = new System.Drawing.Point(304, 41);
            this.CheckOutText.Name = "CheckOutText";
            this.CheckOutText.Size = new System.Drawing.Size(121, 27);
            this.CheckOutText.TabIndex = 3;
            this.CheckOutText.Click += new System.EventHandler(this.CheckOutText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "등급";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "객실";
            // 
            // GradeSelect
            // 
            this.GradeSelect.FormattingEnabled = true;
            this.GradeSelect.Location = new System.Drawing.Point(150, 98);
            this.GradeSelect.Name = "GradeSelect";
            this.GradeSelect.Size = new System.Drawing.Size(121, 28);
            this.GradeSelect.TabIndex = 7;
            // 
            // RoomCount
            // 
            this.RoomCount.FormattingEnabled = true;
            this.RoomCount.Location = new System.Drawing.Point(150, 154);
            this.RoomCount.Name = "RoomCount";
            this.RoomCount.Size = new System.Drawing.Size(121, 28);
            this.RoomCount.TabIndex = 8;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(370, 207);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 31);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "다음";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(29, 218);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(50, 20);
            this.CommentLabel.TabIndex = 10;
            this.CommentLabel.Text = "label6";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 268);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RoomCount);
            this.Controls.Add(this.GradeSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckOutText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckInText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReservationForm";
            this.Text = "예약";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CheckInText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CheckOutText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GradeSelect;
        private System.Windows.Forms.ComboBox RoomCount;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label CommentLabel;
    }
}