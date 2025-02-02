using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.Reports
{
    public partial class ReportViewer<T> : Form where T : new ()
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        public ReportViewer(List<T> DataSource,string reportName )
        {
            InitializeComponent();
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "EntityData";
            rs.Value = DataSource;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);

            reportViewer1.LocalReport.ReportEmbeddedResource = reportName != null || reportName != "" ?  reportName: "ColorOasisSystem.Reports.QuotationReport.rdlc";// "ColorOasisSystem.Reports.QuotationReport.rdlc";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            WindowState= FormWindowState.Normal;
            A2MiniButton1_Click(null,null);
        }

        private void A2MaxiButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void A2MiniButton1_Click(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromRectangle(this.Bounds).WorkingArea.Size;
            FormWindowState windowState = this.WindowState;
            if (windowState != FormWindowState.Normal)
            {
                if (windowState == FormWindowState.Maximized)
                {
                    Form_Dock.BorderRadius = 7;
                    this.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                Form_Dock.BorderRadius = 0;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void A2CloseButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
