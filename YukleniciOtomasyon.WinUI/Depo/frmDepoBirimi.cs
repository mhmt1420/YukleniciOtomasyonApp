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

namespace YukleniciOtomasyon.WinUI.Depo
{
    public partial class frmDepoBirimi : Form
    {
        public frmDepoBirimi()
        {
            InitializeComponent();
        }

        DepoBirimi depoBirimi = new DepoBirimi();
        List<DepoBirimi> depoBirimleri = new List<DepoBirimi>();
        List<DepoBirimiDTO> depoBirimiDTO = new List<DepoBirimiDTO>();
        DepoBirimiService depoBirimiService = new DepoBirimiService();
        Depolar depolar = new Depolar();
        DepolarService depolarService = new DepolarService();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmyanDepo_GuncelleEkle depo_GuncelleEkle = new frmyanDepo_GuncelleEkle();
            depo_GuncelleEkle.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmyanDepo_GuncelleEkle depo_GuncelleEkle = new frmyanDepo_GuncelleEkle
            {
                Tag = depolar
            };
            depo_GuncelleEkle.Show();
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

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            lblguncelle.Visible = true;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            lblguncelle.Visible = false;
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            lblEkle.Visible = true;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            lblEkle.Visible = false;
        }
        #endregion

        public static frmDepoBirimi frmdepoBirimi;

        private void frmDepoBirimi_Load(object sender, EventArgs e)
        {
            depoBirimiDoldur();
        }

        private void txDepoAra_TextChanged(object sender, EventArgs e)
         {
            dgvDepo_MalzemeListele.DataSource = null;
            depoBirimiDoldur(txDepoAra.Text);
        }
        public void depoBirimiDoldur(string a)
        {
            dgvDepo_MalzemeListele.DataSource = null;
            dgvDepo_MalzemeListele.DataSource = depolarService.ArananDepolarService(a);
            dgvDepo_MalzemeListele.Columns["DepoBirimiId"].Visible = false;
             dgvDepo_MalzemeListele.Columns["DepoBirimi"].Visible = false;
             dgvDepo_MalzemeListele.Columns["DepodakiMalzemeler"].Visible = false;
             dgvDepo_MalzemeListele.Columns["DepoOzellikleri"].Visible = false;
             dgvDepo_MalzemeListele.Columns["Id"].Visible = false;

        }
        public void depoBirimiDoldur()
        {
            dgvDepo_MalzemeListele.DataSource = null;
            dgvDepo_MalzemeListele.DataSource = depolarService.TumDepolarıGetir();
            dgvDepo_MalzemeListele.Columns["DepoBirimiId"].Visible = false;
            dgvDepo_MalzemeListele.Columns["DepoBirimi"].Visible = false;
            dgvDepo_MalzemeListele.Columns["DepodakiMalzemeler"].Visible = false;
            dgvDepo_MalzemeListele.Columns["DepoOzellikleri"].Visible = false;
            dgvDepo_MalzemeListele.Columns["Id"].Visible = false;
        }

        private void dgvDepo_MalzemeListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepo_MalzemeListele.SelectedRows[0].DataBoundItem != null)
            {
                int seciliDepoId = Convert.ToInt32(dgvDepo_MalzemeListele.SelectedRows[0].Cells["Id"].Value);
                depolar = depolarService.DepolarGetirById(seciliDepoId);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            depolarService.DepolarSil(depolar);
            depoBirimiDoldur();
        }
    }
}
