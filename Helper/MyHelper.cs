using Bunifu.UI.WinForms;
using ColorOasisSystem.Entities;
using ColorOasisSystem.GUI;
using ColorOasisSystem.GUI.Login;
using ColorOasisSystem.GUI.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace ColorOasisSystem.Helper
{
    public class MyHelper
    {
        bool isEnglish;
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
        public static DataTable ConvertToDataTable(List<Dictionary<string, object>> list, string[] columns)
        {
            DataTable dataTable = new DataTable();

            // Define the columns in the DataTable using AddRange
            var dataColumns = columns.Select(column => new DataColumn(column, typeof(object))).ToArray();
            dataTable.Columns.AddRange(dataColumns);

            // Populate the rows in the DataTable
            foreach (var dict in list)
            {
                var row = dataTable.NewRow();
                foreach (var column in columns)
                {
                    row[column] = dict.ContainsKey(column) ? dict[column] ?? DBNull.Value : DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public static void ChangeMode(Color color)
        {
            MainMenuForm mainMenu = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if(loginForm != null)
            {
                loginForm.BackColor= color;
                loginForm.Banner_Image.BackColor = color;

                foreach (Control ctrl in loginForm.BunifuPages2.Controls)
                {
                    if (ctrl is TabPage)
                    {
                        TabPage TabCtrl = (TabPage)ctrl;
                        TabCtrl.BackColor = color;
                        TabCtrl.Refresh();
                    }
                }
            }
            if (mainMenu != null)
            {
                mainMenu.BackColor= color;
                mainMenu.Exit_PictureBox.BackColor = color;
                foreach (Control ctrl in mainMenu.BunifuPages2.Controls)
                {
                    if (ctrl is TabPage)
                    {
                        TabPage TabCtrl = (TabPage)ctrl;
                        TabCtrl.BackColor = color;
                        TabCtrl.Refresh();
                    }
                }
                mainMenu.A2SGradSlider1.TopLeft = color;
                mainMenu.A2SGradSlider1.BottomRight = color;
                mainMenu.inspectionUC1.SiticonePanel1.PrimerColor = color;
                mainMenu.inspectionUC1.SiticonePanel1.TopLeft = color;
                mainMenu.inspectionUC1.SiticonePanel1.BottomLeft = color;
                mainMenu.inspectionUC1.SiticonePanel1.BottomRight = color;
                mainMenu.inspectionUC1.SiticonePanel1.TopRight = color;

            }

        }
        //                        catch (Exception exc)
                        //{
                        //    Utilities.save_Log(exc.Message, exc);
        public static void save_Log(string message, Exception exception)
        {
            //try
            //{
            //    //get connected db name
            //    System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            //    builder.ConnectionString = DAL.Config.ConnectionString;

            //    string LinkITERP_path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\LinkITERP";
            //    if (!System.IO.Directory.Exists(LinkITERP_path))
            //        System.IO.Directory.CreateDirectory(LinkITERP_path);

            //    string logFileName = LinkITERP_path + "\\" + builder.InitialCatalog + "_Log.txt";
            //    if (!System.IO.File.Exists(logFileName))
            //        System.IO.File.CreateText(logFileName);

            //    StreamWriter sw = File.AppendText(logFileName);
            //    sw.WriteLine(DateTime.Now.ToString() + ">> " + message);
            //    if (exception != null)
            //    {
            //        sw.WriteLine(DateTime.Now.ToString() + "Inner Exception: " + exception.InnerException?.Message);
            //        sw.WriteLine(DateTime.Now.ToString() + "Stacke Trace: " + exception.InnerException?.StackTrace);
            //    }
            //    sw.Flush();
            //    sw.Close();
            //}
            //catch { }
        }
    }
}

