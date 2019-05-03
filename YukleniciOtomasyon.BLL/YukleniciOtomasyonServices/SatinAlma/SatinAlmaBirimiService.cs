using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.SatinAlma;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.SatinAlma
{
    public class SatinAlmaBirimiService
    {
        SatinAlmaBirimiRepository _satinAlmaBirimiRepository;
        public SatinAlmaBirimiService()
        {
            _satinAlmaBirimiRepository = new SatinAlmaBirimiRepository();
        }


        public int AddSatinAlmaBirimiService(SatinAlmaBirimi eklenecekSatinAlmaBirimi)
        {
            try
            {
                return _satinAlmaBirimiRepository.AddItem(eklenecekSatinAlmaBirimi);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }


        public int DeleteSatinAlmaBirimiService(SatinAlmaBirimi silinecekSatinAlmaBirimi)
        {
            try
            {
                return _satinAlmaBirimiRepository.DeleteItem(silinecekSatinAlmaBirimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<SatinAlmaBirimi> TumSatinAlmaBirimiGetirService()
        {
            try
            {
                return _satinAlmaBirimiRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public SatinAlmaBirimi BirSatinAlmaBirimiGetirService(int id)
        {
            try
            {
                return _satinAlmaBirimiRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int UpdateSatinAlmaBirimiService(SatinAlmaBirimi guncellenecekSatinAlmaBirimi)
        {
            try
            {
                return _satinAlmaBirimiRepository.UpdateItem(guncellenecekSatinAlmaBirimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }



    }
}
