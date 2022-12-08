namespace KaloriSay.UI.UserControls
{
    partial class frmKategoriIslemleri
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
            this.pnl_KategoriIslemleri = new System.Windows.Forms.Panel();
            this.btn_Listele = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KategoriEkle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_KategoriGuncelle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_KategoriSil = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.txt_KategoriAdi = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.dgv_Kategoriler = new System.Windows.Forms.DataGridView();
            this.pnl_KategoriIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_KategoriIslemleri
            // 
            this.pnl_KategoriIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.pnl_KategoriIslemleri.Controls.Add(this.btn_Listele);
            this.pnl_KategoriIslemleri.Controls.Add(this.label1);
            this.pnl_KategoriIslemleri.Controls.Add(this.btn_KategoriEkle);
            this.pnl_KategoriIslemleri.Controls.Add(this.btn_KategoriGuncelle);
            this.pnl_KategoriIslemleri.Controls.Add(this.btn_KategoriSil);
            this.pnl_KategoriIslemleri.Controls.Add(this.txt_KategoriAdi);
            this.pnl_KategoriIslemleri.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_KategoriIslemleri.Location = new System.Drawing.Point(840, 0);
            this.pnl_KategoriIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_KategoriIslemleri.Name = "pnl_KategoriIslemleri";
            this.pnl_KategoriIslemleri.Size = new System.Drawing.Size(334, 735);
            this.pnl_KategoriIslemleri.TabIndex = 1;
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
            this.btn_Listele.Location = new System.Drawing.Point(0, 575);
            this.btn_Listele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(334, 40);
            this.btn_Listele.TabIndex = 2;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.TextColor = System.Drawing.Color.White;
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Adı : ";
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_KategoriEkle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_KategoriEkle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_KategoriEkle.BorderRadius = 0;
            this.btn_KategoriEkle.BorderSize = 0;
            this.btn_KategoriEkle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_KategoriEkle.FlatAppearance.BorderSize = 0;
            this.btn_KategoriEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_KategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KategoriEkle.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KategoriEkle.ForeColor = System.Drawing.Color.White;
            this.btn_KategoriEkle.Location = new System.Drawing.Point(0, 615);
            this.btn_KategoriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(334, 40);
            this.btn_KategoriEkle.TabIndex = 3;
            this.btn_KategoriEkle.Text = "Kategori Ekle";
            this.btn_KategoriEkle.TextColor = System.Drawing.Color.White;
            this.btn_KategoriEkle.UseVisualStyleBackColor = false;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // btn_KategoriGuncelle
            // 
            this.btn_KategoriGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_KategoriGuncelle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_KategoriGuncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_KategoriGuncelle.BorderRadius = 0;
            this.btn_KategoriGuncelle.BorderSize = 0;
            this.btn_KategoriGuncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_KategoriGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_KategoriGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_KategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KategoriGuncelle.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KategoriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_KategoriGuncelle.Location = new System.Drawing.Point(0, 655);
            this.btn_KategoriGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KategoriGuncelle.Name = "btn_KategoriGuncelle";
            this.btn_KategoriGuncelle.Size = new System.Drawing.Size(334, 40);
            this.btn_KategoriGuncelle.TabIndex = 4;
            this.btn_KategoriGuncelle.Text = "Kategori Güncelle";
            this.btn_KategoriGuncelle.TextColor = System.Drawing.Color.White;
            this.btn_KategoriGuncelle.UseVisualStyleBackColor = false;
            this.btn_KategoriGuncelle.Click += new System.EventHandler(this.btn_KategoriGuncelle_Click);
            // 
            // btn_KategoriSil
            // 
            this.btn_KategoriSil.BackColor = System.Drawing.Color.Transparent;
            this.btn_KategoriSil.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_KategoriSil.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_KategoriSil.BorderRadius = 0;
            this.btn_KategoriSil.BorderSize = 0;
            this.btn_KategoriSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_KategoriSil.FlatAppearance.BorderSize = 0;
            this.btn_KategoriSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_KategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KategoriSil.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KategoriSil.ForeColor = System.Drawing.Color.White;
            this.btn_KategoriSil.Location = new System.Drawing.Point(0, 695);
            this.btn_KategoriSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KategoriSil.Name = "btn_KategoriSil";
            this.btn_KategoriSil.Size = new System.Drawing.Size(334, 40);
            this.btn_KategoriSil.TabIndex = 5;
            this.btn_KategoriSil.Text = "Kategori Sil";
            this.btn_KategoriSil.TextColor = System.Drawing.Color.White;
            this.btn_KategoriSil.UseVisualStyleBackColor = false;
            this.btn_KategoriSil.Click += new System.EventHandler(this.btn_KategoriSil_Click);
            // 
            // txt_KategoriAdi
            // 
            this.txt_KategoriAdi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_KategoriAdi.BorderColor = System.Drawing.Color.Black;
            this.txt_KategoriAdi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.txt_KategoriAdi.BorderRadius = 0;
            this.txt_KategoriAdi.BorderSize = 2;
            this.txt_KategoriAdi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KategoriAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_KategoriAdi.Location = new System.Drawing.Point(6, 254);
            this.txt_KategoriAdi.Multiline = false;
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_KategoriAdi.PasswordChar = false;
            this.txt_KategoriAdi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_KategoriAdi.PlaceholderText = "";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(324, 38);
            this.txt_KategoriAdi.TabIndex = 1;
            this.txt_KategoriAdi.UnderlinedStyle = false;
            // 
            // dgv_Kategoriler
            // 
            this.dgv_Kategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kategoriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Kategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Kategoriler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Kategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Kategoriler.Location = new System.Drawing.Point(0, 0);
            this.dgv_Kategoriler.MultiSelect = false;
            this.dgv_Kategoriler.Name = "dgv_Kategoriler";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Kategoriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Kategoriler.RowHeadersVisible = false;
            this.dgv_Kategoriler.RowHeadersWidth = 51;
            this.dgv_Kategoriler.RowTemplate.Height = 29;
            this.dgv_Kategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kategoriler.Size = new System.Drawing.Size(840, 735);
            this.dgv_Kategoriler.TabIndex = 2;
            this.dgv_Kategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kategoriler_CellClick);
            this.dgv_Kategoriler.DoubleClick += new System.EventHandler(this.dgv_Kategoriler_DoubleClick);
            // 
            // frmKategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Kategoriler);
            this.Controls.Add(this.pnl_KategoriIslemleri);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKategoriIslemleri";
            this.Size = new System.Drawing.Size(1174, 735);
            this.pnl_KategoriIslemleri.ResumeLayout(false);
            this.pnl_KategoriIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_KategoriIslemleri;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_KategoriEkle;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_KategoriGuncelle;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_KategoriSil;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_KategoriAdi;
        private DataGridView dgv_Kategoriler;
        private Label label1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Listele;
    }
}
