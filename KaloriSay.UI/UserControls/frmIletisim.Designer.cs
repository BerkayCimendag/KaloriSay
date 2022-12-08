namespace KaloriSay.UI.UserControls
{
    partial class frmIletisim
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
            this.pnl_Iletisim = new System.Windows.Forms.Panel();
            this.cmb_TalepSikayet = new System.Windows.Forms.ComboBox();
            this.btn_Gonder = new KullaniciPanel.EjderhaControls.EjderhaButton();
            this.txt_Talep_Sikayet = new KullaniciPanel.EjderhaControls.EjderhaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Iletisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Iletisim
            // 
            this.pnl_Iletisim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Iletisim.Controls.Add(this.cmb_TalepSikayet);
            this.pnl_Iletisim.Controls.Add(this.btn_Gonder);
            this.pnl_Iletisim.Controls.Add(this.txt_Talep_Sikayet);
            this.pnl_Iletisim.Controls.Add(this.label3);
            this.pnl_Iletisim.Controls.Add(this.label2);
            this.pnl_Iletisim.Controls.Add(this.label1);
            this.pnl_Iletisim.Location = new System.Drawing.Point(214, 44);
            this.pnl_Iletisim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Iletisim.Name = "pnl_Iletisim";
            this.pnl_Iletisim.Size = new System.Drawing.Size(732, 518);
            this.pnl_Iletisim.TabIndex = 2;
            // 
            // cmb_TalepSikayet
            // 
            this.cmb_TalepSikayet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TalepSikayet.FormattingEnabled = true;
            this.cmb_TalepSikayet.Items.AddRange(new object[] {
            "Talep",
            "Şikayet"});
            this.cmb_TalepSikayet.Location = new System.Drawing.Point(153, 115);
            this.cmb_TalepSikayet.Name = "cmb_TalepSikayet";
            this.cmb_TalepSikayet.Size = new System.Drawing.Size(422, 24);
            this.cmb_TalepSikayet.TabIndex = 1;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_Gonder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.btn_Gonder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Gonder.BorderRadius = 30;
            this.btn_Gonder.BorderSize = 0;
            this.btn_Gonder.FlatAppearance.BorderSize = 0;
            this.btn_Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gonder.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gonder.ForeColor = System.Drawing.Color.White;
            this.btn_Gonder.Location = new System.Drawing.Point(217, 445);
            this.btn_Gonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(295, 40);
            this.btn_Gonder.TabIndex = 3;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.TextColor = System.Drawing.Color.White;
            this.btn_Gonder.UseVisualStyleBackColor = false;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // txt_Talep_Sikayet
            // 
            this.txt_Talep_Sikayet.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Talep_Sikayet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Talep_Sikayet.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(132)))), ((int)(((byte)(108)))));
            this.txt_Talep_Sikayet.BorderRadius = 15;
            this.txt_Talep_Sikayet.BorderSize = 3;
            this.txt_Talep_Sikayet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Talep_Sikayet.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Talep_Sikayet.Location = new System.Drawing.Point(53, 186);
            this.txt_Talep_Sikayet.Multiline = true;
            this.txt_Talep_Sikayet.Name = "txt_Talep_Sikayet";
            this.txt_Talep_Sikayet.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txt_Talep_Sikayet.PasswordChar = false;
            this.txt_Talep_Sikayet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Talep_Sikayet.PlaceholderText = "";
            this.txt_Talep_Sikayet.Size = new System.Drawing.Size(622, 238);
            this.txt_Talep_Sikayet.TabIndex = 2;
            this.txt_Talep_Sikayet.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(121, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bizimle Hangi Konuda İletişime Geçmek İstiyorsunuz ? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(290, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Talep/Şikayet : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BİZİMLE İLETİŞİME GEÇİNİZ";
            // 
            // frmIletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Iletisim);
            this.Font = new System.Drawing.Font("STXihei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIletisim";
            this.Size = new System.Drawing.Size(1174, 607);
            this.pnl_Iletisim.ResumeLayout(false);
            this.pnl_Iletisim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cmb_TalepSikayet;
        private KullaniciPanel.EjderhaControls.EjderhaButton btn_Gonder;
        private KullaniciPanel.EjderhaControls.EjderhaTextBox txt_Talep_Sikayet;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnl_Iletisim;
    }
}
