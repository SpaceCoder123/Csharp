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
            this.clickButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.CheckBoxing = new System.Windows.Forms.CheckBox();
            this.DropDown1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(6, 19);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(75, 23);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "click here";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(136, 16);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(35, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "label1";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(48, 61);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.Text = "Hello";
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DropDown1);
            this.groupBox1.Controls.Add(this.CheckBoxing);
            this.groupBox1.Controls.Add(this.clickButton);
            this.groupBox1.Controls.Add(this.textBoxInput);
            this.groupBox1.Controls.Add(this.outputLabel);
            this.groupBox1.Location = new System.Drawing.Point(41, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(136, 43);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(85, 17);
            this.RadioButton1.TabIndex = 4;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "radioButton1";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // CheckBoxing
            // 
            this.CheckBoxing.AutoSize = true;
            this.CheckBoxing.Location = new System.Drawing.Point(30, 149);
            this.CheckBoxing.Name = "CheckBoxing";
            this.CheckBoxing.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxing.TabIndex = 3;
            this.CheckBoxing.Text = "checkBox1";
            this.CheckBoxing.UseVisualStyleBackColor = true;
            this.CheckBoxing.CheckedChanged += new System.EventHandler(this.CheckBoxing_CheckedChanged);
            this.CheckBoxing.CheckStateChanged += new System.EventHandler(this.CheckBoxing_CheckStateChanged);
            // 
            // DropDown1
            // 
            this.DropDown1.AllowDrop = true;
            this.DropDown1.FormattingEnabled = true;
            this.DropDown1.Location = new System.Drawing.Point(177, 149);
            this.DropDown1.Name = "DropDown1";
            this.DropDown1.Size = new System.Drawing.Size(121, 21);
            this.DropDown1.TabIndex = 4;
            this.DropDown1.SelectedIndexChanged += new System.EventHandler(this.DropDown1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Button NewButton;
        private Label firstLabel;
        private LinkLabel FirstlLinkLabel1;
        private TextBox MyFirstTextBox;
        private Label Label;
        private Button outputButton;
        private TextBox TextInput;
        private Button clickButton;
        private Label outputLabel;
        private TextBox textBoxInput;
        private GroupBox groupBox1;
        private RadioButton RadioButton1;
        private CheckBox CheckBoxing;
        private ComboBox DropDown1;
    }
}

