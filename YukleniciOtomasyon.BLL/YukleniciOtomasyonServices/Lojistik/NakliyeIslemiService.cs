using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Lojistik;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Lojistik
{
    public class NakliyeIslemiService
    {
        NakliyeIslemiRepository _nakliyeIslemiRepository;
        public NakliyeIslemiService()
        {
            _nakliyeIslemiRepository = new NakliyeIslemiRepository();
        }
        public int AddNakliyeIslemiService(NakliyeIslemi nakliyeIslemi)
        {
            try
            {
                return _nakliyeIslemiRepository.AddItem(nakliyeIslemi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<NakliyeIslemi> TumNakliyeIslemleriniGetir()
        {
            try
            {
                return _nakliyeIslemiRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
            
        }

        public NakliyeIslemi NakliyeIslemleriniGetirById(int ID)
        {
            try
            {
                return _nakliyeIslemiRepository.GetById(ID);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
            
        }

        public int NakliyeIslemiUpdate(NakliyeIslemi nakliyeIslemi)
        {
            try
            {
                return _nakliyeIslemiRepository.UpdateItem(nakliyeIslemi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
            
        }

        public int NakliyeIslemiSil(NakliyeIslemi nakliyeIslemi)
        {
            try
            {
                return _nakliyeIslemiRepository.DeleteItem(nakliyeIslemi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
            
        }

        public List<NakliyeIslemi> NakliyeAraService(string text)
        {
            try
            {
                return _nakliyeIslemiRepository.NakliyeAra(text).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }
    }
}
