using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Depo;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Depo
{
    public class DepoBirimiService
    {
        DepoBirimiRepository _depoBirimiRepository;
        public DepoBirimiService()
        {
            _depoBirimiRepository = new DepoBirimiRepository();
        }

        public int AddDepoBirimiService(DepoBirimi depoBirimi)
        {
            try
            {
                return _depoBirimiRepository.AddItem(depoBirimi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }
        public int DeleteDepoBirimiService(DepoBirimi depoBirimi)
        {
            try
            {
                return _depoBirimiRepository.DeleteItem(depoBirimi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }


        public List<DepoBirimi> TumDepoBirimleriniGetir()
        {
            try
            {
                return _depoBirimiRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public DepoBirimi BirDepoBirimiGetir(int ID)
        {
            try
            {
                return _depoBirimiRepository.GetById(ID);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public int UpdateDepoBirimiService(DepoBirimi depoBirimi)
        {
            try
            {
                return _depoBirimiRepository.UpdateItem(depoBirimi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
        public List<DepoBirimiDTO> DTODepoBirimiGetirService()
        {
            try
            {
                return _depoBirimiRepository.DTODepoBirimiGetir().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }
    }
}
