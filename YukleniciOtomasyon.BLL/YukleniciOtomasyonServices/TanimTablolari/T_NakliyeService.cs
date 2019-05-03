using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_NakliyeService
    {
        T_NakliyeRepository _t_NakliyeRepository;
        public T_NakliyeService()
        {
            _t_NakliyeRepository = new T_NakliyeRepository();
        }

        public int AddNakliyeService(T_Nakliye item)
        {
            try
            {
                return _t_NakliyeRepository.AddItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteNakliyeService(T_Nakliye item)
        {
            try
            {
                return _t_NakliyeRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<T_Nakliye> TumNakliyeleriGetirService()
        {
            try
            {
                return _t_NakliyeRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_Nakliye BirNakliyeGetirService(int id)
        {
            try
            {
                return _t_NakliyeRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateNakliyeService(T_Nakliye item)
        {
            try
            {
                return _t_NakliyeRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<T_Nakliye> NakliyeFirmaAraService(string text)
        {
            try
            {
                return _t_NakliyeRepository.NakliyeFirmaAra(text).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }






    }
}
