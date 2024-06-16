using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorOasisSystem.GUI;
using ColorOasisSystem.GUI.Login; 
namespace ColorOasisSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for tehe application.
        /// </summary>
        [STAThread]//[MTAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MainMenuForm MainForm_Var = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
                LoginForm LoginForm_Var = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                if(MainForm_Var != null)
                {
                    Helper.MyHelper.SnackbarShow(MainForm_Var, MainForm_Var.Snackbar, ex.Message,Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,10);
                }
                else if (LoginForm_Var!=null)
                {
                    Helper.MyHelper.SnackbarShow(LoginForm_Var, LoginForm_Var.Snackbar, ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,10);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
