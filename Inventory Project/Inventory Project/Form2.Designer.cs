
namespace Inventory_Project
{
    partial class updatedList
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
            this.homeButton1 = new System.Windows.Forms.Button();
            this.currentList = new System.Windows.Forms.Label();
            this.searchOne = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // homeButton1
            // 
            this.homeButton1.Location = new System.Drawing.Point(358, 393);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(173, 45);
            this.homeButton1.TabIndex = 0;
            this.homeButton1.Text = "Back to Home";
            this.homeButton1.UseVisualStyleBackColor = true;
            this.homeButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentList
            // 
            this.currentList.AutoSize = true;
            this.currentList.Location = new System.Drawing.Point(367, 9);
            this.currentList.Name = "currentList";
            this.currentList.Size = new System.Drawing.Size(149, 17);
            this.currentList.TabIndex = 1;
            this.currentList.Text = "Current List (Updated)";
            this.currentList.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchOne
            // 
            this.searchOne.Location = new System.Drawing.Point(95, 261);
            this.searchOne.Name = "searchOne";
            this.searchOne.Size = new System.Drawing.Size(75, 27);
            this.searchOne.TabIndex = 2;
            this.searchOne.Text = "Search";
            this.searchOne.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(263, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 340);
            this.listBox1.TabIndex = 4;
            // 
            // updatedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchOne);
            this.Controls.Add(this.currentList);
            this.Controls.Add(this.homeButton1);
            this.Name = "updatedList";
            this.Text = "Updated Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton1;
        private System.Windows.Forms.Label currentList;
        private System.Windows.Forms.Button searchOne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}