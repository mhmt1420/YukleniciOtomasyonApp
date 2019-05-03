using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_IhaleEvraklariService
    {
        T_IhaleEvraklariRepository _t_IhaleEvraklariRepository;
        public T_IhaleEvraklariService()
        {
            _t_IhaleEvraklariRepository = new T_IhaleEvraklariRepository();
        }

        public int AddT_IhaleEvraklariService(T_IhaleEvraklari eklencekIhaleEvragi)
        {
            try
            {
                return _t_IhaleEvraklariRepository.AddItem(eklencekIhaleEvragi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteT_IhaleEvraklariService(T_IhaleEvraklari silinecekIhaleEvragi)
        {
            try
            {
                return _t_IhaleEvraklariRepository.DeleteItem(silinecekIhaleEvragi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<T_IhaleEvraklari> TumIhaleEvraklariniGetirService()
        {
            try
            {
                return _t_IhaleEvraklariRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_IhaleEvraklari IhaleEvragiGetirService(int id)
        {
            try
            {
                return _t_IhaleEvraklariRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateT_IhaleEvraklariService(T_IhaleEvraklari guncellenecekIhaleEvragi)
        {
            try
            {
                return _t_IhaleEvraklariRepository.UpdateItem(guncellenecekIhaleEvragi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }



    }
}
