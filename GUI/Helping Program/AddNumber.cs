using ColorOasisSystem.Enums;
using ColorOasisSystem.GUI.UC;
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

namespace ColorOasisSystem.GUI.Helping_Program
{
    public partial class AddNumber : Form
    {
        DataGridViewCell DataGridViewCell { get; set; }
        int MaximumVal = 0;
        int MinVal = 0;
        public AddNumber()
        {
            InitializeComponent();
            Color color = Properties.Settings.Default.BGColor;
            BackColor = color;
            Item_Qty_TxtBox.AllowOnlyNumbers();
        }
        public AddNumber( DataGridViewCell cell, int MaximumValue, int MinimumValue, AddNumType numType = AddNumType.Qty)
        {
            InitializeComponent();
            DataGridViewCell = cell;
            MaximumVal = MaximumValue;
            MinVal = MinimumValue;
            Item_Qty_TxtBox.Text = DataGridViewCell.Value.ToString();            
            Item_Qty_TxtBox.AllowOnlyNumbers();
        }

        private void Yes_Btn_Click(object sender, EventArgs e)
        {
            decimal Num = Convert.ToDecimal(Item_Qty_TxtBox.Text);
            if (Num < 0)
            {
                Helper.MyHelper.SnackbarShow(this, Snackbar, "The Number Must be Greater Than 0", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
                return;
            }
            if (Num > MaximumVal)
            {
                Helper.MyHelper.SnackbarShow(this, Snackbar, "The Maximum Must be Greater Than The Number", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
                return;
            }
            if (Num < MinVal)
            {
                Helper.MyHelper.SnackbarShow(this, Snackbar, "The Number Must be Greater Than Minimum Value", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
                return;
            }
            if (Num > 0 && Num < MaximumVal && Num > MinVal)
            {
                DataGridViewCell.Value = Item_Qty_TxtBox.Text;
                Dispose();
            }
        }

        private void Item_Qty_TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal Num = Convert.ToDecimal(Item_Qty_TxtBox.Text);
                if (Num < 0)
                {
                    Helper.MyHelper.SnackbarShow(this, Snackbar, "The Number Must be Greater Than 0", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
                    return;
                }
                if (Num > MaximumVal)
                {
                    Helper.MyHelper.SnackbarShow(this, Snackbar, "The Maximum Must be Greater Than The Number", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
                    return;
                }
                if (Num < MinVal)
                {
                    Helper.MyHelper.SnackbarShow(this, Snackbar, "The Number Must be Greater Than Minimum Value", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
                    return;
                }
                if (Num > 0&& Num< MaximumVal&& Num>MinVal)
                {
                    Yes_Btn_Click(null, null);
                }

            }
        }

        private void Item_Qty_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Qty_TxtBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Item_Qty_TxtBox.Text)) return;
            decimal Num= Convert.ToDecimal(Item_Qty_TxtBox.Text);
            if(Num < 0)
            {
                Helper.MyHelper.SnackbarShow(this, Snackbar, "The Number Must be Greater Than 0", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
            }
            if (Num > MaximumVal)
            {
                Helper.MyHelper.SnackbarShow(this, Snackbar, "The Maximum Must be Greater Than The Number", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
            }
            if (Num <MinVal)
            {
                Helper.MyHelper.SnackbarShow(this, Snackbar, "The Number Must be Greater Than Minimum Value", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 10);
            }
        }
    }
}
