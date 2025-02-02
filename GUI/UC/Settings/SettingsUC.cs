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
    public partial class SettingsUC : SettingsMasterUC
    {
        public SettingsUC()
        {
            InitializeComponent();
        }
        public override async Task SaveDataAsync()
        {
            if (NewDataDrpDwn.SelectedIndex == -1)
            {
                popMessage("يجب اختيار كيفيه تنظيف الشاشه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5);
                return;
            }
            else if (NewDataDrpDwn.SelectedIndex == 0)
            {
                Properties.Settings.Default.AfterClose = false;
                Properties.Settings.Default.BeforeOpen = true;
            }
            else if (NewDataDrpDwn.SelectedIndex == 1)
            {
                Properties.Settings.Default.AfterClose = true;
                Properties.Settings.Default.BeforeOpen = false;
            }
            else
            {
                Properties.Settings.Default.AfterClose = false;
                Properties.Settings.Default.BeforeOpen = false;
            }
            Properties.Settings.Default.BGColor = A2ColorChooser1.Value;
            Properties.Settings.Default.Save();
            popMessage("تمت حفظ الاعدادات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            MyHelper.ChangeMode(A2ColorChooser1.Value);
        }


        private void SettingsUC_Load(object sender, EventArgs e)
        {
            bool afterClose = Properties.Settings.Default.AfterClose;
            bool beforeOpen = Properties.Settings.Default.BeforeOpen;
            NewDataDrpDwn.SelectedIndex = afterClose == false && beforeOpen == false ? 2 : afterClose == false && beforeOpen ? 0 : 1;
            A2ColorChooser1.Value = Properties.Settings.Default.BGColor;
        }
    }
}
