using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helpers
{
    public class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox text)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                text.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                text.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidation(TextBox text)
        {
            if(!int.TryParse(text.Text, out int _))
            {
                text.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                text.BackColor = Color.White;
                return true;
            }
        }

        public static bool DateValidation(TextBox text)
        {
            if(!DateTime.TryParseExact(text.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out _))
            {
                text.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                text.BackColor = Color.White;
                return true;
            }
        }

        public static bool ComboValidation(ComboBox cmb)
        {
            if(cmb.SelectedIndex == -1)
            {
                cmb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }

        public static bool AllNumberValidation(TextBox text)
        {
            if(text.Text.Any(s => char.IsLetter(s)))
            {
                text.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                text.BackColor = Color.White;
                return true;
            }
        }

        public static bool BoundaryNumber(TextBox text, int donja, int gornja)
        {
            try
            {
                if(int.Parse(text.Text) < donja || int.Parse(text.Text) > gornja)
                {
                    text.BackColor = Color.LightCoral;
                    return false;
                }
                else
                {
                    text.BackColor = Color.White;
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
