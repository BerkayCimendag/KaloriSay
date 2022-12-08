namespace KaloriSay.UI.UserControls
{
    partial class frmYoneticiGiris
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_YoneticiGiris = new System.Windows.Forms.Panel();
            this.lbl_YoneticiBilgilendirme = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Geri = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_Mail = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GirisYap = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.pnl_YoneticiGiris.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_YoneticiGiris
            // 
            this.pnl_YoneticiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.pnl_YoneticiGiris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_YoneticiGiris.Controls.Add(this.lbl_YoneticiBilgilendirme);
            this.pnl_YoneticiGiris.Controls.Add(this.panel2);
            this.pnl_YoneticiGiris.Controls.Add(this.label3);
            this.pnl_YoneticiGiris.Controls.Add(this.label2);
            this.pnl_YoneticiGiris.Controls.Add(this.txt_Sifre);
            this.pnl_YoneticiGiris.Controls.Add(this.txt_Mail);
            this.pnl_YoneticiGiris.Controls.Add(this.label1);
            this.pnl_YoneticiGiris.Controls.Add(this.btn_GirisYap);
            this.pnl_YoneticiGiris.Location = new System.Drawing.Point(111, 29);
            this.pnl_YoneticiGiris.Name = "pnl_YoneticiGiris";
            this.pnl_YoneticiGiris.Size = new System.Drawing.Size(526, 664);
            this.pnl_YoneticiGiris.TabIndex = 14;
            // 
            // lbl_YoneticiBilgilendirme
            // 
            this.lbl_YoneticiBilgilendirme.AutoSize = true;
            this.lbl_YoneticiBilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.lbl_YoneticiBilgilendirme.Location = new System.Drawing.Point(139, 413);
            this.lbl_YoneticiBilgilendirme.Name = "lbl_YoneticiBilgilendirme";
            this.lbl_YoneticiBilgilendirme.Size = new System.Drawing.Size(215, 16);
            this.lbl_YoneticiBilgilendirme.TabIndex = 16;
            this.lbl_YoneticiBilgilendirme.Text = "Email Adresi Veya Şifre Yanlış";
            this.lbl_YoneticiBilgilendirme.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.btn_Geri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 51);
            this.panel2.TabIndex = 15;
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_Geri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_Geri.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Geri.BorderRadius = 26;
            this.btn_Geri.BorderSize = 2;
            this.btn_Geri.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Geri.FlatAppearance.BorderSize = 0;
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Geri.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(0, 0);
            this.btn_Geri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(206, 51);
            this.btn_Geri.TabIndex = 11;
            this.btn_Geri.Text = "   << Geri";
            this.btn_Geri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Geri.TextColor = System.Drawing.Color.White;
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail : ";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Sifre.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Sifre.BorderColor = System.Drawing.Color.Black;
            this.txt_Sifre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(55)))));
            this.txt_Sifre.BorderRadius = 15;
            this.txt_Sifre.BorderSize = 2;
            this.txt_Sifre.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Sifre.ForeColor = System.Drawing.Color.Black;
            this.txt_Sifre.Location = new System.Drawing.Point(105, 351);
            this.txt_Sifre.Multiline = false;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Sifre.PasswordChar = true;
            this.txt_Sifre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Sifre.PlaceholderText = "";
            this.txt_Sifre.Size = new System.Drawing.Size(312, 37);
            this.txt_Sifre.TabIndex = 2;
            this.txt_Sifre.UnderlinedStyle = false;
            this.txt_Sifre._TextChanged += new System.EventHandler(this.txt_Mail__TextChanged);
            // 
            // txt_Mail
            // 
            this.txt_Mail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Mail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Mail.BorderColor = System.Drawing.Color.Black;
            this.txt_Mail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(85)))), ((int)(((byte)(55)))));
            this.txt_Mail.BorderRadius = 15;
            this.txt_Mail.BorderSize = 2;
            this.txt_Mail.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Mail.ForeColor = System.Drawing.Color.Black;
            this.txt_Mail.Location = new System.Drawing.Point(105, 278);
            this.txt_Mail.Multiline = false;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Mail.PasswordChar = false;
            this.txt_Mail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Mail.PlaceholderText = "";
            this.txt_Mail.Size = new System.Drawing.Size(312, 37);
            this.txt_Mail.TabIndex = 1;
            this.txt_Mail.UnderlinedStyle = false;
            this.txt_Mail._TextChanged += new System.EventHandler(this.txt_Mail__TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yönetici Girişi Yap";
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_GirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_GirisYap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_GirisYap.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_GirisYap.BorderRadius = 34;
            this.btn_GirisYap.BorderSize = 2;
            this.btn_GirisYap.FlatAppearance.BorderSize = 0;
            this.btn_GirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GirisYap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GirisYap.ForeColor = System.Drawing.Color.White;
            this.btn_GirisYap.Location = new System.Drawing.Point(86, 460);
            this.btn_GirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(351, 43);
            this.btn_GirisYap.TabIndex = 3;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.TextColor = System.Drawing.Color.White;
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // frmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Controls.Add(this.pnl_YoneticiGiris);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmYoneticiGiris";
            this.Size = new System.Drawing.Size(748, 723);
            this.pnl_YoneticiGiris.ResumeLayout(false);
            this.pnl_YoneticiGiris.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_YoneticiGiris;
        private Label label3;
        private Label label2;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Sifre;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Mail;
        private Label label1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_GirisYap;
        private Panel panel2;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Geri;
        private Label lbl_YoneticiBilgilendirme;
    }
}
