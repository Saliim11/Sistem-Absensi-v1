namespace Sistem_Absensi_v1
{
    partial class MainTimIT
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
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(361, 188);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(44, 16);
            this.lbl_welcome.TabIndex = 7;
            this.lbl_welcome.Text = "label1";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(364, 233);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 29);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainTimIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_logout);
            this.Name = "MainTimIT";
            this.Text = "Tim IT";
            this.Load += new System.EventHandler(this.MainTimIT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_logout;
    }
}