using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_TedarikciFirmaService
    {
        T_TedarikciFirmaRepository _t_TedarikciFirmaRepository;
        public T_TedarikciFirmaService()
        {
            _t_TedarikciFirmaRepository = new T_TedarikciFirmaRepository();
        }

        public int AddTedarikciFirmaService(T_TedarikciFirma item)
        {
            try
            {
                return _t_TedarikciFirmaRepository.AddItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteTedarikciFirmaService(T_TedarikciFirma item)
        {
            try
            {
                return _t_TedarikciFirmaRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<T_TedarikciFirma> TumTedarikciFirmalariGetirService()
        {
            try
            {
                return _t_TedarikciFirmaRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_TedarikciFirma BirTedarikciFirmaGetirService(int id)
        {
            try
            {
                return _t_TedarikciFirmaRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public int UpdateTedarikciFirmaService(T_TedarikciFirma item)
        {
            try
            {
                return _t_TedarikciFirmaRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
    }
}
