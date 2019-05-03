using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Lojistik;
using YukleniciOtomasyon.Entities.DTO;

namespace YukleniciOtomasyon.WinUI.Lojistik
{
    public partial class frmLojistikBirimi : Form
    {
        LojistikBirimiService _lojistikBirimiService;
        public frmLojistikBirimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmyanNakliyeIrsaliye nakliyeIrsaliye = new frmyanNakliyeIrsaliye();
            nakliyeIrsaliye.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmyanNakliyeIrsaliye nakliyeIrsaliye = new frmyanNakliyeIrsaliye();
            nakliyeIrsaliye.Show();
        }

        public void frmLojistikBirimi_Load(object sender, EventArgs e)
        {
            dgvNakliyeIslemleriListele.DataSource = null;
            List<LojistikBirimiDTO> NakliyeDetaylari = _lojistikBirimiService.DTOLojistikBirimiGetirService();
            dgvNakliyeIslemleriListele.DataSource = NakliyeDetaylari;
        }
        #region labels
        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            lblKapat.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.Visible = false;
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            lblEkle.Visible = true;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            lblEkle.Visible = false;
        }

        private void btnDuzenle_MouseHover(object sender, EventArgs e)
        {
            lblDuzenle.Visible = true;
        }

        private void btnDuzenle_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenle.Visible = false;
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            lblSil.Visible = true;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            lblSil.Visible = false;
        }
#endregion
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
