namespace Arrays
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
            this.ShwBtn = new System.Windows.Forms.Button();
            this.ArrayOutput = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // ShwBtn
            // 
            this.ShwBtn.Location = new System.Drawing.Point(41, 44);
            this.ShwBtn.Name = "ShwBtn";
            this.ShwBtn.Size = new System.Drawing.Size(94, 35);
            this.ShwBtn.TabIndex = 0;
            this.ShwBtn.Text = "Show";
            this.ShwBtn.UseVisualStyleBackColor = true;
            this.ShwBtn.Click += new System.EventHandler(this.ShwBtn_Click);
            // 
            // ArrayOutput
            // 
            this.ArrayOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name});
            this.ArrayOutput.Location = new System.Drawing.Point(41, 85);
            this.ArrayOutput.Name = "ArrayOutput";
            this.ArrayOutput.RowTemplate.Height = 25;
            this.ArrayOutput.Size = new System.Drawing.Size(240, 150);
            this.ArrayOutput.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Day";
            this.Name.Name = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArrayOutput);
            this.Controls.Add(this.ShwBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArrayOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ShwBtn;
        private DataGridView ArrayOutput;
        private DataGridViewTextBoxColumn Name;
    }
}