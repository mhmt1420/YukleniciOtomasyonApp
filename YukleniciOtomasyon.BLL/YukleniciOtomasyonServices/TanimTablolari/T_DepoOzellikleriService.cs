using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari
{
    public class T_DepoOzellikleriService
    {
        T_DepoOzellikleriRepository _t_DepoOzellikleriRepository;
        public T_DepoOzellikleriService()
        {
            _t_DepoOzellikleriRepository = new T_DepoOzellikleriRepository();
        }

        public int AddT_DepoOzellikleriService(T_DepoOzellikleri eklencekDepoOzelligi)
        {
            try
            {
                return _t_DepoOzellikleriRepository.AddItem(eklencekDepoOzelligi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public int DeleteT_DepoOzellikleriService(T_DepoOzellikleri silinecekDepoOzelligi)
        {
            try
            {
                return _t_DepoOzellikleriRepository.DeleteItem(silinecekDepoOzelligi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }
        public List<T_DepoOzellikleri> TumDepoOzellikleriniGetirService()
        {
            try
            {
                return _t_DepoOzellikleriRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public T_DepoOzellikleri DepoOzelligiGetirService(int id)
        {
            try
            {
                return _t_DepoOzellikleriRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public int UpdateT_DepoOzellikleriService(T_DepoOzellikleri guncellenecekDepoOzelligi)
        {
            try
            {
                return _t_DepoOzellikleriRepository.UpdateItem(guncellenecekDepoOzelligi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }



    }
}
