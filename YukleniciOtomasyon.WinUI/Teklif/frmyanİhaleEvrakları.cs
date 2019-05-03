using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Teklif;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.WinUI.Teklif
{
    public partial class frmİhaleEvraklari : Form
    {
        public frmİhaleEvraklari()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        AcilanIhaleler _acilanIhaleler; 
        AcilanIhalelerService _acilanIhalelerService;
        T_IhaleEvraklari _ihaleEvraklari;
        T_IhaleEvraklariService _ihaleEvraklariService;
        TeklifBirimiService _teklifBirimiService;

        private void frmİhaleEvraklari_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmİhaleEvraklari_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmİhaleEvraklari_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmİhaleEvraklari_Load(object sender, EventArgs e)
        {
            _acilanIhaleler = (AcilanIhaleler)Tag;
            _acilanIhalelerService = new AcilanIhalelerService();
            _ihaleEvraklari = new T_IhaleEvraklari();
            _teklifBirimiService = new TeklifBirimiService();
            dgvIhaleEvraklari.DataSource = _teklifBirimiService.DTOTeklifBirimiGetirService(_acilanIhaleler.Id);
        }

        private void btnTicaretOdasiKayitBelgesi_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtTicaretOdasiKayitBelgesi.Text = filename;
                _ihaleEvraklari.TicaretOdasiKayitBelgesi = destination;
            }
        }

        private void btnImzaSirkuleri_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtImzaSirkuleri.Text = filename;
                _ihaleEvraklari.ImzaSirkuleri = destination;
            }
        }

        private void btnTeklifMektubu_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtTeklifMektubu.Text = filename;
                _ihaleEvraklari.TeklifMektubu = destination;
            }
        }

        private void btnGeciciTeminatMektubu_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtGeciciTeminatMektubu.Text = filename;
                _ihaleEvraklari.GeciciTeminatMektubu = destination;
            }
        }

        private void btnIsBitirmeBelgesi_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtIsBitirmeBelgesi.Text = filename;
                _ihaleEvraklari.IsBitirmeBelgesi = destination;
            }
        }

        private void btnVekaletname_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtVekaletname.Text = filename;
                _ihaleEvraklari.Vekaletname = destination;
            }
        }

        private void btnOrtakilBeyannamesi_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtOrtaklikBeyannamesi.Text = filename;
                _ihaleEvraklari.OrtaklikBeyannamesi = destination;
            }
        }

        private void btnBankaReferansMektubu_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtBankaReferansMektubu.Text = filename;
                _ihaleEvraklari.BankaReferansMektubu = destination;
            }
        }

        private void btnMeslekiYeterlilik_Click(object sender, EventArgs e)
        {
            string destination = DosyaAcici.DosyaSec(_ihaleEvraklari.Id, out string filename);
            if (!string.IsNullOrEmpty(destination))
            {
                txtMeslekiYeterlilik.Text = filename;
                _ihaleEvraklari.MeslekiYeterlilik = destination;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _acilanIhaleler.HazirlananEvraklar.Add(_ihaleEvraklari);
            bool durum = _acilanIhalelerService.AddAcilanIhalelerService(_acilanIhaleler) >0 ;
            if (durum)
            {
                MessageBox.Show("Başarıyla Kaydedildi!");
            }
            else
            {
                MessageBox.Show("Hata! Evraklar Kaydedilemedi!");
            }
            dgvIhaleEvraklari.DataSource = _ihaleEvraklari;
        }

        private void dgvIhaleEvraklari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIhaleEvraklari.SelectedRows[0].DataBoundItem != null)
            {
                int seciliIhaleEvraklariId = Convert.ToInt32(dgvIhaleEvraklari.SelectedRows[0].Cells["IhaleEvraklariId"].Value);
                _ihaleEvraklari = _ihaleEvraklariService.IhaleEvragiGetirService(seciliIhaleEvraklariId);

            }
        }

        private void dgvIhaleEvraklari_SelectionChanged(object sender, EventArgs e)
        {
            txtTicaretOdasiKayitBelgesi.Text = _ihaleEvraklari.TicaretOdasiKayitBelgesi;
            txtImzaSirkuleri.Text = _ihaleEvraklari.ImzaSirkuleri;
            txtTeklifMektubu.Text = _ihaleEvraklari.TeklifMektubu;
            txtGeciciTeminatMektubu.Text = _ihaleEvraklari.GeciciTeminatMektubu;
            txtIsBitirmeBelgesi.Text= _ihaleEvraklari.IsBitirmeBelgesi;
            txtVekaletname.Text= _ihaleEvraklari.Vekaletname;
            txtOrtaklikBeyannamesi.Text = _ihaleEvraklari.OrtaklikBeyannamesi;
            txtBankaReferansMektubu.Text= _ihaleEvraklari.BankaReferansMektubu;
            txtMeslekiYeterlilik.Text = _ihaleEvraklari.MeslekiYeterlilik;
        }

        private void txtEvrakAra_TextChanged(object sender, EventArgs e)
        {
            dgvIhaleEvraklari.DataSource = null;
            DGVDTOAyar(txtEvrakAra.Text);
            if (string.IsNullOrEmpty(txtEvrakAra.Text))
            {
                DGVDTOAyar("");
            }
        }
        public void DGVDTOAyar(string text)
        {
            dgvIhaleEvraklari.DataSource = null;
            dgvIhaleEvraklari.DataSource = _teklifBirimiService.DTOTeklifBirimiGetirService(_acilanIhaleler, text);
            foreach (DataGridViewColumn item in dgvIhaleEvraklari.Columns)
            {
                item.Visible = false;

            }
            dgvIhaleEvraklari.Columns["AcilanIhalelerId"].Visible = true;
            dgvIhaleEvraklari.Columns["IhaleEvraklariId"].Visible = true;
            dgvIhaleEvraklari.Columns["IsinAdi"].Visible = true;
            dgvIhaleEvraklari.Columns["IsTanimi"].Visible = true;
            dgvIhaleEvraklari.Columns["TeknikSartname"].Visible = true;
            dgvIhaleEvraklari.Columns["IdariSartname"].Visible = true;
            dgvIhaleEvraklari.Columns["SozlesmeTaslagi"].Visible = true;
            dgvIhaleEvraklari.Columns["TicaretOdasiKayitBelgesi"].Visible = true;
            dgvIhaleEvraklari.Columns["ImzaSirkuleri"].Visible = true;
            dgvIhaleEvraklari.Columns["TeklifMektubu"].Visible = true;
            dgvIhaleEvraklari.Columns["GeciciTeminatMektubu"].Visible = true;
            dgvIhaleEvraklari.Columns["IsBitirmeBelgesi"].Visible = true;
            dgvIhaleEvraklari.Columns["Vekaletname"].Visible = true;
            dgvIhaleEvraklari.Columns["OrtaklikBeyannamesi"].Visible = true;
            dgvIhaleEvraklari.Columns["BankaReferansMektubu"].Visible = true;
            dgvIhaleEvraklari.Columns["MeslekiYeterlilik"].Visible = true;

        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            lblSil.Visible = true;

        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            lblSil.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_ihaleEvraklari !=null)
            {
            _ihaleEvraklariService.DeleteT_IhaleEvraklariService(_ihaleEvraklari);
                MessageBox.Show("Test");
            }
            else
            {
                MessageBox.Show("İhale Seçiniz!");
            }
        }

        private void dgvIhaleEvraklari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_ihaleEvraklari != null)
            {
            _ihaleEvraklariService.UpdateT_IhaleEvraklariService(_ihaleEvraklari);
            MessageBox.Show("Başarıyla Güncellendi!");
            }
            else
            {
                MessageBox.Show("Hata! Güncellemek İçin Lütfen İhale Seçiniz");
            }
            DGVDTOAyar("");
        }
    }
}
