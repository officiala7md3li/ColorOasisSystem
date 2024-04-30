using Bunifu.UI.WinForms;
using ColorOasisSystem.Entities;
using ColorOasisSystem.GUI;
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
        public static void CloseForm<T>() where T : Form
        {
            if (IsFormOpen(typeof(T)))
            {
                var existingForm = Application.OpenForms.OfType<T>().FirstOrDefault();
                if (existingForm != null)
                {
                    existingForm.Close();
                    existingForm.Dispose();
                }
            }
        }
        public static void OpenForm<T>(params object[] constructorArgs) where T : Form
        {
            if (!IsFormOpen(typeof(T)))
            {
                T form;
                if (constructorArgs.Length > 0)
                {
                    form = (T)Activator.CreateInstance(typeof(T), constructorArgs);
                }
                else
                {
                    form = Activator.CreateInstance<T>();
                }
                form.Show();
            }
            else
            {
                var existingForm = Application.OpenForms.OfType<T>().FirstOrDefault();
                if (existingForm != null)
                {
                    RestoreForm(existingForm, constructorArgs);
                }
            }
        }

        public static bool IsFormOpen(Type type)
        {
            if (!typeof(Form).IsAssignableFrom(type))
                throw new ArgumentException("Type is not a form", nameof(type));

            foreach (Form openForm in Application.OpenForms)
            {
                if (type.IsInstanceOfType(openForm))
                    return true;
            }

            return false;
        }

        public static void RestoreForm(Form form, params object[] constructorArgs)
        {
            if (form is MainMenuForm mainMenuForm && constructorArgs.Length > 0)
            {
                mainMenuForm.MainMenuAssign((User)constructorArgs[0]);
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
                form.Show();
                form.BringToFront();
            }
        }
        public static void CenterControlOnScreen(int width, Control control)
        {
            // Calculate the center position of the screen
            int screenWidth = width;
            int centerX = (screenWidth - control.Width) / 2;
            int centerY = 13;

            // Set the control's location to the center position
            control.Location = new System.Drawing.Point(centerX, centerY);
        }

        public static void CenterControlsOnScreen(int width, params Control[] controls)
        {
            // Calculate the center position of the screen
            int screenWidth = width;

            // Calculate total width of all controls
            int totalWidth = 0;
            foreach (Control control in controls)
            {
                totalWidth += control.Width;
            }

            // Calculate starting x-coordinate for the first control
            int startX = (screenWidth - totalWidth) / 2;

            // Set the initial x-coordinate for positioning controls
            int currentX = startX;
            int y = 8;
            foreach (Control control in controls)
            {
                int centerY = controls[1]==control?(y + (controls[0].Height / 2))-(control.Height/2): y;

                // Set the control's location
                control.Location = new System.Drawing.Point(currentX, centerY);

                // Move to next position
                currentX += control.Width;
            }
        }
        public static void SnackbarShow<T>(T FormOwner, BunifuSnackbar snackbar, string message, BunifuSnackbar.MessageTypes messageTypes = BunifuSnackbar.MessageTypes.Information, int messageDuration = 5, string Actionbtntxt = null, BunifuSnackbar.Positions positions = BunifuSnackbar.Positions.TopCenter) where T : Form, new()
        {
            snackbar.Show(FormOwner as Form, message, messageTypes, messageDuration*1000, Actionbtntxt, positions);
        }
    }
}
