namespace Cafe_Free
{
    partial class login
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoatLg = new System.Windows.Forms.Button();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.txtPassUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đăng Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Đăng Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mật Khẩu";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(158, 159);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(119, 37);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đằng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoatLg
            // 
            this.btThoatLg.Location = new System.Drawing.Point(318, 159);
            this.btThoatLg.Name = "btThoatLg";
            this.btThoatLg.Size = new System.Drawing.Size(119, 37);
            this.btThoatLg.TabIndex = 5;
            this.btThoatLg.Text = "Thoát";
            this.btThoatLg.UseVisualStyleBackColor = true;
            this.btThoatLg.Click += new System.EventHandler(this.btThoatLg_Click);
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(175, 61);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(379, 22);
            this.txtNameUser.TabIndex = 6;
            // 
            // txtPassUser
            // 
            this.txtPassUser.Location = new System.Drawing.Point(175, 112);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.Size = new System.Drawing.Size(379, 22);
            this.txtPassUser.TabIndex = 7;
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(661, 208);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassUser);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.btThoatLg);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoatLg;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtPassUser;
    }
}