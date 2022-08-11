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
            this.SuspendLayout();
            // 
            // CheckTemp
            // 
            this.CheckTemp.Location = new System.Drawing.Point(642, 378);
            this.CheckTemp.Name = "CheckTemp";
            this.CheckTemp.Size = new System.Drawing.Size(129, 60);
            this.CheckTemp.TabIndex = 0;
            this.CheckTemp.Text = "Check your tempreture ";
            this.CheckTemp.UseVisualStyleBackColor = true;
            this.CheckTemp.Click += new System.EventHandler(this.CheckTemp_Click);
            // 
            // TempInput
            // 
            this.TempInput.Location = new System.Drawing.Point(369, 164);
            this.TempInput.Name = "TempInput";
            this.TempInput.Size = new System.Drawing.Size(100, 23);
            this.TempInput.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(250, 360);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(204, 56);
            this.Result.TabIndex = 2;
            this.Result.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TempInput);
            this.Controls.Add(this.CheckTemp);
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
    }
}