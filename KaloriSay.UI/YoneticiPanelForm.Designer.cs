namespace KaloriSay.UI
{
    partial class YoneticiPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPanelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_SimgeDurumu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CıkısYap = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_TalepSikayet = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_KullaniciIslemleri = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_KategoriIslemleri = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_BesinIslemleri = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_Raporlar = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.pnl_UserControl = new System.Windows.Forms.Panel();
            this.frmRaporlar1 = new KaloriSay.UI.UserControls.frmRaporlar();
            this.frmTalepSikayet1 = new KaloriSay.UI.UserControls.frmTalepSikayet();
            this.frmKullaniciIslemleri1 = new KaloriSay.UI.UserControls.frmKullaniciIslemleri();
            this.frmKategoriIslemleri1 = new KaloriSay.UI.UserControls.frmKategoriIslemleri();
            this.frmBesinIslemleri1 = new KaloriSay.UI.UserControls.frmBesinIslemleri();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_UserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Cikis);
            this.panel1.Controls.Add(this.btn_SimgeDurumu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(614, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yönetici Paneli";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Image = global::KaloriSay.UI.Properties.Resources.exitIcon;
            this.btn_Cikis.Location = new System.Drawing.Point(1368, -1);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(45, 47);
            this.btn_Cikis.TabIndex = 7;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_SimgeDurumu
            // 
            this.btn_SimgeDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SimgeDurumu.FlatAppearance.BorderSize = 0;
            this.btn_SimgeDurumu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_SimgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SimgeDurumu.Image = global::KaloriSay.UI.Properties.Resources.minimizeIcon;
            this.btn_SimgeDurumu.Location = new System.Drawing.Point(1319, -1);
            this.btn_SimgeDurumu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_SimgeDurumu.Name = "btn_SimgeDurumu";
            this.btn_SimgeDurumu.Size = new System.Drawing.Size(45, 46);
            this.btn_SimgeDurumu.TabIndex = 8;
            this.btn_SimgeDurumu.UseVisualStyleBackColor = true;
            this.btn_SimgeDurumu.Click += new System.EventHandler(this.btn_SimgeDurumu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.btn_CıkısYap);
            this.panel2.Controls.Add(this.btn_TalepSikayet);
            this.panel2.Controls.Add(this.btn_KullaniciIslemleri);
            this.panel2.Controls.Add(this.btn_KategoriIslemleri);
            this.panel2.Controls.Add(this.btn_BesinIslemleri);
            this.panel2.Controls.Add(this.btn_Raporlar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 735);
            this.panel2.TabIndex = 1;
            // 
            // btn_CıkısYap
            // 
            this.btn_CıkısYap.BackColor = System.Drawing.Color.Transparent;
            this.btn_CıkısYap.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_CıkısYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CıkısYap.BackgroundImage")));
            this.btn_CıkısYap.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CıkısYap.BorderRadius = 35;
            this.btn_CıkısYap.BorderSize = 0;
            this.btn_CıkısYap.FlatAppearance.BorderSize = 0;
            this.btn_CıkısYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_CıkısYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CıkısYap.ForeColor = System.Drawing.Color.White;
            this.btn_CıkısYap.Location = new System.Drawing.Point(3, 688);
            this.btn_CıkısYap.Name = "btn_CıkısYap";
            this.btn_CıkısYap.Size = new System.Drawing.Size(35, 35);
            this.btn_CıkısYap.TabIndex = 18;
            this.btn_CıkısYap.TextColor = System.Drawing.Color.White;
            this.btn_CıkısYap.UseVisualStyleBackColor = false;
            this.btn_CıkısYap.Click += new System.EventHandler(this.btn_CıkısYap_Click);
            // 
            // btn_TalepSikayet
            // 
            this.btn_TalepSikayet.BackColor = System.Drawing.Color.Transparent;
            this.btn_TalepSikayet.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_TalepSikayet.BorderColor = System.Drawing.Color.Black;
            this.btn_TalepSikayet.BorderRadius = 0;
            this.btn_TalepSikayet.BorderSize = 0;
            this.btn_TalepSikayet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TalepSikayet.FlatAppearance.BorderSize = 0;
            this.btn_TalepSikayet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_TalepSikayet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TalepSikayet.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TalepSikayet.ForeColor = System.Drawing.Color.White;
            this.btn_TalepSikayet.Image = global::KaloriSay.UI.Properties.Resources.ContactIcon;
            this.btn_TalepSikayet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TalepSikayet.Location = new System.Drawing.Point(0, 268);
            this.btn_TalepSikayet.Name = "btn_TalepSikayet";
            this.btn_TalepSikayet.Size = new System.Drawing.Size(239, 67);
            this.btn_TalepSikayet.TabIndex = 16;
            this.btn_TalepSikayet.Text = "Talep/Şikayet Paneli";
            this.btn_TalepSikayet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TalepSikayet.TextColor = System.Drawing.Color.White;
            this.btn_TalepSikayet.UseVisualStyleBackColor = false;
            this.btn_TalepSikayet.Click += new System.EventHandler(this.btn_TalepSikayet_Click);
            // 
            // btn_KullaniciIslemleri
            // 
            this.btn_KullaniciIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btn_KullaniciIslemleri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_KullaniciIslemleri.BorderColor = System.Drawing.Color.Black;
            this.btn_KullaniciIslemleri.BorderRadius = 0;
            this.btn_KullaniciIslemleri.BorderSize = 0;
            this.btn_KullaniciIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KullaniciIslemleri.FlatAppearance.BorderSize = 0;
            this.btn_KullaniciIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_KullaniciIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KullaniciIslemleri.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KullaniciIslemleri.ForeColor = System.Drawing.Color.White;
            this.btn_KullaniciIslemleri.Image = global::KaloriSay.UI.Properties.Resources.Weight;
            this.btn_KullaniciIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KullaniciIslemleri.Location = new System.Drawing.Point(0, 201);
            this.btn_KullaniciIslemleri.Name = "btn_KullaniciIslemleri";
            this.btn_KullaniciIslemleri.Size = new System.Drawing.Size(239, 67);
            this.btn_KullaniciIslemleri.TabIndex = 13;
            this.btn_KullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.btn_KullaniciIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_KullaniciIslemleri.TextColor = System.Drawing.Color.White;
            this.btn_KullaniciIslemleri.UseVisualStyleBackColor = false;
            this.btn_KullaniciIslemleri.Click += new System.EventHandler(this.btn_KullaniciIslemleri_Click);
            // 
            // btn_KategoriIslemleri
            // 
            this.btn_KategoriIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btn_KategoriIslemleri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_KategoriIslemleri.BorderColor = System.Drawing.Color.Black;
            this.btn_KategoriIslemleri.BorderRadius = 0;
            this.btn_KategoriIslemleri.BorderSize = 0;
            this.btn_KategoriIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KategoriIslemleri.FlatAppearance.BorderSize = 0;
            this.btn_KategoriIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_KategoriIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KategoriIslemleri.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KategoriIslemleri.ForeColor = System.Drawing.Color.White;
            this.btn_KategoriIslemleri.Image = global::KaloriSay.UI.Properties.Resources.CalculatorIcon;
            this.btn_KategoriIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KategoriIslemleri.Location = new System.Drawing.Point(0, 134);
            this.btn_KategoriIslemleri.Name = "btn_KategoriIslemleri";
            this.btn_KategoriIslemleri.Size = new System.Drawing.Size(239, 67);
            this.btn_KategoriIslemleri.TabIndex = 12;
            this.btn_KategoriIslemleri.Text = "Kategori İşlemleri";
            this.btn_KategoriIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_KategoriIslemleri.TextColor = System.Drawing.Color.White;
            this.btn_KategoriIslemleri.UseVisualStyleBackColor = false;
            this.btn_KategoriIslemleri.Click += new System.EventHandler(this.btn_KategoriIslemleri_Click);
            // 
            // btn_BesinIslemleri
            // 
            this.btn_BesinIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btn_BesinIslemleri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_BesinIslemleri.BorderColor = System.Drawing.Color.Black;
            this.btn_BesinIslemleri.BorderRadius = 0;
            this.btn_BesinIslemleri.BorderSize = 0;
            this.btn_BesinIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BesinIslemleri.FlatAppearance.BorderSize = 0;
            this.btn_BesinIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_BesinIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BesinIslemleri.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BesinIslemleri.ForeColor = System.Drawing.Color.White;
            this.btn_BesinIslemleri.Image = global::KaloriSay.UI.Properties.Resources.CreateIcon;
            this.btn_BesinIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BesinIslemleri.Location = new System.Drawing.Point(0, 67);
            this.btn_BesinIslemleri.Name = "btn_BesinIslemleri";
            this.btn_BesinIslemleri.Size = new System.Drawing.Size(239, 67);
            this.btn_BesinIslemleri.TabIndex = 11;
            this.btn_BesinIslemleri.Text = "Besin İşlemleri";
            this.btn_BesinIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BesinIslemleri.TextColor = System.Drawing.Color.White;
            this.btn_BesinIslemleri.UseVisualStyleBackColor = false;
            this.btn_BesinIslemleri.Click += new System.EventHandler(this.btn_BesinIslemleri_Click);
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Raporlar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Raporlar.BorderColor = System.Drawing.Color.Black;
            this.btn_Raporlar.BorderRadius = 0;
            this.btn_Raporlar.BorderSize = 0;
            this.btn_Raporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Raporlar.FlatAppearance.BorderSize = 0;
            this.btn_Raporlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_Raporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Raporlar.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Raporlar.ForeColor = System.Drawing.Color.White;
            this.btn_Raporlar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Raporlar.Image")));
            this.btn_Raporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Raporlar.Location = new System.Drawing.Point(0, 0);
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.Size = new System.Drawing.Size(239, 67);
            this.btn_Raporlar.TabIndex = 10;
            this.btn_Raporlar.Text = "Raporlar";
            this.btn_Raporlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Raporlar.TextColor = System.Drawing.Color.White;
            this.btn_Raporlar.UseVisualStyleBackColor = false;
            this.btn_Raporlar.Click += new System.EventHandler(this.btn_Raporlar_Click);
            // 
            // pnl_UserControl
            // 
            this.pnl_UserControl.Controls.Add(this.frmRaporlar1);
            this.pnl_UserControl.Controls.Add(this.frmTalepSikayet1);
            this.pnl_UserControl.Controls.Add(this.frmKullaniciIslemleri1);
            this.pnl_UserControl.Controls.Add(this.frmKategoriIslemleri1);
            this.pnl_UserControl.Controls.Add(this.frmBesinIslemleri1);
            this.pnl_UserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_UserControl.Location = new System.Drawing.Point(239, 46);
            this.pnl_UserControl.Name = "pnl_UserControl";
            this.pnl_UserControl.Size = new System.Drawing.Size(1174, 735);
            this.pnl_UserControl.TabIndex = 2;
            // 
            // frmRaporlar1
            // 
            this.frmRaporlar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmRaporlar1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmRaporlar1.Location = new System.Drawing.Point(0, 0);
            this.frmRaporlar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmRaporlar1.Name = "frmRaporlar1";
            this.frmRaporlar1.Size = new System.Drawing.Size(1174, 735);
            this.frmRaporlar1.TabIndex = 5;
            // 
            // frmTalepSikayet1
            // 
            this.frmTalepSikayet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTalepSikayet1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmTalepSikayet1.Location = new System.Drawing.Point(0, 0);
            this.frmTalepSikayet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmTalepSikayet1.Name = "frmTalepSikayet1";
            this.frmTalepSikayet1.Size = new System.Drawing.Size(1174, 735);
            this.frmTalepSikayet1.TabIndex = 4;
            this.frmTalepSikayet1.Visible = false;
            // 
            // frmKullaniciIslemleri1
            // 
            this.frmKullaniciIslemleri1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmKullaniciIslemleri1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmKullaniciIslemleri1.Location = new System.Drawing.Point(0, 0);
            this.frmKullaniciIslemleri1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmKullaniciIslemleri1.Name = "frmKullaniciIslemleri1";
            this.frmKullaniciIslemleri1.Size = new System.Drawing.Size(1174, 735);
            this.frmKullaniciIslemleri1.TabIndex = 3;
            this.frmKullaniciIslemleri1.Visible = false;
            // 
            // frmKategoriIslemleri1
            // 
            this.frmKategoriIslemleri1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmKategoriIslemleri1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmKategoriIslemleri1.Location = new System.Drawing.Point(0, 0);
            this.frmKategoriIslemleri1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmKategoriIslemleri1.Name = "frmKategoriIslemleri1";
            this.frmKategoriIslemleri1.Size = new System.Drawing.Size(1174, 735);
            this.frmKategoriIslemleri1.TabIndex = 2;
            this.frmKategoriIslemleri1.Visible = false;
            // 
            // frmBesinIslemleri1
            // 
            this.frmBesinIslemleri1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.frmBesinIslemleri1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmBesinIslemleri1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmBesinIslemleri1.Location = new System.Drawing.Point(0, 0);
            this.frmBesinIslemleri1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmBesinIslemleri1.Name = "frmBesinIslemleri1";
            this.frmBesinIslemleri1.Size = new System.Drawing.Size(1174, 735);
            this.frmBesinIslemleri1.TabIndex = 1;
            this.frmBesinIslemleri1.Visible = false;
            // 
            // YoneticiPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 781);
            this.Controls.Add(this.pnl_UserControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YoneticiPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiPanelForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_UserControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_Cikis;
        private Button btn_SimgeDurumu;
        private Panel panel2;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_TalepSikayet;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_KullaniciIslemleri;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_KategoriIslemleri;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_BesinIslemleri;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Raporlar;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_CıkısYap;
        private Label label1;
        private Panel pnl_UserControl;
        private UserControls.frmKategoriIslemleri frmKategoriIslemleri1;
        private UserControls.frmBesinIslemleri frmBesinIslemleri1;
        private UserControls.frmKullaniciIslemleri frmKullaniciIslemleri1;
        private UserControls.frmTalepSikayet frmTalepSikayet1;
        private UserControls.frmRaporlar frmRaporlar1;
    }
}