using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.WinUI
{
    public partial class frmGirisForm : Form
    {
        public frmGirisForm()
        {
            InitializeComponent();
        }
        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            FakeDataDoldur fdd = new FakeDataDoldur();
            fdd.PersonelDoldur(10).ToList();
            fdd.DepartmanDoldur("Teklif Birimi", 10);
            fdd.DepartmanDoldur("Satın Alma Birimi", 10);
            fdd.DepartmanDoldur("Depo Birimi", 10);
            fdd.DepartmanDoldur("Lojistik Birimi", 10);
            fdd.DepartmanDoldur("Şantiye Birimi", 10);

            frmAnaForm AnaSayfa = new frmAnaForm();
            AnaSayfa.Show();
            this.Hide();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void frmGirisForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmGirisForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmGirisForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text=="Kullanıcı Adınızı Giriniz")
            {
                txtKullaniciAdi.Text = "";
                txtKullaniciAdi.ForeColor = Color.White;
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.ForeColor = Color.DarkGray;
                txtKullaniciAdi.Text = "Kullanıcı Adınızı Giriniz";
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Sifrenizi Giriniz")
            {
                txtSifre.Text = "";
                txtSifre.PasswordChar = '*';
                txtSifre.ForeColor = Color.White;
            }
        }
        char? bosluk = null;
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.PasswordChar = Convert.ToChar(bosluk);
                txtSifre.ForeColor = Color.DarkGray;
                txtSifre.Text = "Sifrenizi Giriniz";
            }
        }

        private void frmGirisForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.95;
        }
    }
}
