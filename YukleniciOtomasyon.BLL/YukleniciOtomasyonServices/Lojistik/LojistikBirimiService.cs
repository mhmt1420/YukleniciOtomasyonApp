using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Lojistik;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Lojistik
{
    public class LojistikBirimiService
    {
        LojistikBirimiRepository _lojistikBirimiRepository;
        public LojistikBirimiService()
        {
            _lojistikBirimiRepository = new LojistikBirimiRepository();
        }
        public int AddLojistikBirimiService(LojistikBirimi lojistik)
        {
            try
            {
                return _lojistikBirimiRepository.AddItem(lojistik);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<LojistikBirimi> TumLojistikleriGetirService()
        {
            return _lojistikBirimiRepository.GetAll().ToList();
        }

        public LojistikBirimi LojistikBirimiGetirService(int ID)
        {
            return _lojistikBirimiRepository.GetById(ID);
        }

        public int LojistikBirimiUpdateService(LojistikBirimi lojistik)
        {
            return _lojistikBirimiRepository.UpdateItem(lojistik);
        }

        public int LojistikBirimiSilService(LojistikBirimi lojistik)
        {
            return _lojistikBirimiRepository.DeleteItem(lojistik);
        }
        public List<LojistikBirimiDTO> DTOLojistikBirimiGetirService()
        {
            try
            {
                return _lojistikBirimiRepository.DTOLojistikBirimiGetir().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }
    }
}
