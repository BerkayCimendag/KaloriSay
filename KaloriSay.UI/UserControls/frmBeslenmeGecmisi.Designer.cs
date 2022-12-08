namespace KaloriSay.UI.UserControls
{
    partial class frmBeslenmeGecmisi
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
            this.dgv_BeslenmeGecmisi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_Bitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_Baslangic = new System.Windows.Forms.DateTimePicker();
            this.btn_TumunuGöster = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.btn_RaporAl = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BeslenmeGecmisi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BeslenmeGecmisi
            // 
            this.dgv_BeslenmeGecmisi.AllowUserToAddRows = false;
            this.dgv_BeslenmeGecmisi.AllowUserToDeleteRows = false;
            this.dgv_BeslenmeGecmisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BeslenmeGecmisi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BeslenmeGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BeslenmeGecmisi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BeslenmeGecmisi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_BeslenmeGecmisi.Location = new System.Drawing.Point(0, 60);
            this.dgv_BeslenmeGecmisi.MultiSelect = false;
            this.dgv_BeslenmeGecmisi.Name = "dgv_BeslenmeGecmisi";
            this.dgv_BeslenmeGecmisi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BeslenmeGecmisi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BeslenmeGecmisi.RowHeadersVisible = false;
            this.dgv_BeslenmeGecmisi.RowHeadersWidth = 51;
            this.dgv_BeslenmeGecmisi.RowTemplate.Height = 29;
            this.dgv_BeslenmeGecmisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BeslenmeGecmisi.Size = new System.Drawing.Size(1174, 547);
            this.dgv_BeslenmeGecmisi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtp_Bitis);
            this.panel1.Controls.Add(this.dtp_Baslangic);
            this.panel1.Controls.Add(this.btn_TumunuGöster);
            this.panel1.Controls.Add(this.btn_RaporAl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 54);
            this.panel1.TabIndex = 1;
            // 
            // dtp_Bitis
            // 
            this.dtp_Bitis.Location = new System.Drawing.Point(554, 12);
            this.dtp_Bitis.Name = "dtp_Bitis";
            this.dtp_Bitis.Size = new System.Drawing.Size(220, 28);
            this.dtp_Bitis.TabIndex = 3;
            // 
            // dtp_Baslangic
            // 
            this.dtp_Baslangic.Location = new System.Drawing.Point(173, 12);
            this.dtp_Baslangic.Name = "dtp_Baslangic";
            this.dtp_Baslangic.Size = new System.Drawing.Size(220, 28);
            this.dtp_Baslangic.TabIndex = 3;
            this.dtp_Baslangic.Value = new System.DateTime(2022, 11, 30, 0, 0, 0, 0);
            // 
            // btn_TumunuGöster
            // 
            this.btn_TumunuGöster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_TumunuGöster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_TumunuGöster.BorderColor = System.Drawing.Color.Black;
            this.btn_TumunuGöster.BorderRadius = 29;
            this.btn_TumunuGöster.BorderSize = 0;
            this.btn_TumunuGöster.FlatAppearance.BorderSize = 0;
            this.btn_TumunuGöster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TumunuGöster.ForeColor = System.Drawing.Color.White;
            this.btn_TumunuGöster.Location = new System.Drawing.Point(968, 8);
            this.btn_TumunuGöster.Name = "btn_TumunuGöster";
            this.btn_TumunuGöster.Size = new System.Drawing.Size(199, 40);
            this.btn_TumunuGöster.TabIndex = 2;
            this.btn_TumunuGöster.Text = "Tümünü Göster";
            this.btn_TumunuGöster.TextColor = System.Drawing.Color.White;
            this.btn_TumunuGöster.UseVisualStyleBackColor = false;
            this.btn_TumunuGöster.Click += new System.EventHandler(this.btn_TumunuGöster_Click);
            // 
            // btn_RaporAl
            // 
            this.btn_RaporAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_RaporAl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_RaporAl.BorderColor = System.Drawing.Color.Black;
            this.btn_RaporAl.BorderRadius = 29;
            this.btn_RaporAl.BorderSize = 0;
            this.btn_RaporAl.FlatAppearance.BorderSize = 0;
            this.btn_RaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RaporAl.ForeColor = System.Drawing.Color.White;
            this.btn_RaporAl.Location = new System.Drawing.Point(780, 7);
            this.btn_RaporAl.Name = "btn_RaporAl";
            this.btn_RaporAl.Size = new System.Drawing.Size(182, 40);
            this.btn_RaporAl.TabIndex = 2;
            this.btn_RaporAl.Text = "Beslenme Geçmişini Görüntüle";
            this.btn_RaporAl.TextColor = System.Drawing.Color.White;
            this.btn_RaporAl.UseVisualStyleBackColor = false;
            this.btn_RaporAl.Click += new System.EventHandler(this.btn_RaporAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(438, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi : ";
            // 
            // frmBeslenmeGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_BeslenmeGecmisi);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBeslenmeGecmisi";
            this.Size = new System.Drawing.Size(1174, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BeslenmeGecmisi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_BeslenmeGecmisi;
        private Panel panel1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_RaporAl;
        private Label label1;
        private DateTimePicker dtp_Bitis;
        private DateTimePicker dtp_Baslangic;
        private Label label2;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_TumunuGöster;
    }
}
