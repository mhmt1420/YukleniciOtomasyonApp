namespace YukleniciOtomasyon.WinUI.Santiye
{
    partial class frmSantiyeBirimi
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
            this.lblEkle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSantiyeAra = new System.Windows.Forms.TextBox();
            this.dgvSantiye_MalzemeListele = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSantiye_MalzemeListele)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvSantiye_MalzemeListele);
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
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.lblDuzenle);
            this.groupBox2.Controls.Add(this.lblEkle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSantiyeAra);
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
            this.lblSil.Location = new System.Drawing.Point(873, 135);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(25, 18);
            this.lblSil.TabIndex = 198;
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
            this.lblDuzenle.Location = new System.Drawing.Point(912, 135);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(61, 18);
            this.lblDuzenle.TabIndex = 196;
            this.lblDuzenle.Text = "Güncelle";
            this.lblDuzenle.Visible = false;
            // 
            // lblEkle
            // 
            this.lblEkle.AutoSize = true;
            this.lblEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkle.ForeColor = System.Drawing.Color.DimGray;
            this.lblEkle.Location = new System.Drawing.Point(989, 134);
            this.lblEkle.Name = "lblEkle";
            this.lblEkle.Size = new System.Drawing.Size(36, 18);
            this.lblEkle.TabIndex = 195;
            this.lblEkle.Text = "Ekle";
            this.lblEkle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(598, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Şantiye Ara :";
            // 
            // txtSantiyeAra
            // 
            this.txtSantiyeAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSantiyeAra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSantiyeAra.ForeColor = System.Drawing.Color.DimGray;
            this.txtSantiyeAra.Location = new System.Drawing.Point(690, 180);
            this.txtSantiyeAra.Name = "txtSantiyeAra";
            this.txtSantiyeAra.Size = new System.Drawing.Size(173, 22);
            this.txtSantiyeAra.TabIndex = 111;
            this.txtSantiyeAra.TextChanged += new System.EventHandler(this.txtSantiyeAra_TextChanged);
            // 
            // dgvSantiye_MalzemeListele
            // 
            this.dgvSantiye_MalzemeListele.AllowUserToAddRows = false;
            this.dgvSantiye_MalzemeListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dgvSantiye_MalzemeListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSantiye_MalzemeListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSantiye_MalzemeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSantiye_MalzemeListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSantiye_MalzemeListele.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSantiye_MalzemeListele.Location = new System.Drawing.Point(6, 234);
            this.dgvSantiye_MalzemeListele.Name = "dgvSantiye_MalzemeListele";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.dgvSantiye_MalzemeListele.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSantiye_MalzemeListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSantiye_MalzemeListele.Size = new System.Drawing.Size(1037, 306);
            this.dgvSantiye_MalzemeListele.TabIndex = 180;
            this.dgvSantiye_MalzemeListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSantiye_MalzemeListele_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "seçim";
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Location = new System.Drawing.Point(68, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 37);
            this.panel2.TabIndex = 128;
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKapat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.DimGray;
            this.lblKapat.Location = new System.Drawing.Point(948, 12);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(44, 18);
            this.lblKapat.TabIndex = 197;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(437, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 108;
            this.label4.Text = "ŞANTİYE BİRİMİ";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.ic_delete_128_28267;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(869, 156);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 46);
            this.btnSil.TabIndex = 197;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(975, 156);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(47, 46);
            this.btnEkle.TabIndex = 194;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.btnDuzenle.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuzenle.Location = new System.Drawing.Point(922, 156);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(47, 46);
            this.btnDuzenle.TabIndex = 193;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            this.btnDuzenle.MouseLeave += new System.EventHandler(this.btnDuzenle_MouseLeave);
            this.btnDuzenle.MouseHover += new System.EventHandler(this.btnDuzenle_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::YukleniciOtomasyon.WinUI.Properties.Resources.d4674f46e4cd5c03f14410fe259b5e5f_industrial_crane_side_icon_by_vexels;
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources._1486564399_close_81512;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(998, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 28);
            this.btnKapat.TabIndex = 192;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            this.btnKapat.MouseHover += new System.EventHandler(this.btnKapat_MouseHover);
            // 
            // frmSantiyeBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSantiyeBirimi";
            this.Text = "frmSantiyeBirimi";
            this.Load += new System.EventHandler(this.frmSantiyeBirimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSantiye_MalzemeListele)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSantiyeAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSantiye_MalzemeListele;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDuzenle;
        private System.Windows.Forms.Label lblEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Button btnSil;
    }
}