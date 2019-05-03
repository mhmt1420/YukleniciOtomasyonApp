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
    public class DepolarService
    {
        DepolarRepository _depolarRepository;
        public DepolarService()
        {
            _depolarRepository = new DepolarRepository();
        }

        public int AddDepolarService(Depolar depolar)
        {
            try
            {
                return _depolarRepository.AddItem(depolar);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<Depolar> TumDepolarıGetir()
        {
            return _depolarRepository.GetAll().ToList();
        }

        public Depolar DepolarGetirById(int ID)
        {
            return _depolarRepository.GetById(ID);
        }

        public int DepolarUpdate(Depolar depolar)
        {
            return _depolarRepository.UpdateItem(depolar);
        }

        public int DepolarSil(Depolar depolar)
        {
            return _depolarRepository.DeleteItem(depolar);
        }

        public List<Depolar> ArananDepolarService(string isim)
        {
            return _depolarRepository.DepoAra(isim).ToList();
        }
    }
}

