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
    public partial class WelcomeUC : UserControl
    {
        public WelcomeUC()
        {
            InitializeComponent();
            MyHelper.CenterControlsOnScreen(this.Width, LogoLbl, LogoPic);
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.clientUC1);
        }

        private void Companies_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.companyUC1);
        }

        private void Inspection_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.inspectionUC1);
        }

        private void Quotation_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.quotationUC1);
        }
    }
}
