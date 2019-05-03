namespace YukleniciOtomasyon.WinUI.SatinAlma
{
    partial class frmyanSatinAlmaListele
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOncekiFormaGit = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSatınALma = new System.Windows.Forms.GroupBox();
            this.lblKaydet = new System.Windows.Forms.Label();
            this.lblGuncelle = new System.Windows.Forms.Label();
            this.gbNormalKaydet = new System.Windows.Forms.GroupBox();
            this.lblMalzeme = new System.Windows.Forms.Label();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciGetir = new System.Windows.Forms.Button();
            this.dgvMalzemeListele = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbCekVadesi = new System.Windows.Forms.ComboBox();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.btnMalzemeGetir = new System.Windows.Forms.Button();
            this.cmbFirmaAdi = new System.Windows.Forms.ComboBox();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpSatinAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gbSatınALma.SuspendLayout();
            this.gbNormalKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblOncekiFormaGit);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 41);
            this.panel2.TabIndex = 112;
            // 
            // lblOncekiFormaGit
            // 
            this.lblOncekiFormaGit.AutoSize = true;
            this.lblOncekiFormaGit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOncekiFormaGit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOncekiFormaGit.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncekiFormaGit.ForeColor = System.Drawing.Color.DimGray;
            this.lblOncekiFormaGit.Location = new System.Drawing.Point(533, 11);
            this.lblOncekiFormaGit.Name = "lblOncekiFormaGit";
            this.lblOncekiFormaGit.Size = new System.Drawing.Size(110, 19);
            this.lblOncekiFormaGit.TabIndex = 208;
            this.lblOncekiFormaGit.Text = "Önceki Forma Git";
            this.lblOncekiFormaGit.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.exit_symbol_1_icon_icons_com_70162;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(649, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(33, 35);
            this.btnKapat.TabIndex = 109;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(209, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "SATIN ALMA GÜNCELLE / EKLE";
            // 
            // gbSatınALma
            // 
            this.gbSatınALma.BackColor = System.Drawing.Color.DimGray;
            this.gbSatınALma.Controls.Add(this.lblKaydet);
            this.gbSatınALma.Controls.Add(this.lblGuncelle);
            this.gbSatınALma.Controls.Add(this.gbNormalKaydet);
            this.gbSatınALma.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbSatınALma.ForeColor = System.Drawing.Color.White;
            this.gbSatınALma.Location = new System.Drawing.Point(5, 59);
            this.gbSatınALma.Name = "gbSatınALma";
            this.gbSatınALma.Size = new System.Drawing.Size(687, 587);
            this.gbSatınALma.TabIndex = 111;
            this.gbSatınALma.TabStop = false;
            // 
            // lblKaydet
            // 
            this.lblKaydet.AutoSize = true;
            this.lblKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKaydet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKaydet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydet.ForeColor = System.Drawing.Color.DimGray;
            this.lblKaydet.Location = new System.Drawing.Point(616, 480);
            this.lblKaydet.Name = "lblKaydet";
            this.lblKaydet.Size = new System.Drawing.Size(51, 18);
            this.lblKaydet.TabIndex = 210;
            this.lblKaydet.Text = "Kaydet";
            this.lblKaydet.Visible = false;
            // 
            // lblGuncelle
            // 
            this.lblGuncelle.AutoSize = true;
            this.lblGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblGuncelle.Location = new System.Drawing.Point(548, 480);
            this.lblGuncelle.Name = "lblGuncelle";
            this.lblGuncelle.Size = new System.Drawing.Size(61, 18);
            this.lblGuncelle.TabIndex = 212;
            this.lblGuncelle.Text = "Güncelle";
            this.lblGuncelle.Visible = false;
            // 
            // gbNormalKaydet
            // 
            this.gbNormalKaydet.BackColor = System.Drawing.Color.Transparent;
            this.gbNormalKaydet.Controls.Add(this.lblMalzeme);
            this.gbNormalKaydet.Controls.Add(this.lblTedarikci);
            this.gbNormalKaydet.Controls.Add(this.txtToplamFiyat);
            this.gbNormalKaydet.Controls.Add(this.label1);
            this.gbNormalKaydet.Controls.Add(this.btnTedarikciGetir);
            this.gbNormalKaydet.Controls.Add(this.dgvMalzemeListele);
            this.gbNormalKaydet.Controls.Add(this.cmbCekVadesi);
            this.gbNormalKaydet.Controls.Add(this.cmbOdemeTipi);
            this.gbNormalKaydet.Controls.Add(this.btnMalzemeGetir);
            this.gbNormalKaydet.Controls.Add(this.cmbFirmaAdi);
            this.gbNormalKaydet.Controls.Add(this.dtpTeslimTarihi);
            this.gbNormalKaydet.Controls.Add(this.label24);
            this.gbNormalKaydet.Controls.Add(this.dtpSatinAlmaTarihi);
            this.gbNormalKaydet.Controls.Add(this.label26);
            this.gbNormalKaydet.Controls.Add(this.label27);
            this.gbNormalKaydet.Controls.Add(this.label31);
            this.gbNormalKaydet.Controls.Add(this.btnGuncelle);
            this.gbNormalKaydet.Controls.Add(this.label32);
            this.gbNormalKaydet.Controls.Add(this.label34);
            this.gbNormalKaydet.Controls.Add(this.btnKaydet);
            this.gbNormalKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbNormalKaydet.ForeColor = System.Drawing.Color.DimGray;
            this.gbNormalKaydet.Location = new System.Drawing.Point(6, 14);
            this.gbNormalKaydet.Name = "gbNormalKaydet";
            this.gbNormalKaydet.Size = new System.Drawing.Size(675, 554);
            this.gbNormalKaydet.TabIndex = 156;
            this.gbNormalKaydet.TabStop = false;
            // 
            // lblMalzeme
            // 
            this.lblMalzeme.AutoSize = true;
            this.lblMalzeme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMalzeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMalzeme.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.lblMalzeme.ForeColor = System.Drawing.Color.DimGray;
            this.lblMalzeme.Location = new System.Drawing.Point(38, 219);
            this.lblMalzeme.Name = "lblMalzeme";
            this.lblMalzeme.Size = new System.Drawing.Size(103, 19);
            this.lblMalzeme.TabIndex = 188;
            this.lblMalzeme.Text = "Malzeme Listele";
            this.lblMalzeme.Visible = false;
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTedarikci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTedarikci.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.lblTedarikci.ForeColor = System.Drawing.Color.DimGray;
            this.lblTedarikci.Location = new System.Drawing.Point(320, 145);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(102, 19);
            this.lblTedarikci.TabIndex = 187;
            this.lblTedarikci.Text = "Tedarikçi Listele";
            this.lblTedarikci.Visible = false;
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtToplamFiyat.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtToplamFiyat.Location = new System.Drawing.Point(139, 138);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(154, 26);
            this.txtToplamFiyat.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 185;
            this.label1.Text = "Toplam Fiyat :";
            // 
            // btnTedarikciGetir
            // 
            this.btnTedarikciGetir.BackColor = System.Drawing.Color.Transparent;
            this.btnTedarikciGetir.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.preview_search_find_locate_1551;
            this.btnTedarikciGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTedarikciGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTedarikciGetir.Location = new System.Drawing.Point(299, 113);
            this.btnTedarikciGetir.Name = "btnTedarikciGetir";
            this.btnTedarikciGetir.Size = new System.Drawing.Size(29, 27);
            this.btnTedarikciGetir.TabIndex = 184;
            this.btnTedarikciGetir.UseVisualStyleBackColor = false;
            this.btnTedarikciGetir.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvMalzemeListele
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.dgvMalzemeListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMalzemeListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMalzemeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMalzemeListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMalzemeListele.GridColor = System.Drawing.Color.DimGray;
            this.dgvMalzemeListele.Location = new System.Drawing.Point(139, 168);
            this.dgvMalzemeListele.Name = "dgvMalzemeListele";
            this.dgvMalzemeListele.Size = new System.Drawing.Size(328, 374);
            this.dgvMalzemeListele.TabIndex = 157;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seç";
            this.Column1.Name = "Column1";
            // 
            // cmbCekVadesi
            // 
            this.cmbCekVadesi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbCekVadesi.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbCekVadesi.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCekVadesi.FormattingEnabled = true;
            this.cmbCekVadesi.Location = new System.Drawing.Point(139, 88);
            this.cmbCekVadesi.Name = "cmbCekVadesi";
            this.cmbCekVadesi.Size = new System.Drawing.Size(154, 24);
            this.cmbCekVadesi.TabIndex = 183;
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbOdemeTipi.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOdemeTipi.ForeColor = System.Drawing.Color.DimGray;
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Location = new System.Drawing.Point(139, 63);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(154, 24);
            this.cmbOdemeTipi.TabIndex = 182;
            // 
            // btnMalzemeGetir
            // 
            this.btnMalzemeGetir.BackColor = System.Drawing.Color.Transparent;
            this.btnMalzemeGetir.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.preview_search_find_locate_1551;
            this.btnMalzemeGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMalzemeGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMalzemeGetir.Location = new System.Drawing.Point(110, 189);
            this.btnMalzemeGetir.Name = "btnMalzemeGetir";
            this.btnMalzemeGetir.Size = new System.Drawing.Size(29, 27);
            this.btnMalzemeGetir.TabIndex = 181;
            this.btnMalzemeGetir.UseVisualStyleBackColor = false;
            this.btnMalzemeGetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFirmaAdi
            // 
            this.cmbFirmaAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbFirmaAdi.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbFirmaAdi.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFirmaAdi.FormattingEnabled = true;
            this.cmbFirmaAdi.Location = new System.Drawing.Point(139, 113);
            this.cmbFirmaAdi.Name = "cmbFirmaAdi";
            this.cmbFirmaAdi.Size = new System.Drawing.Size(154, 24);
            this.cmbFirmaAdi.TabIndex = 178;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(139, 42);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(154, 20);
            this.dtpTeslimTarihi.TabIndex = 167;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(42, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 16);
            this.label24.TabIndex = 166;
            this.label24.Text = "Teslim Tarihi :";
            // 
            // dtpSatinAlmaTarihi
            // 
            this.dtpSatinAlmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSatinAlmaTarihi.Location = new System.Drawing.Point(139, 21);
            this.dtpSatinAlmaTarihi.Name = "dtpSatinAlmaTarihi";
            this.dtpSatinAlmaTarihi.Size = new System.Drawing.Size(154, 20);
            this.dtpSatinAlmaTarihi.TabIndex = 164;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(13, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(126, 16);
            this.label26.TabIndex = 163;
            this.label26.Text = "Satın Alma Tarihi :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label27.Location = new System.Drawing.Point(53, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 16);
            this.label27.TabIndex = 162;
            this.label27.Text = "Çek Vadesi :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label31.Location = new System.Drawing.Point(49, 66);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 16);
            this.label31.TabIndex = 158;
            this.label31.Text = "Ödeme Tipi :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(565, 502);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(49, 46);
            this.btnGuncelle.TabIndex = 154;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label32.Location = new System.Drawing.Point(61, 116);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 16);
            this.label32.TabIndex = 157;
            this.label32.Text = "Firma Adı :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label34.Location = new System.Drawing.Point(48, 168);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 16);
            this.label34.TabIndex = 155;
            this.label34.Text = "Malzemeler :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(620, 502);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(49, 46);
            this.btnKaydet.TabIndex = 153;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmyanSatinAlmaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbSatınALma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmyanSatinAlmaListele";
            this.Text = "SatinAlmaListele";
            this.Load += new System.EventHandler(this.frmyanSatinAlmaListele_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmyanSatinAlmaListele_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmyanSatinAlmaListele_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmyanSatinAlmaListele_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSatınALma.ResumeLayout(false);
            this.gbSatınALma.PerformLayout();
            this.gbNormalKaydet.ResumeLayout(false);
            this.gbNormalKaydet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzemeListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSatınALma;
        private System.Windows.Forms.GroupBox gbNormalKaydet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbFirmaAdi;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpSatinAlmaTarihi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cmbCekVadesi;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.Button btnMalzemeGetir;
        private System.Windows.Forms.DataGridView dgvMalzemeListele;
        private System.Windows.Forms.Button btnTedarikciGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label lblOncekiFormaGit;
        private System.Windows.Forms.Label lblKaydet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblGuncelle;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Label lblMalzeme;
    }
}