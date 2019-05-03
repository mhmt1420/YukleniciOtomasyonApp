namespace YukleniciOtomasyon.WinUI.Teklif
{
    partial class frmTeklifBirimi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSil = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblDuzenle = new System.Windows.Forms.Label();
            this.lblEkle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIhaleAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGunccelle = new System.Windows.Forms.Button();
            this.dgvTekliflerListele = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTekliflerListele)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvTekliflerListele);
            this.groupBox1.Location = new System.Drawing.Point(62, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 546);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.lblSil);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.lblDuzenle);
            this.groupBox2.Controls.Add(this.lblEkle);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtIhaleAra);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnGunccelle);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 217);
            this.groupBox2.TabIndex = 155;
            this.groupBox2.TabStop = false;
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSil.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.ForeColor = System.Drawing.Color.DimGray;
            this.lblSil.Location = new System.Drawing.Point(881, 134);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(23, 19);
            this.lblSil.TabIndex = 200;
            this.lblSil.Text = "Sil";
            this.lblSil.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.ic_delete_128_28267;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(877, 155);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 46);
            this.btnSil.TabIndex = 199;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // lblDuzenle
            // 
            this.lblDuzenle.AutoSize = true;
            this.lblDuzenle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuzenle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDuzenle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzenle.ForeColor = System.Drawing.Color.DimGray;
            this.lblDuzenle.Location = new System.Drawing.Point(921, 133);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(56, 19);
            this.lblDuzenle.TabIndex = 180;
            this.lblDuzenle.Text = "Düzenle";
            this.lblDuzenle.Visible = false;
            // 
            // lblEkle
            // 
            this.lblEkle.AutoSize = true;
            this.lblEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEkle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkle.ForeColor = System.Drawing.Color.DimGray;
            this.lblEkle.Location = new System.Drawing.Point(986, 133);
            this.lblEkle.Name = "lblEkle";
            this.lblEkle.Size = new System.Drawing.Size(33, 19);
            this.lblEkle.TabIndex = 179;
            this.lblEkle.Text = "Ekle";
            this.lblEkle.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::YukleniciOtomasyon.WinUI.Properties.Resources.architect_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // txtIhaleAra
            // 
            this.txtIhaleAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIhaleAra.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIhaleAra.ForeColor = System.Drawing.Color.Black;
            this.txtIhaleAra.Location = new System.Drawing.Point(665, 175);
            this.txtIhaleAra.Name = "txtIhaleAra";
            this.txtIhaleAra.Size = new System.Drawing.Size(206, 26);
            this.txtIhaleAra.TabIndex = 127;
            this.txtIhaleAra.TextChanged += new System.EventHandler(this.txtIhaleAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(588, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 126;
            this.label2.Text = "İhale Ara :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(983, 155);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(47, 46);
            this.btnKaydet.TabIndex = 153;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            this.btnKaydet.MouseHover += new System.EventHandler(this.btnKaydet_MouseHover);
            // 
            // btnGunccelle
            // 
            this.btnGunccelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGunccelle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnGunccelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGunccelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGunccelle.Location = new System.Drawing.Point(930, 155);
            this.btnGunccelle.Name = "btnGunccelle";
            this.btnGunccelle.Size = new System.Drawing.Size(47, 46);
            this.btnGunccelle.TabIndex = 154;
            this.btnGunccelle.UseVisualStyleBackColor = false;
            this.btnGunccelle.Click += new System.EventHandler(this.btnGunccelle_Click);
            this.btnGunccelle.MouseLeave += new System.EventHandler(this.btnGunccelle_MouseLeave);
            this.btnGunccelle.MouseHover += new System.EventHandler(this.btnGunccelle_MouseHover);
            // 
            // dgvTekliflerListele
            // 
            this.dgvTekliflerListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTekliflerListele.CausesValidation = false;
            this.dgvTekliflerListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTekliflerListele.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTekliflerListele.Location = new System.Drawing.Point(6, 230);
            this.dgvTekliflerListele.Name = "dgvTekliflerListele";
            this.dgvTekliflerListele.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            this.dgvTekliflerListele.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTekliflerListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTekliflerListele.Size = new System.Drawing.Size(1037, 310);
            this.dgvTekliflerListele.TabIndex = 39;
            this.dgvTekliflerListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTekliflerListele_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(477, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "TEKLİF DEPRTMANI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblKapat);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(62, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 37);
            this.panel2.TabIndex = 113;
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKapat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKapat.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.DimGray;
            this.lblKapat.Location = new System.Drawing.Point(977, 13);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(44, 19);
            this.lblKapat.TabIndex = 181;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources._1486564399_close_81512;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(1016, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 28);
            this.btnKapat.TabIndex = 109;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            this.btnKapat.MouseHover += new System.EventHandler(this.btnKapat_MouseHover);
            // 
            // frmTeklifBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeklifBirimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acilanİhaleler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeklifBirimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTekliflerListele)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTekliflerListele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtIhaleAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGunccelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDuzenle;
        private System.Windows.Forms.Label lblEkle;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Button btnSil;
    }
}