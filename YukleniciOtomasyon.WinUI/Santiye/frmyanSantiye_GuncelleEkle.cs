using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YukleniciOtomasyon.WinUI.Santiye
{
    public partial class frmyanSantiye_GuncelleEkle : Form
    {
        public frmyanSantiye_GuncelleEkle()
        {
            InitializeComponent();
        }
        #region design
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void frmyanSantiye_GuncelleEkle_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmyanSantiye_GuncelleEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmyanSantiye_GuncelleEkle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        #endregion
        #region Labels
        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = true;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            lblOncekiFormaGit.Visible = false;
        }

        private void btnKaydetSantiyeOzellik_MouseHover(object sender, EventArgs e)
        {
            lblKaydetSantiyeOzellik.Visible = true;
        }

        private void btnKaydetSantiyeOzellik_MouseLeave(object sender, EventArgs e)
        {
            lblKaydetSantiyeOzellik.Visible = false;
        }

        private void btnGuncelleSantiyeOzellik_MouseHover(object sender, EventArgs e)
        {
            lblGuncelleSantiyeOzellik.Visible = true;
        }

        private void btnGuncelleSantiyeOzellik_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelleSantiyeOzellik.Visible = false;
        }

        private void btnKaydetSantiyeIsTakibi_MouseHover(object sender, EventArgs e)
        {
            lblGuncelleSantiyeIsTakibi.Visible = true;
        }

        private void btnKaydetSantiyeIsTakibi_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelleSantiyeIsTakibi.Visible = false;
        }

        private void btnSilSantiyeIsTakibi_MouseHover(object sender, EventArgs e)
        {
            lblSilSantiyeIsTakibi.Visible = true;
        }

        private void btnSilSantiyeIsTakibi_MouseLeave(object sender, EventArgs e)
        {
            lblSilSantiyeIsTakibi.Visible = false;
        }

        private void btnSilSantiyeOzellik_MouseHover(object sender, EventArgs e)
        {
            lblSilSantiyeOzellik.Visible = true;
        }

        private void btnSilSantiyeOzellik_MouseLeave(object sender, EventArgs e)
        {
            lblSilSantiyeOzellik.Visible = false;
        }

        private void btnEkleMalzeme_MouseHover(object sender, EventArgs e)
        {
            lblMalzemeEkle.Visible = true;
        }

        private void btnEkleMalzeme_MouseLeave(object sender, EventArgs e)
        {
            lblMalzemeEkle.Visible = false;
        }

        private void btnDuzenleMalzeme_MouseHover(object sender, EventArgs e)
        {
            lblDuzenleMalzeme.Visible = true;
        }

        private void btnDuzenleMalzeme_MouseLeave(object sender, EventArgs e)
        {
            lblDuzenleMalzeme.Visible = false;
        }

        private void btnSilMalzeme_MouseHover(object sender, EventArgs e)
        {
            lblSilMalzeme.Visible = true;
        }

        private void btnSilMalzeme_MouseLeave(object sender, EventArgs e)
        {
            lblSilMalzeme.Visible = false;
        }
        #endregion


    }
}
