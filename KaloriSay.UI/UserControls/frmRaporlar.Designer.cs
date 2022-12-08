namespace KaloriSay.UI.UserControls
{
    partial class frmRaporlar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Yenile = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_PasifUye = new System.Windows.Forms.Label();
            this.lbl_AktifUye = new System.Windows.Forms.Label();
            this.lbl_KayitliUye = new System.Windows.Forms.Label();
            this.lbl_TalepSikayetSayisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Raporlar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Raporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.btn_Yenile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(842, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 735);
            this.panel1.TabIndex = 0;
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.BackColor = System.Drawing.Color.Transparent;
            this.btn_Yenile.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Yenile.BorderColor = System.Drawing.Color.Empty;
            this.btn_Yenile.BorderRadius = 0;
            this.btn_Yenile.BorderSize = 0;
            this.btn_Yenile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Yenile.FlatAppearance.BorderSize = 0;
            this.btn_Yenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_Yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yenile.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Yenile.ForeColor = System.Drawing.Color.White;
            this.btn_Yenile.Location = new System.Drawing.Point(0, 676);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(332, 59);
            this.btn_Yenile.TabIndex = 1;
            this.btn_Yenile.Text = "Yenile";
            this.btn_Yenile.TextColor = System.Drawing.Color.White;
            this.btn_Yenile.UseVisualStyleBackColor = false;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_PasifUye);
            this.panel2.Controls.Add(this.lbl_AktifUye);
            this.panel2.Controls.Add(this.lbl_KayitliUye);
            this.panel2.Controls.Add(this.lbl_TalepSikayetSayisi);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 228);
            this.panel2.TabIndex = 0;
            // 
            // lbl_PasifUye
            // 
            this.lbl_PasifUye.AutoSize = true;
            this.lbl_PasifUye.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PasifUye.Location = new System.Drawing.Point(242, 193);
            this.lbl_PasifUye.Name = "lbl_PasifUye";
            this.lbl_PasifUye.Size = new System.Drawing.Size(57, 16);
            this.lbl_PasifUye.TabIndex = 1;
            this.lbl_PasifUye.Text = "label2";
            // 
            // lbl_AktifUye
            // 
            this.lbl_AktifUye.AutoSize = true;
            this.lbl_AktifUye.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AktifUye.Location = new System.Drawing.Point(242, 154);
            this.lbl_AktifUye.Name = "lbl_AktifUye";
            this.lbl_AktifUye.Size = new System.Drawing.Size(57, 16);
            this.lbl_AktifUye.TabIndex = 1;
            this.lbl_AktifUye.Text = "label2";
            // 
            // lbl_KayitliUye
            // 
            this.lbl_KayitliUye.AutoSize = true;
            this.lbl_KayitliUye.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KayitliUye.Location = new System.Drawing.Point(242, 115);
            this.lbl_KayitliUye.Name = "lbl_KayitliUye";
            this.lbl_KayitliUye.Size = new System.Drawing.Size(57, 16);
            this.lbl_KayitliUye.TabIndex = 1;
            this.lbl_KayitliUye.Text = "label2";
            // 
            // lbl_TalepSikayetSayisi
            // 
            this.lbl_TalepSikayetSayisi.AutoSize = true;
            this.lbl_TalepSikayetSayisi.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TalepSikayetSayisi.Location = new System.Drawing.Point(242, 78);
            this.lbl_TalepSikayetSayisi.Name = "lbl_TalepSikayetSayisi";
            this.lbl_TalepSikayetSayisi.Size = new System.Drawing.Size(57, 16);
            this.lbl_TalepSikayetSayisi.TabIndex = 1;
            this.lbl_TalepSikayetSayisi.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(91, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pasif Üye Sayısı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(93, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aktif Üye Sayısı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kayıtlı Üye Sayısı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okunmamış Talep/Şikayet : ";
            // 
            // dgv_Raporlar
            // 
            this.dgv_Raporlar.AllowUserToAddRows = false;
            this.dgv_Raporlar.AllowUserToDeleteRows = false;
            this.dgv_Raporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Raporlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Raporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Raporlar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Raporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Raporlar.Location = new System.Drawing.Point(0, 0);
            this.dgv_Raporlar.MultiSelect = false;
            this.dgv_Raporlar.Name = "dgv_Raporlar";
            this.dgv_Raporlar.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Raporlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Raporlar.RowHeadersVisible = false;
            this.dgv_Raporlar.RowHeadersWidth = 51;
            this.dgv_Raporlar.RowTemplate.Height = 29;
            this.dgv_Raporlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Raporlar.Size = new System.Drawing.Size(842, 735);
            this.dgv_Raporlar.TabIndex = 1;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Raporlar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRaporlar";
            this.Size = new System.Drawing.Size(1174, 735);
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Raporlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Yenile;
        private Panel panel2;
        private Label lbl_KayitliUye;
        private Label lbl_TalepSikayetSayisi;
        private Label label3;
        private Label label1;
        private Label lbl_PasifUye;
        private Label lbl_AktifUye;
        private Label label7;
        private Label label5;
        private DataGridView dgv_Raporlar;
    }
}
