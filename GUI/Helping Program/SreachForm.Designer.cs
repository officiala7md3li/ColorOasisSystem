using System.Collections.Generic;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.HelpingProgram
{
    partial class SreachForm<T>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Search = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Eli1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Eli2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Search_CmboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ASeperator1 = new A7MD_Library.Seperators.ASeperator();
            this.A2CloseButton1 = new A7MD_Library.NewControls.A2CloseButton();
            this.Search_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Search
            // 
            this.DGV_Search.AllowUserToAddRows = false;
            this.DGV_Search.AllowUserToDeleteRows = false;
            this.DGV_Search.AllowUserToResizeColumns = false;
            this.DGV_Search.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Search.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Search.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Search.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGV_Search.Location = new System.Drawing.Point(12, 110);
            this.DGV_Search.MultiSelect = false;
            this.DGV_Search.Name = "DGV_Search";
            this.DGV_Search.ReadOnly = true;
            this.DGV_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(128)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Search.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Search.RowHeadersVisible = false;
            this.DGV_Search.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Search.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Search.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.DGV_Search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Search.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Search.Size = new System.Drawing.Size(528, 188);
            this.DGV_Search.TabIndex = 233;
            this.DGV_Search.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.DGV_Search.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Search.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_Search.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_Search.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.DGV_Search.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Search.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Search.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGV_Search.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.DGV_Search.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Search.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGV_Search.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Search.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Search.ThemeStyle.HeaderStyle.Height = 21;
            this.DGV_Search.ThemeStyle.ReadOnly = true;
            this.DGV_Search.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Search.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Search.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DGV_Search.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_Search.ThemeStyle.RowsStyle.Height = 22;
            this.DGV_Search.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.DGV_Search.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_Search_MouseDoubleClick);
            // 
            // Eli1
            // 
            this.Eli1.BorderRadius = 7;
            this.Eli1.TargetControl = this;
            // 
            // Eli2
            // 
            this.Eli2.BorderRadius = 15;
            this.Eli2.TargetControl = this.DGV_Search;
            // 
            // Search_CmboBox
            // 
            this.Search_CmboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_CmboBox.Animated = true;
            this.Search_CmboBox.AutoRoundedCorners = true;
            this.Search_CmboBox.BackColor = System.Drawing.Color.Transparent;
            this.Search_CmboBox.BorderColor = System.Drawing.Color.DarkGray;
            this.Search_CmboBox.BorderRadius = 17;
            this.Search_CmboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_CmboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Search_CmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Search_CmboBox.DropDownWidth = 106;
            this.Search_CmboBox.FocusedColor = System.Drawing.Color.DodgerBlue;
            this.Search_CmboBox.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Search_CmboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Search_CmboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Search_CmboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.Search_CmboBox.ItemHeight = 30;
            this.Search_CmboBox.Items.AddRange(new object[] {
            "لايوجد"});
            this.Search_CmboBox.Location = new System.Drawing.Point(387, 48);
            this.Search_CmboBox.Name = "Search_CmboBox";
            this.Search_CmboBox.Size = new System.Drawing.Size(131, 36);
            this.Search_CmboBox.TabIndex = 237;
            this.Search_CmboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_CmboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Enabled = false;
            this.Label4.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Gray;
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(255, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 24);
            this.Label4.TabIndex = 234;
            this.Label4.Text = "بحث";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Drag
            // 
            this.Form_Drag.DockIndicatorTransparencyValue = 0.6D;
            this.Form_Drag.DragStartTransparencyValue = 0.85D;
            this.Form_Drag.UseTransparentDrag = true;
            // 
            // ASeperator1
            // 
            this.ASeperator1.BackColor = System.Drawing.Color.Transparent;
            this.ASeperator1.Border = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ASeperator1.Colors = new A7MD_Library.A2_Library.Helping.Bloom[0];
            this.ASeperator1.Customization = "";
            this.ASeperator1.Enabled = false;
            this.ASeperator1.EndBorder = System.Drawing.Color.LightGray;
            this.ASeperator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.ASeperator1.Image = null;
            this.ASeperator1.Location = new System.Drawing.Point(93, 89);
            this.ASeperator1.Name = "ASeperator1";
            this.ASeperator1.NoRounding = false;
            this.ASeperator1.Size = new System.Drawing.Size(366, 14);
            this.ASeperator1.TabIndex = 238;
            this.ASeperator1.Text = "ASeperator1";
            this.ASeperator1.Transparent = true;
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
            this.A2CloseButton1.IsCloseButton = true;
            this.A2CloseButton1.Location = new System.Drawing.Point(521, 7);
            this.A2CloseButton1.Name = "A2CloseButton1";
            this.A2CloseButton1.NoRounding = false;
            this.A2CloseButton1.Size = new System.Drawing.Size(23, 23);
            this.A2CloseButton1.TabIndex = 232;
            this.A2CloseButton1.Text = "A2CloseButton1";
            this.A2CloseButton1.Transparent = true;
            // 
            // Search_TxtBox
            // 
            this.Search_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_TxtBox.AutoRoundedCorners = true;
            this.Search_TxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.Search_TxtBox.BorderRadius = 16;
            this.Search_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_TxtBox.DefaultText = "";
            this.Search_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TxtBox.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Search_TxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search_TxtBox.ForeColor = System.Drawing.Color.DimGray;
            this.Search_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.Search_TxtBox.IconLeft = global::ColorOasisSystem.Properties.Resources.Search_TxtBox_IconRight;
            this.Search_TxtBox.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Search_TxtBox.IconLeftOffset = new System.Drawing.Point(7, 2);
            this.Search_TxtBox.IconRightOffset = new System.Drawing.Point(2, 0);
            this.Search_TxtBox.Location = new System.Drawing.Point(34, 48);
            this.Search_TxtBox.Name = "Search_TxtBox";
            this.Search_TxtBox.PasswordChar = '\0';
            this.Search_TxtBox.PlaceholderText = "ادخل ماتريد البحث عنه ";
            this.Search_TxtBox.SelectedText = "";
            this.Search_TxtBox.Size = new System.Drawing.Size(347, 35);
            this.Search_TxtBox.TabIndex = 236;
            this.Search_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_TxtBox.IconLeftClick += new System.EventHandler(this.Search_TxtBox_IconLeftClick);
            this.Search_TxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_TxtBox_KeyDown);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox1.Image = global::ColorOasisSystem.Properties.Resources.Search_48px;
            this.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBox1.Location = new System.Drawing.Point(287, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 235;
            this.PictureBox1.TabStop = false;
            // 
            // SreachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 305);
            this.Controls.Add(this.DGV_Search);
            this.Controls.Add(this.Search_CmboBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ASeperator1);
            this.Controls.Add(this.Search_TxtBox);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.A2CloseButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SreachForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SreachForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2DataGridView DGV_Search;
        internal Guna.UI2.WinForms.Guna2Elipse Eli1;
        internal Guna.UI2.WinForms.Guna2Elipse Eli2;
        internal Guna.UI2.WinForms.Guna2ComboBox Search_CmboBox;
        private System.Windows.Forms.Label Label4;
        internal Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        internal A7MD_Library.Seperators.ASeperator ASeperator1;
        internal Guna.UI2.WinForms.Guna2TextBox Search_TxtBox;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal A7MD_Library.NewControls.A2CloseButton A2CloseButton1;
    }
}