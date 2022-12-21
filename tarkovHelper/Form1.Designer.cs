namespace tarkovHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tarkovHelper.RoundedBtn FindBtn;
            this.NameItem = new System.Windows.Forms.Label();
            this.InputItem = new System.Windows.Forms.TextBox();
            this.roundedBtn2 = new tarkovHelper.RoundedBtn();
            this.roundedBtn3 = new tarkovHelper.RoundedBtn();
            this.roundedBtn4 = new tarkovHelper.RoundedBtn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountFind = new System.Windows.Forms.Label();
            FindBtn = new tarkovHelper.RoundedBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FindBtn
            // 
            FindBtn.BackColor = System.Drawing.Color.IndianRed;
            FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FindBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FindBtn.ForeColor = System.Drawing.Color.Black;
            FindBtn.Location = new System.Drawing.Point(56, 135);
            FindBtn.Name = "FindBtn";
            FindBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            FindBtn.Size = new System.Drawing.Size(138, 46);
            FindBtn.TabIndex = 7;
            FindBtn.Text = "Find";
            FindBtn.UseVisualStyleBackColor = false;
            FindBtn.Click += new System.EventHandler(this.FindBtn_Click_1);
            // 
            // NameItem
            // 
            this.NameItem.AutoSize = true;
            this.NameItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameItem.Location = new System.Drawing.Point(56, 218);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(128, 25);
            this.NameItem.TabIndex = 2;
            this.NameItem.Text = "Name:  Price:";
            // 
            // InputItem
            // 
            this.InputItem.Location = new System.Drawing.Point(38, 87);
            this.InputItem.Name = "InputItem";
            this.InputItem.Size = new System.Drawing.Size(200, 23);
            this.InputItem.TabIndex = 3;
            // 
            // roundedBtn2
            // 
            this.roundedBtn2.Location = new System.Drawing.Point(12, 33);
            this.roundedBtn2.Name = "roundedBtn2";
            this.roundedBtn2.Size = new System.Drawing.Size(72, 31);
            this.roundedBtn2.TabIndex = 8;
            this.roundedBtn2.Text = "roundedBtn2";
            this.roundedBtn2.UseVisualStyleBackColor = true;
            // 
            // roundedBtn3
            // 
            this.roundedBtn3.Location = new System.Drawing.Point(101, 33);
            this.roundedBtn3.Name = "roundedBtn3";
            this.roundedBtn3.Size = new System.Drawing.Size(72, 31);
            this.roundedBtn3.TabIndex = 9;
            this.roundedBtn3.Text = "roundedBtn3";
            this.roundedBtn3.UseVisualStyleBackColor = true;
            // 
            // roundedBtn4
            // 
            this.roundedBtn4.Location = new System.Drawing.Point(190, 33);
            this.roundedBtn4.Name = "roundedBtn4";
            this.roundedBtn4.Size = new System.Drawing.Size(72, 31);
            this.roundedBtn4.TabIndex = 10;
            this.roundedBtn4.Text = "roundedBtn4";
            this.roundedBtn4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 82);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CountFind
            // 
            this.CountFind.AutoSize = true;
            this.CountFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountFind.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountFind.Location = new System.Drawing.Point(101, 184);
            this.CountFind.Name = "CountFind";
            this.CountFind.Size = new System.Drawing.Size(43, 15);
            this.CountFind.TabIndex = 12;
            this.CountFind.Text = "Find: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.CountFind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedBtn4);
            this.Controls.Add(this.roundedBtn3);
            this.Controls.Add(this.roundedBtn2);
            this.Controls.Add(FindBtn);
            this.Controls.Add(this.InputItem);
            this.Controls.Add(this.NameItem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label NameItem;
        private TextBox InputItem;
        private RoundedBtn FindBtn;
        private RoundedBtn roundedBtn2;
        private RoundedBtn roundedBtn3;
        private RoundedBtn roundedBtn4;
        private PictureBox pictureBox1;
        private Label CountFind;
    }
}