using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Teklif;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Teklif
{
    public class AcilanIhalelerService
    {
        AcilanIhalelerRepository _acilanIhalelerRepository;
        public AcilanIhalelerService()
        {
            _acilanIhalelerRepository = new AcilanIhalelerRepository();
        }


        public int AddAcilanIhalelerService(AcilanIhaleler EklenecekIhale)
        {
            try
            {
                return _acilanIhalelerRepository.AddItem(EklenecekIhale);
            }
            catch (Exception e )
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int DeleteAcilanIhalelerService(AcilanIhaleler silinecekIhale)
        {
            try
            {
                return _acilanIhalelerRepository.DeleteItem(silinecekIhale);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<AcilanIhaleler> TumAcilanIhaleleriGetirService()
        {
            try
            {
                return _acilanIhalelerRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public AcilanIhaleler BirIhaleGetirService(int id)
        {
            try
            {
                return _acilanIhalelerRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int UpdateAcilanIhalelerService(AcilanIhaleler guncellenecekIhale)
        {
            try
            {
                return _acilanIhalelerRepository.UpdateItem(guncellenecekIhale);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<AcilanIhaleler> IhaleAraService(string aranacakMetin)
        {
            try
            {
                return _acilanIhalelerRepository.IhaleAra(aranacakMetin).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<AcilanIhaleler> IhaleTarihiAraService(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            try
            {
                return _acilanIhalelerRepository.IhaleTarihiAra(baslangicTarihi, bitisTarihi).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }


    }
}
