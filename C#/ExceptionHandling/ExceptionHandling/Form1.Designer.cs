namespace ExceptionHandling
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Num2Inp = new System.Windows.Forms.TextBox();
            this.Num1Inp = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(241, 136);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(123, 45);
            this.CalculateBtn.TabIndex = 0;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Num2Inp
            // 
            this.Num2Inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Num2Inp.Location = new System.Drawing.Point(52, 163);
            this.Num2Inp.Name = "Num2Inp";
            this.Num2Inp.Size = new System.Drawing.Size(100, 45);
            this.Num2Inp.TabIndex = 1;
            // 
            // Num1Inp
            // 
            this.Num1Inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Num1Inp.Location = new System.Drawing.Point(52, 108);
            this.Num1Inp.Name = "Num1Inp";
            this.Num1Inp.Size = new System.Drawing.Size(100, 45);
            this.Num1Inp.TabIndex = 2;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(562, 142);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 16);
            this.OutputLabel.TabIndex = 3;
            // 
            // OutputLabel1
            // 
            this.OutputLabel1.AutoSize = true;
            this.OutputLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.OutputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OutputLabel1.Location = new System.Drawing.Point(409, 142);
            this.OutputLabel1.Name = "OutputLabel1";
            this.OutputLabel1.Size = new System.Drawing.Size(0, 39);
            this.OutputLabel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 505);
            this.Controls.Add(this.OutputLabel1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Num1Inp);
            this.Controls.Add(this.Num2Inp);
            this.Controls.Add(this.CalculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox Num2Inp;
        private System.Windows.Forms.TextBox Num1Inp;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label OutputLabel1;
    }
}

