namespace KaloriSay.UI
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SimgeDurumu = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.tgb_Secim = new KullaniciPanel.EjderhaControls.EjderhaToggleButton();
            this.lbl_GirisYap = new System.Windows.Forms.Label();
            this.lbl_UyeOl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.frmKayitDevamForm1 = new KaloriSay.UI.FrmKayitDevamForm();
            this.frmGiris1 = new KaloriSay.UI.FrmGiris();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SimgeDurumu
            // 
            this.btn_SimgeDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SimgeDurumu.FlatAppearance.BorderSize = 0;
            this.btn_SimgeDurumu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_SimgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SimgeDurumu.Image = global::KaloriSay.UI.Properties.Resources.minimizeIcon;
            this.btn_SimgeDurumu.Location = new System.Drawing.Point(1317, 0);
            this.btn_SimgeDurumu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_SimgeDurumu.Name = "btn_SimgeDurumu";
            this.btn_SimgeDurumu.Size = new System.Drawing.Size(40, 46);
            this.btn_SimgeDurumu.TabIndex = 2;
            this.btn_SimgeDurumu.UseVisualStyleBackColor = true;
            this.btn_SimgeDurumu.Click += new System.EventHandler(this.btn_SimgeDurumu_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Image = global::KaloriSay.UI.Properties.Resources.exitIcon;
            this.btn_Cikis.Location = new System.Drawing.Point(1355, 0);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(40, 46);
            this.btn_Cikis.TabIndex = 0;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // tgb_Secim
            // 
            this.tgb_Secim.Location = new System.Drawing.Point(997, 100);
            this.tgb_Secim.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tgb_Secim.MinimumSize = new System.Drawing.Size(56, 18);
            this.tgb_Secim.Name = "tgb_Secim";
            this.tgb_Secim.Size = new System.Drawing.Size(56, 24);
            this.tgb_Secim.TabIndex = 3;
            this.tgb_Secim.Text = "ejderhaToggleButton1";
            this.tgb_Secim.UseVisualStyleBackColor = true;
            this.tgb_Secim.CheckedChanged += new System.EventHandler(this.tgb_Secim_CheckedChanged);
            // 
            // lbl_GirisYap
            // 
            this.lbl_GirisYap.AutoSize = true;
            this.lbl_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GirisYap.Location = new System.Drawing.Point(905, 106);
            this.lbl_GirisYap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GirisYap.Name = "lbl_GirisYap";
            this.lbl_GirisYap.Size = new System.Drawing.Size(77, 18);
            this.lbl_GirisYap.TabIndex = 4;
            this.lbl_GirisYap.Text = "Giriş Yap";
            this.lbl_GirisYap.Visible = false;
            // 
            // lbl_UyeOl
            // 
            this.lbl_UyeOl.AutoSize = true;
            this.lbl_UyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UyeOl.Location = new System.Drawing.Point(1061, 106);
            this.lbl_UyeOl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UyeOl.Name = "lbl_UyeOl";
            this.lbl_UyeOl.Size = new System.Drawing.Size(67, 18);
            this.lbl_UyeOl.TabIndex = 4;
            this.lbl_UyeOl.Text = "Kayıt Ol";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.btn_Cikis);
            this.panel1.Controls.Add(this.btn_SimgeDurumu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 46);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 806);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KaloriSay.UI.Properties.Resources.Tanitim;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 806);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.frmKayitDevamForm1);
            this.panel3.Controls.Add(this.frmGiris1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(647, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 723);
            this.panel3.TabIndex = 7;
            // 
            // frmKayitDevamForm1
            // 
            this.frmKayitDevamForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.frmKayitDevamForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmKayitDevamForm1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmKayitDevamForm1.Location = new System.Drawing.Point(0, 0);
            this.frmKayitDevamForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmKayitDevamForm1.Name = "frmKayitDevamForm1";
            this.frmKayitDevamForm1.Size = new System.Drawing.Size(748, 723);
            this.frmKayitDevamForm1.TabIndex = 1;
            this.frmKayitDevamForm1.Visible = false;
            // 
            // frmGiris1
            // 
            this.frmGiris1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.frmGiris1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmGiris1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmGiris1.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frmGiris1.Location = new System.Drawing.Point(0, 0);
            this.frmGiris1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmGiris1.Name = "frmGiris1";
            this.frmGiris1.Size = new System.Drawing.Size(748, 723);
            this.frmGiris1.TabIndex = 0;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1395, 852);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_UyeOl);
            this.Controls.Add(this.lbl_GirisYap);
            this.Controls.Add(this.tgb_Secim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(1395, 852);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Cikis;
        private Button btn_SimgeDurumu;
        private KullaniciPanel.EjderhaControls.EjderhaToggleButton tgb_Secim;
        private Label lbl_GirisYap;
        private Label lbl_UyeOl;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;        
        private Panel panel3;
        private FrmKayitDevamForm frmKayitDevamForm1;
        private FrmGiris frmGiris1;
    }
}