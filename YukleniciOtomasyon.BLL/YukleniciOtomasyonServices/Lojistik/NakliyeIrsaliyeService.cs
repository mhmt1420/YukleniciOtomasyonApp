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
    public class NakliyeIrsaliyeService
    {
        NakliyeIrsaliyeRepository _nakliyeIrsaliyeRepository;
        public NakliyeIrsaliyeService()
        {
            _nakliyeIrsaliyeRepository = new NakliyeIrsaliyeRepository();
        }
        public int AddNakliyeIrsaliyeService(NakliyeIrsaliye nakliye)
        {
            try
            {
                return _nakliyeIrsaliyeRepository.AddItem(nakliye);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<NakliyeIrsaliye> TumNakliyeIrsaliyeGetirService()
        {
            return _nakliyeIrsaliyeRepository.GetAll().ToList();
        }

        public NakliyeIrsaliye NakliyeIrsaliyeGetirService(int ID)
        {
            return _nakliyeIrsaliyeRepository.GetById(ID);
        }

        public int DepolarUpdateService(NakliyeIrsaliye nakliye)
        {
            return _nakliyeIrsaliyeRepository.UpdateItem(nakliye);
        }

        public int DepolarSilService(NakliyeIrsaliye nakliye)
        {
            return _nakliyeIrsaliyeRepository.DeleteItem(nakliye);
        }

        public List<NakliyeIrsaliye> TarihlereGoreNakliyeIrsaliyeAraService(DateTime cikisTarihi,DateTime bitisTarihi)
        {
           return _nakliyeIrsaliyeRepository.NakliyeTarihAra(cikisTarihi, bitisTarihi).ToList();
        }

        public List<NakliyeIrsaliye> NakliyeIrsaliyeAraService(string text)
        {
            return _nakliyeIrsaliyeRepository.IrsaliyeAra(text).ToList();
        }
    }
}
