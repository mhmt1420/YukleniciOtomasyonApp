using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_PersonelUnvanService
    {
        T_PersonelUnvanRepository _t_PersonelUnvanRepository;
        public T_PersonelUnvanService()
        {
            _t_PersonelUnvanRepository = new T_PersonelUnvanRepository();
        }

        public int AddPersonelUnvanService(T_PersonelUnvan item)
        {
            try
            {
                return _t_PersonelUnvanRepository.AddItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeletePersonelUnvanService(T_PersonelUnvan item)
        {
            try
            {
                return _t_PersonelUnvanRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<T_PersonelUnvan> TumPersonelUnvanlariniGetirService()
        {
            try
            {
                return _t_PersonelUnvanRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public T_PersonelUnvan BirPersonelUnvaniGetirService(int id)
        {
            try
            {
                return _t_PersonelUnvanRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public int UpdatePersonelUnvaniService(T_PersonelUnvan item)
        {
            try
            {
                return _t_PersonelUnvanRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

    }
}
