namespace YukleniciOtomasyon.WinUI.Lojistik
{
    partial class frmLojistikBirimi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSil = new System.Windows.Forms.Label();
            this.lblDuzenle = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.gbNakliyeIslemiEkle = new System.Windows.Forms.GroupBox();
            this.lblEkle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAltBirim = new System.Windows.Forms.ComboBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.dtpIsBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpIsBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNakliyeİslemiAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvNakliyeIslemleriListele = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblKapat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbNakliyeIslemiEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNakliyeIslemleriListele)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvNakliyeIslemleriListele);
            this.groupBox1.Location = new System.Drawing.Point(62, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 546);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.lblSil);
            this.groupBox2.Controls.Add(this.lblDuzenle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.gbNakliyeIslemiEkle);
            this.groupBox2.Controls.Add(this.dtpIsBitisTarihi);
            this.groupBox2.Controls.Add(this.dtpIsBaslangicTarihi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNakliyeİslemiAra);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 219);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.ForeColor = System.Drawing.Color.DimGray;
            this.lblSil.Location = new System.Drawing.Point(782, 194);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(25, 18);
            this.lblSil.TabIndex = 233;
            this.lblSil.Text = "Sil";
            this.lblSil.Visible = false;
            // 
            // lblDuzenle
            // 
            this.lblDuzenle.AutoSize = true;
            this.lblDuzenle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuzenle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDuzenle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzenle.ForeColor = System.Drawing.Color.DimGray;
            this.lblDuzenle.Location = new System.Drawing.Point(849, 168);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(57, 18);
            this.lblDuzenle.TabIndex = 236;
            this.lblDuzenle.Text = "Düzenle";
            this.lblDuzenle.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.ic_delete_128_28267;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(790, 175);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(33, 31);
            this.btnSil.TabIndex = 235;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.btnDuzenle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuzenle.Location = new System.Drawing.Point(824, 175);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(36, 31);
            this.btnDuzenle.TabIndex = 234;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.MouseLeave += new System.EventHandler(this.btnDuzenle_MouseLeave);
            this.btnDuzenle.MouseHover += new System.EventHandler(this.btnDuzenle_MouseHover);
            // 
            // gbNakliyeIslemiEkle
            // 
            this.gbNakliyeIslemiEkle.BackColor = System.Drawing.Color.DimGray;
            this.gbNakliyeIslemiEkle.Controls.Add(this.lblEkle);
            this.gbNakliyeIslemiEkle.Controls.Add(this.label11);
            this.gbNakliyeIslemiEkle.Controls.Add(this.btnEkle);
            this.gbNakliyeIslemiEkle.Controls.Add(this.label6);
            this.gbNakliyeIslemiEkle.Controls.Add(this.cmbAltBirim);
            this.gbNakliyeIslemiEkle.Controls.Add(this.cmbBirim);
            this.gbNakliyeIslemiEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbNakliyeIslemiEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbNakliyeIslemiEkle.Location = new System.Drawing.Point(461, 10);
            this.gbNakliyeIslemiEkle.Name = "gbNakliyeIslemiEkle";
            this.gbNakliyeIslemiEkle.Size = new System.Drawing.Size(570, 123);
            this.gbNakliyeIslemiEkle.TabIndex = 232;
            this.gbNakliyeIslemiEkle.TabStop = false;
            this.gbNakliyeIslemiEkle.Text = "Nakliye İşlemi Ekle";
            // 
            // lblEkle
            // 
            this.lblEkle.AutoSize = true;
            this.lblEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEkle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkle.ForeColor = System.Drawing.Color.DimGray;
            this.lblEkle.Location = new System.Drawing.Point(527, 83);
            this.lblEkle.Name = "lblEkle";
            this.lblEkle.Size = new System.Drawing.Size(33, 19);
            this.lblEkle.TabIndex = 201;
            this.lblEkle.Text = "Ekle";
            this.lblEkle.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(269, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 230;
            this.label11.Text = "Hangi Birim :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(513, 34);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(47, 46);
            this.btnEkle.TabIndex = 200;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(265, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 231;
            this.label6.Text = "AltBirim Seç :";
            // 
            // cmbAltBirim
            // 
            this.cmbAltBirim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbAltBirim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAltBirim.ForeColor = System.Drawing.Color.DimGray;
            this.cmbAltBirim.FormattingEnabled = true;
            this.cmbAltBirim.Location = new System.Drawing.Point(363, 59);
            this.cmbAltBirim.Name = "cmbAltBirim";
            this.cmbAltBirim.Size = new System.Drawing.Size(144, 24);
            this.cmbAltBirim.TabIndex = 229;
            // 
            // cmbBirim
            // 
            this.cmbBirim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbBirim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBirim.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Şantiyeler",
            "Depolar"});
            this.cmbBirim.Location = new System.Drawing.Point(363, 34);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(144, 24);
            this.cmbBirim.TabIndex = 228;
            // 
            // dtpIsBitisTarihi
            // 
            this.dtpIsBitisTarihi.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBitisTarihi.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBitisTarihi.Location = new System.Drawing.Point(782, 146);
            this.dtpIsBitisTarihi.Name = "dtpIsBitisTarihi";
            this.dtpIsBitisTarihi.Size = new System.Drawing.Size(171, 19);
            this.dtpIsBitisTarihi.TabIndex = 181;
            // 
            // dtpIsBaslangicTarihi
            // 
            this.dtpIsBaslangicTarihi.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBaslangicTarihi.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBaslangicTarihi.Location = new System.Drawing.Point(603, 146);
            this.dtpIsBaslangicTarihi.Name = "dtpIsBaslangicTarihi";
            this.dtpIsBaslangicTarihi.Size = new System.Drawing.Size(173, 19);
            this.dtpIsBaslangicTarihi.TabIndex = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(458, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 179;
            this.label1.Text = "Tarih Aralığı Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(469, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Nakliye İşlemi Ara :";
            // 
            // txtNakliyeİslemiAra
            // 
            this.txtNakliyeİslemiAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNakliyeİslemiAra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNakliyeİslemiAra.ForeColor = System.Drawing.Color.DimGray;
            this.txtNakliyeİslemiAra.Location = new System.Drawing.Point(603, 181);
            this.txtNakliyeİslemiAra.Name = "txtNakliyeİslemiAra";
            this.txtNakliyeİslemiAra.Size = new System.Drawing.Size(173, 22);
            this.txtNakliyeİslemiAra.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::YukleniciOtomasyon.WinUI.Properties.Resources.fri_frakt;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // dgvNakliyeIslemleriListele
            // 
            this.dgvNakliyeIslemleriListele.AllowUserToAddRows = false;
            this.dgvNakliyeIslemleriListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dgvNakliyeIslemleriListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNakliyeIslemleriListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNakliyeIslemleriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNakliyeIslemleriListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNakliyeIslemleriListele.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNakliyeIslemleriListele.Location = new System.Drawing.Point(6, 234);
            this.dgvNakliyeIslemleriListele.Name = "dgvNakliyeIslemleriListele";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.dgvNakliyeIslemleriListele.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNakliyeIslemleriListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNakliyeIslemleriListele.Size = new System.Drawing.Size(1037, 306);
            this.dgvNakliyeIslemleriListele.TabIndex = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "seçim";
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.lblKapat);
            this.panel2.Location = new System.Drawing.Point(68, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 37);
            this.panel2.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(422, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 22);
            this.label4.TabIndex = 108;
            this.label4.Text = "LOJİSTİK DEPARTMANI";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources._1486564399_close_81512;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(1007, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 28);
            this.btnKapat.TabIndex = 198;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            this.btnKapat.MouseHover += new System.EventHandler(this.btnKapat_MouseHover);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKapat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.DimGray;
            this.lblKapat.Location = new System.Drawing.Point(954, 14);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(44, 18);
            this.lblKapat.TabIndex = 203;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Visible = false;
            // 
            // frmLojistikBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLojistikBirimi";
            this.Text = "frmLojistikBirimi";
            this.Load += new System.EventHandler(this.frmLojistikBirimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbNakliyeIslemiEkle.ResumeLayout(false);
            this.gbNakliyeIslemiEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNakliyeIslemleriListele)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNakliyeİslemiAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvNakliyeIslemleriListele;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIsBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpIsBaslangicTarihi;
        private System.Windows.Forms.Label lblEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.ComboBox cmbAltBirim;
        private System.Windows.Forms.GroupBox gbNakliyeIslemiEkle;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Label lblDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
    }
}