namespace KaloriSay.UI.UserControls
{
    partial class frmAyarlar
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
            this.pnl_Ayarlar = new System.Windows.Forms.Panel();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_AyarBilgilendirme = new System.Windows.Forms.Label();
            this.btn_UyelikSil = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_BilgiGuncelle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.txt_SifreTekrar = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_Sifre = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Kilo = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_Yas = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Boy = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Ayarlar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Ayarlar
            // 
            this.pnl_Ayarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_Ayarlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Ayarlar.Controls.Add(this.panel1);
            this.pnl_Ayarlar.Controls.Add(this.lbl_Sifre);
            this.pnl_Ayarlar.Controls.Add(this.lbl_AyarBilgilendirme);
            this.pnl_Ayarlar.Controls.Add(this.btn_UyelikSil);
            this.pnl_Ayarlar.Controls.Add(this.btn_BilgiGuncelle);
            this.pnl_Ayarlar.Controls.Add(this.txt_Kilo);
            this.pnl_Ayarlar.Controls.Add(this.txt_Yas);
            this.pnl_Ayarlar.Controls.Add(this.label3);
            this.pnl_Ayarlar.Controls.Add(this.label5);
            this.pnl_Ayarlar.Controls.Add(this.txt_Boy);
            this.pnl_Ayarlar.Controls.Add(this.label2);
            this.pnl_Ayarlar.Controls.Add(this.label1);
            this.pnl_Ayarlar.Location = new System.Drawing.Point(75, 44);
            this.pnl_Ayarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Ayarlar.Name = "pnl_Ayarlar";
            this.pnl_Ayarlar.Size = new System.Drawing.Size(1025, 518);
            this.pnl_Ayarlar.TabIndex = 1;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("STXihei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sifre.ForeColor = System.Drawing.Color.Red;
            this.lbl_Sifre.Location = new System.Drawing.Point(296, 423);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(414, 38);
            this.lbl_Sifre.TabIndex = 13;
            this.lbl_Sifre.Text = "Şifreniz En Az 8 Karakter, 2 Büyük Harf,3 Küçük Harf,\r\n2 Tanede Özel Karakter Olm" +
    "ak Zorundadır.";
            this.lbl_Sifre.Visible = false;
            // 
            // lbl_AyarBilgilendirme
            // 
            this.lbl_AyarBilgilendirme.AutoSize = true;
            this.lbl_AyarBilgilendirme.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AyarBilgilendirme.ForeColor = System.Drawing.Color.Red;
            this.lbl_AyarBilgilendirme.Location = new System.Drawing.Point(385, 400);
            this.lbl_AyarBilgilendirme.Name = "lbl_AyarBilgilendirme";
            this.lbl_AyarBilgilendirme.Size = new System.Drawing.Size(57, 16);
            this.lbl_AyarBilgilendirme.TabIndex = 5;
            this.lbl_AyarBilgilendirme.Text = "label7";
            this.lbl_AyarBilgilendirme.Visible = false;
            // 
            // btn_UyelikSil
            // 
            this.btn_UyelikSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UyelikSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_UyelikSil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_UyelikSil.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_UyelikSil.BorderRadius = 30;
            this.btn_UyelikSil.BorderSize = 0;
            this.btn_UyelikSil.FlatAppearance.BorderSize = 0;
            this.btn_UyelikSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UyelikSil.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UyelikSil.ForeColor = System.Drawing.Color.White;
            this.btn_UyelikSil.Location = new System.Drawing.Point(878, 472);
            this.btn_UyelikSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UyelikSil.Name = "btn_UyelikSil";
            this.btn_UyelikSil.Size = new System.Drawing.Size(140, 40);
            this.btn_UyelikSil.TabIndex = 7;
            this.btn_UyelikSil.Text = "Üyelik Sil";
            this.btn_UyelikSil.TextColor = System.Drawing.Color.White;
            this.btn_UyelikSil.UseVisualStyleBackColor = false;
            this.btn_UyelikSil.Click += new System.EventHandler(this.btn_UyelikSil_Click);
            // 
            // btn_BilgiGuncelle
            // 
            this.btn_BilgiGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BilgiGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BilgiGuncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BilgiGuncelle.BorderRadius = 30;
            this.btn_BilgiGuncelle.BorderSize = 0;
            this.btn_BilgiGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_BilgiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BilgiGuncelle.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BilgiGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_BilgiGuncelle.Location = new System.Drawing.Point(354, 463);
            this.btn_BilgiGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BilgiGuncelle.Name = "btn_BilgiGuncelle";
            this.btn_BilgiGuncelle.Size = new System.Drawing.Size(312, 40);
            this.btn_BilgiGuncelle.TabIndex = 6;
            this.btn_BilgiGuncelle.Text = "Güncelle";
            this.btn_BilgiGuncelle.TextColor = System.Drawing.Color.White;
            this.btn_BilgiGuncelle.UseVisualStyleBackColor = false;
            this.btn_BilgiGuncelle.Click += new System.EventHandler(this.btn_BilgiGuncelle_Click);
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SifreTekrar.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SifreTekrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_SifreTekrar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_SifreTekrar.BorderRadius = 0;
            this.txt_SifreTekrar.BorderSize = 2;
            this.txt_SifreTekrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SifreTekrar.ForeColor = System.Drawing.Color.DimGray;
            this.txt_SifreTekrar.Location = new System.Drawing.Point(4, 85);
            this.txt_SifreTekrar.Multiline = false;
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_SifreTekrar.PasswordChar = true;
            this.txt_SifreTekrar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SifreTekrar.PlaceholderText = "";
            this.txt_SifreTekrar.Size = new System.Drawing.Size(312, 38);
            this.txt_SifreTekrar.TabIndex = 5;
            this.txt_SifreTekrar.UnderlinedStyle = true;
            this.txt_SifreTekrar._TextChanged += new System.EventHandler(this.txt_Boy__TextChanged);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Sifre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Sifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Sifre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Sifre.BorderRadius = 0;
            this.txt_Sifre.BorderSize = 2;
            this.txt_Sifre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Sifre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Sifre.Location = new System.Drawing.Point(4, 22);
            this.txt_Sifre.Multiline = false;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Sifre.PasswordChar = true;
            this.txt_Sifre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Sifre.PlaceholderText = "";
            this.txt_Sifre.Size = new System.Drawing.Size(312, 38);
            this.txt_Sifre.TabIndex = 4;
            this.txt_Sifre.UnderlinedStyle = true;
            this.txt_Sifre._TextChanged += new System.EventHandler(this.txt_Boy__TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre Tekrarı : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şifre : ";
            // 
            // txt_Kilo
            // 
            this.txt_Kilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Kilo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Kilo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Kilo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Kilo.BorderRadius = 0;
            this.txt_Kilo.BorderSize = 2;
            this.txt_Kilo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Kilo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Kilo.Location = new System.Drawing.Point(354, 151);
            this.txt_Kilo.Multiline = false;
            this.txt_Kilo.Name = "txt_Kilo";
            this.txt_Kilo.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Kilo.PasswordChar = false;
            this.txt_Kilo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Kilo.PlaceholderText = "";
            this.txt_Kilo.Size = new System.Drawing.Size(312, 38);
            this.txt_Kilo.TabIndex = 2;
            this.txt_Kilo.UnderlinedStyle = true;
            this.txt_Kilo._TextChanged += new System.EventHandler(this.txt_Boy__TextChanged);
            // 
            // txt_Yas
            // 
            this.txt_Yas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Yas.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Yas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Yas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Yas.BorderRadius = 0;
            this.txt_Yas.BorderSize = 2;
            this.txt_Yas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Yas.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Yas.Location = new System.Drawing.Point(354, 223);
            this.txt_Yas.Multiline = false;
            this.txt_Yas.Name = "txt_Yas";
            this.txt_Yas.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Yas.PasswordChar = false;
            this.txt_Yas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Yas.PlaceholderText = "";
            this.txt_Yas.Size = new System.Drawing.Size(312, 38);
            this.txt_Yas.TabIndex = 3;
            this.txt_Yas.UnderlinedStyle = true;
            this.txt_Yas._TextChanged += new System.EventHandler(this.txt_Boy__TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(354, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kilo : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(354, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yaş :";
            // 
            // txt_Boy
            // 
            this.txt_Boy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Boy.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Boy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Boy.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Boy.BorderRadius = 0;
            this.txt_Boy.BorderSize = 2;
            this.txt_Boy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Boy.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Boy.Location = new System.Drawing.Point(354, 78);
            this.txt_Boy.Multiline = false;
            this.txt_Boy.Name = "txt_Boy";
            this.txt_Boy.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Boy.PasswordChar = false;
            this.txt_Boy.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Boy.PlaceholderText = "";
            this.txt_Boy.Size = new System.Drawing.Size(312, 38);
            this.txt_Boy.TabIndex = 1;
            this.txt_Boy.UnderlinedStyle = true;
            this.txt_Boy._TextChanged += new System.EventHandler(this.txt_Boy__TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boy :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(423, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "AYARLAR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Sifre);
            this.panel1.Controls.Add(this.txt_SifreTekrar);
            this.panel1.Location = new System.Drawing.Point(344, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 130);
            this.panel1.TabIndex = 14;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Ayarlar);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAyarlar";
            this.Size = new System.Drawing.Size(1174, 607);
            this.pnl_Ayarlar.ResumeLayout(false);
            this.pnl_Ayarlar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Ayarlar;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_BilgiGuncelle;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_SifreTekrar;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Sifre;
        private Label label4;
        private Label label6;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Kilo;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Yas;
        private Label label3;
        private Label label5;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Boy;
        private Label label2;
        private Label label1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_UyelikSil;
        private Label lbl_AyarBilgilendirme;
        private Label lbl_Sifre;
        private Panel panel1;
    }
}
