using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices
{
    public class DepartmanService
    {
        DepartmanRepository _departmanRepository;
        public DepartmanService()
        {
            _departmanRepository = new DepartmanRepository();
        }

        public int AddDepartmanService(Departman item)
        {
            try
            {
            return _departmanRepository.AddItem(item);
                
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int DeleteDepartmanService(Departman item)
        {
            try
            {
                return _departmanRepository.DeleteItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public Departman BirDepartmanGetirService(int id)
        {
            try
            {
                return _departmanRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public int UpdateDepartmanService(Departman item)
        {
            try
            {
                return _departmanRepository.UpdateItem(item);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<Departman> TumDepartmanlariGetirService()
        {
            try
            {
                return _departmanRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public List<Departman> DepartmanAra(string text)
        {
            try
            {
                return _departmanRepository.DepartmanAra(text).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<DepartmanPersonelDTO> DTODepartmanPersonelService(string text)
        {
            try
            {
                return _departmanRepository.DTODepartmanPersonelGetir(text).ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }



        }
    }
}
