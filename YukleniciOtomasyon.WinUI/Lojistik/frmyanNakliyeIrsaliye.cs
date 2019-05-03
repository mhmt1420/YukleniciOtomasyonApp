using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YukleniciOtomasyon.WinUI.Lojistik
{
    public partial class frmyanNakliyeIrsaliye : Form
    {
        public frmyanNakliyeIrsaliye()
        {
            InitializeComponent();
        }

        private void btnGuncelleNakliyeIrsaliye_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydetNakliyeIrsaliye_Click(object sender, EventArgs e)
        {

        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void frmyanNakliyeIrsaliye_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmyanNakliyeIrsaliye_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmyanNakliyeIrsaliye_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region labels 
        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = false;
        }

        private void btnKaydetNakliyetFirması_MouseHover(object sender, EventArgs e)
        {
            lblKaydetNakliyetFirması.Visible = true;
        }

        private void btnKaydetNakliyetFirması_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetNakliyetFirması.Visible = false;
        }

        private void btnGuncelleNakliyetFirması_MouseHover(object sender, EventArgs e)
        {
            lblGuncelleNakliyetFirması.Visible = true;
        }

        private void btnGuncelleNakliyetFirması_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelleNakliyetFirması.Visible = false;
        }

        private void btnDuzenleNakliyeFirma_MouseHover(object sender, EventArgs e)
        {
            lblDuzenleNakliyeFirma.Visible = true;
        }

        private void btnDuzenleNakliyeFirma_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenleNakliyeFirma.Visible = false;
        }

        private void btnSilNakliyeFirma_MouseHover(object sender, EventArgs e)
        {
            lblSilNakliyeFirma.Visible = true;
        }

        private void btnSilNakliyeFirma_MouseLeave(object sender, EventArgs e)
        {
            lblSilNakliyeFirma.Visible = false;
        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            lblKaydet.Visible = true;
        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            lblKaydet.Visible = false;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelle.Visible = true;
        }

        private void btnGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            lblGuncelle.Visible = false;
        }

        private void btnDuzenleNakliyeArac_MouseHover(object sender, EventArgs e)
        {
            lblDuzenleNakliyeArac.Visible = true;
        }

        private void btnDuzenleNakliyeArac_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenleNakliyeArac.Visible = false;
        }

        private void btnSilNakliyeArac_MouseHover(object sender, EventArgs e)
        {
            lblSilNakliyeArac.Visible = true;
        }

        private void btnSilNakliyeArac_MouseLeave(object sender, EventArgs e)
        {
            lblSilNakliyeArac.Visible = false;
        }

        private void btnKaydetNakliyeIrsaliye_MouseHover(object sender, EventArgs e)
        {
            lblKaydetNakliyeIrsaliye.Visible = true;
        }

        private void btnKaydetNakliyeIrsaliye_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetNakliyeIrsaliye.Visible = true;
        }

        private void btnGuncelleNakliyeIrsaliye_MouseHover(object sender, EventArgs e)
        {
            lblGuncelleNakliyeIrsaliye.Visible = false;
        }

        private void btnGuncelleNakliyeIrsaliye_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelleNakliyeIrsaliye.Visible = false;
        }

        private void btnDuzenleNakliyeIrsaliye_MouseHover(object sender, EventArgs e)
        {
            lblDuzenleNakliyeIrsaliye.Visible = true;
        }

        private void btnDuzenleNakliyeIrsaliye_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenleNakliyeIrsaliye.Visible = false;
        }

        private void btnSilNakliyeIrsaliye_MouseHover(object sender, EventArgs e)
        {
            lblSilNakliyeIrsaliye.Visible = true;
        }

        private void btnSilNakliyeIrsaliye_MouseLeave(object sender, EventArgs e)
        {
            lblSilNakliyeIrsaliye.Visible = false;
        }
#endregion
    }
}
