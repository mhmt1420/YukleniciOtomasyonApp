using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataMesaji
{
    public static class HataMesajiVerme
    {
        static bool _temizle=false;
        static ErrorProvider _errorProvider = new ErrorProvider();
        
        public static double SayiMi(Control item)
        {
            double converted = -1;
            if (item is TextBox)
            {
                TextBox cont = (TextBox)item;
                try
                {
                    try
                    {
                        string[] words = cont.Text.Split(',', '.');
                        string newword = "0," + words[1];
                        converted = Convert.ToDouble(words[0]) + Convert.ToDouble(newword);
                    }
                    catch (Exception)
                    {
                        converted = Convert.ToInt32(cont.Text);
                    }
                    _errorProvider.SetError(cont, String.Empty);

                }
                catch (Exception)
                {
                    _errorProvider.SetError(cont, "Lütfen Sayı Giriniz!");
                }
            }
            else if (item is NumericUpDown)
            {
                NumericUpDown cont = (NumericUpDown)item;
                try
                {
                    if (cont.Value>=cont.Minimum && cont.Value<=cont.Maximum)
                    {
                    converted = Convert.ToInt32(cont.Value);
                    _errorProvider.SetError(cont, String.Empty);
                        MessageBox.Show(Convert.ToString(converted));
                    }
                }
                catch (Exception)
                {
                    _errorProvider.SetError(cont, string.Format("Lütfen {0}-{1} Arasında Sayı Giriniz!",cont.Minimum,cont.Maximum));
                }
            }
            return converted;
        }

        public static string HarfMi(Control cont)
        {
            string converted=null;
            string[] words = cont.Text.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            if (words.Length==1)
            {
                converted = cont.Text;
                _errorProvider.SetError(cont, String.Empty);
            }
            else
            {
                _errorProvider.SetError(cont, "Girdiğiniz Değeri Kontrol Ediniz!");
            }
            return converted;
        }
        public static void HataVarMi(Control.ControlCollection koleksiyon, bool temizle)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    if (string.IsNullOrEmpty(tb.Text))
                    {
                        _errorProvider.SetError(tb, "Bu Alan Boş Geçilemez!");
                    }
                    if (temizle)
                    {
                        tb.Clear();
                    }
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)item;
                    SayiMi(item);
                    if (temizle)
                    {
                    nmr.Value = nmr.Minimum;
                    }
                }
                else if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if (temizle)
                    {
                    cb.Checked = false;
                    }
                }
                else if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (temizle)
                    {
                    rb.Checked = false;
                    }
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    HataVarMi(gb.Controls,_temizle);

                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flv = (FlowLayoutPanel)item;
                    HataVarMi(flv.Controls,_temizle);
                }
                else if (item is DataGridView)
                {
                    DataGridView dgw = (DataGridView)item;
                    HataVarMi(dgw.Controls,_temizle);
                }
                else if (item is ListBox)
                {
                    ListBox lb = (ListBox)item;
                    HataVarMi(lb.Controls,_temizle);
                }
                else if (item is CheckedListBox)
                {
                    CheckedListBox clb = (CheckedListBox)item;
                    HataVarMi(clb.Controls,_temizle);
                }
            }
        }
    }
}
