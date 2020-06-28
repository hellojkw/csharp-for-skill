namespace EXCEL2020
{
    partial class RegisterForm
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PwText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YearSelect = new System.Windows.Forms.ComboBox();
            this.MonthSelect = new System.Windows.Forms.ComboBox();
            this.DaySelect = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(123, 21);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(113, 27);
            this.UserNameText.TabIndex = 1;
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(123, 54);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(113, 27);
            this.IdText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "아이디";
            // 
            // PwText
            // 
            this.PwText.Location = new System.Drawing.Point(123, 87);
            this.PwText.Name = "PwText";
            this.PwText.PasswordChar = '●';
            this.PwText.Size = new System.Drawing.Size(113, 27);
            this.PwText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "생년월일";
            // 
            // YearSelect
            // 
            this.YearSelect.FormattingEnabled = true;
            this.YearSelect.Location = new System.Drawing.Point(123, 120);
            this.YearSelect.Name = "YearSelect";
            this.YearSelect.Size = new System.Drawing.Size(113, 28);
            this.YearSelect.TabIndex = 7;
            // 
            // MonthSelect
            // 
            this.MonthSelect.FormattingEnabled = true;
            this.MonthSelect.Location = new System.Drawing.Point(242, 120);
            this.MonthSelect.Name = "MonthSelect";
            this.MonthSelect.Size = new System.Drawing.Size(113, 28);
            this.MonthSelect.TabIndex = 8;
            // 
            // DaySelect
            // 
            this.DaySelect.FormattingEnabled = true;
            this.DaySelect.Location = new System.Drawing.Point(361, 120);
            this.DaySelect.Name = "DaySelect";
            this.DaySelect.Size = new System.Drawing.Size(113, 28);
            this.DaySelect.TabIndex = 9;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(112, 174);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(124, 38);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "등록";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(291, 174);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(124, 38);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 249);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.DaySelect);
            this.Controls.Add(this.MonthSelect);
            this.Controls.Add(this.YearSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PwText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PwText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox YearSelect;
        private System.Windows.Forms.ComboBox MonthSelect;
        private System.Windows.Forms.ComboBox DaySelect;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button CancelButton;
    }
}