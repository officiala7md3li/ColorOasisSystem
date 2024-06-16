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
            frm.SelectedUC(frm.quotationUC1);
        }

        private void Inspection_Click(object sender, EventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            frm.SelectedUC(frm.inspectionUC1);
        }
    }
}
