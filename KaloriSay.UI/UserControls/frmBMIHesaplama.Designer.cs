namespace KaloriSay.UI.UserControls
{
    partial class frmBMIHesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMIHesaplama));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_BMIHesapla = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.lbl_VucutKitleIndeksi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KiloBMI = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BoyBMI = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_BMIHesapla);
            this.panel1.Controls.Add(this.lbl_VucutKitleIndeksi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_KiloBMI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_BoyBMI);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(75, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 518);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(558, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 514);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(463, 514);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_BMIHesapla
            // 
            this.btn_BMIHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BMIHesapla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_BMIHesapla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BMIHesapla.BorderRadius = 30;
            this.btn_BMIHesapla.BorderSize = 0;
            this.btn_BMIHesapla.FlatAppearance.BorderSize = 0;
            this.btn_BMIHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMIHesapla.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BMIHesapla.ForeColor = System.Drawing.Color.White;
            this.btn_BMIHesapla.Location = new System.Drawing.Point(88, 347);
            this.btn_BMIHesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BMIHesapla.Name = "btn_BMIHesapla";
            this.btn_BMIHesapla.Size = new System.Drawing.Size(312, 40);
            this.btn_BMIHesapla.TabIndex = 3;
            this.btn_BMIHesapla.Text = "Hesapla";
            this.btn_BMIHesapla.TextColor = System.Drawing.Color.White;
            this.btn_BMIHesapla.UseVisualStyleBackColor = false;
            this.btn_BMIHesapla.Click += new System.EventHandler(this.btn_BMIHesapla_Click);
            // 
            // lbl_VucutKitleIndeksi
            // 
            this.lbl_VucutKitleIndeksi.AutoSize = true;
            this.lbl_VucutKitleIndeksi.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_VucutKitleIndeksi.Location = new System.Drawing.Point(275, 430);
            this.lbl_VucutKitleIndeksi.Name = "lbl_VucutKitleIndeksi";
            this.lbl_VucutKitleIndeksi.Size = new System.Drawing.Size(84, 19);
            this.lbl_VucutKitleIndeksi.TabIndex = 3;
            this.lbl_VucutKitleIndeksi.Text = "Test Test";
            this.lbl_VucutKitleIndeksi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vücut Kitle İndeksiniz : ";
            // 
            // txt_KiloBMI
            // 
            this.txt_KiloBMI.BackColor = System.Drawing.SystemColors.Control;
            this.txt_KiloBMI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_KiloBMI.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_KiloBMI.BorderRadius = 0;
            this.txt_KiloBMI.BorderSize = 2;
            this.txt_KiloBMI.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_KiloBMI.ForeColor = System.Drawing.Color.Black;
            this.txt_KiloBMI.Location = new System.Drawing.Point(88, 283);
            this.txt_KiloBMI.Multiline = false;
            this.txt_KiloBMI.Name = "txt_KiloBMI";
            this.txt_KiloBMI.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_KiloBMI.PasswordChar = false;
            this.txt_KiloBMI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_KiloBMI.PlaceholderText = "";
            this.txt_KiloBMI.Size = new System.Drawing.Size(312, 40);
            this.txt_KiloBMI.TabIndex = 2;
            this.txt_KiloBMI.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lütfen Kilonuzu Giriniz";
            // 
            // txt_BoyBMI
            // 
            this.txt_BoyBMI.BackColor = System.Drawing.SystemColors.Control;
            this.txt_BoyBMI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_BoyBMI.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_BoyBMI.BorderRadius = 0;
            this.txt_BoyBMI.BorderSize = 2;
            this.txt_BoyBMI.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_BoyBMI.ForeColor = System.Drawing.Color.Black;
            this.txt_BoyBMI.Location = new System.Drawing.Point(88, 189);
            this.txt_BoyBMI.Multiline = false;
            this.txt_BoyBMI.Name = "txt_BoyBMI";
            this.txt_BoyBMI.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_BoyBMI.PasswordChar = false;
            this.txt_BoyBMI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_BoyBMI.PlaceholderText = "";
            this.txt_BoyBMI.Size = new System.Drawing.Size(312, 40);
            this.txt_BoyBMI.TabIndex = 1;
            this.txt_BoyBMI.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Boyunuzu Santimetre Cinsinden Giriniz  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "VÜCUT KİTLE İNDEKSİ HESAPLAMA";
            // 
            // frmBMIHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBMIHesaplama";
            this.Size = new System.Drawing.Size(1174, 607);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_BoyBMI;
        private Label label2;
        private Label label1;
        private Label lbl_VucutKitleIndeksi;
        private Label label4;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_KiloBMI;
        private Label label3;
        private Panel panel2;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_BMIHesapla;
        private Label label5;
    }
}
