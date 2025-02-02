using A7MD_Library.Sliders;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC
{
    public partial class SettingsMasterUC : MasterSecondMenu
    {
        public SettingsMasterUC()
        {
            InitializeComponent();
        }

        private async void SaveSettings_Btn_Click(object sender, EventArgs e)
        {
            await SaveDataAsync();
        }
        public virtual async Task SaveDataAsync()
        {
            popMessage("تمت حفظ الاعدادات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
        }
        private void Option_Btn_Click(object sender, EventArgs e)
        {
            SaveSettings_Btn.BringToFront();
            Cursor.Position = new Point(SaveSettings_Btn.Parent.PointToScreen(SaveSettings_Btn.Location).X + (SaveSettings_Btn.Size.Width / 2), SaveSettings_Btn.Parent.PointToScreen(SaveSettings_Btn.Location).Y + (SaveSettings_Btn.Size.Height / 2));
            SaveSettings_Btn.Visible = true;
            Options_Tmr.Start();
            Refresh();
        }

        private void Options_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                Options_Tmr.Stop();
                A2SAnimator1.StandardAnimate(SaveSettings_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                SaveSettings_Btn.Visible = false;
            }
            catch
            {
                SaveSettings_Btn.Visible = false;
            }
        }

        private void SaveSettings_Btn_MouseLeave(object sender, EventArgs e)
        {
            Options_Tmr.Start();
        }

        private void SaveSettingsMouseEnterHover(object sender, EventArgs e)
        {
            Options_Tmr.Stop();
        }
    }
}
