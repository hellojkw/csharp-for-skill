namespace EXCEL2020
{
    partial class OrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.RoomMaximumLabel = new System.Windows.Forms.Label();
            this.RoomUnitPriceLabel = new System.Windows.Forms.Label();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserCount = new System.Windows.Forms.NumericUpDown();
            this.RoomNoSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PointOption = new System.Windows.Forms.RadioButton();
            this.CashOption = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.UserPointLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.RoomListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddRoomButton);
            this.groupBox1.Controls.Add(this.RoomMaximumLabel);
            this.groupBox1.Controls.Add(this.RoomUnitPriceLabel);
            this.groupBox1.Controls.Add(this.RoomTypeLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserCount);
            this.groupBox1.Controls.Add(this.RoomNoSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택 객실 확인";
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(23, 441);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(322, 31);
            this.AddRoomButton.TabIndex = 10;
            this.AddRoomButton.Text = "확인";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // RoomMaximumLabel
            // 
            this.RoomMaximumLabel.AutoSize = true;
            this.RoomMaximumLabel.Location = new System.Drawing.Point(112, 366);
            this.RoomMaximumLabel.Name = "RoomMaximumLabel";
            this.RoomMaximumLabel.Size = new System.Drawing.Size(69, 20);
            this.RoomMaximumLabel.TabIndex = 9;
            this.RoomMaximumLabel.Text = "선택객실";
            // 
            // RoomUnitPriceLabel
            // 
            this.RoomUnitPriceLabel.AutoSize = true;
            this.RoomUnitPriceLabel.Location = new System.Drawing.Point(112, 325);
            this.RoomUnitPriceLabel.Name = "RoomUnitPriceLabel";
            this.RoomUnitPriceLabel.Size = new System.Drawing.Size(69, 20);
            this.RoomUnitPriceLabel.TabIndex = 8;
            this.RoomUnitPriceLabel.Text = "선택객실";
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(112, 282);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(69, 20);
            this.RoomTypeLabel.TabIndex = 7;
            this.RoomTypeLabel.Text = "선택객실";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "최대인원수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "1박요금";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "객실구분";
            // 
            // UserCount
            // 
            this.UserCount.Location = new System.Drawing.Point(243, 227);
            this.UserCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserCount.Name = "UserCount";
            this.UserCount.Size = new System.Drawing.Size(120, 27);
            this.UserCount.TabIndex = 3;
            this.UserCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserCount.ValueChanged += new System.EventHandler(this.UserCount_ValueChanged);
            // 
            // RoomNoSelect
            // 
            this.RoomNoSelect.FormattingEnabled = true;
            this.RoomNoSelect.Location = new System.Drawing.Point(116, 227);
            this.RoomNoSelect.Name = "RoomNoSelect";
            this.RoomNoSelect.Size = new System.Drawing.Size(121, 28);
            this.RoomNoSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "선택객실";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CancelButton);
            this.groupBox2.Controls.Add(this.SubmitButton);
            this.groupBox2.Controls.Add(this.PointOption);
            this.groupBox2.Controls.Add(this.CashOption);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.UserPointLabel);
            this.groupBox2.Controls.Add(this.TotalPriceLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CheckOutLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CheckInLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DeleteRoomButton);
            this.groupBox2.Controls.Add(this.RoomListView);
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결제 정보";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(227, 440);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 32);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(86, 440);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 32);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "결제";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // PointOption
            // 
            this.PointOption.AutoSize = true;
            this.PointOption.Location = new System.Drawing.Point(227, 389);
            this.PointOption.Name = "PointOption";
            this.PointOption.Size = new System.Drawing.Size(72, 24);
            this.PointOption.TabIndex = 4;
            this.PointOption.TabStop = true;
            this.PointOption.Text = "포인트";
            this.PointOption.UseVisualStyleBackColor = true;
            // 
            // CashOption
            // 
            this.CashOption.AutoSize = true;
            this.CashOption.Location = new System.Drawing.Point(142, 389);
            this.CashOption.Name = "CashOption";
            this.CashOption.Size = new System.Drawing.Size(57, 24);
            this.CashOption.TabIndex = 3;
            this.CashOption.TabStop = true;
            this.CashOption.Text = "현금";
            this.CashOption.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "체크인";
            // 
            // UserPointLabel
            // 
            this.UserPointLabel.AutoSize = true;
            this.UserPointLabel.Location = new System.Drawing.Point(138, 345);
            this.UserPointLabel.Name = "UserPointLabel";
            this.UserPointLabel.Size = new System.Drawing.Size(54, 20);
            this.UserPointLabel.TabIndex = 2;
            this.UserPointLabel.Text = "체크인";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(138, 300);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(54, 20);
            this.TotalPriceLabel.TabIndex = 2;
            this.TotalPriceLabel.Text = "체크인";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "체크인";
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Location = new System.Drawing.Point(138, 257);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(54, 20);
            this.CheckOutLabel.TabIndex = 2;
            this.CheckOutLabel.Text = "체크인";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "체크인";
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Location = new System.Drawing.Point(138, 215);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(54, 20);
            this.CheckInLabel.TabIndex = 2;
            this.CheckInLabel.Text = "체크인";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "체크인";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "체크인";
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(320, 162);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(100, 32);
            this.DeleteRoomButton.TabIndex = 1;
            this.DeleteRoomButton.Text = "삭제";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // RoomListView
            // 
            this.RoomListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.RoomListView.FullRowSelect = true;
            this.RoomListView.GridLines = true;
            this.RoomListView.HideSelection = false;
            this.RoomListView.Location = new System.Drawing.Point(6, 26);
            this.RoomListView.Name = "RoomListView";
            this.RoomListView.Size = new System.Drawing.Size(414, 130);
            this.RoomListView.TabIndex = 0;
            this.RoomListView.UseCompatibleStateImageBehavior = false;
            this.RoomListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "객실번호";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "객실구분";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "인원";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "1박요금";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.Text = "결제";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Label RoomMaximumLabel;
        private System.Windows.Forms.Label RoomUnitPriceLabel;
        private System.Windows.Forms.Label RoomTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UserCount;
        private System.Windows.Forms.ComboBox RoomNoSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.RadioButton PointOption;
        private System.Windows.Forms.RadioButton CashOption;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label UserPointLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.ListView RoomListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}