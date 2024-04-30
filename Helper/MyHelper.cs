using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.Helper
{
    public class MyHelper
    {
        public static void OpenForm<T>() where T : Form, new()
        {
            if (!IsFormOpen(typeof(T)))
            {
                T form = new T();
                form.Show();
            }
            else
            {
                var openForm = Application.OpenForms.OfType<T>().FirstOrDefault();
                if (openForm != null)
                {
                    RestoreForm(openForm.Name);
                }
            }
        }

        public static bool IsFormOpen(Type type)
        {
            if (!type.IsSubclassOf(typeof(Form)) && !(type == typeof(Form)))
                throw new ArgumentException("Type is not a form", "type");
            try
            {
                for (int i1 = 0; i1 < Application.OpenForms.Count; i1++)
                {
                    Form f = Application.OpenForms[i1];
                    if (type.IsInstanceOfType(f))
                        return true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                //This can change if they close/open a form while code is running. Just throw it away
            }
            return false;
        }

        public static void RestoreForm(string formName)
        {
            Form f = Application.OpenForms[formName];
            if (f != null)
            {
                f.WindowState = FormWindowState.Normal;
                f.BringToFront();
            }
        }
        public void SnackbarShow<T>(T FormOwner, BunifuSnackbar snackbar, string message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, int messageDuration = 5, string Actionbtntxt = null, BunifuSnackbar.Positions positions=BunifuSnackbar.Positions.TopCenter)
        {
            snackbar.Show(FormOwner as Form, message, messageTypes, messageDuration * 1000, Actionbtntxt, positions);
        }

    }
}
