using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.SatinAlma;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.WinUI.SatinAlma
{
    public partial class frmyanSatinAlmaListele : Form
    {
        SatinAlmalar _secilenSatinAlma;
        SatinAlmalarService _satinAlmaService;
        T_MalzemeService _malzemeService;
        T_MalzemeFiyatService _malzemeFiyatiService;
        T_Malzeme _malzemeler;
        T_MalzemeFiyat _malzemeFiyati;
        T_TedarikciFirmaService _firmaService;
        T_TedarikciFirma _firma;


        public frmyanSatinAlmaListele()
        {
            InitializeComponent();
            _malzemeService = new T_MalzemeService();
            _malzemeFiyatiService = new T_MalzemeFiyatService();
            _firmaService = new T_TedarikciFirmaService();
            _secilenSatinAlma = new SatinAlmalar();

            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            CheckboxColumn.Width = 40;
            dgvMalzemeListele.Columns.Add(CheckboxColumn);
        }
        #region design
        bool move;
        int mouse_x;
        int mouse_y;

        private void frmyanSatinAlmaListele_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmyanSatinAlmaListele_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmyanSatinAlmaListele_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            frmyanMalzemeBilgisi_Listele malzemeEkle = new frmyanMalzemeBilgisi_Listele();
            malzemeEkle.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmyanTedarikciFirma_Listele tedarikciFirmalar = new frmyanTedarikciFirma_Listele();
            tedarikciFirmalar.Show();
        }

        private void frmyanSatinAlmaListele_Load(object sender, EventArgs e)
        {
           
            if (Tag == null)
            {
                dgvMalzemeListele.DataSource = null;
                dgvMalzemeListele.DataSource = _malzemeService.TumMalzemeleriGetirService();
               // dgvMalzemeListele.DataSource = _malzemeFiyatiService.TumMalzemeFiyatlariniGetirService();
                cmbFirmaAdi.Items.Add(_firmaService.TumTedarikciFirmalariGetirService());
                _secilenSatinAlma = new SatinAlmalar();
            }
            else
            {
                frmSatinAlmaBirimi satinAlma =new frmSatinAlmaBirimi();
                _secilenSatinAlma = (SatinAlmalar)satinAlma.Tag;

                dtpSatinAlmaTarihi.Value = _secilenSatinAlma.SatinAlmaTarihi;
                dtpTeslimTarihi.Value = _secilenSatinAlma.TeslimTarihi;
                cmbOdemeTipi.SelectedItem = _secilenSatinAlma.OdemeTuru;
                cmbCekVadesi.SelectedItem = _secilenSatinAlma.CekVadesi;
                cmbFirmaAdi.SelectedItem = _secilenSatinAlma.TedarikciFirma;
                txtToplamFiyat.Text = _secilenSatinAlma.ToplamFiyat.ToString();

                dgvMalzemeListele.DataSource = null;
                dgvMalzemeListele.DataSource = _malzemeService.TumMalzemeleriGetirService();
                //dgvMalzemeListele.DataSource = _secilenSatinAlma.AlinanMalzemeler.ToString();
            }
        }

        private void chkItems_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMalzemeListele.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                if (chk.Selected == true)
                {
                    int seciliMalzeme = Convert.ToInt32(dgvMalzemeListele.SelectedRows[0].Cells[1].Value);
                    _malzemeler = _malzemeService.BirMalzemeGetirService(seciliMalzeme);
                    _malzemeFiyati = _malzemeFiyatiService.MalzemeFiyatiGetirService(seciliMalzeme);
                    chk.Selected = false;
                }
                else
                {
                    chk.Selected = true;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _secilenSatinAlma.SatinAlmaTarihi = dtpSatinAlmaTarihi.Value;
            _secilenSatinAlma.TeslimTarihi = dtpTeslimTarihi.Value;
            _secilenSatinAlma.OdemeTuru = (OdemeTurleri)cmbOdemeTipi.SelectedIndex;
            _secilenSatinAlma.CekVadesi = (CekVadeleri)cmbCekVadesi.SelectedIndex;
            _secilenSatinAlma.TedarikciFirma = (T_TedarikciFirma)cmbFirmaAdi.SelectedItem;
            _secilenSatinAlma.ToplamFiyat = Convert.ToDecimal(txtToplamFiyat.Text);
            _malzemeService.UpdateMalzemeService(_malzemeler);
            _secilenSatinAlma.DuzenlenmeTarihi = DateTime.Now;
            _secilenSatinAlma.AktifMi = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _secilenSatinAlma.SatinAlmaTarihi = dtpSatinAlmaTarihi.Value;
            _secilenSatinAlma.TeslimTarihi = dtpTeslimTarihi.Value;
            _secilenSatinAlma.OdemeTuru = (OdemeTurleri)cmbOdemeTipi.SelectedIndex;
            _secilenSatinAlma.CekVadesi = (CekVadeleri)cmbCekVadesi.SelectedIndex;
            _secilenSatinAlma.TedarikciFirma = (T_TedarikciFirma)cmbFirmaAdi.SelectedItem;
            _secilenSatinAlma.ToplamFiyat = Convert.ToDecimal(txtToplamFiyat.Text);
            _malzemeService.AddMalzemeService(_malzemeler);
            _secilenSatinAlma.OlusturulmaTarihi = DateTime.Now;
            _secilenSatinAlma.AktifMi = true;
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            lblGuncelle.Visible = true;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelle.Visible = false;
        }

        private void btnTedarikciGetir_MouseHover(object sender, EventArgs e)
        {
            lblTedarikci.Visible = true;
        }

        private void btnTedarikciGetir_MouseLeave(object sender, EventArgs e)
        {
            lblTedarikci.Visible = false;
        }

        private void btnMalzemeGetir_MouseHover(object sender, EventArgs e)
        {
            lblMalzeme.Visible = true;
        }

        private void btnMalzemeGetir_MouseLeave(object sender, EventArgs e)
        {
            lblMalzeme.Visible = false;
        }
    }
}
