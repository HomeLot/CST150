
namespace Activity_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputLabel1 = new System.Windows.Forms.TextBox();
            this.termsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inputLabel2 = new System.Windows.Forms.TextBox();
            this.solution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputLabel1
            // 
            this.inputLabel1.Location = new System.Drawing.Point(170, 12);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(100, 22);
            this.inputLabel1.TabIndex = 0;
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(14, 12);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(137, 17);
            this.termsLabel.TabIndex = 1;
            this.termsLabel.Text = "Enter the # of terms:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(170, 50);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 48);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // inputLabel2
            // 
            this.inputLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inputLabel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLabel2.Location = new System.Drawing.Point(12, 118);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(341, 15);
            this.inputLabel2.TabIndex = 3;
            // 
            // solution
            // 
            this.solution.BackColor = System.Drawing.SystemColors.Menu;
            this.solution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solution.Location = new System.Drawing.Point(12, 150);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(341, 15);
            this.solution.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 194);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.inputLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLabel1;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox inputLabel2;
        private System.Windows.Forms.TextBox solution;
    }
}

