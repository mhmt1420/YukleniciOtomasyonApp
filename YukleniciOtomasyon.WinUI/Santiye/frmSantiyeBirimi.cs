using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Santiye;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.WinUI.Santiye
{
    public partial class frmSantiyeBirimi : Form
    {
        frmyanSantiye_GuncelleEkle santiye_GuncelleEkle;
        Santiyeler _santiyeler = new Santiyeler();
        SantiyeBirimiService _santiyeBirimiService = new SantiyeBirimiService();
        List<Santiyeler> _santiyelerListesi;
        SantiyeBirimiDTO santiyeBirimiDTO = new SantiyeBirimiDTO();
        SantiyelerService _santiyelerService = new SantiyelerService();

        public frmSantiyeBirimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            santiye_GuncelleEkle = new frmyanSantiye_GuncelleEkle();
            santiye_GuncelleEkle.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            lblEkle.Visible = true;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            lblEkle.Visible = false;
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
        #endregion

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            santiye_GuncelleEkle = new frmyanSantiye_GuncelleEkle
            {
                Tag = _santiyeler
            };
            santiye_GuncelleEkle.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _santiyelerService.SantiyelerSilService(_santiyeler);
            santiyeBirimiDoldur();
        }

        private void frmSantiyeBirimi_Load(object sender, EventArgs e)
        {
            dgvSantiye_MalzemeListele.DataSource = null;
            santiyeBirimiDoldur();
        }

        private void txtSantiyeAra_TextChanged(object sender, EventArgs e)
        {
            dgvSantiye_MalzemeListele.DataSource = null;
            santiyeBirimiDoldur(txtSantiyeAra.Text);
        }

        private void dgvSantiye_MalzemeListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSantiye_MalzemeListele.SelectedRows[0].DataBoundItem != null)
            {
                int seciliSantiyeId = Convert.ToInt32(dgvSantiye_MalzemeListele.SelectedRows[0].Cells["Id"].Value);
                _santiyeler = _santiyelerService.BirSantiyeGetirService(seciliSantiyeId);
            }
        }

        public void santiyeBirimiDoldur(string a)
        {
            dgvSantiye_MalzemeListele.DataSource = null;
            _santiyelerListesi = _santiyelerService.SantiyeAraService(a);
            //dgvSantiye_MalzemeListele.DataSource = _santiyelerListesi;
            dgvSantiye_MalzemeListele.Columns["SantiyeBirimiId"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyeBirimi"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyedekiMalzemeler"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyeOzellikleri"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyeIsTakipleri"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["Id"].Visible = false;
        }
        public void santiyeBirimiDoldur()
        {
            dgvSantiye_MalzemeListele.DataSource = null;
            _santiyelerListesi = _santiyelerService.SantiyeleriGetirService();
            dgvSantiye_MalzemeListele.DataSource = _santiyelerListesi;
            dgvSantiye_MalzemeListele.Columns["SantiyeBirimiId"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyeBirimi"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyedekiMalzemeler"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyeOzellikleri"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["SantiyeIsTakipleri"].Visible = false;
            dgvSantiye_MalzemeListele.Columns["Id"].Visible = false;
        }


        

    }
}
