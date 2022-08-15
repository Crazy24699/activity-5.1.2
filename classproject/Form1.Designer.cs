namespace classproject
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
            this.CheckTemp = new System.Windows.Forms.Button();
            this.TempInput = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CheckTemp
            // 
            this.CheckTemp.Location = new System.Drawing.Point(734, 504);
            this.CheckTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckTemp.Name = "CheckTemp";
            this.CheckTemp.Size = new System.Drawing.Size(147, 80);
            this.CheckTemp.TabIndex = 0;
            this.CheckTemp.Text = "Check your tempreture ";
            this.CheckTemp.UseVisualStyleBackColor = true;
            this.CheckTemp.Click += new System.EventHandler(this.CheckTemp_Click);
            // 
            // TempInput
            // 
            this.TempInput.Location = new System.Drawing.Point(422, 219);
            this.TempInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TempInput.Name = "TempInput";
            this.TempInput.Size = new System.Drawing.Size(114, 27);
            this.TempInput.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(286, 480);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(233, 75);
            this.Result.TabIndex = 2;
            this.Result.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(391, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://sacoronavirus.co.za";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TempInput);
            this.Controls.Add(this.CheckTemp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CheckTemp;
        private TextBox TempInput;
        private Label Result;
        private LinkLabel linkLabel1;
    }
}