
namespace Inventory_Project
{
    partial class Form1
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
            this.inventoryButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.brandButton = new System.Windows.Forms.Button();
            this.requestButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(39, 188);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(124, 72);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Inventory List";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(209, 188);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(124, 72);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "Modify List";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // brandButton
            // 
            this.brandButton.Location = new System.Drawing.Point(439, 188);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(124, 72);
            this.brandButton.TabIndex = 2;
            this.brandButton.Text = "Brands Available";
            this.brandButton.UseVisualStyleBackColor = true;
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(610, 188);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(124, 72);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "Request Brand";
            this.requestButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(315, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 72);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.brandButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.inventoryButton);
            this.Name = "Form1";
            this.Text = "Pet Food Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Button exitButton;
    }
}

