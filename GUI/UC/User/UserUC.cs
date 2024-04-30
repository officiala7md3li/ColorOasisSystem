using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC
{
    public partial class UserUC : MasterUC
    {
        public UserUC()
        {
            InitializeComponent();
        }
        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Image_Capture = this.Username_Pic;
            var mainMenuForm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            mainMenuForm.Showing_Page_On_Screen(false, true, "Camera_Shot");
            mainMenuForm.Refresh();

        }
    }
}
