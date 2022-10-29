namespace Loops
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
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.InputInteger = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.IntegerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputBox.Location = new System.Drawing.Point(30, 74);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(349, 482);
            this.OutputBox.TabIndex = 0;
            // 
            // InputInteger
            // 
            this.InputInteger.Location = new System.Drawing.Point(834, 240);
            this.InputInteger.Multiline = true;
            this.InputInteger.Name = "InputInteger";
            this.InputInteger.Size = new System.Drawing.Size(249, 23);
            this.InputInteger.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(834, 297);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(182, 49);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // IntegerName
            // 
            this.IntegerName.AutoSize = true;
            this.IntegerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IntegerName.Location = new System.Drawing.Point(834, 175);
            this.IntegerName.Name = "IntegerName";
            this.IntegerName.Size = new System.Drawing.Size(319, 21);
            this.IntegerName.TabIndex = 3;
            this.IntegerName.Text = "Enter the integer you want to print the table?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 646);
            this.Controls.Add(this.IntegerName);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.InputInteger);
            this.Controls.Add(this.OutputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputBox;
        private TextBox InputInteger;
        private Button Calculate;
        private Label IntegerName;
    }
}