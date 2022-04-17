
namespace _2_Mass_and_Weight_Problem
{
    partial class weightCalculator
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
            this.buttonMass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMass
            // 
            this.buttonMass.Location = new System.Drawing.Point(83, 81);
            this.buttonMass.Name = "buttonMass";
            this.buttonMass.Size = new System.Drawing.Size(126, 25);
            this.buttonMass.TabIndex = 0;
            this.buttonMass.Text = "Calculate Mass";
            this.buttonMass.UseVisualStyleBackColor = true;
            this.buttonMass.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the mass of the object:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(94, 53);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 2;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // weightCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 123);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMass);
            this.Name = "weightCalculator";
            this.Text = "Weight Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
    }
}

