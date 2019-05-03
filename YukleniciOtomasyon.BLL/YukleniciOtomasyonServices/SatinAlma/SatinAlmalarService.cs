using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.SatinAlma;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.SatinAlma
{
    public class SatinAlmalarService
    {
        SatinAlmalarRepository _satinAlmalarRepository;
        public SatinAlmalarService()
        {
            _satinAlmalarRepository = new SatinAlmalarRepository();
        }



        public int AddSatinAlmalarService(SatinAlmalar satinAlmalar)
        {
            try
            {
                return _satinAlmalarRepository.AddItem(satinAlmalar);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int DeleteSatinAlmalarService(SatinAlmalar satinAlmalar)
        {
            try
            {
                return _satinAlmalarRepository.DeleteItem(satinAlmalar);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<SatinAlmalar> TumSatinAlmalariGetirService()
        {
            try
            {
                return _satinAlmalarRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public SatinAlmalar BirSatinAlmaGetirService(int id)
        {
            try
            {
                return _satinAlmalarRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int UpdateSatinAlmalarService(SatinAlmalar satinAlmalar)
        {
            try
            {
                return _satinAlmalarRepository.UpdateItem(satinAlmalar);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<SatinAlmalar> SatinAlmaAraService(string text)
        {
            return _satinAlmalarRepository.SatinAlmaAra(text).ToList();
        }

        public List<SatinAlmalar> SatinAlmaTarihAraService(DateTime ilkSatinAlmaTarihi, DateTime sonSatinAlmaTarihi)
        {
            return _satinAlmalarRepository.SatinAlmaTarihAra(ilkSatinAlmaTarihi, sonSatinAlmaTarihi).ToList();
        }
    }
}
