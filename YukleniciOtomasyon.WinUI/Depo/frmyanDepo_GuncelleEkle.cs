using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Depo;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.WinUI.Depo
{
    public partial class frmyanDepo_GuncelleEkle : Form
    {
        public frmyanDepo_GuncelleEkle()
        {
            InitializeComponent();
        }
        Depolar _depolar;

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region design
        bool move;
        int mouse_x;
        int mouse_y;

        private void frmyanDepo_GuncelleEkle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmyanDepo_GuncelleEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmyanDepo_GuncelleEkle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
#endregion
        #region labels
        private void btnKaydetDepoOzellik_MouseHover(object sender, EventArgs e)
        {
            lblKaydetDepoOzellik.Visible = true;
        }

        private void btnKaydetDepoOzellik_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetDepoOzellik.Visible = false;
        }

        private void btnGuncelleDepoOzellik_MouseHover(object sender, EventArgs e)
        {
            lblGuncelleDepoOzellik.Visible = true;
        }
        private void btnGuncelleDepoOzellik_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelleDepoOzellik.Visible = false;
        }

        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = false;
        }

        private void btnSilDepoOzellik_MouseHover(object sender, EventArgs e)
        {
            lblSilDepoOzellik.Visible = true;
        }

        private void btnSilDepoOzellik_MouseLeave(object sender, EventArgs e)
        {
            lblSilDepoOzellik.Visible = false;
        }
        
        private void btnSilMalzeme_MouseHover(object sender, EventArgs e)
        {
            lblsilMalzeme.Visible = true;
        }

        private void btnSilMalzeme_MouseLeave(object sender, EventArgs e)
        {
            lblsilMalzeme.Visible = false;
        }

        private void btnDuzenleMalzeme_MouseHover(object sender, EventArgs e)
        {
            lblDuzenleMalzeme.Visible = true;
        }

        private void btnDuzenleMalzeme_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenleMalzeme.Visible = false;
        }

        private void btnEkleMalzeme_MouseHover(object sender, EventArgs e)
        {
            lblEkleMalzeme.Visible = true;
        }

        private void btnEkleMalzeme_MouseLeave(object sender, EventArgs e)
        {
            lblEkleMalzeme.Visible = false;
        }
        #endregion

        DepolarService _depolarService = new DepolarService();
        T_Malzeme _Malzeme = new T_Malzeme();
        T_MalzemeService _MalzemeService = new T_MalzemeService();
        T_DepoOzellikleriService _DepoOzellikleriService = new T_DepoOzellikleriService();
        int _seciliDepoID;
        //DepolarService _seciliDepo;
        //T_MalzemeService _seciliMalzeme;
        //T_DepoOzellikleriService _seciliDepoOzellik;
        T_DepoOzellikleri depoOzellikleri;
        List<T_DepoOzellikleri> depoOzellikleriListesi;
        List<T_Malzeme> _malzemeler;


        public void DepoOzellikDoldur()
        {
            dgvDepoOzellikListele.DataSource = null;
            depoOzellikleriListesi = new List<T_DepoOzellikleri>();
            foreach (var item in _depolar.DepoOzellikleri)
            {
                depoOzellikleriListesi.Add(_DepoOzellikleriService.DepoOzelligiGetirService(item.Id));
            }
            
            dgvDepoOzellikListele.DataSource = depoOzellikleriListesi;
        }

        public void MalzemeDoldur()
        {
            dgvMalzemeListele.DataSource = null;
            _malzemeler = _MalzemeService.TumMalzemeleriGetirService();
            foreach (var item in _depolar.DepodakiMalzemeler)
            {
                _malzemeler.Add(_MalzemeService.BirMalzemeGetirService(item.Id));
            }

            dgvMalzemeListele.DataSource = _malzemeler;
        }

        private void btnKaydetDepoOzellik_Click(object sender, EventArgs e)
        {
            T_DepoOzellikleri depoOzellikleri = new T_DepoOzellikleri();

            depoOzellikleri.Ad = txtDepoAdi.Text;
            depoOzellikleri.Boyutu = txtBoyutu.Text;
            depoOzellikleri.Adres = txtAdresi.Text;
            depoOzellikleri.AktifMi = true;
            depoOzellikleri.OlusturulmaTarihi = DateTime.Now;
            _depolar.DepoOzellikleri.Add(depoOzellikleri);
            //depoOzellikleri.DepolarId = _seciliDepoID;

            int etkilenen = _depolarService.DepolarUpdate(_depolar);
            if (etkilenen>0)
            {
                MessageBox.Show("Depo Özelliği başarıyla eklenmiştir.");
            }
            DepoOzellikDoldur();
        }

        private void btnKaydetDepo_Click(object sender, EventArgs e)
        {
            _depolar.DepoAdi = txtDepoAdi.Text;

            //depo.DepoOzellikleri = dgvDepoOzellikListele.SelectedRows.
            _depolar.AktifMi = true;
            _depolar.OlusturulmaTarihi = DateTime.Now;
        }

        private void frmyanDepo_GuncelleEkle_Load(object sender, EventArgs e)
        {
            if (Tag !=null)
            {
                _depolar = (Depolar)Tag;

            }
            else
            {
                _depolar = new Depolar();
            }
            DepoOzellikDoldur();
            MalzemeDoldur();
        }

        private void btnGuncelleDepoOzellik_Click(object sender, EventArgs e)
        {
            if (depoOzellikleri !=null)
            {
                depoOzellikleri.Boyutu = txtBoyutu.Text;
                depoOzellikleri.Adres = txtAdresi.Text;
                depoOzellikleri.Ad = txtDepoAdi.Text;
                _depolar.DepoOzellikleri.Add(depoOzellikleri);
                _depolarService.DepolarUpdate(_depolar);

            }
            else
            {
                MessageBox.Show("Depo Özelliği Seçi");
            }
        }

        private void dgvDepoOzellikListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepoOzellikListele.SelectedRows[0].DataBoundItem != null)
            {
                int seciliDepoOzellikId = Convert.ToInt32(dgvDepoOzellikListele.SelectedRows[0].Cells["Id"].Value);
                depoOzellikleri = _DepoOzellikleriService.DepoOzelligiGetirService(seciliDepoOzellikId);
                txtDepoAdi.Text = depoOzellikleri.Ad;
                txtAdresi.Text = depoOzellikleri.Adres;
                txtBoyutu.Text = depoOzellikleri.Boyutu;
            }
        }

        private void btnSilDepoOzellik_Click(object sender, EventArgs e)
        {
            if (_depolar != null)
            {
                _depolar.DepoOzellikleri.Remove(depoOzellikleri);
                _depolarService.DepolarUpdate(_depolar);
            }
            else
            {
                MessageBox.Show("Depo Özelliği Seçi");
            }
        }

        private void btnEkleMalzeme_Click(object sender, EventArgs e)
        {
            frmyanMalzemeBilgisi_Listele frmyanMalzemeBilgisi_Listele = new frmyanMalzemeBilgisi_Listele();
        }

        private void btnDuzenleMalzeme_Click(object sender, EventArgs e)
        {
            frmyanMalzemeBilgisi_Listele frmyanMalzemeBilgisi_Listele = new frmyanMalzemeBilgisi_Listele();
            frmyanMalzemeBilgisi_Listele.Tag = _Malzeme;
        }

        private void btnSilMalzeme_Click(object sender, EventArgs e)
        {
            if (_Malzeme != null)
            {
                _MalzemeService.DeleteMalzemeService(_Malzeme);
            }
            else
            {
                MessageBox.Show("Malzeme Seçiniz!");
            }
        }

        private void dgvMalzemeListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dgvMalzemeListele.SelectedRows[0].DataBoundItem != null)
            {
                int seciliMalzemeId = Convert.ToInt32(dgvMalzemeListele.SelectedRows[0].Cells["Id"].Value);
                _Malzeme = _MalzemeService.BirMalzemeGetirService(seciliMalzemeId);
                txtDepoAdi.Text = depoOzellikleri.Ad;
                txtAdresi.Text = depoOzellikleri.Adres;
                txtBoyutu.Text = depoOzellikleri.Boyutu;
            }
        }
    }
}
