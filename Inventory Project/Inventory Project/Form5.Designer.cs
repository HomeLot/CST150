
namespace Inventory_Project
{
    partial class requestForm
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
            this.requestButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.customerEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(129, 227);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(115, 23);
            this.requestButton.TabIndex = 0;
            this.requestButton.Text = "Send Request";
            this.requestButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 22);
            this.textBox3.TabIndex = 3;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(48, 76);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(83, 17);
            this.customerName.TabIndex = 4;
            this.customerName.Text = "Your Name:";
            // 
            // customerEmail
            // 
            this.customerEmail.AutoSize = true;
            this.customerEmail.Location = new System.Drawing.Point(48, 132);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(80, 17);
            this.customerEmail.TabIndex = 5;
            this.customerEmail.Text = "Your Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Requested Product:";
            // 
            // homeButton1
            // 
            this.homeButton1.Location = new System.Drawing.Point(98, 299);
            this.homeButton1.Name = "homeButton1";
            this.homeButton1.Size = new System.Drawing.Size(173, 45);
            this.homeButton1.TabIndex = 9;
            this.homeButton1.Text = "Back to Home";
            this.homeButton1.UseVisualStyleBackColor = true;
            // 
            // requestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 370);
            this.Controls.Add(this.homeButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.requestButton);
            this.Name = "requestForm";
            this.Text = "Request A Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeButton1;
    }
}