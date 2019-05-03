namespace YukleniciOtomasyon.WinUI.SatinAlma
{
    partial class frmSatinAlmaBirimi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSil = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblguncelle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblekle = new System.Windows.Forms.Label();
            this.txtPersonelAdiSoyadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvSatinAlmalariListele = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatinAlmalariListele)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 109;
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKapat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.DimGray;
            this.lblKapat.Location = new System.Drawing.Point(963, 8);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(44, 18);
            this.lblKapat.TabIndex = 185;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources._1486564399_close_81512;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(1013, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 28);
            this.btnKapat.TabIndex = 109;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(390, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 22);
            this.label4.TabIndex = 108;
            this.label4.Text = "SATIN ALMA DEPARTMANI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvSatinAlmalariListele);
            this.groupBox1.Location = new System.Drawing.Point(62, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 546);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.lblSil);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.dtpSonTarih);
            this.groupBox2.Controls.Add(this.dtpIlkTarih);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.lblguncelle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblekle);
            this.groupBox2.Controls.Add(this.txtPersonelAdiSoyadi);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnGuncelle);
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
            this.lblSil.Location = new System.Drawing.Point(867, 124);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(25, 18);
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
            this.btnSil.Location = new System.Drawing.Point(863, 145);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 46);
            this.btnSil.TabIndex = 199;
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpSonTarih.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpSonTarih.Location = new System.Drawing.Point(678, 124);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(171, 19);
            this.dtpSonTarih.TabIndex = 184;
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIlkTarih.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIlkTarih.Location = new System.Drawing.Point(499, 124);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(173, 19);
            this.dtpIlkTarih.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(354, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 182;
            this.label1.Text = "Tarih Aralığı Seçiniz :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(969, 145);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(47, 46);
            this.btnEkle.TabIndex = 174;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblguncelle
            // 
            this.lblguncelle.AutoSize = true;
            this.lblguncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblguncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblguncelle.Location = new System.Drawing.Point(906, 124);
            this.lblguncelle.Name = "lblguncelle";
            this.lblguncelle.Size = new System.Drawing.Size(61, 18);
            this.lblguncelle.TabIndex = 178;
            this.lblguncelle.Text = "Güncelle";
            this.lblguncelle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(385, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Satın Alma Ara :";
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.ForeColor = System.Drawing.Color.DimGray;
            this.lblekle.Location = new System.Drawing.Point(983, 124);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(36, 18);
            this.lblekle.TabIndex = 177;
            this.lblekle.Text = "Ekle";
            this.lblekle.Visible = false;
            // 
            // txtPersonelAdiSoyadi
            // 
            this.txtPersonelAdiSoyadi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPersonelAdiSoyadi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdiSoyadi.ForeColor = System.Drawing.Color.DimGray;
            this.txtPersonelAdiSoyadi.Location = new System.Drawing.Point(499, 157);
            this.txtPersonelAdiSoyadi.Name = "txtPersonelAdiSoyadi";
            this.txtPersonelAdiSoyadi.Size = new System.Drawing.Size(173, 22);
            this.txtPersonelAdiSoyadi.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::YukleniciOtomasyon.WinUI.Properties.Resources.compare_grey_300x300_01;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(916, 145);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(47, 46);
            this.btnGuncelle.TabIndex = 126;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvSatinAlmalariListele
            // 
            this.dgvSatinAlmalariListele.AllowUserToAddRows = false;
            this.dgvSatinAlmalariListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dgvSatinAlmalariListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSatinAlmalariListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSatinAlmalariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSatinAlmalariListele.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSatinAlmalariListele.Location = new System.Drawing.Point(6, 234);
            this.dgvSatinAlmalariListele.Name = "dgvSatinAlmalariListele";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.dgvSatinAlmalariListele.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSatinAlmalariListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatinAlmalariListele.Size = new System.Drawing.Size(1037, 306);
            this.dgvSatinAlmalariListele.TabIndex = 180;
            // 
            // frmSatinAlmaBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatinAlmaBirimi";
            this.Text = "SATIN ALMA DEPARTMANI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSatinAlmaBirimi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatinAlmalariListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblekle;
        private System.Windows.Forms.TextBox txtPersonelAdiSoyadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvSatinAlmalariListele;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKapat;
        public System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Button btnSil;
    }
}