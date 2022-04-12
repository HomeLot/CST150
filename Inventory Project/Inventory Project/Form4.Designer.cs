
namespace Inventory_Project
{
    partial class brands
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchTwo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.homeButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // searchTwo
            // 
            this.searchTwo.Location = new System.Drawing.Point(66, 213);
            this.searchTwo.Name = "searchTwo";
            this.searchTwo.Size = new System.Drawing.Size(75, 23);
            this.searchTwo.TabIndex = 2;
            this.searchTwo.Text = "Search";
            this.searchTwo.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(209, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 356);
            this.listBox1.TabIndex = 3;
            // 
            // homeButton1
            // 
            this.homeButton1.Location = new System.Drawing.Point(315, 393);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(173, 45);
            this.homeButton1.TabIndex = 8;
            this.homeButton1.Text = "Back to Home";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.homeButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchTwo);
            this.Controls.Add(this.textBox1);
            this.Name = "brands";
            this.Text = "Available Brands";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchTwo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button homeButton1;
    }
}