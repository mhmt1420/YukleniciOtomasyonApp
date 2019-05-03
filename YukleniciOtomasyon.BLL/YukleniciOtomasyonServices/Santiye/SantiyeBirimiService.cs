using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Santiye
{
    public class SantiyeBirimiService
    {
        SantiyeBirimiRepository _santiyeBirimiRepository;
        public SantiyeBirimiService()
        {
            _santiyeBirimiRepository = new SantiyeBirimiRepository();
        }

        public int AddSantiyeBirimiService(SantiyeBirimi santiye)
        {
            try
            {
                return _santiyeBirimiRepository.AddItem(santiye);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<SantiyeBirimi> TumSantiyeBirimleriniGetirService()
        {
            return _santiyeBirimiRepository.GetAll().ToList();
        }

        public SantiyeBirimi SantiyeBirimleriniGetirService(int ID)
        {
            return _santiyeBirimiRepository.GetById(ID);
        }

        public int SantiyeBirimiUpdateService(SantiyeBirimi santiye)
        {
            return _santiyeBirimiRepository.UpdateItem(santiye);
        }

        public int SantiyeBirimiSilService(SantiyeBirimi santiye)
        {
            return _santiyeBirimiRepository.DeleteItem(santiye);
        }
        public List<SantiyeBirimiDTO> DTOSantiyeBirimiGetirService()
        {
            try
            {
                return _santiyeBirimiRepository.DTOSantiyeBirimiGetir().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }
    }
}
