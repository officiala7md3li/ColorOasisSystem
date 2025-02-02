using ColorOasisSystem.Entities;
using ColorOasisSystem.Helper;
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
    public partial class MasterSecondMenu : UserControl
    {
        public MasterSecondMenu()
        {
            InitializeComponent();
            //LogoLabel = "";
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            Enabled = false;
            var mainMenuForm = Application.OpenForms.Cast<MainMenuForm>().Where(x => x.Name == "MainMenuForm").FirstOrDefault();
            mainMenuForm.SelectedUC(mainMenuForm.welcomeUC1);
            if (!mainMenuForm.SidePanel.Visible)
            {
                mainMenuForm.SidePanel.Show();
            }
            mainMenuForm.SidePanel.Top = mainMenuForm.Main_Menu_Home_Btn.Top;
            mainMenuForm.A2SGradSlider1.Refresh();
            mainMenuForm.A2SGradSlider1.Invalidate();
        }
        public void SetPermissions(Permission permission)
        {
            MasterUCLock = !permission.Lock;
            Refresh();
            Invalidate();
        }
        private bool masterUCLockValue = false;
        public bool MasterUCLock
        {
            get { return masterUCLockValue; }
            set
            {
                masterUCLockValue = value;
                DisableLockBtn.Visible = value;
                Invalidate();
            }
        }
        public Image Logoimage 
        { 
            get
            { return LogoPic.Image; } 
            set 
            { 
                LogoPic.Image = value;
                Invalidate();
                MyHelper.CenterControlsOnScreen(this.Width, LogoLbl, LogoPic);
                LogoPic.Refresh();
            } 
        }
        public string LogoLabel
        {
            get { return LogoLbl.Text; }
            set 
            {
                //logoLabel = value;
                LogoLbl.Text = value;
                MyHelper.CenterControlsOnScreen(this.Width,LogoLbl ,LogoPic );
                Invalidate();
            }
        }
        public virtual void popMessage(string Caption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes, int timerDelay = 5)
        {
            MainMenuForm MainForm_Var = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            MyHelper.SnackbarShow(MainForm_Var, MainForm_Var.Snackbar, Caption, messageTypes, timerDelay);
        }

    }
}
