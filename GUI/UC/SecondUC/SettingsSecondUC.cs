using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC.SecondUC
{
    public partial class SettingsSecondUC : ColorOasisSystem.GUI.UC.MasterSecondMenu
    {
        public SettingsSecondUC()
        {
            InitializeComponent();
        }

        private void GlobalSettings_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.settingsUC1);
        }
    }
}
