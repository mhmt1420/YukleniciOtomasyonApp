using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YukleniciOtomasyon.WinUI
{
    public class DosyaAcici
    {
        public static string DosyaSec(int id,out string filename)
        {
            List<string> vs = new List<string>();
            string source=null;
            filename=null;
            string destination = null;

            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileDialog.Filter =
                "Dökümanlar (*.doc;*.docm;*.dotx;*.dotm;*.xlsx;*.xlsm;*.xltx;*.xltm;*.xlam;*.pptx;*.pptm;*.sldx;" +
                "*.docx;*.odt;*.pdf;*.rtf;*.tex;*.wks;*.wps;*.wpd;*.txt)" +
                "|*.doc;*.docm;*.dotx;*.dotm;*.xlsx;*.xlsm;*.xltx;*.xltm;*.xlam;*.pptx;*.pptm;*.sldx;" +
                "*.docx;*.odt;*.pdf;*.rtf;*.tex;*.wks;*.wps;*.wpd;*.txt" +

                "|Görüntü Dosyaları(*.png;*.gif;*.tiff;*.psd;*.ai;*.eps;*.indd;*.bmp;*.raw;*.bmp;*.jpg;*.gif)" +
                "|*.png;*.gif;*.tiff;*.psd;*.ai;*.eps;*.indd;*.bmp;*.raw;*.bmp;*.jpg;*.gif" +

                "|All files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;
            

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                source = fileDialog.FileName;
                filename = id.ToString() + "_" + Path.GetFileName(source);
                destination = @"C:\\Teklif Birimi\\Ihaleler\\" + id.ToString() + "_Ihale";
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }
                File.Copy(source, Path.Combine(destination, filename));
            }
            return destination;
        }
    }
}
