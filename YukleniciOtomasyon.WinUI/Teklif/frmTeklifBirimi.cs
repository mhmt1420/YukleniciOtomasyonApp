using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Teklif;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.WinUI.Teklif
{
    public partial class frmTeklifBirimi : Form
    {
        public frmTeklifBirimi()
        {
            InitializeComponent();
        }

        AcilanIhaleler _acilanIhaleler = new AcilanIhaleler();
        AcilanIhalelerService _acilanIhalelerService = new AcilanIhalelerService();
        TeklifBirimi _teklifBirimi = new TeklifBirimi();
        TeklifBirimiService _teklifBirimiService = new TeklifBirimiService();


        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmyanİhaleKaydet ihaleKaydet = new frmyanİhaleKaydet();
            ihaleKaydet.Show();
        }
        public static frmTeklifBirimi frmTeklif;
        private void frmTeklifBirimi_Load(object sender, EventArgs e)
        {
            DGVDTOAyar("");
        }

        private void txtIhaleAra_TextChanged(object sender, EventArgs e)
        {
            dgvTekliflerListele.DataSource = null;
            DGVDTOAyar(txtIhaleAra.Text);
            if (string.IsNullOrEmpty(txtIhaleAra.Text))
            {
                DGVDTOAyar("");
            }
        }

        private void btnGunccelle_Click(object sender, EventArgs e)
        {
            frmyanİhaleKaydet ihaleKaydet = new frmyanİhaleKaydet
            {
                Tag = _teklifBirimi
            };
            ihaleKaydet.Show();
        }

        private void dgvTekliflerListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTekliflerListele.SelectedRows[0].DataBoundItem != null)
            {
                //teklifBirimi = teklifBirimiService.BirTeklifBirimiGetirService(dgvTekliflerListele.SelectedRows[0].Index);
                int seciliTeklifBirimiId = Convert.ToInt32(dgvTekliflerListele.SelectedRows[0].Cells["TeklifBirimiId"].Value);
                _teklifBirimi = _teklifBirimiService.BirTeklifBirimiGetirService(seciliTeklifBirimiId);
            }
        }
        public void DGVDTOAyar(string text)
        {
            dgvTekliflerListele.DataSource = _teklifBirimiService.DTOTeklifBirimiGetirService(_teklifBirimi, text);
            foreach (DataGridViewColumn item in dgvTekliflerListele.Columns)
            {
                item.Visible = false;

            }
            //dgvTekliflerListele.Columns["TeklifBirimiId"].Visible = true;
            //dgvTekliflerListele.Columns["AcilanIhalelerId"].Visible = true;
            dgvTekliflerListele.Columns["BirimAdi"].Visible = true;
            dgvTekliflerListele.Columns["KurumFirmaAdi"].Visible = true;
            dgvTekliflerListele.Columns["IsinAdi"].Visible = true;
            dgvTekliflerListele.Columns["IsTanimi"].Visible = true;
        }
        #region labels
        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            lblKapat.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.Visible = false;
        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            lblEkle.Visible = true;
        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            lblEkle.Visible = false;
        }

        private void btnGunccelle_MouseHover(object sender, EventArgs e)
        {
            lblDuzenle.Visible = true;
        }

        private void btnGunccelle_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenle.Visible = false;
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            lblSil.Visible = true;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            lblSil.Visible = false;
        }
        #endregion
        private void btnSil_Click(object sender, EventArgs e)
        {
            _teklifBirimiService.DeleteTeklifBirimiService(_teklifBirimi);
            DGVDTOAyar("");
        }
    }
}
