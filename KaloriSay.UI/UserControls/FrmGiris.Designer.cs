namespace KaloriSay.UI
{
    partial class FrmGiris
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
            this.btn_GirisYap = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.cb_BeniHatirla = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_KullaniciGirisi = new System.Windows.Forms.Panel();
            this.lbl_GirisBilgilendirme = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_YoneticiGiris = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_ProjeYoneticisiGiris = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_Mail = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.frmYoneticiGiris1 = new KaloriSay.UI.UserControls.frmYoneticiGiris();
            this.frmProjeYoneticisiGirisi1 = new KaloriSay.UI.UserControls.frmProjeYoneticisiGirisi();
            this.pnl_KullaniciGirisi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_GirisYap.Location = new System.Drawing.Point(87, 449);
            this.btn_GirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(351, 43);
            this.btn_GirisYap.TabIndex = 4;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.TextColor = System.Drawing.Color.White;
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // cb_BeniHatirla
            // 
            this.cb_BeniHatirla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_BeniHatirla.AutoSize = true;
            this.cb_BeniHatirla.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_BeniHatirla.Location = new System.Drawing.Point(296, 395);
            this.cb_BeniHatirla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_BeniHatirla.Name = "cb_BeniHatirla";
            this.cb_BeniHatirla.Size = new System.Drawing.Size(122, 20);
            this.cb_BeniHatirla.TabIndex = 3;
            this.cb_BeniHatirla.Text = "Beni Hatırla";
            this.cb_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giriş Yap";
            // 
            // pnl_KullaniciGirisi
            // 
            this.pnl_KullaniciGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.pnl_KullaniciGirisi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_KullaniciGirisi.Controls.Add(this.lbl_GirisBilgilendirme);
            this.pnl_KullaniciGirisi.Controls.Add(this.panel2);
            this.pnl_KullaniciGirisi.Controls.Add(this.label3);
            this.pnl_KullaniciGirisi.Controls.Add(this.label2);
            this.pnl_KullaniciGirisi.Controls.Add(this.txt_Sifre);
            this.pnl_KullaniciGirisi.Controls.Add(this.txt_Mail);
            this.pnl_KullaniciGirisi.Controls.Add(this.label1);
            this.pnl_KullaniciGirisi.Controls.Add(this.btn_GirisYap);
            this.pnl_KullaniciGirisi.Controls.Add(this.cb_BeniHatirla);
            this.pnl_KullaniciGirisi.Location = new System.Drawing.Point(111, 30);
            this.pnl_KullaniciGirisi.Name = "pnl_KullaniciGirisi";
            this.pnl_KullaniciGirisi.Size = new System.Drawing.Size(526, 664);
            this.pnl_KullaniciGirisi.TabIndex = 13;
            // 
            // lbl_GirisBilgilendirme
            // 
            this.lbl_GirisBilgilendirme.AutoSize = true;
            this.lbl_GirisBilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.lbl_GirisBilgilendirme.Location = new System.Drawing.Point(151, 370);
            this.lbl_GirisBilgilendirme.Name = "lbl_GirisBilgilendirme";
            this.lbl_GirisBilgilendirme.Size = new System.Drawing.Size(225, 16);
            this.lbl_GirisBilgilendirme.TabIndex = 15;
            this.lbl_GirisBilgilendirme.Text = "Mail Adresi Veya Şifreniz Yanlış";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.btn_YoneticiGiris);
            this.panel2.Controls.Add(this.btn_ProjeYoneticisiGiris);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 51);
            this.panel2.TabIndex = 14;
            // 
            // btn_YoneticiGiris
            // 
            this.btn_YoneticiGiris.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_YoneticiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_YoneticiGiris.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_YoneticiGiris.BorderColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiGiris.BorderRadius = 26;
            this.btn_YoneticiGiris.BorderSize = 2;
            this.btn_YoneticiGiris.FlatAppearance.BorderSize = 0;
            this.btn_YoneticiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YoneticiGiris.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_YoneticiGiris.ForeColor = System.Drawing.Color.White;
            this.btn_YoneticiGiris.Location = new System.Drawing.Point(52, 5);
            this.btn_YoneticiGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YoneticiGiris.Name = "btn_YoneticiGiris";
            this.btn_YoneticiGiris.Size = new System.Drawing.Size(206, 40);
            this.btn_YoneticiGiris.TabIndex = 11;
            this.btn_YoneticiGiris.Text = "Yönetici Girişi";
            this.btn_YoneticiGiris.TextColor = System.Drawing.Color.White;
            this.btn_YoneticiGiris.UseVisualStyleBackColor = false;
            this.btn_YoneticiGiris.Click += new System.EventHandler(this.btn_YoneticiGiris_Click);
            // 
            // btn_ProjeYoneticisiGiris
            // 
            this.btn_ProjeYoneticisiGiris.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ProjeYoneticisiGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_ProjeYoneticisiGiris.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_ProjeYoneticisiGiris.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ProjeYoneticisiGiris.BorderRadius = 26;
            this.btn_ProjeYoneticisiGiris.BorderSize = 2;
            this.btn_ProjeYoneticisiGiris.FlatAppearance.BorderSize = 0;
            this.btn_ProjeYoneticisiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProjeYoneticisiGiris.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ProjeYoneticisiGiris.ForeColor = System.Drawing.Color.White;
            this.btn_ProjeYoneticisiGiris.Location = new System.Drawing.Point(264, 5);
            this.btn_ProjeYoneticisiGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ProjeYoneticisiGiris.Name = "btn_ProjeYoneticisiGiris";
            this.btn_ProjeYoneticisiGiris.Size = new System.Drawing.Size(206, 40);
            this.btn_ProjeYoneticisiGiris.TabIndex = 11;
            this.btn_ProjeYoneticisiGiris.Text = "Proje Yöneticisi Girişi";
            this.btn_ProjeYoneticisiGiris.TextColor = System.Drawing.Color.White;
            this.btn_ProjeYoneticisiGiris.UseVisualStyleBackColor = false;
            this.btn_ProjeYoneticisiGiris.Click += new System.EventHandler(this.btn_ProjeYoneticisiGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 221);
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
            this.txt_Sifre.Location = new System.Drawing.Point(106, 326);
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
            this.txt_Mail.Location = new System.Drawing.Point(106, 253);
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
            // frmYoneticiGiris1
            // 
            this.frmYoneticiGiris1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.frmYoneticiGiris1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmYoneticiGiris1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmYoneticiGiris1.Location = new System.Drawing.Point(0, 0);
            this.frmYoneticiGiris1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmYoneticiGiris1.Name = "frmYoneticiGiris1";
            this.frmYoneticiGiris1.Size = new System.Drawing.Size(748, 723);
            this.frmYoneticiGiris1.TabIndex = 14;
            this.frmYoneticiGiris1.Visible = false;
            // 
            // frmProjeYoneticisiGirisi1
            // 
            this.frmProjeYoneticisiGirisi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.frmProjeYoneticisiGirisi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmProjeYoneticisiGirisi1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmProjeYoneticisiGirisi1.Location = new System.Drawing.Point(0, 0);
            this.frmProjeYoneticisiGirisi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmProjeYoneticisiGirisi1.Name = "frmProjeYoneticisiGirisi1";
            this.frmProjeYoneticisiGirisi1.Size = new System.Drawing.Size(748, 723);
            this.frmProjeYoneticisiGirisi1.TabIndex = 15;
            this.frmProjeYoneticisiGirisi1.Visible = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.frmProjeYoneticisiGirisi1);
            this.Controls.Add(this.frmYoneticiGiris1);
            this.Controls.Add(this.pnl_KullaniciGirisi);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGiris";
            this.Size = new System.Drawing.Size(748, 723);
            this.pnl_KullaniciGirisi.ResumeLayout(false);
            this.pnl_KullaniciGirisi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_GirisYap;
        private CheckBox cb_BeniHatirla;
        private Label label1;
        private Panel pnl_KullaniciGirisi;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Sifre;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Mail;
        private Label label3;
        private Label label2;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_ProjeYoneticisiGiris;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_YoneticiGiris;
        private Panel panel2;
        private Label lbl_GirisBilgilendirme;
        private UserControls.frmYoneticiGiris frmYoneticiGiris1;
        private UserControls.frmProjeYoneticisiGirisi frmProjeYoneticisiGirisi1;
    }
}
