using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M15_trabalho
{
    class Elementos
    {
        public int id { get; set; }

        public override string ToString()
        {
            return id.ToString();
        }
           
        public static void ErrorProvider(MaskedTextBox mtb, ErrorProvider ep, string msg)
        {
            string text = mtb.Text;
            bool hasDigit = false;

            foreach (var letter in text)
            {
                if(char.IsDigit(letter))
                {
                    hasDigit = true;
                    break;
                }
            }

            if(!hasDigit)
            {
                ep.SetError(mtb, msg);
            }
            else
            {
                ep.Clear();
            }
        }

        public static void ErrorProviderComboBox(ComboBox cb, ErrorProvider ep, string msg)
        {
            if(cb.SelectedIndex == -1)
            {
                ep.SetError(cb, msg);
            }
            else
            {
                ep.Clear();
            }
        }
            
    }
}
