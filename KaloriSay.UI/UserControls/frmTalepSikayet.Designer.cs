namespace KaloriSay.UI.UserControls
{
    partial class frmTalepSikayet
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
            this.dgv_TalepSikayet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_OkunduBilgisiGuncelle = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Listele = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TumunuGetir = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.lbl_Acıklama = new System.Windows.Forms.Label();
            this.rb_Okunmadı = new System.Windows.Forms.RadioButton();
            this.rb_Okundu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TalepSikayet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TalepSikayet
            // 
            this.dgv_TalepSikayet.AllowUserToAddRows = false;
            this.dgv_TalepSikayet.AllowUserToDeleteRows = false;
            this.dgv_TalepSikayet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TalepSikayet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TalepSikayet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TalepSikayet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TalepSikayet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TalepSikayet.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_TalepSikayet.Location = new System.Drawing.Point(0, 0);
            this.dgv_TalepSikayet.MultiSelect = false;
            this.dgv_TalepSikayet.Name = "dgv_TalepSikayet";
            this.dgv_TalepSikayet.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TalepSikayet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TalepSikayet.RowHeadersVisible = false;
            this.dgv_TalepSikayet.RowHeadersWidth = 51;
            this.dgv_TalepSikayet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TalepSikayet.Size = new System.Drawing.Size(842, 735);
            this.dgv_TalepSikayet.TabIndex = 0;
            this.dgv_TalepSikayet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TalepSikayet_CellClick);
            this.dgv_TalepSikayet.DoubleClick += new System.EventHandler(this.dgv_TalepSikayet_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_Acıklama);
            this.panel1.Controls.Add(this.rb_Okunmadı);
            this.panel1.Controls.Add(this.rb_Okundu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(840, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 735);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_OkunduBilgisiGuncelle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 78);
            this.panel4.TabIndex = 7;
            // 
            // btn_OkunduBilgisiGuncelle
            // 
            this.btn_OkunduBilgisiGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_OkunduBilgisiGuncelle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_OkunduBilgisiGuncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_OkunduBilgisiGuncelle.BorderRadius = 0;
            this.btn_OkunduBilgisiGuncelle.BorderSize = 0;
            this.btn_OkunduBilgisiGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OkunduBilgisiGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_OkunduBilgisiGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_OkunduBilgisiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OkunduBilgisiGuncelle.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OkunduBilgisiGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_OkunduBilgisiGuncelle.Location = new System.Drawing.Point(0, 0);
            this.btn_OkunduBilgisiGuncelle.Name = "btn_OkunduBilgisiGuncelle";
            this.btn_OkunduBilgisiGuncelle.Size = new System.Drawing.Size(334, 78);
            this.btn_OkunduBilgisiGuncelle.TabIndex = 3;
            this.btn_OkunduBilgisiGuncelle.Text = "Okundu Bilgisi Güncelle";
            this.btn_OkunduBilgisiGuncelle.TextColor = System.Drawing.Color.White;
            this.btn_OkunduBilgisiGuncelle.UseVisualStyleBackColor = false;
            this.btn_OkunduBilgisiGuncelle.Click += new System.EventHandler(this.btn_OkunduBilgisiGuncelle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Listele);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 579);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 78);
            this.panel3.TabIndex = 6;
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Transparent;
            this.btn_Listele.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Listele.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Listele.BorderRadius = 0;
            this.btn_Listele.BorderSize = 0;
            this.btn_Listele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Listele.FlatAppearance.BorderSize = 0;
            this.btn_Listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listele.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Listele.ForeColor = System.Drawing.Color.White;
            this.btn_Listele.Location = new System.Drawing.Point(0, 0);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(334, 78);
            this.btn_Listele.TabIndex = 4;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.TextColor = System.Drawing.Color.White;
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_TumunuGetir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 78);
            this.panel2.TabIndex = 5;
            // 
            // btn_TumunuGetir
            // 
            this.btn_TumunuGetir.BackColor = System.Drawing.Color.Transparent;
            this.btn_TumunuGetir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_TumunuGetir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TumunuGetir.BorderRadius = 0;
            this.btn_TumunuGetir.BorderSize = 0;
            this.btn_TumunuGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TumunuGetir.FlatAppearance.BorderSize = 0;
            this.btn_TumunuGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_TumunuGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TumunuGetir.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TumunuGetir.ForeColor = System.Drawing.Color.White;
            this.btn_TumunuGetir.Location = new System.Drawing.Point(0, 0);
            this.btn_TumunuGetir.Name = "btn_TumunuGetir";
            this.btn_TumunuGetir.Size = new System.Drawing.Size(334, 78);
            this.btn_TumunuGetir.TabIndex = 5;
            this.btn_TumunuGetir.Text = "Tümünü Getir";
            this.btn_TumunuGetir.TextColor = System.Drawing.Color.White;
            this.btn_TumunuGetir.UseVisualStyleBackColor = false;
            this.btn_TumunuGetir.Click += new System.EventHandler(this.btn_TumunuGetir_Click);
            // 
            // lbl_Acıklama
            // 
            this.lbl_Acıklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Acıklama.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Acıklama.Location = new System.Drawing.Point(0, 0);
            this.lbl_Acıklama.Name = "lbl_Acıklama";
            this.lbl_Acıklama.Size = new System.Drawing.Size(334, 343);
            this.lbl_Acıklama.TabIndex = 2;
            this.lbl_Acıklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Okunmadı
            // 
            this.rb_Okunmadı.AutoSize = true;
            this.rb_Okunmadı.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Okunmadı.Location = new System.Drawing.Point(191, 439);
            this.rb_Okunmadı.Name = "rb_Okunmadı";
            this.rb_Okunmadı.Size = new System.Drawing.Size(112, 20);
            this.rb_Okunmadı.TabIndex = 2;
            this.rb_Okunmadı.TabStop = true;
            this.rb_Okunmadı.Text = "Okunmadı";
            this.rb_Okunmadı.UseVisualStyleBackColor = true;
            // 
            // rb_Okundu
            // 
            this.rb_Okundu.AutoSize = true;
            this.rb_Okundu.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Okundu.Location = new System.Drawing.Point(42, 439);
            this.rb_Okundu.Name = "rb_Okundu";
            this.rb_Okundu.Size = new System.Drawing.Size(92, 20);
            this.rb_Okundu.TabIndex = 1;
            this.rb_Okundu.TabStop = true;
            this.rb_Okundu.Text = "Okundu";
            this.rb_Okundu.UseVisualStyleBackColor = true;
            // 
            // frmTalepSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_TalepSikayet);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTalepSikayet";
            this.Size = new System.Drawing.Size(1174, 735);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TalepSikayet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_TalepSikayet;
        private Panel panel1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_OkunduBilgisiGuncelle;
        private RadioButton rb_Okunmadı;
        private RadioButton rb_Okundu;
        private Label lbl_Acıklama;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Listele;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_TumunuGetir;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
    }
}
