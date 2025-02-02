using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.Helper
{
    public static class TextBoxExtension
    {
        public static void AllowOnlyNumbers(this Guna2TextBox textBox)
        {
            textBox.KeyPress += TextBox_KeyPress;
            textBox.TextChanged += TextBox_TextChanged;
            textBox.ShortcutsEnabled = false;
        }

        private static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys such as backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static void TextBox_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;

            if (textBox != null)
            {
                string text = textBox.Text;
                if (!Regex.IsMatch(text, @"^\d*$"))
                {
                    textBox.Text = Regex.Replace(text, @"[^\d]", string.Empty);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }
    }
}
