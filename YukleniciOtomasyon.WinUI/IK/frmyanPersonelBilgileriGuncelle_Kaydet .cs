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
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.EnumTypes;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.WinUI.IK
{
    public partial class PersonelBilgileriGuncelle_Kaydet : Form
    {
        PersonelService _personelService;
        PersonelIletisimService _iletisimService;
        PersonelMuhasebeService _muhasebeService;
        int seciliPersonelID;
        Personel _seciliPersonel;
        PersonelIletisim _personelIletisim;
        PersonelMuhasebe _personelMuhasebe;
        T_PersonelUnvanService _unvanService;
        T_PersonelUnvan _personelUnvan;

        public PersonelBilgileriGuncelle_Kaydet()
        {
            InitializeComponent();
            _personelService = new PersonelService();
            _iletisimService = new PersonelIletisimService();
            _muhasebeService = new PersonelMuhasebeService();
            _unvanService = new T_PersonelUnvanService();
            _personelUnvan = new T_PersonelUnvan();
            _personelMuhasebe = new PersonelMuhasebe();

        }
        #region design
        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void PersonelBilgileriGuncelle_Kaydet_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void PersonelBilgileriGuncelle_Kaydet_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void PersonelBilgileriGuncelle_Kaydet_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        #endregion
        public void PersonelDoldur()
        {
            dgvPersonelEkle.DataSource = null;
            List<Personel> PersonelListesi = _personelService.TumPersonelleriGetirService();
            dgvPersonelEkle.DataSource = PersonelListesi;
        }
        public void PersonelIletisimDoldur()
        {
            dgvPersonelIletisim.DataSource = null;
            List<PersonelIletisim> IletisimciListesi = _iletisimService.TumPersonelIletisimleriGetir();
            dgvPersonelIletisim.DataSource = IletisimciListesi;
        }

        public void PersonelMuhasebeDoldur()
        {
            dgvPersonelMuhasebe.DataSource = null;
            List<PersonelMuhasebe> personelMuhasebeListesi = _muhasebeService.TumPersonelMuhasebeleriGetirService();
            dgvPersonelMuhasebe.DataSource = personelMuhasebeListesi;
        }
        

        private void btnKaydetPersonelIletisim_Click(object sender, EventArgs e)//DOĞRU
        {
            //frmIKBirimi frmIK = new frmIKBirimi();
            //frmIK.PersonelDoldur();
            //if (_seciliPersonel!=null)
            //{
     
            PersonelIletisim iletisim = new PersonelIletisim();
            
            iletisim.Telefon = txtTelefon.Text;
            iletisim.EMail = txtEPosta.Text;
            iletisim.Sifre = txtSifre.Text;
            iletisim.Adres = txtAdres.Text;
            iletisim.DahiliTel = txtDahiliTelefon.Text;
            iletisim.PostaKodu = txtPostaKodu.Text;
            //iletisim.ResimUrl = picboxResim.ImageLocation;
            iletisim.AktifMi = true;
            iletisim.OlusturulmaTarihi = DateTime.Now;
            iletisim.PersonelId = seciliPersonelID;
           
            //_seciliPersonel.Personelletisimleri.Add(iletisim);
            
            int etkilenen = _personelService.UpdatePersonelService(_seciliPersonel);
            if (etkilenen > 0)
            {
                MessageBox.Show("Personel İletişim başarıyle eklenmiştir.");
            }
            PersonelIletisimDoldur();
            //}
        }

        private void btnKaydetPersonel_Click(object sender, EventArgs e)//DOĞRU
        {                       
            Personel personel = new Personel();
            personel.Ad = txtAdi.Text;
            personel.Soyad = txtSoyadi.Text;
            personel.KimlikNo = txtKimlikNo.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;//?
            personel.Cinsiyet= rdbErkek.Checked == true ? Cinsiyeti.Erkek : Cinsiyeti.Kadın;
            personel.MedeniHal = rdbEvli.Checked == true ? MedeniHali.Evli : MedeniHali.Bekar;
            personel.EgitimDurumu = (EgitimDurumlari)cmbEgitimDurumu.SelectedIndex;
            personel.BaslangicTarihi = dtpIseGirisTarihi.Value;
            //personel.CikisTarihi = dtpIstenCikisTarihi.Value;
            personel.OlusturulmaTarihi = DateTime.Now;
            personel.AktifMi = true;

            int sayi = _personelService.AddPersonelService(personel);
            if (sayi > 0)
            {
                MessageBox.Show("Personel başarıyla eklendi");
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
            PersonelDoldur();
            
        }
        private void btnKaydetPersonelMuhasebe_Click(object sender, EventArgs e)//PERSONEL MUHASEBE BİLGİLERİ BUTONU
        {
            if (_seciliPersonel!=null)
            {
                
            PersonelMuhasebe muhasebe = new PersonelMuhasebe();
            T_PersonelUnvan p_unvan = new T_PersonelUnvan();
                
            muhasebe.Maas = Convert.ToDecimal(txtMaas.Text);
            
            p_unvan.UnvanAdi =cmbUnvan.SelectedItem.ToString(); //sor?  /*parantez içerisine yeni oluşturacağımız enum sınıfının adı yazılacak.*/ 
            //MessageBox.Show(p_unvan.UnvanAdi);
            _seciliPersonel.PersonelMuhasebeleri.Add(muhasebe);
                _seciliPersonel.PersonelUnvanlar.Add(p_unvan);
                
                int sayi = _personelService.UpdatePersonelService(_seciliPersonel);

            if (sayi > 0)
            {
                MessageBox.Show("eklendi");
            }
            else
            {
                MessageBox.Show("eklenemedi");
            }
            PersonelMuhasebeDoldur();
            }
        }

        private void PersonelBilgileriGuncelle_Kaydet_Load(object sender, EventArgs e)//FORM LOAD
        {            
            cmbEgitimDurumu.DataSource = Enum.GetNames(typeof(EgitimDurumlari));
            cmbUnvan.DataSource = Enum.GetNames(typeof(PersonelTurleri));//Unvan enum sınıfı eklenecek !!!
            PersonelDoldur();
            PersonelIletisimDoldur();
            PersonelMuhasebeDoldur();
            
        }

        private void btnGuncellePersonel_Click(object sender, EventArgs e)//PERSONEL GÜNCELLE BUTTONU
        {
            Personel personel = new Personel();
            personel=_seciliPersonel;

            personel.Ad = txtAdi.Text;
            personel.Soyad = txtSoyadi.Text;
            personel.KimlikNo = txtKimlikNo.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;//?
            personel.Cinsiyet = rdbErkek.Checked == true ? Cinsiyeti.Erkek : Cinsiyeti.Kadın;
            personel.MedeniHal = rdbEvli.Checked == true ? MedeniHali.Evli : MedeniHali.Bekar;
            personel.EgitimDurumu = (EgitimDurumlari)cmbEgitimDurumu.SelectedIndex;
            personel.BaslangicTarihi = dtpIseGirisTarihi.Value;
            //personel.CikisTarihi = dtpIstenCikisTarihi.Value;
            personel.OlusturulmaTarihi = DateTime.Now;
            personel.AktifMi = true;

            int sayi = _personelService.UpdatePersonelService(personel);
            if (sayi > 0)
            {
                MessageBox.Show("Personel başarıyla güncellendi");
            }
            else
            {
                MessageBox.Show("Güncellenemedi");
            }
            PersonelDoldur();
        }
       
        private void dgvPersonelEkle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            seciliPersonelID = Convert.ToInt32(dgvPersonelEkle.SelectedRows[0].Cells["ID"].Value);

            _seciliPersonel = _personelService.BirPersonelGetirService(seciliPersonelID);

            txtAdi.Text = _seciliPersonel.Ad;
            txtSoyadi.Text = _seciliPersonel.Soyad;
            txtKimlikNo.Text = _seciliPersonel.KimlikNo;
            dtpDogumTarihi.Value = _seciliPersonel.DogumTarihi;
            cmbEgitimDurumu.SelectedItem = _seciliPersonel.EgitimDurumu;
            dtpIseGirisTarihi.Value = _seciliPersonel.BaslangicTarihi;
            //dtpIstenCikisTarihi.Value = _seciliPersonel.CikisTarihi;//?
            if (_seciliPersonel.Cinsiyet == Cinsiyeti.Erkek)
            {
                rdbErkek.Checked = true;
            }
            else if (_seciliPersonel.Cinsiyet == Cinsiyeti.Kadın)
            {
                rdbKadin.Checked = true;
            }

            if (_seciliPersonel.MedeniHal == MedeniHali.Evli)
            {
                rdbEvli.Checked = true;
            }
            else if (_seciliPersonel.MedeniHal == MedeniHali.Bekar)
            {
                rdbBekar.Checked = true;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)//personel sil
        {
            int etkilenen = _personelService.DeletePersonelService(_seciliPersonel);
            if (etkilenen > 0)
            {
                MessageBox.Show("Personel silindi");
                PersonelDoldur();
            }
        }
        private void btnGuncellePersonelIletisim_Click(object sender, EventArgs e)
        {
            PersonelIletisim iletisim = new PersonelIletisim();
            
            iletisim.Telefon = txtTelefon.Text;
            iletisim.EMail = txtEPosta.Text;
            iletisim.Sifre = txtSifre.Text;
            iletisim.Adres = txtAdres.Text;
            iletisim.DahiliTel = txtDahiliTelefon.Text;
            iletisim.PostaKodu = txtPostaKodu.Text;
            //iletisim.ResimUrl = picboxResim.ImageLocation;
            iletisim.AktifMi = true;
            iletisim.OlusturulmaTarihi = DateTime.Now;

            _seciliPersonel.Personelletisimleri.Add(iletisim);
            _personelService.UpdatePersonelService(_seciliPersonel);
            int sayi = _iletisimService.UpdatePersonelIletisimService(iletisim);
            if (sayi > 0)
            {
                MessageBox.Show("Personel iletişim başarıyla güncellendi");
            }
            else
            {
                MessageBox.Show("Güncellenemedi");
            }
            PersonelIletisimDoldur();
        }
        private void dgvPersonelIletisim_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            seciliPersonelID = Convert.ToInt32(dgvPersonelIletisim.SelectedRows[0].Cells["ID"].Value);
            _personelIletisim = _iletisimService.PersonelIletisimGetir(seciliPersonelID);

            txtTelefon.Text = _personelIletisim.Telefon;
            txtEPosta.Text = _personelIletisim.EMail;
            txtSifre.Text = _personelIletisim.Sifre;
            txtAdres.Text = _personelIletisim.Adres;
            txtDahiliTelefon.Text = _personelIletisim.DahiliTel;
            txtPostaKodu.Text = _personelIletisim.PostaKodu;
            //picboxResim.ImageLocation = _personelIletisim.ResimUrl;
        }
        private void dgvPersonelMuhasebe_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            seciliPersonelID = Convert.ToInt32(dgvPersonelMuhasebe.SelectedRows[0].Cells["ID"].Value);
            _personelMuhasebe = _muhasebeService.PersonelMuhasebeGetirService(seciliPersonelID);
            
            _personelUnvan= _unvanService.BirPersonelUnvaniGetirService(cmbUnvan.SelectedIndex);
        }


        #region labels
        private void btnFormKapat_MouseHover(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = true;
        }

        private void btnFormKapat_MouseLeave(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = false;
        }

        private void btnKaydetPersonelMuhasebe_MouseHover(object sender, EventArgs e)
        {
            lblKaydetPersonelMuhasebe.Visible = true;
        }

        private void btnKaydetPersonelMuhasebe_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetPersonelMuhasebe.Visible = false;
        }

        private void btnGuncellePersonelMuhasebe_MouseHover(object sender, EventArgs e)
        {
            lblGuncellePersonelMuhasebe.Visible = true;
        }

        private void btnGuncellePersonelMuhasebe_MouseLeave(object sender, EventArgs e)
        {
            lblGuncellePersonelMuhasebe.Visible = false;
        }

        private void btnKaydetPersonelIletisim_MouseHover(object sender, EventArgs e)
        {
            lblKaydetPersonelIletisim.Visible = true;
        }

        private void btnKaydetPersonelIletisim_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetPersonelIletisim.Visible = false;
        }

        private void btnGuncellePersonelIletisim_MouseHover(object sender, EventArgs e)
        {
            lblGuncellePersonelIletisim.Visible = true;
        }

        private void btnGuncellePersonelIletisim_MouseLeave(object sender, EventArgs e)
        {
            lblGuncellePersonelIletisim.Visible = false;
        }

        private void btnKaydetPersonel_MouseHover(object sender, EventArgs e)
        {
            lblKaydetPersonel.Visible = true;
        }

        private void btnKaydetPersonel_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetPersonel.Visible = false;
        }

        private void btnGuncellePersonel_MouseHover(object sender, EventArgs e)
        {
            lblguncellePersonel.Visible = true;
        }

        private void btnGuncellePersonel_MouseLeave(object sender, EventArgs e)
        {
            lblguncellePersonel.Visible = false;
        }





        #endregion

        private void button1_Click(object sender, EventArgs e)//iletişim sil
        {
            int etkilenen = _iletisimService.DeletePersonelIletisimService(_personelIletisim);
            if (etkilenen > 0)
            {
                MessageBox.Show("Personel iletişim silindi");
                PersonelIletisimDoldur();
            }
        }

        private void btnGuncellePersonelMuhasebe_Click(object sender, EventArgs e)
        {

            _personelMuhasebe.Maas = Convert.ToDecimal(txtMaas.Text);
            if (cmbUnvan.SelectedItem != null)
            {
            _personelUnvan.UnvanAdi = cmbUnvan.SelectedItem.ToString(); //sor?  /*parantez içerisine yeni oluşturacağımız enum sınıfının adı yazılacak.*/ 

            }
            ////MessageBox.Show(p_unvan.UnvanAdi);
            //_seciliPersonel.PersonelMuhasebeleri.Add(_personelMuhasebe);
            //_seciliPersonel.PersonelUnvanlar.Add(_personelUnvan);

            int sayi = _muhasebeService.UpdatePersonelMuhasebeService(_personelMuhasebe);
            sayi += _unvanService.UpdatePersonelUnvaniService(_personelUnvan);

            if (sayi > 0)
            {
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Güncellenemedi");
            }
            PersonelMuhasebeDoldur();
        }

        private void button2_Click(object sender, EventArgs e)//muhasebe sil
        {
            int etkilenen = _muhasebeService.DeletePersonelMuhasebeService(_personelMuhasebe);
            if (etkilenen > 0)
            {
                MessageBox.Show("Personel muhasebe bilgisi silindi");
                PersonelMuhasebeDoldur();
            }
        }
    }    
}
