using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_NakliyeAraclariService
    {
        T_NakliyeAraclariRepository _t_NakliyeAraclariRepository;
        public T_NakliyeAraclariService()
        {
            _t_NakliyeAraclariRepository = new T_NakliyeAraclariRepository();
        }

        public int AddNakliyeAraciService(T_NakliyeAraclari item)
        {
            try
            {
                return _t_NakliyeAraclariRepository.AddItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteNakliyeAraciService(T_NakliyeAraclari item)
        {
            try
            {
                return _t_NakliyeAraclariRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<T_NakliyeAraclari> TumNakliyeAraclariGetirService()
        {
            try
            {
                return _t_NakliyeAraclariRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_NakliyeAraclari BirNakliyeAraciGetirService(int id)
        {
            try
            {
                return _t_NakliyeAraclariRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateNakliyeAraciService(T_NakliyeAraclari item)
        {
            try
            {
                return _t_NakliyeAraclariRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
    }
}
