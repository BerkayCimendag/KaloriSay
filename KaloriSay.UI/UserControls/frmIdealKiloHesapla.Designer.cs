namespace KaloriSay.UI.UserControls
{
    partial class frmIdealKiloHesapla
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_IdealHesapla = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.lbl_IdealKilo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BoyIdeal = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_IdealHesapla);
            this.panel1.Controls.Add(this.lbl_IdealKilo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_BoyIdeal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(328, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 518);
            this.panel1.TabIndex = 1;
            // 
            // btn_IdealHesapla
            // 
            this.btn_IdealHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_IdealHesapla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_IdealHesapla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_IdealHesapla.BorderRadius = 30;
            this.btn_IdealHesapla.BorderSize = 0;
            this.btn_IdealHesapla.FlatAppearance.BorderSize = 0;
            this.btn_IdealHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IdealHesapla.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IdealHesapla.ForeColor = System.Drawing.Color.White;
            this.btn_IdealHesapla.Location = new System.Drawing.Point(114, 311);
            this.btn_IdealHesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IdealHesapla.Name = "btn_IdealHesapla";
            this.btn_IdealHesapla.Size = new System.Drawing.Size(312, 40);
            this.btn_IdealHesapla.TabIndex = 2;
            this.btn_IdealHesapla.Text = "Hesapla";
            this.btn_IdealHesapla.TextColor = System.Drawing.Color.White;
            this.btn_IdealHesapla.UseVisualStyleBackColor = false;
            this.btn_IdealHesapla.Click += new System.EventHandler(this.btn_IdealHesapla_Click);
            // 
            // lbl_IdealKilo
            // 
            this.lbl_IdealKilo.AutoSize = true;
            this.lbl_IdealKilo.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IdealKilo.Location = new System.Drawing.Point(292, 431);
            this.lbl_IdealKilo.Name = "lbl_IdealKilo";
            this.lbl_IdealKilo.Size = new System.Drawing.Size(84, 19);
            this.lbl_IdealKilo.TabIndex = 3;
            this.lbl_IdealKilo.Text = "Test Test";
            this.lbl_IdealKilo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "İdeal Kilonuz : ";
            // 
            // txt_BoyIdeal
            // 
            this.txt_BoyIdeal.BackColor = System.Drawing.SystemColors.Control;
            this.txt_BoyIdeal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_BoyIdeal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_BoyIdeal.BorderRadius = 0;
            this.txt_BoyIdeal.BorderSize = 2;
            this.txt_BoyIdeal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_BoyIdeal.ForeColor = System.Drawing.Color.DimGray;
            this.txt_BoyIdeal.Location = new System.Drawing.Point(114, 203);
            this.txt_BoyIdeal.Multiline = false;
            this.txt_BoyIdeal.Name = "txt_BoyIdeal";
            this.txt_BoyIdeal.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_BoyIdeal.PasswordChar = false;
            this.txt_BoyIdeal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_BoyIdeal.PlaceholderText = "";
            this.txt_BoyIdeal.Size = new System.Drawing.Size(312, 38);
            this.txt_BoyIdeal.TabIndex = 1;
            this.txt_BoyIdeal.UnderlinedStyle = true;
            this.txt_BoyIdeal._TextChanged += new System.EventHandler(this.txt_BoyIdeal__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Boyunuzu Santimetre Cinsinden Giriniz  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İDEAL KİLO HESAPLAMA";
            // 
            // frmIdealKiloHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIdealKiloHesapla";
            this.Size = new System.Drawing.Size(1174, 607);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_IdealHesapla;
        private Label lbl_IdealKilo;
        private Label label4;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_BoyIdeal;
        private Label label2;
        private Label label1;
    }
}
