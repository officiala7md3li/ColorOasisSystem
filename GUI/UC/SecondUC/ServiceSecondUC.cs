using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC
{
    public partial class ServiceSecondUC : ColorOasisSystem.GUI.UC.MasterSecondMenu
    {
        public ServiceSecondUC()
        {
            InitializeComponent();
        }

        private void ServiceType_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.addDropDownUC1);
        }

        private void ServiceCategory_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.addDropDownUC1);
        }

        private void Service_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.servicesUC1);
        }
    }
}
