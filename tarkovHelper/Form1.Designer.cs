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
            this.PriceItem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
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
            this.NameItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameItem.AutoSize = true;
            this.NameItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameItem.Location = new System.Drawing.Point(101, 209);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(44, 17);
            this.NameItem.TabIndex = 2;
            this.NameItem.Text = "Name";
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
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(74, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 170);
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
            // PriceItem
            // 
            this.PriceItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceItem.AutoSize = true;
            this.PriceItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceItem.Location = new System.Drawing.Point(100, 402);
            this.PriceItem.Name = "PriceItem";
            this.PriceItem.Size = new System.Drawing.Size(42, 17);
            this.PriceItem.TabIndex = 13;
            this.PriceItem.Text = "Price:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Count.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Count.Location = new System.Drawing.Point(112, 199);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(14, 15);
            this.Count.TabIndex = 16;
            this.Count.Text = "0";
            this.Count.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceItem);
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
        private Label PriceItem;
        private Button button1;
        private Button button2;
        private Label Count;
    }
}