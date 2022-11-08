namespace PersonalTracker
{
    partial class PersonalTrackerLoginForm
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
            this.EnterUsernamePassword = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterUsernamePassword
            // 
            this.EnterUsernamePassword.Location = new System.Drawing.Point(246, 239);
            this.EnterUsernamePassword.Name = "EnterUsernamePassword";
            this.EnterUsernamePassword.Size = new System.Drawing.Size(94, 29);
            this.EnterUsernamePassword.TabIndex = 0;
            this.EnterUsernamePassword.Text = "Enter";
            this.EnterUsernamePassword.UseVisualStyleBackColor = true;
            this.EnterUsernamePassword.Click += new System.EventHandler(this.EnterUsernamePassword_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(256, 127);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(125, 27);
            this.UserNameInput.TabIndex = 4;
            this.UserNameInput.TextChanged += new System.EventHandler(this.UserNameInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(255, 185);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(125, 27);
            this.PasswordInput.TabIndex = 5;
            // 
            // PersonalTrackerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EnterUsernamePassword);
            this.Name = "PersonalTrackerLoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EnterUsernamePassword;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox UserNameInput;
        private TextBox PasswordInput;
    }
}