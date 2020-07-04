namespace EXCEL2020
{
    partial class ReviewForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomNoSelect = new System.Windows.Forms.ComboBox();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.RoomGradeNumber = new System.Windows.Forms.NumericUpDown();
            this.PublicOption = new System.Windows.Forms.RadioButton();
            this.PrivateOption = new System.Windows.Forms.RadioButton();
            this.ReviewText = new System.Windows.Forms.TextBox();
            this.AddOrUpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGradeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "객실번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "객실구분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "평점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "공개여부";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "리뷰";
            // 
            // RoomNoSelect
            // 
            this.RoomNoSelect.FormattingEnabled = true;
            this.RoomNoSelect.Location = new System.Drawing.Point(131, 16);
            this.RoomNoSelect.Name = "RoomNoSelect";
            this.RoomNoSelect.Size = new System.Drawing.Size(173, 28);
            this.RoomNoSelect.TabIndex = 1;
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(131, 57);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(70, 20);
            this.RoomTypeLabel.TabIndex = 0;
            this.RoomTypeLabel.Text = "Standard";
            // 
            // RoomGradeNumber
            // 
            this.RoomGradeNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.RoomGradeNumber.Location = new System.Drawing.Point(131, 96);
            this.RoomGradeNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RoomGradeNumber.Name = "RoomGradeNumber";
            this.RoomGradeNumber.Size = new System.Drawing.Size(173, 27);
            this.RoomGradeNumber.TabIndex = 2;
            // 
            // PublicOption
            // 
            this.PublicOption.AutoSize = true;
            this.PublicOption.Location = new System.Drawing.Point(131, 143);
            this.PublicOption.Name = "PublicOption";
            this.PublicOption.Size = new System.Drawing.Size(39, 24);
            this.PublicOption.TabIndex = 3;
            this.PublicOption.TabStop = true;
            this.PublicOption.Text = "O";
            this.PublicOption.UseVisualStyleBackColor = true;
            // 
            // PrivateOption
            // 
            this.PrivateOption.AutoSize = true;
            this.PrivateOption.Location = new System.Drawing.Point(210, 143);
            this.PrivateOption.Name = "PrivateOption";
            this.PrivateOption.Size = new System.Drawing.Size(36, 24);
            this.PrivateOption.TabIndex = 3;
            this.PrivateOption.TabStop = true;
            this.PrivateOption.Text = "X";
            this.PrivateOption.UseVisualStyleBackColor = true;
            // 
            // ReviewText
            // 
            this.ReviewText.Location = new System.Drawing.Point(24, 215);
            this.ReviewText.Multiline = true;
            this.ReviewText.Name = "ReviewText";
            this.ReviewText.Size = new System.Drawing.Size(334, 131);
            this.ReviewText.TabIndex = 4;
            // 
            // AddOrUpdateButton
            // 
            this.AddOrUpdateButton.Location = new System.Drawing.Point(24, 367);
            this.AddOrUpdateButton.Name = "AddOrUpdateButton";
            this.AddOrUpdateButton.Size = new System.Drawing.Size(129, 33);
            this.AddOrUpdateButton.TabIndex = 5;
            this.AddOrUpdateButton.Text = "등록";
            this.AddOrUpdateButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(229, 367);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(129, 33);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 426);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddOrUpdateButton);
            this.Controls.Add(this.ReviewText);
            this.Controls.Add(this.PrivateOption);
            this.Controls.Add(this.PublicOption);
            this.Controls.Add(this.RoomGradeNumber);
            this.Controls.Add(this.RoomNoSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomTypeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReviewForm";
            this.Text = "리뷰등록수정";
            ((System.ComponentModel.ISupportInitialize)(this.RoomGradeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoomNoSelect;
        private System.Windows.Forms.Label RoomTypeLabel;
        private System.Windows.Forms.NumericUpDown RoomGradeNumber;
        private System.Windows.Forms.RadioButton PublicOption;
        private System.Windows.Forms.RadioButton PrivateOption;
        private System.Windows.Forms.TextBox ReviewText;
        private System.Windows.Forms.Button AddOrUpdateButton;
        private System.Windows.Forms.Button CancelButton;
    }
}