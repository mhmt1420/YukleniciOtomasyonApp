using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.WinUI.IK
{
    public partial class frmIKBirimi : Form
    {
        PersonelService _personelService;
        PersonelIletisimService _personelIletisimService;
        PersonelMuhasebeService _personelMuhasebeService;
        

        Personel _secilenPersonel;
       
        public frmIKBirimi()
        {
            InitializeComponent();
            _personelService = new PersonelService();
            _personelIletisimService = new PersonelIletisimService();
            _personelMuhasebeService = new PersonelMuhasebeService();
            

        }

        public void PersonelDoldur()
        {
            dgvPersonelListele.DataSource = null;
            List<Personel> PersonelListesi = _personelService.TumPersonelleriGetirService();
            dgvPersonelListele.DataSource = PersonelListesi;
        }
        public void PersonelIletisimDoldur()
        {
            dgvPersonelListele.DataSource = null;
            List<PersonelIletisim> personelIletisimListesi = _personelIletisimService.TumPersonelIletisimleriGetir();
            dgvPersonelListele.DataSource = personelIletisimListesi;
        }
        public void PersonelMuhasebeDoldur()
        {
            dgvPersonelListele.DataSource = null;
            List<PersonelMuhasebe> personelMuhasebeListesi = _personelMuhasebeService.TumPersonelMuhasebeleriGetirService();
            dgvPersonelListele.DataSource = personelMuhasebeListesi;
        }

        
        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            PersonelBilgileriGuncelle_Kaydet PersonelKaydet = new PersonelBilgileriGuncelle_Kaydet();
            PersonelKaydet.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmIKBirimi_Load(object sender, EventArgs e)//IK FORM LOAD
        {
            PersonelDoldur();
            PersonelIletisimDoldur();
            PersonelMuhasebeDoldur();

            dgvPersonelListele.DataSource = null;
            List<Personel> PersonelListesi = _personelService.PersonelAraService(txtPersonelAra.Text);
            dgvPersonelListele.DataSource = PersonelListesi;

        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            dgvPersonelListele.DataSource = null;
            List<Personel> PersonelListesi = _personelService.PersonelAraService(txtPersonelAra.Text);
            dgvPersonelListele.DataSource = PersonelListesi;
        }

        private void dgvPersonelListele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int seciliPersonelID=Convert.ToInt32(dgvPersonelListele.SelectedRows[0].Cells["ID"].Value);
            _secilenPersonel = _personelService.BirPersonelGetirService(seciliPersonelID);
            txtPersonelAra.Text = _secilenPersonel.Ad;
            txtPersonelAra.Text = _secilenPersonel.Soyad;
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

        private void btnGuncelleIK_MouseHover(object sender, EventArgs e)
        {
            lblguncelle.Visible = true;
        }

        private void btnGuncelleIK_MouseLeave(object sender, EventArgs e)
        {
            lblguncelle.Visible = false;
        }

        private void btnPersonelListele_MouseHover(object sender, EventArgs e)
        {
            lblekle.Visible = true;
        }

        private void btnPersonelListele_MouseLeave(object sender, EventArgs e)
        {
            lblekle.Visible = false;
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

        private void btnGuncelleIK_Click(object sender, EventArgs e)
        {
            int etkilenen = _personelService.UpdatePersonelService(_secilenPersonel);
            if (etkilenen > 0)
            {
                MessageBox.Show("Personel Güncellendi");
                PersonelDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int etkilenen = _personelService.DeletePersonelService(_secilenPersonel);
            if (etkilenen > 0)
            {
                MessageBox.Show("Personel silindi");
                PersonelDoldur();
            }
        }
    }
}
