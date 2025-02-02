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
    public partial class ClientWorkSecondUC : ColorOasisSystem.GUI.UC.MasterSecondMenu
    {
        public ClientWorkSecondUC()
        {
            InitializeComponent();
        }

        private void Quotation_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.quotationUC1, frm.CurrentUser.UserPermission.QuotationUCPermission);
        }

        private void Inspection_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.inspectionUC1, frm.CurrentUser.UserPermission.InspectionUCPermission);
        }
    }
}
