using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK;
using YukleniciOtomasyon.Entities.Model.IK;
using YukleniciOtomasyon.WinUI.Depo;
using YukleniciOtomasyon.WinUI.IK;
using YukleniciOtomasyon.WinUI.Lojistik;
using YukleniciOtomasyon.WinUI.Santiye;
using YukleniciOtomasyon.WinUI.SatinAlma;
using YukleniciOtomasyon.WinUI.Teklif;

namespace YukleniciOtomasyon.WinUI
{
    public partial class frmAnaForm : Form
    {
        PersonelService _personelService;
        PersonelIletisimService _iletisimService;
        PersonelMuhasebeService _muhasebeService;
        public frmAnaForm()
        {
            InitializeComponent();
            _personelService = new PersonelService();
            _iletisimService = new PersonelIletisimService();
            _muhasebeService = new PersonelMuhasebeService();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void frmAnaForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmAnaForm_MouseMove(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmAnaForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }        

        private void btnInsanKaynaklari_Click(object sender, EventArgs e)
        {
            //frmIKBirimi İnsanKaynaklari = new frmIKBirimi();
            //İnsanKaynaklari.MdiParent = this;
            //İnsanKaynaklari.Show();
            //İnsanKaynaklari.MaximizeBox = true;

            panelIslem.Controls.Clear();
            frmIKBirimi insankaynakları = new frmIKBirimi();
            insankaynakları.TopLevel = false;
            panelIslem.Controls.Add(insankaynakları);
            insankaynakları.Show();
            insankaynakları.Dock = DockStyle.Fill;
            insankaynakları.BringToFront();
           

        }

        private void btnTeklifDepartmani_Click(object sender, EventArgs e)
        {

            //
            //TeklifDepartmani.MdiParent = this;
            //TeklifDepartmani.MaximizeBox = true;


            panelIslem.Controls.Clear();
            frmTeklifBirimi TeklifDepartmani = new frmTeklifBirimi();
            TeklifDepartmani.TopLevel = false;
            panelIslem.Controls.Add(TeklifDepartmani);
            TeklifDepartmani.Show();
            TeklifDepartmani.Dock = DockStyle.Fill;
            TeklifDepartmani.BringToFront();

        }

        private void btnSatinAlmaDepartmani_Click(object sender, EventArgs e)
        {
            frmSatinAlmaBirimi satinAlmaDepartmani = new frmSatinAlmaBirimi();
            satinAlmaDepartmani.TopLevel = false;
            panelIslem.Controls.Add(satinAlmaDepartmani);
            satinAlmaDepartmani.Show();
            satinAlmaDepartmani.Dock = DockStyle.Fill;
            satinAlmaDepartmani.BringToFront();
        }

        private void btnBilgilendirme_Click(object sender, EventArgs e)
        {
            if (paneleks.Visible == true)
            {
                paneleks.Visible = false;
            }
            else
            {
                paneleks.Visible = true;
            }
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            paneleks.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmyanMalzemeBilgisi_Listele malzemeBilgisi = new frmyanMalzemeBilgisi_Listele();
            malzemeBilgisi.Show();
            paneleks.Visible = false;
        }

        private void btnLojistikDepartman_Click(object sender, EventArgs e)
        {
            frmLojistikBirimi lojistikDepartmani = new frmLojistikBirimi();
            lojistikDepartmani.TopLevel = false;
            panelIslem.Controls.Add(lojistikDepartmani);
            lojistikDepartmani.Show();
            lojistikDepartmani.Dock = DockStyle.Fill;
            lojistikDepartmani.BringToFront();
        }

        private void btnDepo_Click(object sender, EventArgs e)
        {
            frmDepoBirimi depoBirimi = new frmDepoBirimi();
            depoBirimi.TopLevel = false;
            panelIslem.Controls.Add(depoBirimi);
            depoBirimi.Show();
            depoBirimi.Dock = DockStyle.Fill;
            depoBirimi.BringToFront();
        }

        private void btnSantiye_Click(object sender, EventArgs e)
        {
            frmSantiyeBirimi santiyeBirimi = new frmSantiyeBirimi();
            santiyeBirimi.TopLevel = false;
            panelIslem.Controls.Add(santiyeBirimi);
            santiyeBirimi.Show();
            santiyeBirimi.Dock = DockStyle.Fill;
            santiyeBirimi.BringToFront();
        }

        private void btnCikis_MouseHover(object sender, EventArgs e)
        {
            lblcıkıs.Visible = true;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            lblcıkıs.Visible = false;
        }

        private void btnKucult_MouseHover(object sender, EventArgs e)
        {
            lblKucult.Visible = true;
        }

        private void btnKucult_MouseLeave(object sender, EventArgs e)
        {
            lblKucult.Visible = false;
        }

        private void btnBilgilendirme_MouseHover(object sender, EventArgs e)
        {
            lblBilgilendirme.Visible = true;
        }

        private void btnBilgilendirme_MouseLeave(object sender, EventArgs e)
        {
            lblBilgilendirme.Visible = false;
        }
    }
}
