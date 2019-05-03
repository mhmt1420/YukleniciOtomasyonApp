using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_MalzemeService
    {
        T_MalzemeRepository _t_MalzemeRepository;
        public T_MalzemeService()
        {
            _t_MalzemeRepository = new T_MalzemeRepository();
        }

        public int AddMalzemeService(T_Malzeme item)
        {
            try
            {
                return _t_MalzemeRepository.AddItem(item);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteMalzemeService(T_Malzeme item)
        {
            try
            {
                return _t_MalzemeRepository.DeleteItem(item);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<T_Malzeme> TumMalzemeleriGetirService()
        {
            try
            {
                return _t_MalzemeRepository.GetAll().ToList();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_Malzeme BirMalzemeGetirService(int id)
        {
            try
            {
                return _t_MalzemeRepository.GetById(id);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateMalzemeService(T_Malzeme item)
        {
            try
            {
                return _t_MalzemeRepository.UpdateItem(item);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<T_Malzeme> MalzemeAraService(string text)
        {
            try
            {
                return _t_MalzemeRepository.MalzemeAra(text).ToList();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }


    }
}
