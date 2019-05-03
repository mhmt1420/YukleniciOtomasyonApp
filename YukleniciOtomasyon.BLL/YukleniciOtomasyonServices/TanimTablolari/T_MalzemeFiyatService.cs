using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_MalzemeFiyatService
    {
        T_MalzemeFiyatRepository _t_MalzemeFiyatRepository;
        public T_MalzemeFiyatService()
        {
            _t_MalzemeFiyatRepository = new T_MalzemeFiyatRepository();
        }

        public int AddMalzemeFiyatService(T_MalzemeFiyat item)
        {
            try
            {
                return _t_MalzemeFiyatRepository.AddItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
           
        }
        public int DeleteMalzemeFiyatService(T_MalzemeFiyat item)
        {
            try
            {
                return _t_MalzemeFiyatRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<T_MalzemeFiyat> TumMalzemeFiyatlariniGetirService()
        {
            try
            {
                return _t_MalzemeFiyatRepository.GetAll().ToList();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_MalzemeFiyat MalzemeFiyatiGetirService(int id)
        {
            try
            {
                return _t_MalzemeFiyatRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateMalzemeFiyatService(T_MalzemeFiyat item)
        {
            try
            {
                return _t_MalzemeFiyatRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }

        }
        public List<T_MalzemeFiyat> BirimFiyatAraService(decimal birimFiyat)
        {
            try
            {
                return _t_MalzemeFiyatRepository.BirimFiyatAra(birimFiyat).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }


    }
}
