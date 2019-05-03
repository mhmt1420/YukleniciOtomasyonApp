using HataMesaji;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Teklif;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.WinUI.Teklif
{
    public partial class frmyanİhaleKaydet : Form
    {
        public frmyanİhaleKaydet()
        {
            InitializeComponent();
        }

        private AcilanIhaleler _acilanIhaleler;
        private List<AcilanIhaleler> _tumacilanIhaleler;
        private AcilanIhalelerService _acilanIhalelerService;
        private TeklifBirimi _teklifBirimi;
        private TeklifBirimiService _teklifBirimiService;
        private TeklifBirimiDTO teklifBirimiDTO;

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIhaleEvraklariListele_Click(object sender, EventArgs e)
        {
            frmİhaleEvraklari ihaleEvraklari = new frmİhaleEvraklari();
            ihaleEvraklari.Tag = _acilanIhaleler;
            ihaleEvraklari.Show();
        }

        private bool move;
        private int mouse_x;
        private int mouse_y;

        private void frmİhaleKaydet_MouseDown_1(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmİhaleKaydet_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmİhaleKaydet_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmyanİhaleKaydet_Load(object sender, EventArgs e)
        {
            _teklifBirimiService = new TeklifBirimiService();
            _acilanIhaleler = new AcilanIhaleler();
            if (Tag != null)
            {
                _acilanIhalelerService = new AcilanIhalelerService();
                _teklifBirimi = (TeklifBirimi)Tag;
                DGVDTOAyar("");
            }
            else
            {
                _teklifBirimi = new TeklifBirimi();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            _acilanIhaleler.KurumFirmaAdi = HataMesajiVerme.HarfMi(txtKurum_FirmaAdi);
            _acilanIhaleler.IsTanimi = txtKurum_FirmaAdi.Text;
            _acilanIhaleler.KurumFirmaAdi = txtKurum_FirmaAdi.Text;
            _acilanIhaleler.IhaleTarihSaat = dtpIhaleTarihi_Saati.Value;
            _acilanIhaleler.IsBaslangicTarihi = dtpIsBaslangicTarihi.Value;
            _acilanIhaleler.IsBitisTarihi = dtpIsBitisTarihi.Value;
            _acilanIhaleler.IhaleyiAlanFirmaAdi = HataMesajiVerme.HarfMi(txtIhaleyiAlanFirmaAdi);
            _acilanIhaleler.AlanFirmaninTeklifi = txtFirmaninTeklifTutari.Text;
            _teklifBirimi.KatilimSaglananIhaleler.Add(_acilanIhaleler);
            bool durum = false;
            if (_teklifBirimi != null)
            {
                durum = _teklifBirimiService.UpdateTeklifBirimi(_teklifBirimi) > 0;
            }
            else
            {
                durum = _teklifBirimiService.AddTeklifBirimiService(_teklifBirimi) > 0;
            }

            if (durum)
            {
                MessageBox.Show("Başarıyla Eklendi!");
            }
            DGVDTOAyar("");
        }

        private void btnTeknikSartname_Click(object sender, EventArgs e)
        {
            if (_acilanIhaleler is null)
            {
                MessageBox.Show("Lutfen İhale Seçiniz!");
            }
            else
            {
                string destination = DosyaAcici.DosyaSec(_acilanIhaleler.Id, out string filename);
                if (!string.IsNullOrEmpty(destination))
                {
                    txtTeknikSartname.Text = filename;
                    _acilanIhaleler.TeknikSartname = destination;
                }
            }

        }

        private void btnIdariSartname_Click(object sender, EventArgs e)
        {
            if (_acilanIhaleler is null)
            {
                MessageBox.Show("Lutfen İhale Seçiniz!");
            }
            else
            {
                string destination = DosyaAcici.DosyaSec(_acilanIhaleler.Id, out string filename);
                if (!string.IsNullOrEmpty(destination))
                {
                    txtIdariSartname.Text = filename;
                    _acilanIhaleler.IdariSartname = destination;
                }
            }
        }

        private void btnSozlesmeTaslagi_Click(object sender, EventArgs e)
        {
            if (_acilanIhaleler is null)
            {
                MessageBox.Show("Lutfen İhale Seçiniz!");
            }
            else
            {
                string destination = DosyaAcici.DosyaSec(_acilanIhaleler.Id, out string filename);
                if (!string.IsNullOrEmpty(destination))
                {
                    txtSozlesmeTaslagi.Text = filename;
                    _acilanIhaleler.SozlesmeTaslagi = destination;
                }
            }
        }

        private void dgvAcilanİhalelerListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAcilanİhalelerListele.SelectedRows[0].DataBoundItem != null)
            {
                int seciliAcilanIhalelerId = Convert.ToInt32(dgvAcilanİhalelerListele.SelectedRows[0].Cells["IhaleEvraklariId"].Value);
                _acilanIhaleler = _acilanIhalelerService.BirIhaleGetirService(seciliAcilanIhalelerId);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _acilanIhalelerService.UpdateAcilanIhalelerService(_acilanIhaleler);
            MessageBox.Show("Başarıyla Güncellendi!");
            DGVDTOAyar("");
        }

        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = false;
        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            lblKaydet.Visible = true;
        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            lblKaydet.Visible = false;
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            lblGuncelle.Visible = true;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelle.Visible = false;
        }

        private void btnDuzenle_MouseHover(object sender, EventArgs e)
        {
            lblDuzenle.Visible = true;
        }

        private void btnDuzenle_MouseLeave(object sender, EventArgs e)
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

        public void DGVDTOAyar(string text)
        {
            dgvAcilanİhalelerListele.DataSource = null;

            if (string.IsNullOrEmpty(text))
            {
                dgvAcilanİhalelerListele.DataSource = _teklifBirimiService.DTOTeklifBirimiGetirService();
            }
            dgvAcilanİhalelerListele.DataSource = _teklifBirimiService.DTOTeklifBirimiGetirService(_teklifBirimi.Id);

            foreach (DataGridViewColumn item in dgvAcilanİhalelerListele.Columns)
            {
                item.Visible = false;

            }
            dgvAcilanİhalelerListele.Columns["TeklifBirimiId"].Visible = true;
            dgvAcilanİhalelerListele.Columns["AcilanIhalelerId"].Visible = true;
            dgvAcilanİhalelerListele.Columns["BirimAdi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["KurumFirmaAdi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["IsinAdi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["IsTanimi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["IsBaslangicTarihi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["IsBitisTarihi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["IhaleyiAlanFirmaAdi"].Visible = true;
            dgvAcilanİhalelerListele.Columns["AlanFirmaninTeklifi"].Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _acilanIhalelerService.DeleteAcilanIhalelerService(_acilanIhaleler);
            MessageBox.Show("Başarıyla Silindi!");
            DGVDTOAyar("");
        }

        private void txtIhaleAra_TextChanged(object sender, EventArgs e)
        {
            dgvAcilanİhalelerListele.DataSource = null;
            DGVDTOAyar(txtIhaleAra.Text);
            if (string.IsNullOrEmpty(txtIhaleAra.Text))
            {
                DGVDTOAyar("");
            }
        }

        private void dgvAcilanİhalelerListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKurum_FirmaAdi.Text = _acilanIhaleler.KurumFirmaAdi;
            txtIsTanimi.Text = _acilanIhaleler.IsTanimi;
            txtİhaleOturumAdres.Text = _acilanIhaleler.IhaleOturumAdresi;
            dtpIhaleTarihi_Saati.Value = _acilanIhaleler.IhaleTarihSaat;
            dtpIsBaslangicTarihi.Value = _acilanIhaleler.IsBaslangicTarihi;
            dtpIsBitisTarihi.Value = _acilanIhaleler.IsBitisTarihi;
            txtIhaleyiAlanFirmaAdi.Text = _acilanIhaleler.IhaleyiAlanFirmaAdi;
            txtFirmaninTeklifTutari.Text = _acilanIhaleler.AlanFirmaninTeklifi;
        }
    }
}
