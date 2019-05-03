using System.Windows.Forms;

namespace YukleniciOtomasyon.WinUI.IK
{
    partial class frmIKBirimi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKapat = new System.Windows.Forms.Label();
            this.gbPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSil = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblguncelle = new System.Windows.Forms.Label();
            this.lblekle = new System.Windows.Forms.Label();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelleIK = new System.Windows.Forms.Button();
            this.dgvPersonelListele = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.gbPersonelBilgileri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblKapat);
            this.panel2.Location = new System.Drawing.Point(68, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 37);
            this.panel2.TabIndex = 108;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources._1486564399_close_81512;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(1015, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 25);
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
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(364, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 22);
            this.label4.TabIndex = 108;
            this.label4.Text = "İNSAN KAYNAKLARI DEPARTMANI";
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKapat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKapat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.DimGray;
            this.lblKapat.Location = new System.Drawing.Point(965, 12);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(44, 18);
            this.lblKapat.TabIndex = 188;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Visible = false;
            // 
            // gbPersonelBilgileri
            // 
            this.gbPersonelBilgileri.BackColor = System.Drawing.Color.DimGray;
            this.gbPersonelBilgileri.Controls.Add(this.groupBox2);
            this.gbPersonelBilgileri.Controls.Add(this.dgvPersonelListele);
            this.gbPersonelBilgileri.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbPersonelBilgileri.Location = new System.Drawing.Point(62, 55);
            this.gbPersonelBilgileri.Name = "gbPersonelBilgileri";
            this.gbPersonelBilgileri.Size = new System.Drawing.Size(1064, 546);
            this.gbPersonelBilgileri.TabIndex = 107;
            this.gbPersonelBilgileri.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.lblSil);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.lblguncelle);
            this.groupBox2.Controls.Add(this.lblekle);
            this.groupBox2.Controls.Add(this.btnPersonelListele);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPersonelAra);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnGuncelleIK);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 219);
            this.groupBox2.TabIndex = 179;
            this.groupBox2.TabStop = false;
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.ForeColor = System.Drawing.Color.DimGray;
            this.lblSil.Location = new System.Drawing.Point(869, 131);
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
            this.btnSil.Location = new System.Drawing.Point(865, 152);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 46);
            this.btnSil.TabIndex = 199;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // lblguncelle
            // 
            this.lblguncelle.AutoSize = true;
            this.lblguncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblguncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblguncelle.Location = new System.Drawing.Point(908, 131);
            this.lblguncelle.Name = "lblguncelle";
            this.lblguncelle.Size = new System.Drawing.Size(61, 18);
            this.lblguncelle.TabIndex = 187;
            this.lblguncelle.Text = "Güncelle";
            this.lblguncelle.Visible = false;
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.ForeColor = System.Drawing.Color.DimGray;
            this.lblekle.Location = new System.Drawing.Point(985, 130);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(36, 18);
            this.lblekle.TabIndex = 186;
            this.lblekle.Text = "Ekle";
            this.lblekle.Visible = false;
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelListele.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.kaydet_icon_png_5;
            this.btnPersonelListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelListele.Location = new System.Drawing.Point(971, 152);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(47, 46);
            this.btnPersonelListele.TabIndex = 174;
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            this.btnPersonelListele.MouseLeave += new System.EventHandler(this.btnPersonelListele_MouseLeave);
            this.btnPersonelListele.MouseHover += new System.EventHandler(this.btnPersonelListele_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(582, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Personel Ara :";
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPersonelAra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAra.ForeColor = System.Drawing.Color.DimGray;
            this.txtPersonelAra.Location = new System.Drawing.Point(686, 176);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(173, 22);
            this.txtPersonelAra.TabIndex = 111;
            this.txtPersonelAra.TextChanged += new System.EventHandler(this.txtPersonelAra_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::YukleniciOtomasyon.WinUI.Properties.Resources.user_1275780_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(32, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuncelleIK
            // 
            this.btnGuncelleIK.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelleIK.BackgroundImage = global::YukleniciOtomasyon.WinUI.Properties.Resources.refresh_2_91000;
            this.btnGuncelleIK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelleIK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelleIK.Location = new System.Drawing.Point(918, 152);
            this.btnGuncelleIK.Name = "btnGuncelleIK";
            this.btnGuncelleIK.Size = new System.Drawing.Size(47, 46);
            this.btnGuncelleIK.TabIndex = 126;
            this.btnGuncelleIK.UseVisualStyleBackColor = false;
            this.btnGuncelleIK.Click += new System.EventHandler(this.btnGuncelleIK_Click);
            this.btnGuncelleIK.MouseLeave += new System.EventHandler(this.btnGuncelleIK_MouseLeave);
            this.btnGuncelleIK.MouseHover += new System.EventHandler(this.btnGuncelleIK_MouseHover);
            // 
            // dgvPersonelListele
            // 
            this.dgvPersonelListele.AllowUserToAddRows = false;
            this.dgvPersonelListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonelListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonelListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonelListele.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonelListele.Location = new System.Drawing.Point(6, 237);
            this.dgvPersonelListele.Name = "dgvPersonelListele";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            this.dgvPersonelListele.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPersonelListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonelListele.Size = new System.Drawing.Size(1052, 292);
            this.dgvPersonelListele.TabIndex = 114;
            this.dgvPersonelListele.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonelListele_CellMouseDoubleClick);
            // 
            // frmIKBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbPersonelBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIKBirimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonelListele";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmIKBirimi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbPersonelBilgileri.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPersonelBilgileri;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersonelListele;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnGuncelleIK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label lblguncelle;
        private System.Windows.Forms.Label lblekle;
        private Label lblSil;
        private Button btnSil;
    }
}