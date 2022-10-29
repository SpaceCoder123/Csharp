namespace CBSE_Calculator
{
    partial class MainForm
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Physics = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mathematics = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Chemistry = new System.Windows.Forms.Label();
            this.ComputerScience = new System.Windows.Forms.Label();
            this.Biology = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calculate.Location = new System.Drawing.Point(744, 252);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 50);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Physics
            // 
            this.Physics.AutoSize = true;
            this.Physics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Physics.Location = new System.Drawing.Point(135, 132);
            this.Physics.Name = "Physics";
            this.Physics.Size = new System.Drawing.Size(55, 20);
            this.Physics.TabIndex = 1;
            this.Physics.Text = "Physics";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Mathematics
            // 
            this.Mathematics.AutoSize = true;
            this.Mathematics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mathematics.Location = new System.Drawing.Point(135, 206);
            this.Mathematics.Name = "Mathematics";
            this.Mathematics.Size = new System.Drawing.Size(94, 20);
            this.Mathematics.TabIndex = 3;
            this.Mathematics.Text = "Mathematics";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 299);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 432);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 7;
            // 
            // Chemistry
            // 
            this.Chemistry.AutoSize = true;
            this.Chemistry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chemistry.Location = new System.Drawing.Point(135, 274);
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.Size = new System.Drawing.Size(74, 20);
            this.Chemistry.TabIndex = 8;
            this.Chemistry.Text = "Chemistry";
            this.Chemistry.Click += new System.EventHandler(this.Chemistry_Click);
            // 
            // ComputerScience
            // 
            this.ComputerScience.AutoSize = true;
            this.ComputerScience.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComputerScience.Location = new System.Drawing.Point(135, 341);
            this.ComputerScience.Name = "ComputerScience";
            this.ComputerScience.Size = new System.Drawing.Size(125, 20);
            this.ComputerScience.TabIndex = 9;
            this.ComputerScience.Text = "ComputerScience";
            this.ComputerScience.Click += new System.EventHandler(this.label3_Click);
            // 
            // Biology
            // 
            this.Biology.AutoSize = true;
            this.Biology.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Biology.Location = new System.Drawing.Point(136, 409);
            this.Biology.Name = "Biology";
            this.Biology.Size = new System.Drawing.Size(60, 20);
            this.Biology.TabIndex = 10;
            this.Biology.Text = "Biology";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Biology);
            this.Controls.Add(this.ComputerScience);
            this.Controls.Add(this.Chemistry);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Mathematics);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Physics);
            this.Controls.Add(this.Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    }
}