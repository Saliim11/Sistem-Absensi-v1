namespace Sistem_Absensi_v1
{
    partial class MainGuru
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.check_in = new System.Windows.Forms.Button();
            this.check_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(444, 270);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(70, 25);
            this.lbl_welcome.TabIndex = 3;
            this.lbl_welcome.Text = "label1";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(504, 456);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(142, 45);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // check_in
            // 
            this.check_in.Location = new System.Drawing.Point(411, 364);
            this.check_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_in.Name = "check_in";
            this.check_in.Size = new System.Drawing.Size(142, 45);
            this.check_in.TabIndex = 4;
            this.check_in.Text = "Check In";
            this.check_in.UseVisualStyleBackColor = true;
            this.check_in.Click += new System.EventHandler(this.check_in_Click);
            // 
            // check_out
            // 
            this.check_out.Location = new System.Drawing.Point(613, 364);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(142, 45);
            this.check_out.TabIndex = 5;
            this.check_out.Text = "Check Out";
            this.check_out.UseVisualStyleBackColor = true;
            this.check_out.Click += new System.EventHandler(this.check_out_Click);
            // 
            // MainGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.check_in);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainGuru";
            this.Text = "Guru";
            this.Load += new System.EventHandler(this.MainGuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button check_in;
        private System.Windows.Forms.Button check_out;
    }
}