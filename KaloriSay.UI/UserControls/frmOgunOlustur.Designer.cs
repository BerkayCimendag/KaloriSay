namespace KaloriSay.UI.UserControls
{
    partial class frmOgunOlustur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Ogunler = new System.Windows.Forms.Panel();
            this.lbl_AlinanKalori = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_AraOgun = new System.Windows.Forms.RadioButton();
            this.rb_AksamYemegi = new System.Windows.Forms.RadioButton();
            this.rb_OgleYemegi = new System.Windows.Forms.RadioButton();
            this.rb_Kahvalti = new System.Windows.Forms.RadioButton();
            this.btn_BesinEkle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.cmb_Besinler = new System.Windows.Forms.ComboBox();
            this.cmb_Kategoriler = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_BesinEkle = new System.Windows.Forms.Panel();
            this.pb_BesinResmi = new System.Windows.Forms.PictureBox();
            this.lbl_MiktarBirim = new System.Windows.Forms.Label();
            this.nud_Miktar = new System.Windows.Forms.NumericUpDown();
            this.btn_BesinSİl = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_BesinGuncelle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_AraOgun = new System.Windows.Forms.DataGridView();
            this.dgv_AksamYemegi = new System.Windows.Forms.DataGridView();
            this.dgv_OgleYemegi = new System.Windows.Forms.DataGridView();
            this.dgv_Kahvaltı = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_Ogunler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_BesinEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BesinResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Miktar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AraOgun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AksamYemegi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OgleYemegi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kahvaltı)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Ogunler
            // 
            this.pnl_Ogunler.Controls.Add(this.lbl_AlinanKalori);
            this.pnl_Ogunler.Controls.Add(this.label8);
            this.pnl_Ogunler.Controls.Add(this.rb_AraOgun);
            this.pnl_Ogunler.Controls.Add(this.rb_AksamYemegi);
            this.pnl_Ogunler.Controls.Add(this.rb_OgleYemegi);
            this.pnl_Ogunler.Controls.Add(this.rb_Kahvalti);
            this.pnl_Ogunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Ogunler.Location = new System.Drawing.Point(0, 150);
            this.pnl_Ogunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Ogunler.Name = "pnl_Ogunler";
            this.pnl_Ogunler.Size = new System.Drawing.Size(1174, 50);
            this.pnl_Ogunler.TabIndex = 0;
            // 
            // lbl_AlinanKalori
            // 
            this.lbl_AlinanKalori.AutoSize = true;
            this.lbl_AlinanKalori.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AlinanKalori.Location = new System.Drawing.Point(197, 15);
            this.lbl_AlinanKalori.Name = "lbl_AlinanKalori";
            this.lbl_AlinanKalori.Size = new System.Drawing.Size(13, 16);
            this.lbl_AlinanKalori.TabIndex = 1;
            this.lbl_AlinanKalori.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alınan Toplam Kalori : ";
            // 
            // rb_AraOgun
            // 
            this.rb_AraOgun.AutoSize = true;
            this.rb_AraOgun.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_AraOgun.Location = new System.Drawing.Point(748, 11);
            this.rb_AraOgun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_AraOgun.Name = "rb_AraOgun";
            this.rb_AraOgun.Size = new System.Drawing.Size(107, 20);
            this.rb_AraOgun.TabIndex = 7;
            this.rb_AraOgun.Text = "Ara Öğün";
            this.rb_AraOgun.UseVisualStyleBackColor = true;
            // 
            // rb_AksamYemegi
            // 
            this.rb_AksamYemegi.AutoSize = true;
            this.rb_AksamYemegi.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_AksamYemegi.Location = new System.Drawing.Point(582, 11);
            this.rb_AksamYemegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_AksamYemegi.Name = "rb_AksamYemegi";
            this.rb_AksamYemegi.Size = new System.Drawing.Size(149, 20);
            this.rb_AksamYemegi.TabIndex = 6;
            this.rb_AksamYemegi.Text = "Akşam Yemeği";
            this.rb_AksamYemegi.UseVisualStyleBackColor = true;
            // 
            // rb_OgleYemegi
            // 
            this.rb_OgleYemegi.AutoSize = true;
            this.rb_OgleYemegi.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_OgleYemegi.Location = new System.Drawing.Point(430, 11);
            this.rb_OgleYemegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_OgleYemegi.Name = "rb_OgleYemegi";
            this.rb_OgleYemegi.Size = new System.Drawing.Size(135, 20);
            this.rb_OgleYemegi.TabIndex = 5;
            this.rb_OgleYemegi.Text = "Öğle Yemeği";
            this.rb_OgleYemegi.UseVisualStyleBackColor = true;
            // 
            // rb_Kahvalti
            // 
            this.rb_Kahvalti.AutoSize = true;
            this.rb_Kahvalti.Checked = true;
            this.rb_Kahvalti.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Kahvalti.Location = new System.Drawing.Point(320, 11);
            this.rb_Kahvalti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Kahvalti.Name = "rb_Kahvalti";
            this.rb_Kahvalti.Size = new System.Drawing.Size(93, 20);
            this.rb_Kahvalti.TabIndex = 4;
            this.rb_Kahvalti.TabStop = true;
            this.rb_Kahvalti.Text = "Kahvaltı";
            this.rb_Kahvalti.UseVisualStyleBackColor = true;
            // 
            // btn_BesinEkle
            // 
            this.btn_BesinEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BesinEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BesinEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BesinEkle.BorderRadius = 30;
            this.btn_BesinEkle.BorderSize = 0;
            this.btn_BesinEkle.FlatAppearance.BorderSize = 0;
            this.btn_BesinEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BesinEkle.ForeColor = System.Drawing.Color.White;
            this.btn_BesinEkle.Location = new System.Drawing.Point(825, 11);
            this.btn_BesinEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BesinEkle.Name = "btn_BesinEkle";
            this.btn_BesinEkle.Size = new System.Drawing.Size(185, 30);
            this.btn_BesinEkle.TabIndex = 8;
            this.btn_BesinEkle.Text = "Besin Ekle";
            this.btn_BesinEkle.TextColor = System.Drawing.Color.White;
            this.btn_BesinEkle.UseVisualStyleBackColor = false;
            this.btn_BesinEkle.Click += new System.EventHandler(this.btn_BesinEkle_Click);
            // 
            // cmb_Besinler
            // 
            this.cmb_Besinler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Besinler.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_Besinler.FormattingEnabled = true;
            this.cmb_Besinler.Location = new System.Drawing.Point(154, 55);
            this.cmb_Besinler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Besinler.Name = "cmb_Besinler";
            this.cmb_Besinler.Size = new System.Drawing.Size(440, 24);
            this.cmb_Besinler.TabIndex = 2;
            this.cmb_Besinler.SelectedIndexChanged += new System.EventHandler(this.cmb_Besinler_SelectedIndexChanged);
            // 
            // cmb_Kategoriler
            // 
            this.cmb_Kategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kategoriler.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_Kategoriler.FormattingEnabled = true;
            this.cmb_Kategoriler.Location = new System.Drawing.Point(154, 8);
            this.cmb_Kategoriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Kategoriler.Name = "cmb_Kategoriler";
            this.cmb_Kategoriler.Size = new System.Drawing.Size(440, 24);
            this.cmb_Kategoriler.TabIndex = 1;
            this.cmb_Kategoriler.SelectedIndexChanged += new System.EventHandler(this.cmb_Kategoriler_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 44);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(979, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ara Öğün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(670, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Akşam Yemeği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(378, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğle Yemeği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kahvaltı";
            // 
            // pnl_BesinEkle
            // 
            this.pnl_BesinEkle.Controls.Add(this.pb_BesinResmi);
            this.pnl_BesinEkle.Controls.Add(this.lbl_MiktarBirim);
            this.pnl_BesinEkle.Controls.Add(this.nud_Miktar);
            this.pnl_BesinEkle.Controls.Add(this.btn_BesinSİl);
            this.pnl_BesinEkle.Controls.Add(this.btn_BesinGuncelle);
            this.pnl_BesinEkle.Controls.Add(this.btn_BesinEkle);
            this.pnl_BesinEkle.Controls.Add(this.cmb_Kategoriler);
            this.pnl_BesinEkle.Controls.Add(this.cmb_Besinler);
            this.pnl_BesinEkle.Controls.Add(this.label7);
            this.pnl_BesinEkle.Controls.Add(this.label6);
            this.pnl_BesinEkle.Controls.Add(this.label5);
            this.pnl_BesinEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BesinEkle.Location = new System.Drawing.Point(0, 0);
            this.pnl_BesinEkle.Name = "pnl_BesinEkle";
            this.pnl_BesinEkle.Size = new System.Drawing.Size(1174, 150);
            this.pnl_BesinEkle.TabIndex = 1;
            // 
            // pb_BesinResmi
            // 
            this.pb_BesinResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_BesinResmi.Location = new System.Drawing.Point(613, 8);
            this.pb_BesinResmi.Name = "pb_BesinResmi";
            this.pb_BesinResmi.Size = new System.Drawing.Size(178, 137);
            this.pb_BesinResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BesinResmi.TabIndex = 11;
            this.pb_BesinResmi.TabStop = false;
            // 
            // lbl_MiktarBirim
            // 
            this.lbl_MiktarBirim.AutoSize = true;
            this.lbl_MiktarBirim.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MiktarBirim.Location = new System.Drawing.Point(411, 111);
            this.lbl_MiktarBirim.Name = "lbl_MiktarBirim";
            this.lbl_MiktarBirim.Size = new System.Drawing.Size(13, 16);
            this.lbl_MiktarBirim.TabIndex = 4;
            this.lbl_MiktarBirim.Text = "-";
            // 
            // nud_Miktar
            // 
            this.nud_Miktar.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nud_Miktar.Location = new System.Drawing.Point(154, 102);
            this.nud_Miktar.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_Miktar.Name = "nud_Miktar";
            this.nud_Miktar.Size = new System.Drawing.Size(237, 28);
            this.nud_Miktar.TabIndex = 3;
            this.nud_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_BesinSİl
            // 
            this.btn_BesinSİl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BesinSİl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BesinSİl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BesinSİl.BorderRadius = 30;
            this.btn_BesinSİl.BorderSize = 0;
            this.btn_BesinSİl.FlatAppearance.BorderSize = 0;
            this.btn_BesinSİl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BesinSİl.ForeColor = System.Drawing.Color.White;
            this.btn_BesinSİl.Location = new System.Drawing.Point(825, 83);
            this.btn_BesinSİl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BesinSİl.Name = "btn_BesinSİl";
            this.btn_BesinSİl.Size = new System.Drawing.Size(185, 30);
            this.btn_BesinSİl.TabIndex = 10;
            this.btn_BesinSİl.Text = "Besin Sil";
            this.btn_BesinSİl.TextColor = System.Drawing.Color.White;
            this.btn_BesinSİl.UseVisualStyleBackColor = false;
            this.btn_BesinSİl.Click += new System.EventHandler(this.btn_BesinSİl_Click);
            // 
            // btn_BesinGuncelle
            // 
            this.btn_BesinGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BesinGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BesinGuncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BesinGuncelle.BorderRadius = 30;
            this.btn_BesinGuncelle.BorderSize = 0;
            this.btn_BesinGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_BesinGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BesinGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_BesinGuncelle.Location = new System.Drawing.Point(825, 49);
            this.btn_BesinGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BesinGuncelle.Name = "btn_BesinGuncelle";
            this.btn_BesinGuncelle.Size = new System.Drawing.Size(185, 30);
            this.btn_BesinGuncelle.TabIndex = 9;
            this.btn_BesinGuncelle.Text = "Besin Güncelle";
            this.btn_BesinGuncelle.TextColor = System.Drawing.Color.White;
            this.btn_BesinGuncelle.UseVisualStyleBackColor = false;
            this.btn_BesinGuncelle.Click += new System.EventHandler(this.btn_BesinGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Miktarı Giriniz : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(68, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Besinler : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategoriler : ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_AraOgun);
            this.panel5.Controls.Add(this.dgv_AksamYemegi);
            this.panel5.Controls.Add(this.dgv_OgleYemegi);
            this.panel5.Controls.Add(this.dgv_Kahvaltı);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1174, 407);
            this.panel5.TabIndex = 7;
            // 
            // dgv_AraOgun
            // 
            this.dgv_AraOgun.AllowUserToAddRows = false;
            this.dgv_AraOgun.AllowUserToDeleteRows = false;
            this.dgv_AraOgun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AraOgun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AraOgun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AraOgun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AraOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(202)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AraOgun.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_AraOgun.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_AraOgun.Location = new System.Drawing.Point(881, 44);
            this.dgv_AraOgun.MultiSelect = false;
            this.dgv_AraOgun.Name = "dgv_AraOgun";
            this.dgv_AraOgun.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AraOgun.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_AraOgun.RowHeadersVisible = false;
            this.dgv_AraOgun.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.dgv_AraOgun.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_AraOgun.RowTemplate.Height = 29;
            this.dgv_AraOgun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AraOgun.Size = new System.Drawing.Size(293, 363);
            this.dgv_AraOgun.TabIndex = 6;
            this.dgv_AraOgun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kahvaltı_CellClick);
            this.dgv_AraOgun.DoubleClick += new System.EventHandler(this.dgv_AraOgun_DoubleClick);
            // 
            // dgv_AksamYemegi
            // 
            this.dgv_AksamYemegi.AllowUserToAddRows = false;
            this.dgv_AksamYemegi.AllowUserToDeleteRows = false;
            this.dgv_AksamYemegi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AksamYemegi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AksamYemegi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_AksamYemegi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AksamYemegi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_AksamYemegi.Location = new System.Drawing.Point(588, 44);
            this.dgv_AksamYemegi.MultiSelect = false;
            this.dgv_AksamYemegi.Name = "dgv_AksamYemegi";
            this.dgv_AksamYemegi.ReadOnly = true;
            this.dgv_AksamYemegi.RowHeadersVisible = false;
            this.dgv_AksamYemegi.RowHeadersWidth = 51;
            this.dgv_AksamYemegi.RowTemplate.Height = 29;
            this.dgv_AksamYemegi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AksamYemegi.Size = new System.Drawing.Size(293, 363);
            this.dgv_AksamYemegi.TabIndex = 5;
            this.dgv_AksamYemegi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kahvaltı_CellClick);
            this.dgv_AksamYemegi.DoubleClick += new System.EventHandler(this.dgv_AksamYemegi_DoubleClick);
            // 
            // dgv_OgleYemegi
            // 
            this.dgv_OgleYemegi.AllowUserToAddRows = false;
            this.dgv_OgleYemegi.AllowUserToDeleteRows = false;
            this.dgv_OgleYemegi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OgleYemegi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_OgleYemegi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_OgleYemegi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OgleYemegi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_OgleYemegi.Location = new System.Drawing.Point(294, 44);
            this.dgv_OgleYemegi.MultiSelect = false;
            this.dgv_OgleYemegi.Name = "dgv_OgleYemegi";
            this.dgv_OgleYemegi.ReadOnly = true;
            this.dgv_OgleYemegi.RowHeadersVisible = false;
            this.dgv_OgleYemegi.RowHeadersWidth = 51;
            this.dgv_OgleYemegi.RowTemplate.Height = 29;
            this.dgv_OgleYemegi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OgleYemegi.Size = new System.Drawing.Size(294, 363);
            this.dgv_OgleYemegi.TabIndex = 4;
            this.dgv_OgleYemegi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kahvaltı_CellClick);
            this.dgv_OgleYemegi.DoubleClick += new System.EventHandler(this.dgv_OgleYemegi_DoubleClick);
            // 
            // dgv_Kahvaltı
            // 
            this.dgv_Kahvaltı.AllowUserToAddRows = false;
            this.dgv_Kahvaltı.AllowUserToDeleteRows = false;
            this.dgv_Kahvaltı.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kahvaltı.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Kahvaltı.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Kahvaltı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kahvaltı.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_Kahvaltı.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.dgv_Kahvaltı.Location = new System.Drawing.Point(0, 44);
            this.dgv_Kahvaltı.MultiSelect = false;
            this.dgv_Kahvaltı.Name = "dgv_Kahvaltı";
            this.dgv_Kahvaltı.ReadOnly = true;
            this.dgv_Kahvaltı.RowHeadersVisible = false;
            this.dgv_Kahvaltı.RowHeadersWidth = 51;
            this.dgv_Kahvaltı.RowTemplate.Height = 29;
            this.dgv_Kahvaltı.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kahvaltı.Size = new System.Drawing.Size(294, 363);
            this.dgv_Kahvaltı.TabIndex = 3;
            this.dgv_Kahvaltı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kahvaltı_CellClick);
            this.dgv_Kahvaltı.DoubleClick += new System.EventHandler(this.dgv_Kahvaltı_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnl_Ogunler);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pnl_BesinEkle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 607);
            this.panel4.TabIndex = 8;
            // 
            // frmOgunOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOgunOlustur";
            this.Size = new System.Drawing.Size(1174, 607);
            this.pnl_Ogunler.ResumeLayout(false);
            this.pnl_Ogunler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_BesinEkle.ResumeLayout(false);
            this.pnl_BesinEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BesinResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Miktar)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AraOgun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AksamYemegi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OgleYemegi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kahvaltı)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Ogunler;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_BesinEkle;
        private ComboBox cmb_Besinler;
        private ComboBox cmb_Kategoriler;
        private RadioButton rb_AraOgun;
        private RadioButton rb_AksamYemegi;
        private RadioButton rb_OgleYemegi;
        private RadioButton rb_Kahvalti;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnl_BesinEkle;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private NumericUpDown nud_Miktar;
        private Label label7;
        private Panel panel4;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_BesinSİl;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_BesinGuncelle;
        private Label lbl_MiktarBirim;
        private DataGridView dgv_AraOgun;
        private DataGridView dgv_AksamYemegi;
        private DataGridView dgv_OgleYemegi;
        private DataGridView dgv_Kahvaltı;
        private Label lbl_AlinanKalori;
        private Label label8;
        private PictureBox pb_BesinResmi;
    }
}
