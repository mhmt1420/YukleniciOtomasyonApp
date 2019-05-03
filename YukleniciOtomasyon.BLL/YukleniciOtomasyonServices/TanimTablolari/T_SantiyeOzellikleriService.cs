using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_SantiyeOzellikleriService
    {
        T_SantiyeOzellikleriRepository _t_SantiyeOzellikleriRepository;
        public T_SantiyeOzellikleriService()
        {
            _t_SantiyeOzellikleriRepository = new T_SantiyeOzellikleriRepository();
        }

        public int AddSantiyeOzellikleriService(T_SantiyeOzellikleri item)
        {
            try
            {
                return _t_SantiyeOzellikleriRepository.AddItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteSantiyeOzellikleriService(T_SantiyeOzellikleri item)
        {
            try
            {
                return _t_SantiyeOzellikleriRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<T_SantiyeOzellikleri> TumSantiyeOzellikleriniGetirService()
        {
            try
            {
                return _t_SantiyeOzellikleriRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_SantiyeOzellikleri SantiyeOzelliginiGetirService(int id)
        {
            try
            {
                return _t_SantiyeOzellikleriRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateSantiyeOzellikleriService(T_SantiyeOzellikleri item)
        {
            try
            {
                return _t_SantiyeOzellikleriRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
    }
}
