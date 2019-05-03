namespace YukleniciOtomasyon.WinUI.Teklif
{
    partial class frmyanİhaleKaydet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOncekiFormaGit = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.txtIhaleAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnIhaleEvraklariListele = new System.Windows.Forms.Button();
            this.lblSil = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDuzenle = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.dgvAcilanİhalelerListele = new System.Windows.Forms.DataGridView();
            this.grbAcilanİhaleler = new System.Windows.Forms.GroupBox();
            this.txtSozlesmeTaslagi = new System.Windows.Forms.TextBox();
            this.txtIdariSartname = new System.Windows.Forms.TextBox();
            this.txtTeknikSartname = new System.Windows.Forms.TextBox();
            this.btnIdariSartname = new System.Windows.Forms.Button();
            this.btnSozlesmeTaslagi = new System.Windows.Forms.Button();
            this.btnTeknikSartname = new System.Windows.Forms.Button();
            this.lblKaydet = new System.Windows.Forms.Label();
            this.lblGuncelle = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpIhaleTarihi_Saati = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFirmaninTeklifTutari = new System.Windows.Forms.TextBox();
            this.txtKurum_FirmaAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIsBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtIsTanimi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIhaleyiAlanFirmaAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpIsBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtİhaleOturumAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBoxPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcilanİhalelerListele)).BeginInit();
            this.grbAcilanİhaleler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblOncekiFormaGit);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 38);
            this.panel2.TabIndex = 110;
            // 
            // lblOncekiFormaGit
            // 
            this.lblOncekiFormaGit.AutoSize = true;
            this.lblOncekiFormaGit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOncekiFormaGit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOncekiFormaGit.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncekiFormaGit.ForeColor = System.Drawing.Color.DimGray;
            this.lblOncekiFormaGit.Location = new System.Drawing.Point(763, 11);
            this.lblOncekiFormaGit.Name = "lblOncekiFormaGit";
            this.lblOncekiFormaGit.Size = new System.Drawing.Size(110, 19);
            this.lblOncekiFormaGit.TabIndex = 209;
            this.lblOncekiFormaGit.Text = "Önceki Forma Git";
            this.lblOncekiFormaGit.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.exit_symbol_1_icon_icons_com_70162;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(878, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 32);
            this.btnKapat.TabIndex = 109;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            this.btnKapat.MouseHover += new System.EventHandler(this.btnKapat_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(202, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "İHALE LİSTELE / GÜNCELLE / EKLE";
            // 
            // groupBoxPersonelBilgileri
            // 
            this.groupBoxPersonelBilgileri.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtIhaleAra);
            this.groupBoxPersonelBilgileri.Controls.Add(this.label14);
            this.groupBoxPersonelBilgileri.Controls.Add(this.btnIhaleEvraklariListele);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblSil);
            this.groupBoxPersonelBilgileri.Controls.Add(this.label9);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblDuzenle);
            this.groupBoxPersonelBilgileri.Controls.Add(this.btnSil);
            this.groupBoxPersonelBilgileri.Controls.Add(this.btnDuzenle);
            this.groupBoxPersonelBilgileri.Controls.Add(this.dgvAcilanİhalelerListele);
            this.groupBoxPersonelBilgileri.Controls.Add(this.grbAcilanİhaleler);
            this.groupBoxPersonelBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPersonelBilgileri.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.groupBoxPersonelBilgileri.Location = new System.Drawing.Point(2, 56);
            this.groupBoxPersonelBilgileri.Name = "groupBoxPersonelBilgileri";
            this.groupBoxPersonelBilgileri.Size = new System.Drawing.Size(911, 584);
            this.groupBoxPersonelBilgileri.TabIndex = 109;
            this.groupBoxPersonelBilgileri.TabStop = false;
            // 
            // txtIhaleAra
            // 
            this.txtIhaleAra.Location = new System.Drawing.Point(629, 341);
            this.txtIhaleAra.Name = "txtIhaleAra";
            this.txtIhaleAra.Size = new System.Drawing.Size(155, 24);
            this.txtIhaleAra.TabIndex = 229;
            this.txtIhaleAra.TextChanged += new System.EventHandler(this.txtIhaleAra_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(554, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 228;
            this.label14.Text = "İhale Ara:";
            // 
            // btnIhaleEvraklariListele
            // 
            this.btnIhaleEvraklariListele.BackColor = System.Drawing.Color.Transparent;
            this.btnIhaleEvraklariListele.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources._1486564398_menu2_81519;
            this.btnIhaleEvraklariListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIhaleEvraklariListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIhaleEvraklariListele.Location = new System.Drawing.Point(7, 330);
            this.btnIhaleEvraklariListele.Name = "btnIhaleEvraklariListele";
            this.btnIhaleEvraklariListele.Size = new System.Drawing.Size(43, 42);
            this.btnIhaleEvraklariListele.TabIndex = 176;
            this.btnIhaleEvraklariListele.UseVisualStyleBackColor = false;
            this.btnIhaleEvraklariListele.Click += new System.EventHandler(this.btnIhaleEvraklariListele_Click);
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSil.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.ForeColor = System.Drawing.Color.DimGray;
            this.lblSil.Location = new System.Drawing.Point(797, 318);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(23, 19);
            this.lblSil.TabIndex = 218;
            this.lblSil.Text = "Sil";
            this.lblSil.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(56, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 42);
            this.label9.TabIndex = 175;
            this.label9.Text = "İhale Evraklari Listele";
            // 
            // lblDuzenle
            // 
            this.lblDuzenle.AutoSize = true;
            this.lblDuzenle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDuzenle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDuzenle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzenle.ForeColor = System.Drawing.Color.DimGray;
            this.lblDuzenle.Location = new System.Drawing.Point(849, 318);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(56, 19);
            this.lblDuzenle.TabIndex = 222;
            this.lblDuzenle.Text = "Düzenle";
            this.lblDuzenle.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.ic_delete_128_28267;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(797, 326);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 46);
            this.btnSil.TabIndex = 221;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.btnDuzenle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuzenle.Location = new System.Drawing.Point(869, 336);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(36, 30);
            this.btnDuzenle.TabIndex = 219;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.MouseLeave += new System.EventHandler(this.btnDuzenle_MouseLeave);
            this.btnDuzenle.MouseHover += new System.EventHandler(this.btnDuzenle_MouseHover);
            // 
            // dgvAcilanİhalelerListele
            // 
            this.dgvAcilanİhalelerListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAcilanİhalelerListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAcilanİhalelerListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcilanİhalelerListele.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcilanİhalelerListele.Location = new System.Drawing.Point(6, 378);
            this.dgvAcilanİhalelerListele.Name = "dgvAcilanİhalelerListele";
            this.dgvAcilanİhalelerListele.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            this.dgvAcilanİhalelerListele.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAcilanİhalelerListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcilanİhalelerListele.Size = new System.Drawing.Size(899, 200);
            this.dgvAcilanİhalelerListele.TabIndex = 152;
            this.dgvAcilanİhalelerListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcilanİhalelerListele_CellClick);
            this.dgvAcilanİhalelerListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcilanİhalelerListele_CellDoubleClick);
            // 
            // grbAcilanİhaleler
            // 
            this.grbAcilanİhaleler.BackColor = System.Drawing.Color.Transparent;
            this.grbAcilanİhaleler.Controls.Add(this.txtSozlesmeTaslagi);
            this.grbAcilanİhaleler.Controls.Add(this.txtIdariSartname);
            this.grbAcilanİhaleler.Controls.Add(this.txtTeknikSartname);
            this.grbAcilanİhaleler.Controls.Add(this.btnIdariSartname);
            this.grbAcilanİhaleler.Controls.Add(this.btnSozlesmeTaslagi);
            this.grbAcilanİhaleler.Controls.Add(this.btnTeknikSartname);
            this.grbAcilanİhaleler.Controls.Add(this.lblKaydet);
            this.grbAcilanİhaleler.Controls.Add(this.lblGuncelle);
            this.grbAcilanİhaleler.Controls.Add(this.btnGuncelle);
            this.grbAcilanİhaleler.Controls.Add(this.btnKaydet);
            this.grbAcilanİhaleler.Controls.Add(this.dtpIhaleTarihi_Saati);
            this.grbAcilanİhaleler.Controls.Add(this.panel3);
            this.grbAcilanİhaleler.Controls.Add(this.txtFirmaninTeklifTutari);
            this.grbAcilanİhaleler.Controls.Add(this.txtKurum_FirmaAdi);
            this.grbAcilanİhaleler.Controls.Add(this.label13);
            this.grbAcilanİhaleler.Controls.Add(this.dtpIsBaslangicTarihi);
            this.grbAcilanİhaleler.Controls.Add(this.txtIsTanimi);
            this.grbAcilanİhaleler.Controls.Add(this.label12);
            this.grbAcilanİhaleler.Controls.Add(this.txtIhaleyiAlanFirmaAdi);
            this.grbAcilanİhaleler.Controls.Add(this.label5);
            this.grbAcilanİhaleler.Controls.Add(this.label10);
            this.grbAcilanİhaleler.Controls.Add(this.label11);
            this.grbAcilanİhaleler.Controls.Add(this.dtpIsBitisTarihi);
            this.grbAcilanİhaleler.Controls.Add(this.label8);
            this.grbAcilanİhaleler.Controls.Add(this.label1);
            this.grbAcilanİhaleler.Controls.Add(this.label7);
            this.grbAcilanİhaleler.Controls.Add(this.label2);
            this.grbAcilanİhaleler.Controls.Add(this.txtİhaleOturumAdres);
            this.grbAcilanİhaleler.Controls.Add(this.label6);
            this.grbAcilanİhaleler.Controls.Add(this.label3);
            this.grbAcilanİhaleler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbAcilanİhaleler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grbAcilanİhaleler.Location = new System.Drawing.Point(7, 11);
            this.grbAcilanİhaleler.Name = "grbAcilanİhaleler";
            this.grbAcilanİhaleler.Size = new System.Drawing.Size(898, 301);
            this.grbAcilanİhaleler.TabIndex = 151;
            this.grbAcilanİhaleler.TabStop = false;
            this.grbAcilanİhaleler.Text = "Açılan İhaleler";
            // 
            // txtSozlesmeTaslagi
            // 
            this.txtSozlesmeTaslagi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSozlesmeTaslagi.Enabled = false;
            this.txtSozlesmeTaslagi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSozlesmeTaslagi.ForeColor = System.Drawing.Color.DimGray;
            this.txtSozlesmeTaslagi.Location = new System.Drawing.Point(511, 96);
            this.txtSozlesmeTaslagi.Name = "txtSozlesmeTaslagi";
            this.txtSozlesmeTaslagi.Size = new System.Drawing.Size(237, 26);
            this.txtSozlesmeTaslagi.TabIndex = 220;
            // 
            // txtIdariSartname
            // 
            this.txtIdariSartname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIdariSartname.Enabled = false;
            this.txtIdariSartname.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIdariSartname.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdariSartname.Location = new System.Drawing.Point(511, 58);
            this.txtIdariSartname.Name = "txtIdariSartname";
            this.txtIdariSartname.Size = new System.Drawing.Size(237, 26);
            this.txtIdariSartname.TabIndex = 219;
            // 
            // txtTeknikSartname
            // 
            this.txtTeknikSartname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTeknikSartname.Enabled = false;
            this.txtTeknikSartname.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeknikSartname.ForeColor = System.Drawing.Color.DimGray;
            this.txtTeknikSartname.Location = new System.Drawing.Point(511, 20);
            this.txtTeknikSartname.Name = "txtTeknikSartname";
            this.txtTeknikSartname.Size = new System.Drawing.Size(237, 26);
            this.txtTeknikSartname.TabIndex = 218;
            // 
            // btnIdariSartname
            // 
            this.btnIdariSartname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdariSartname.ForeColor = System.Drawing.Color.DimGray;
            this.btnIdariSartname.Location = new System.Drawing.Point(754, 57);
            this.btnIdariSartname.Name = "btnIdariSartname";
            this.btnIdariSartname.Size = new System.Drawing.Size(144, 26);
            this.btnIdariSartname.TabIndex = 217;
            this.btnIdariSartname.Text = "Dosya Seç";
            this.btnIdariSartname.UseVisualStyleBackColor = false;
            this.btnIdariSartname.Click += new System.EventHandler(this.btnIdariSartname_Click);
            // 
            // btnSozlesmeTaslagi
            // 
            this.btnSozlesmeTaslagi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSozlesmeTaslagi.ForeColor = System.Drawing.Color.DimGray;
            this.btnSozlesmeTaslagi.Location = new System.Drawing.Point(754, 96);
            this.btnSozlesmeTaslagi.Name = "btnSozlesmeTaslagi";
            this.btnSozlesmeTaslagi.Size = new System.Drawing.Size(144, 26);
            this.btnSozlesmeTaslagi.TabIndex = 216;
            this.btnSozlesmeTaslagi.Text = "Dosya Seç";
            this.btnSozlesmeTaslagi.UseVisualStyleBackColor = false;
            this.btnSozlesmeTaslagi.Click += new System.EventHandler(this.btnSozlesmeTaslagi_Click);
            // 
            // btnTeknikSartname
            // 
            this.btnTeknikSartname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeknikSartname.ForeColor = System.Drawing.Color.DimGray;
            this.btnTeknikSartname.Location = new System.Drawing.Point(754, 18);
            this.btnTeknikSartname.Name = "btnTeknikSartname";
            this.btnTeknikSartname.Size = new System.Drawing.Size(144, 26);
            this.btnTeknikSartname.TabIndex = 215;
            this.btnTeknikSartname.Text = "Dosya Seç";
            this.btnTeknikSartname.UseVisualStyleBackColor = false;
            this.btnTeknikSartname.Click += new System.EventHandler(this.btnTeknikSartname_Click);
            // 
            // lblKaydet
            // 
            this.lblKaydet.AutoSize = true;
            this.lblKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKaydet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKaydet.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydet.ForeColor = System.Drawing.Color.DimGray;
            this.lblKaydet.Location = new System.Drawing.Point(838, 236);
            this.lblKaydet.Name = "lblKaydet";
            this.lblKaydet.Size = new System.Drawing.Size(50, 19);
            this.lblKaydet.TabIndex = 214;
            this.lblKaydet.Text = "Kaydet";
            this.lblKaydet.Visible = false;
            // 
            // lblGuncelle
            // 
            this.lblGuncelle.AutoSize = true;
            this.lblGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuncelle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblGuncelle.Location = new System.Drawing.Point(773, 236);
            this.lblGuncelle.Name = "lblGuncelle";
            this.lblGuncelle.Size = new System.Drawing.Size(59, 19);
            this.lblGuncelle.TabIndex = 213;
            this.lblGuncelle.Text = "Güncelle";
            this.lblGuncelle.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(788, 249);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(49, 46);
            this.btnGuncelle.TabIndex = 212;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            this.btnGuncelle.MouseHover += new System.EventHandler(this.btnGuncelle_MouseHover);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(843, 249);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(49, 46);
            this.btnKaydet.TabIndex = 211;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            this.btnKaydet.MouseHover += new System.EventHandler(this.btnKaydet_MouseHover);
            // 
            // dtpIhaleTarihi_Saati
            // 
            this.dtpIhaleTarihi_Saati.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIhaleTarihi_Saati.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIhaleTarihi_Saati.Location = new System.Drawing.Point(164, 79);
            this.dtpIhaleTarihi_Saati.Name = "dtpIhaleTarihi_Saati";
            this.dtpIhaleTarihi_Saati.Size = new System.Drawing.Size(144, 19);
            this.dtpIhaleTarihi_Saati.TabIndex = 161;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(331, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 284);
            this.panel3.TabIndex = 106;
            // 
            // txtFirmaninTeklifTutari
            // 
            this.txtFirmaninTeklifTutari.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirmaninTeklifTutari.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaninTeklifTutari.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirmaninTeklifTutari.Location = new System.Drawing.Point(511, 172);
            this.txtFirmaninTeklifTutari.Name = "txtFirmaninTeklifTutari";
            this.txtFirmaninTeklifTutari.Size = new System.Drawing.Size(144, 26);
            this.txtFirmaninTeklifTutari.TabIndex = 141;
            // 
            // txtKurum_FirmaAdi
            // 
            this.txtKurum_FirmaAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKurum_FirmaAdi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKurum_FirmaAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txtKurum_FirmaAdi.Location = new System.Drawing.Point(164, 23);
            this.txtKurum_FirmaAdi.Name = "txtKurum_FirmaAdi";
            this.txtKurum_FirmaAdi.Size = new System.Drawing.Size(144, 26);
            this.txtKurum_FirmaAdi.TabIndex = 147;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(356, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 16);
            this.label13.TabIndex = 146;
            this.label13.Text = "Firmanın Teklif Tutarı :";
            // 
            // dtpIsBaslangicTarihi
            // 
            this.dtpIsBaslangicTarihi.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBaslangicTarihi.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBaslangicTarihi.Location = new System.Drawing.Point(164, 201);
            this.dtpIsBaslangicTarihi.Name = "dtpIsBaslangicTarihi";
            this.dtpIsBaslangicTarihi.Size = new System.Drawing.Size(144, 19);
            this.dtpIsBaslangicTarihi.TabIndex = 128;
            // 
            // txtIsTanimi
            // 
            this.txtIsTanimi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIsTanimi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsTanimi.ForeColor = System.Drawing.Color.DimGray;
            this.txtIsTanimi.Location = new System.Drawing.Point(164, 51);
            this.txtIsTanimi.Name = "txtIsTanimi";
            this.txtIsTanimi.Size = new System.Drawing.Size(144, 26);
            this.txtIsTanimi.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(349, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 16);
            this.label12.TabIndex = 145;
            this.label12.Text = "İhaleyi Alan Firma Adı :";
            // 
            // txtIhaleyiAlanFirmaAdi
            // 
            this.txtIhaleyiAlanFirmaAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIhaleyiAlanFirmaAdi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIhaleyiAlanFirmaAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txtIhaleyiAlanFirmaAdi.Location = new System.Drawing.Point(511, 134);
            this.txtIhaleyiAlanFirmaAdi.Name = "txtIhaleyiAlanFirmaAdi";
            this.txtIhaleyiAlanFirmaAdi.Size = new System.Drawing.Size(144, 26);
            this.txtIhaleyiAlanFirmaAdi.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(87, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 148;
            this.label5.Text = "İs Tanımı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(384, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 129;
            this.label10.Text = "Teknik Şartname :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(396, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 130;
            this.label11.Text = "İdari Şartname :";
            // 
            // dtpIsBitisTarihi
            // 
            this.dtpIsBitisTarihi.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBitisTarihi.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIsBitisTarihi.Location = new System.Drawing.Point(164, 222);
            this.dtpIsBitisTarihi.Name = "dtpIsBitisTarihi";
            this.dtpIsBitisTarihi.Size = new System.Drawing.Size(144, 19);
            this.dtpIsBitisTarihi.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(28, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 134;
            this.label8.Text = "İş Baslangıç Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Kurum/Firma Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(63, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 135;
            this.label7.Text = "İş Bitiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 144;
            this.label2.Text = "İhalenin Oturum Adres :";
            // 
            // txtİhaleOturumAdres
            // 
            this.txtİhaleOturumAdres.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtİhaleOturumAdres.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİhaleOturumAdres.ForeColor = System.Drawing.Color.DimGray;
            this.txtİhaleOturumAdres.Location = new System.Drawing.Point(164, 100);
            this.txtİhaleOturumAdres.Multiline = true;
            this.txtİhaleOturumAdres.Name = "txtİhaleOturumAdres";
            this.txtİhaleOturumAdres.Size = new System.Drawing.Size(144, 99);
            this.txtİhaleOturumAdres.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(380, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 136;
            this.label6.Text = "Sözleşme Taslağı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 143;
            this.label3.Text = "İhale Tarihi/Saati :";
            // 
            // frmyanİhaleKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxPersonelBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmyanİhaleKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IhaleKaydet";
            this.Load += new System.EventHandler(this.frmyanİhaleKaydet_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmİhaleKaydet_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmİhaleKaydet_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmİhaleKaydet_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxPersonelBilgileri.ResumeLayout(false);
            this.groupBoxPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcilanİhalelerListele)).EndInit();
            this.grbAcilanİhaleler.ResumeLayout(false);
            this.grbAcilanİhaleler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPersonelBilgileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpIsBitisTarihi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpIsBaslangicTarihi;
        private System.Windows.Forms.TextBox txtKurum_FirmaAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtİhaleOturumAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirmaninTeklifTutari;
        private System.Windows.Forms.TextBox txtIhaleyiAlanFirmaAdi;
        private System.Windows.Forms.TextBox txtIsTanimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbAcilanİhaleler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAcilanİhalelerListele;
        private System.Windows.Forms.DateTimePicker dtpIhaleTarihi_Saati;
        private System.Windows.Forms.Button btnIhaleEvraklariListele;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOncekiFormaGit;
        private System.Windows.Forms.Label lblKaydet;
        private System.Windows.Forms.Label lblGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIdariSartname;
        private System.Windows.Forms.Button btnSozlesmeTaslagi;
        private System.Windows.Forms.Button btnTeknikSartname;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Label lblDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox txtSozlesmeTaslagi;
        private System.Windows.Forms.TextBox txtIdariSartname;
        private System.Windows.Forms.TextBox txtTeknikSartname;
        private System.Windows.Forms.TextBox txtIhaleAra;
        private System.Windows.Forms.Label label14;
    }
}