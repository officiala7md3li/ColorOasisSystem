using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ColorOasisSystem.GUI.HelpingProgram
{
    public partial class SreachForm<T> : Form where T : new()
    {
        private List<T> Items { get; set; }
        public SreachForm(List<T> items, List<HelpingSearchForm> helpingSearch)
        {
            InitializeComponent();
            Items=items;
            // Create the DataGridViewButtonColumn for the first column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "ButtonColumn",
                HeaderText = "التفاصيل",
                Text = "عرض",
                DisplayIndex = 0,
                Width = 79,
                SortMode = DataGridViewColumnSortMode.Programmatic,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                FlatStyle = FlatStyle.Flat,
            };

            // Add the button column to the DataGridView.
            DGV_Search.Columns.Add(buttonColumn);


            // Enable column header editing.
            DGV_Search.EnableHeadersVisualStyles = false;
            DGV_Search.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DGV_Search.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            DGV_Search.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            DGV_Search.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            DGV_Search.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DGV_Search.DefaultCellStyle.Font = new Font("Cairo", 8.0f);
            DGV_Search.DefaultCellStyle.ForeColor = Color.White;
            DGV_Search.DefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 188, 152);
            DGV_Search.DefaultCellStyle.SelectionForeColor = Color.White;
            DGV_Search.DefaultCellStyle.BackColor = Color.FromArgb(2, 188, 152);
            DGV_Search.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Search.DefaultCellStyle.Font = new Font("Cairo", 8.0f);
            DGV_Search.ThemeStyle.HeaderStyle.BackColor= Color.FromArgb(2, 188, 152);
            //DGV_Search.CellTemplate.Style.BackColor = Color.FromArgb(2, 188, 152);
            //DGV_Search.CellTemplate.Style.ForeColor = Color.White;
            //DGV_Search.CellTemplate.Style.SelectionBackColor = Color.FromArgb(170, 199, 254);

            // Hook up the event handler for column header editing.


            Search_CmboBox.DataSource = helpingSearch;
            // Bind the generic list to the DataGridView.
            DGV_Search.DataSource = Items;

            // Set ValueMember and DisplayMember
            Search_CmboBox.DisplayMember = "Display"; // DisplayMember is the "Display" property
            Search_CmboBox.ValueMember = "Value";
            Search_CmboBox.SelectedIndex= 1;

        }
        public SreachForm()
        {
            InitializeComponent();
        }

        public List<T> GetRecordByProperty<T>(List<T> sourceList, string propertyName, string searchValue)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found in type '{typeof(T).Name}'.");
            }

            // return sourceList.FirstOrDefault(item => propertyInfo.GetValue(item)?.ToString() == searchValue);
            List<T> result = sourceList.Where(item => (propertyInfo.GetValue(item)?.ToString()).Contains(searchValue) == true).ToList(); 
            return result;

        }

        private void Search_TxtBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (Search_TxtBox.Text == "" || String.IsNullOrEmpty(Search_TxtBox.Text) || String.IsNullOrWhiteSpace(Search_TxtBox.Text))
            {
                DGV_Search.DataSource =Items;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DGV_Search.DataSource = null;

                DGV_Search.DataBindings.Clear();
                DGV_Search.Rows.Clear();
                DGV_Search.DataSource =  GetRecordByProperty(Items, Search_CmboBox.SelectedValue.ToString(), Search_TxtBox.Text);
                }
            }
        }

        private void Search_TxtBox_IconLeftClick(object sender, EventArgs e)
        {

            DGV_Search.DataSource = null;

            DGV_Search.DataBindings.Clear();
            DGV_Search.Rows.Clear();
            DGV_Search.DataSource = GetRecordByProperty(Items, Search_CmboBox.SelectedValue.ToString(), Search_TxtBox.Text);
        }

        private void DGV_Search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainMenuForm frm = Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            // Allow editing of the column header text.
            //if (e.Buttoni >= 1) // Skip the first column (Button Column).
            //{
            //todo:uncomment
           // frm.branchUC1.LoadData((int)DGV_Search.CurrentRow.Cells[1].Value);
                Dispose();
            //}
        }
    }
}
