using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Santiye
{
    public class SantiyelerService
    {
        SantiyelerRepository _santiyelerRepository;
        public SantiyelerService()
        {
            _santiyelerRepository = new SantiyelerRepository();
        }
        public int AddSantiyelerDepolarService(Santiyeler santiye)
        {
            try
            {
                return _santiyelerRepository.AddItem(santiye);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<Santiyeler> SantiyeleriGetirService()
        {
            return _santiyelerRepository.GetAll().ToList();
        }

        public Santiyeler BirSantiyeGetirService(int ID)
        {
            return _santiyelerRepository.GetById(ID);
        }

        public int SantiyelerUpdateService(Santiyeler santiye)
        {
            return _santiyelerRepository.UpdateItem(santiye);
        }

        public int SantiyelerSilService(Santiyeler santiye)
        {
            return _santiyelerRepository.DeleteItem(santiye);
        }
        public List<Santiyeler> SantiyeAraService(string text)
        {
            try
            {
                return _santiyelerRepository.SantiyeAra(text).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }

        public List<Santiyeler> SantiyeTarihAraService(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            try
            {
                return _santiyelerRepository.SantiyeTarihAra(baslangicTarihi, bitisTarihi).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }


    }
}
