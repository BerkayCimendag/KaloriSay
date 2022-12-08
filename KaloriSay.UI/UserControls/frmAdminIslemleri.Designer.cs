namespace KaloriSay.UI.UserControls
{
    partial class frmAdminIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Yonetici = new System.Windows.Forms.Panel();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.rb_Pasif = new System.Windows.Forms.RadioButton();
            this.rb_Aktif = new System.Windows.Forms.RadioButton();
            this.btn_Listele = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_YoneticiEkle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_YoneticiGuncelle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_YoneticiSil = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.txt_YoneticiSifre = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_KullaniciMail = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_KullaniciSoyadi = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.txt_KullaniciAdi = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.dgv_Adminler = new System.Windows.Forms.DataGridView();
            this.pnl_Yonetici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adminler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Yonetici
            // 
            this.pnl_Yonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnl_Yonetici.Controls.Add(this.lbl_Sifre);
            this.pnl_Yonetici.Controls.Add(this.rb_Pasif);
            this.pnl_Yonetici.Controls.Add(this.rb_Aktif);
            this.pnl_Yonetici.Controls.Add(this.btn_Listele);
            this.pnl_Yonetici.Controls.Add(this.btn_YoneticiEkle);
            this.pnl_Yonetici.Controls.Add(this.btn_YoneticiGuncelle);
            this.pnl_Yonetici.Controls.Add(this.btn_YoneticiSil);
            this.pnl_Yonetici.Controls.Add(this.txt_YoneticiSifre);
            this.pnl_Yonetici.Controls.Add(this.txt_KullaniciMail);
            this.pnl_Yonetici.Controls.Add(this.txt_KullaniciSoyadi);
            this.pnl_Yonetici.Controls.Add(this.txt_KullaniciAdi);
            this.pnl_Yonetici.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Yonetici.Location = new System.Drawing.Point(804, 0);
            this.pnl_Yonetici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Yonetici.Name = "pnl_Yonetici";
            this.pnl_Yonetici.Size = new System.Drawing.Size(334, 641);
            this.pnl_Yonetici.TabIndex = 0;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.Font = new System.Drawing.Font("STXihei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sifre.ForeColor = System.Drawing.Color.Red;
            this.lbl_Sifre.Location = new System.Drawing.Point(7, 346);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(324, 83);
            this.lbl_Sifre.TabIndex = 14;
            this.lbl_Sifre.Text = "Şifreniz En Az 8 Karakter, 2 Büyük Harf,3 Küçük Harf,\r\n2 Tanede Özel Karakter Olm" +
    "ak Zorundadır.";
            this.lbl_Sifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Sifre.Visible = false;
            // 
            // rb_Pasif
            // 
            this.rb_Pasif.AutoSize = true;
            this.rb_Pasif.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Pasif.Location = new System.Drawing.Point(209, 294);
            this.rb_Pasif.Name = "rb_Pasif";
            this.rb_Pasif.Size = new System.Drawing.Size(66, 20);
            this.rb_Pasif.TabIndex = 5;
            this.rb_Pasif.Text = "Pasif";
            this.rb_Pasif.UseVisualStyleBackColor = true;
            // 
            // rb_Aktif
            // 
            this.rb_Aktif.AutoSize = true;
            this.rb_Aktif.Checked = true;
            this.rb_Aktif.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Aktif.Location = new System.Drawing.Point(55, 294);
            this.rb_Aktif.Name = "rb_Aktif";
            this.rb_Aktif.Size = new System.Drawing.Size(65, 20);
            this.rb_Aktif.TabIndex = 4;
            this.rb_Aktif.TabStop = true;
            this.rb_Aktif.Text = "Aktif";
            this.rb_Aktif.UseVisualStyleBackColor = true;
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Transparent;
            this.btn_Listele.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Listele.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Listele.BorderRadius = 0;
            this.btn_Listele.BorderSize = 0;
            this.btn_Listele.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Listele.FlatAppearance.BorderSize = 0;
            this.btn_Listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listele.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Listele.ForeColor = System.Drawing.Color.White;
            this.btn_Listele.Location = new System.Drawing.Point(0, 481);
            this.btn_Listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(334, 40);
            this.btn_Listele.TabIndex = 6;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.TextColor = System.Drawing.Color.White;
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_YoneticiEkle
            // 
            this.btn_YoneticiEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiEkle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_YoneticiEkle.BorderRadius = 0;
            this.btn_YoneticiEkle.BorderSize = 0;
            this.btn_YoneticiEkle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_YoneticiEkle.FlatAppearance.BorderSize = 0;
            this.btn_YoneticiEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_YoneticiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YoneticiEkle.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_YoneticiEkle.ForeColor = System.Drawing.Color.White;
            this.btn_YoneticiEkle.Location = new System.Drawing.Point(0, 521);
            this.btn_YoneticiEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YoneticiEkle.Name = "btn_YoneticiEkle";
            this.btn_YoneticiEkle.Size = new System.Drawing.Size(334, 40);
            this.btn_YoneticiEkle.TabIndex = 7;
            this.btn_YoneticiEkle.Text = "Yönetici Ekle";
            this.btn_YoneticiEkle.TextColor = System.Drawing.Color.White;
            this.btn_YoneticiEkle.UseVisualStyleBackColor = false;
            this.btn_YoneticiEkle.Click += new System.EventHandler(this.btn_YoneticiEkle_Click);
            // 
            // btn_YoneticiGuncelle
            // 
            this.btn_YoneticiGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiGuncelle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiGuncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_YoneticiGuncelle.BorderRadius = 0;
            this.btn_YoneticiGuncelle.BorderSize = 0;
            this.btn_YoneticiGuncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_YoneticiGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_YoneticiGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_YoneticiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YoneticiGuncelle.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_YoneticiGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_YoneticiGuncelle.Location = new System.Drawing.Point(0, 561);
            this.btn_YoneticiGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YoneticiGuncelle.Name = "btn_YoneticiGuncelle";
            this.btn_YoneticiGuncelle.Size = new System.Drawing.Size(334, 40);
            this.btn_YoneticiGuncelle.TabIndex = 8;
            this.btn_YoneticiGuncelle.Text = "Yönetici Güncelle";
            this.btn_YoneticiGuncelle.TextColor = System.Drawing.Color.White;
            this.btn_YoneticiGuncelle.UseVisualStyleBackColor = false;
            this.btn_YoneticiGuncelle.Click += new System.EventHandler(this.btn_YoneticiGuncelle_Click);
            // 
            // btn_YoneticiSil
            // 
            this.btn_YoneticiSil.BackColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiSil.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_YoneticiSil.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_YoneticiSil.BorderRadius = 0;
            this.btn_YoneticiSil.BorderSize = 0;
            this.btn_YoneticiSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_YoneticiSil.FlatAppearance.BorderSize = 0;
            this.btn_YoneticiSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_YoneticiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YoneticiSil.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_YoneticiSil.ForeColor = System.Drawing.Color.White;
            this.btn_YoneticiSil.Location = new System.Drawing.Point(0, 601);
            this.btn_YoneticiSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_YoneticiSil.Name = "btn_YoneticiSil";
            this.btn_YoneticiSil.Size = new System.Drawing.Size(334, 40);
            this.btn_YoneticiSil.TabIndex = 9;
            this.btn_YoneticiSil.Text = "Yönetici Sil";
            this.btn_YoneticiSil.TextColor = System.Drawing.Color.White;
            this.btn_YoneticiSil.UseVisualStyleBackColor = false;
            this.btn_YoneticiSil.Click += new System.EventHandler(this.btn_YoneticiSil_Click);
            // 
            // txt_YoneticiSifre
            // 
            this.txt_YoneticiSifre.BackColor = System.Drawing.SystemColors.Window;
            this.txt_YoneticiSifre.BorderColor = System.Drawing.Color.Black;
            this.txt_YoneticiSifre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.txt_YoneticiSifre.BorderRadius = 0;
            this.txt_YoneticiSifre.BorderSize = 2;
            this.txt_YoneticiSifre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_YoneticiSifre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_YoneticiSifre.Location = new System.Drawing.Point(6, 203);
            this.txt_YoneticiSifre.Multiline = false;
            this.txt_YoneticiSifre.Name = "txt_YoneticiSifre";
            this.txt_YoneticiSifre.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_YoneticiSifre.PasswordChar = false;
            this.txt_YoneticiSifre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_YoneticiSifre.PlaceholderText = "Şifre";
            this.txt_YoneticiSifre.Size = new System.Drawing.Size(324, 38);
            this.txt_YoneticiSifre.TabIndex = 3;
            this.txt_YoneticiSifre.UnderlinedStyle = false;
            // 
            // txt_KullaniciMail
            // 
            this.txt_KullaniciMail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_KullaniciMail.BorderColor = System.Drawing.Color.Black;
            this.txt_KullaniciMail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.txt_KullaniciMail.BorderRadius = 0;
            this.txt_KullaniciMail.BorderSize = 2;
            this.txt_KullaniciMail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KullaniciMail.ForeColor = System.Drawing.Color.DimGray;
            this.txt_KullaniciMail.Location = new System.Drawing.Point(6, 159);
            this.txt_KullaniciMail.Multiline = false;
            this.txt_KullaniciMail.Name = "txt_KullaniciMail";
            this.txt_KullaniciMail.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_KullaniciMail.PasswordChar = false;
            this.txt_KullaniciMail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_KullaniciMail.PlaceholderText = "Email";
            this.txt_KullaniciMail.Size = new System.Drawing.Size(324, 38);
            this.txt_KullaniciMail.TabIndex = 2;
            this.txt_KullaniciMail.UnderlinedStyle = false;
            // 
            // txt_KullaniciSoyadi
            // 
            this.txt_KullaniciSoyadi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_KullaniciSoyadi.BorderColor = System.Drawing.Color.Black;
            this.txt_KullaniciSoyadi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.txt_KullaniciSoyadi.BorderRadius = 0;
            this.txt_KullaniciSoyadi.BorderSize = 2;
            this.txt_KullaniciSoyadi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KullaniciSoyadi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_KullaniciSoyadi.Location = new System.Drawing.Point(6, 115);
            this.txt_KullaniciSoyadi.Multiline = false;
            this.txt_KullaniciSoyadi.Name = "txt_KullaniciSoyadi";
            this.txt_KullaniciSoyadi.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_KullaniciSoyadi.PasswordChar = false;
            this.txt_KullaniciSoyadi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_KullaniciSoyadi.PlaceholderText = "Soyadı";
            this.txt_KullaniciSoyadi.Size = new System.Drawing.Size(324, 38);
            this.txt_KullaniciSoyadi.TabIndex = 1;
            this.txt_KullaniciSoyadi.UnderlinedStyle = false;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_KullaniciAdi.BorderColor = System.Drawing.Color.Black;
            this.txt_KullaniciAdi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.txt_KullaniciAdi.BorderRadius = 0;
            this.txt_KullaniciAdi.BorderSize = 2;
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KullaniciAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(6, 71);
            this.txt_KullaniciAdi.Multiline = false;
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_KullaniciAdi.PasswordChar = false;
            this.txt_KullaniciAdi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_KullaniciAdi.PlaceholderText = "Adı";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(324, 38);
            this.txt_KullaniciAdi.TabIndex = 0;
            this.txt_KullaniciAdi.UnderlinedStyle = false;
            // 
            // dgv_Adminler
            // 
            this.dgv_Adminler.AllowUserToAddRows = false;
            this.dgv_Adminler.AllowUserToDeleteRows = false;
            this.dgv_Adminler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Adminler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Adminler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Adminler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Adminler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Adminler.Location = new System.Drawing.Point(0, 0);
            this.dgv_Adminler.MultiSelect = false;
            this.dgv_Adminler.Name = "dgv_Adminler";
            this.dgv_Adminler.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Adminler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Adminler.RowHeadersVisible = false;
            this.dgv_Adminler.RowHeadersWidth = 51;
            this.dgv_Adminler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Adminler.Size = new System.Drawing.Size(804, 641);
            this.dgv_Adminler.TabIndex = 3;
            this.dgv_Adminler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Adminler_CellClick);
            this.dgv_Adminler.DoubleClick += new System.EventHandler(this.dgv_Adminler_DoubleClick);
            // 
            // frmAdminIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Adminler);
            this.Controls.Add(this.pnl_Yonetici);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminIslemleri";
            this.Size = new System.Drawing.Size(1138, 641);
            this.pnl_Yonetici.ResumeLayout(false);
            this.pnl_Yonetici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adminler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Yonetici;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_YoneticiEkle;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_YoneticiGuncelle;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_YoneticiSil;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_YoneticiSifre;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_KullaniciMail;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_KullaniciSoyadi;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_KullaniciAdi;
        private DataGridView dgv_Adminler;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Listele;
        private RadioButton rb_Pasif;
        private RadioButton rb_Aktif;
        private Label lbl_Sifre;
    }
}
