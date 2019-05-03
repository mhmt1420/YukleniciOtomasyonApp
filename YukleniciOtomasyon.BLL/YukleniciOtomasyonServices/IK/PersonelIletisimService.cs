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
    public class PersonelIletisimService
    {
        PersonelIletisimRepository _personelIletisimRepository;
        public PersonelIletisimService()
        {
            _personelIletisimRepository = new PersonelIletisimRepository();
        }

        public int AddPersonelIletisimService(PersonelIletisim personelIletisim)
        {
            try
            {
                return _personelIletisimRepository.AddItem(personelIletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }

        public int DeletePersonelIletisimService(PersonelIletisim personelIletisim)
        {
            try
            {
                return _personelIletisimRepository.DeleteItem(personelIletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return 0;
            }
        }

        public List<PersonelIletisim> TumPersonelIletisimleriGetir()
        {
            try
            {
                return _personelIletisimRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return null;
            }
        }

        public PersonelIletisim PersonelIletisimGetir(int id)
        {
            try
            {
                return _personelIletisimRepository.GetById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                return null;
            }
           
        }

        public int UpdatePersonelIletisimService(PersonelIletisim personelIletisim)
        {
            try
            {
                return _personelIletisimRepository.UpdateItem(personelIletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }
    }
}
