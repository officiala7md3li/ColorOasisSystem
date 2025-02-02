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
            frm.addDropDownUC1.SelectType(Enums.AddDropDown.ItemType);
            frm.AssignPermission(frm.addDropDownUC1, frm.CurrentUser.UserPermission.ServiceTypeUCPermission);
        }

        private void ServiceCategory_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.addDropDownUC1.SelectType(Enums.AddDropDown.ItemCategory);
            frm.AssignPermission(frm.addDropDownUC1, frm.CurrentUser.UserPermission.ServiceCategoryUCPermission);
        }

        private void Service_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.AssignPermission(frm.servicesUC1, frm.CurrentUser.UserPermission.ServiceUCPermission);
        }
    }
}
