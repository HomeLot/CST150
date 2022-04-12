
namespace Inventory_Project
{
    partial class modifyList
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
            this.addToList = new System.Windows.Forms.Button();
            this.deleteFromList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homeButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(58, 175);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(75, 23);
            this.addToList.TabIndex = 0;
            this.addToList.Text = "Add";
            this.addToList.UseVisualStyleBackColor = true;
            // 
            // deleteFromList
            // 
            this.deleteFromList.Location = new System.Drawing.Point(58, 240);
            this.deleteFromList.Name = "deleteFromList";
            this.deleteFromList.Size = new System.Drawing.Size(75, 23);
            this.deleteFromList.TabIndex = 1;
            this.deleteFromList.Text = "Remove";
            this.deleteFromList.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(231, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 356);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // homeButton1
            // 
            this.homeButton1.Location = new System.Drawing.Point(333, 393);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(173, 45);
            this.homeButton1.TabIndex = 7;
            this.homeButton1.Text = "Back to Home";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // modifyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteFromList);
            this.Controls.Add(this.addToList);
            this.Name = "modifyList";
            this.Text = "Modify Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.Button deleteFromList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button homeButton1;
    }
}