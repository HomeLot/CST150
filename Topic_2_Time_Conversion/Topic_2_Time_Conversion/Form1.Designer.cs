
namespace Topic_2_Time_Conversion
{
    partial class timeForm
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
            this.convert1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convert1
            // 
            this.convert1.Location = new System.Drawing.Point(97, 117);
            this.convert1.Name = "convert1";
            this.convert1.Size = new System.Drawing.Size(75, 23);
            this.convert1.TabIndex = 0;
            this.convert1.Text = "Convert";
            this.convert1.UseVisualStyleBackColor = true;
            this.convert1.Click += new System.EventHandler(this.convert1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a number to be converted:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(86, 73);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 2;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 151);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert1);
            this.Name = "timeForm";
            this.Text = "Time Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
    }
}

