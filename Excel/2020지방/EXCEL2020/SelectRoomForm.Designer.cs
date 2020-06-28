namespace EXCEL2020
{
    partial class SelectRoomForm
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
            this.FreeRoomCountLabel = new System.Windows.Forms.Label();
            this.SelectedRoomCountLabel = new System.Windows.Forms.Label();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "선택 가능한 방 개수 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "선택한 방 개수 :";
            // 
            // FreeRoomCountLabel
            // 
            this.FreeRoomCountLabel.AutoSize = true;
            this.FreeRoomCountLabel.Location = new System.Drawing.Point(170, 19);
            this.FreeRoomCountLabel.Name = "FreeRoomCountLabel";
            this.FreeRoomCountLabel.Size = new System.Drawing.Size(32, 20);
            this.FreeRoomCountLabel.TabIndex = 2;
            this.FreeRoomCountLabel.Text = "0개";
            // 
            // SelectedRoomCountLabel
            // 
            this.SelectedRoomCountLabel.AutoSize = true;
            this.SelectedRoomCountLabel.Location = new System.Drawing.Point(135, 54);
            this.SelectedRoomCountLabel.Name = "SelectedRoomCountLabel";
            this.SelectedRoomCountLabel.Size = new System.Drawing.Size(32, 20);
            this.SelectedRoomCountLabel.TabIndex = 2;
            this.SelectedRoomCountLabel.Text = "0개";
            // 
            // RoomListBox
            // 
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 20;
            this.RoomListBox.Location = new System.Drawing.Point(16, 120);
            this.RoomListBox.MultiColumn = true;
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RoomListBox.Size = new System.Drawing.Size(455, 344);
            this.RoomListBox.TabIndex = 3;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(374, 483);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(97, 31);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "다음";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 544);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RoomListBox);
            this.Controls.Add(this.SelectedRoomCountLabel);
            this.Controls.Add(this.FreeRoomCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectRoomForm";
            this.Text = "객실선택";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FreeRoomCountLabel;
        private System.Windows.Forms.Label SelectedRoomCountLabel;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.Button NextButton;
    }
}