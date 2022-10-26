using System.Windows.Forms;

namespace MyFirstApp
{
    partial class MainForm
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
            this.NewButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.FirstlLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(114, 89);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "button2";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(61, 149);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(94, 13);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "This is a new label";
            this.firstLabel.Click += new System.EventHandler(this.firstLabel_Click);
            // 
            // FirstlLinkLabel1
            // 
            this.FirstlLinkLabel1.AutoSize = true;
            this.FirstlLinkLabel1.Location = new System.Drawing.Point(133, 218);
            this.FirstlLinkLabel1.Name = "FirstlLinkLabel1";
            this.FirstlLinkLabel1.Size = new System.Drawing.Size(55, 13);
            this.FirstlLinkLabel1.TabIndex = 2;
            this.FirstlLinkLabel1.TabStop = true;
            this.FirstlLinkLabel1.Text = "linkLabel1";
            this.FirstlLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FirstlLinkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FirstlLinkLabel1);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.NewButton);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Button NewButton;
        private Label firstLabel;
        private LinkLabel FirstlLinkLabel1;
    }
}

