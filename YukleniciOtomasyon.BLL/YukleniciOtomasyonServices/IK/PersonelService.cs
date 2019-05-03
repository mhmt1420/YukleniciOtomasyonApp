using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.IK;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK
{
    public class PersonelService
    {
        PersonelRepository _personelRepository;
        public PersonelService()
        {
            _personelRepository = new PersonelRepository();
        }



        public int AddPersonelService (Personel yeniPersonel)
        {
            try
            {
                return _personelRepository.AddItem(yeniPersonel);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;               
            }
        }
         
        public int DeletePersonelService(Personel silinecekPersonel)
        {
            try
            {
                return _personelRepository.DeleteItem(silinecekPersonel);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return 0;
            }
        }

        public List<Personel> TumPersonelleriGetirService()
        {
            try
            {
                return _personelRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return null;
            }
        }
        
        public Personel BirPersonelGetirService(int id)
        {
            try
            {
                return _personelRepository.GetById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return null;
            }            
        }

        public int UpdatePersonelService(Personel guncellenecekPersonel)
        {
            try
            {
                return _personelRepository.UpdateItem(guncellenecekPersonel);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return 0;
            }
        }

        public bool PersonelLoginKontrolService(string kimlikNo, string sifre)
        {
            try
            {
                return _personelRepository.PersonelLoginKontrol(kimlikNo,sifre);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                return false;
            }
        }

        public List<Personel> PersonelAraService(string text)
        {
            try
            {
                return _personelRepository.PersonelAra(text).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                return null;
            }
        }

    }
}
