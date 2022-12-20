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
            this.FindBtn = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.Label();
            this.InputItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(43, 101);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(110, 38);
            this.FindBtn.TabIndex = 0;
            this.FindBtn.Text = "button1";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(43, 165);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 15);
            this.Price.TabIndex = 1;
            this.Price.Text = "label1";
            // 
            // NameItem
            // 
            this.NameItem.AutoSize = true;
            this.NameItem.Location = new System.Drawing.Point(43, 202);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(38, 15);
            this.NameItem.TabIndex = 2;
            this.NameItem.Text = "label2";
            // 
            // InputItem
            // 
            this.InputItem.Location = new System.Drawing.Point(43, 56);
            this.InputItem.Name = "InputItem";
            this.InputItem.Size = new System.Drawing.Size(200, 23);
            this.InputItem.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.InputItem);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.FindBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FindBtn;
        private Label Price;
        private Label NameItem;
        private TextBox InputItem;
    }
}