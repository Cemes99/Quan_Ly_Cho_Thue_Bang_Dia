
namespace Project
{
    partial class Home
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
            this.toDisk = new System.Windows.Forms.Button();
            this.toMember = new System.Windows.Forms.Button();
            this.toBill = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toDisk
            // 
            this.toDisk.Location = new System.Drawing.Point(317, 77);
            this.toDisk.Name = "toDisk";
            this.toDisk.Size = new System.Drawing.Size(150, 30);
            this.toDisk.TabIndex = 0;
            this.toDisk.Text = "Quản lý băng đĩa";
            this.toDisk.UseVisualStyleBackColor = true;
            this.toDisk.Click += new System.EventHandler(this.toDisk_Click);
            // 
            // button2
            // 
            this.toMember.Location = new System.Drawing.Point(317, 160);
            this.toMember.Name = "button2";
            this.toMember.Size = new System.Drawing.Size(150, 30);
            this.toMember.TabIndex = 1;
            this.toMember.Text = "Quản lý thành viên";
            this.toMember.UseVisualStyleBackColor = true;
            this.toMember.Click += new System.EventHandler(this.toMember_Click);
            // 
            // button3
            // 
            this.toBill.Location = new System.Drawing.Point(317, 245);
            this.toBill.Name = "button3";
            this.toBill.Size = new System.Drawing.Size(150, 30);
            this.toBill.TabIndex = 2;
            this.toBill.Text = "Quản lý phiếu thuê";
            this.toBill.UseVisualStyleBackColor = true;
            this.toBill.Click += new System.EventHandler(this.toBill_Click);
            // 
            // button4
            // 
            this.logout.Location = new System.Drawing.Point(317, 328);
            this.logout.Name = "button4";
            this.logout.Size = new System.Drawing.Size(150, 30);
            this.logout.TabIndex = 3;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.toBill);
            this.Controls.Add(this.toMember);
            this.Controls.Add(this.toDisk);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toDisk;
        private System.Windows.Forms.Button toMember;
        private System.Windows.Forms.Button toBill;
        private System.Windows.Forms.Button logout;
    }
}