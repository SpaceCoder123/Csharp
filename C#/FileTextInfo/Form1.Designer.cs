namespace FileTextInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteFile = new System.Windows.Forms.Button();
            this.WriteFile = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.getInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(294, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteFile
            // 
            this.DeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DeleteFile.Location = new System.Drawing.Point(480, 104);
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Size = new System.Drawing.Size(167, 66);
            this.DeleteFile.TabIndex = 1;
            this.DeleteFile.Text = "Delete File";
            this.DeleteFile.UseVisualStyleBackColor = true;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // WriteFile
            // 
            this.WriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WriteFile.Location = new System.Drawing.Point(119, 104);
            this.WriteFile.Name = "WriteFile";
            this.WriteFile.Size = new System.Drawing.Size(152, 66);
            this.WriteFile.TabIndex = 2;
            this.WriteFile.Text = "Write File";
            this.WriteFile.UseVisualStyleBackColor = true;
            this.WriteFile.Click += new System.EventHandler(this.WriteFile_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ReadFile.Location = new System.Drawing.Point(119, 12);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(152, 65);
            this.ReadFile.TabIndex = 3;
            this.ReadFile.Text = "Read File";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(119, 210);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(528, 183);
            this.OutputBox.TabIndex = 4;
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(119, 415);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(75, 23);
            this.getInfo.TabIndex = 5;
            this.getInfo.Text = "Properties";
            this.getInfo.UseVisualStyleBackColor = true;
            this.getInfo.Click += new System.EventHandler(this.getInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getInfo);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.WriteFile);
            this.Controls.Add(this.DeleteFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteFile;
        private System.Windows.Forms.Button WriteFile;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button getInfo;
    }
}

