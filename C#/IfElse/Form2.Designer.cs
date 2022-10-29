namespace IfElse
{
    partial class Form2
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
            this.Number = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number.Location = new System.Drawing.Point(99, 84);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(222, 37);
            this.Number.TabIndex = 1;
            this.Number.Text = "Enter the number";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Heading.Location = new System.Drawing.Point(234, 27);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(433, 37);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Which Department do you belong?";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(372, 383);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 15);
            this.OutputLabel.TabIndex = 3;
            // 
            // AgeInput
            // 
            this.AgeInput.Location = new System.Drawing.Point(111, 157);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(201, 23);
            this.AgeInput.TabIndex = 4;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(578, 131);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(146, 58);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.AgeInput);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.Number);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Number;
        private Label Heading;
        private Label OutputLabel;
        private TextBox AgeInput;
        private Button Calculate;
    }
}