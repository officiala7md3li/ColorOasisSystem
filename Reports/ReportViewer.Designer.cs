using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
namespace ColorOasisSystem.Reports
{
    partial class ReportViewer<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewer));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.A2MaxiButton1 = new A7MD_Library.NewControls.A2MaximizeButton();
            this.A2MiniButton1 = new A7MD_Library.NewControls.A2MinimizeButton();
            this.A2CloseButton1 = new A7MD_Library.NewControls.A2CloseButton();
            this.Form_Dock = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.bunifuFormResizer1 = new Bunifu.UI.WinForms.BunifuFormResizer(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 417);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.bunifuLabel1);
            this.Panel1.Controls.Add(this.A2MaxiButton1);
            this.Panel1.Controls.Add(this.A2MiniButton1);
            this.Panel1.Controls.Add(this.A2CloseButton1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Panel1.Size = new System.Drawing.Size(800, 33);
            this.Panel1.TabIndex = 249;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(121, 25);
            this.bunifuLabel1.TabIndex = 51;
            this.bunifuLabel1.Text = "Report Viewer";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // A2MaxiButton1
            // 
            this.A2MaxiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A2MaxiButton1.BackColor = System.Drawing.Color.Transparent;
            this.A2MaxiButton1.Colors = new A7MD_Library.A2_Library.Helping.Bloom[0];
            this.A2MaxiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2MaxiButton1.Customization = "";
            this.A2MaxiButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.A2MaxiButton1.Image = null;
            this.A2MaxiButton1.IsMaximizeButton = false;
            this.A2MaxiButton1.Location = new System.Drawing.Point(708, 3);
            this.A2MaxiButton1.Name = "A2MaxiButton1";
            this.A2MaxiButton1.NoRounding = false;
            this.A2MaxiButton1.Size = new System.Drawing.Size(23, 23);
            this.A2MaxiButton1.TabIndex = 26;
            this.A2MaxiButton1.Text = "A2MaxiButton1";
            this.A2MaxiButton1.Transparent = true;
            this.A2MaxiButton1.Click += new System.EventHandler(this.A2MaxiButton1_Click);
            // 
            // A2MiniButton1
            // 
            this.A2MiniButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A2MiniButton1.BackColor = System.Drawing.Color.Transparent;
            this.A2MiniButton1.Colors = new A7MD_Library.A2_Library.Helping.Bloom[0];
            this.A2MiniButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2MiniButton1.Customization = "";
            this.A2MiniButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.A2MiniButton1.Image = null;
            this.A2MiniButton1.IsMinimizeButton = false;
            this.A2MiniButton1.Location = new System.Drawing.Point(737, 3);
            this.A2MiniButton1.Name = "A2MiniButton1";
            this.A2MiniButton1.NoRounding = false;
            this.A2MiniButton1.Size = new System.Drawing.Size(23, 23);
            this.A2MiniButton1.TabIndex = 25;
            this.A2MiniButton1.Text = "A2MiniButton1";
            this.A2MiniButton1.Transparent = true;
            this.A2MiniButton1.Click += new System.EventHandler(this.A2MiniButton1_Click);
            // 
            // A2CloseButton1
            // 
            this.A2CloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A2CloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.A2CloseButton1.Colors = new A7MD_Library.A2_Library.Helping.Bloom[0];
            this.A2CloseButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2CloseButton1.Customization = "";
            this.A2CloseButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.A2CloseButton1.Image = null;
            this.A2CloseButton1.IsCloseButton = false;
            this.A2CloseButton1.Location = new System.Drawing.Point(766, 3);
            this.A2CloseButton1.Name = "A2CloseButton1";
            this.A2CloseButton1.NoRounding = false;
            this.A2CloseButton1.Size = new System.Drawing.Size(23, 23);
            this.A2CloseButton1.TabIndex = 24;
            this.A2CloseButton1.Text = "A2CloseButton1";
            this.A2CloseButton1.Transparent = true;
            this.A2CloseButton1.Click += new System.EventHandler(this.A2CloseButton1_Click);
            // 
            // Form_Dock
            // 
            this.Form_Dock.BorderRadius = 7;
            this.Form_Dock.ContainerControl = this;
            this.Form_Dock.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.Form_Dock.DockIndicatorTransparencyValue = 0.1D;
            this.Form_Dock.DragStartTransparencyValue = 0.5D;
            this.Form_Dock.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.Form_Dock.TransparentWhileDrag = true;
            // 
            // bunifuFormResizer1
            // 
            this.bunifuFormResizer1.ContainerControl = this;
            this.bunifuFormResizer1.Enabled = true;
            this.bunifuFormResizer1.ParentForm = this;
            this.bunifuFormResizer1.ResizeHandlesWidth = 6;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        internal A7MD_Library.NewControls.A2MaximizeButton A2MaxiButton1;
        internal A7MD_Library.NewControls.A2MinimizeButton A2MiniButton1;
        internal A7MD_Library.NewControls.A2CloseButton A2CloseButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        internal Guna.UI2.WinForms.Guna2BorderlessForm Form_Dock;
        private Bunifu.UI.WinForms.BunifuFormResizer bunifuFormResizer1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}