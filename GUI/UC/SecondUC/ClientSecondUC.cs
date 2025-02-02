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
    public partial class ClientSecondUC : MasterSecondMenu
    {
        public ClientSecondUC()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.clientUC1, frm.CurrentUser.UserPermission.ClientUCPermission);
        }

        private void Companies_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.companyUC1, frm.CurrentUser.UserPermission.CompanyUCPermission);
        }

        private void ClientTransaction_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.clientTransactionsUC1, frm.CurrentUser.UserPermission.ClientTransUCPermission);
        }

        private void CompanyTransaction_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.clientTransactionsUC1, frm.CurrentUser.UserPermission.CompanyTransUCPermission);
        }
    }
}
