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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountFind = new System.Windows.Forms.Label();
            this.PriceItem = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            FindBtn = new tarkovHelper.RoundedBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // FindBtn
            // 
            FindBtn.BackColor = System.Drawing.Color.IndianRed;
            FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FindBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FindBtn.ForeColor = System.Drawing.Color.Black;
            FindBtn.Location = new System.Drawing.Point(54, 92);
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
            this.NameItem.Location = new System.Drawing.Point(54, 166);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(44, 17);
            this.NameItem.TabIndex = 2;
            this.NameItem.Text = "Name";
            this.NameItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputItem
            // 
            this.InputItem.Location = new System.Drawing.Point(36, 44);
            this.InputItem.Name = "InputItem";
            this.InputItem.Size = new System.Drawing.Size(200, 23);
            this.InputItem.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::tarkovHelper.Properties.Resources.circle;
            this.pictureBox1.Location = new System.Drawing.Point(83, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CountFind
            // 
            this.CountFind.AutoSize = true;
            this.CountFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountFind.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountFind.Location = new System.Drawing.Point(99, 141);
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
            this.PriceItem.Location = new System.Drawing.Point(56, 359);
            this.PriceItem.Name = "PriceItem";
            this.PriceItem.Size = new System.Drawing.Size(42, 17);
            this.PriceItem.TabIndex = 13;
            this.PriceItem.Text = "Price:";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Count.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Count.Location = new System.Drawing.Point(110, 156);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(14, 15);
            this.Count.TabIndex = 16;
            this.Count.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tarkovHelper.Properties.Resources.right_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(187, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::tarkovHelper.Properties.Resources.left_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(28, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.PriceItem);
            this.Controls.Add(this.CountFind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(FindBtn);
            this.Controls.Add(this.InputItem);
            this.Controls.Add(this.NameItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label NameItem;
        private TextBox InputItem;
        private RoundedBtn FindBtn;
        private PictureBox pictureBox1;
        private Label CountFind;
        private Label PriceItem;
        private Label Count;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}