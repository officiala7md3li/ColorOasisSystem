namespace ColorOasisSystem.GUI.Helping_Program
{
    partial class AddNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNumber));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Yes_Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.A2CloseButton1 = new A7MD_Library.NewControls.A2CloseButton();
            this.Eli1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Item_Qty_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Snackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(66, 9);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(25, 28);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 250;
            this.PictureBox2.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Enabled = false;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new System.Drawing.Point(90, 14);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(106, 18);
            this.Label5.TabIndex = 249;
            this.Label5.Text = "Item Quantity";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Yes_Btn
            // 
            this.Yes_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.BorderRadius = 16;
            this.Yes_Btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Yes_Btn.BorderThickness = 1;
            this.Yes_Btn.FillColor = System.Drawing.Color.Transparent;
            this.Yes_Btn.FillColor2 = System.Drawing.Color.Transparent;
            this.Yes_Btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Yes_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.Location = new System.Drawing.Point(88, 100);
            this.Yes_Btn.Name = "Yes_Btn";
            this.Yes_Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.Size = new System.Drawing.Size(87, 33);
            this.Yes_Btn.TabIndex = 247;
            this.Yes_Btn.Text = "Submit";
            this.Yes_Btn.Click += new System.EventHandler(this.Yes_Btn_Click);
            // 
            // A2CloseButton1
            // 
            this.A2CloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A2CloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.A2CloseButton1.Colors = new A7MD_Library.A2_Library.Helping.Bloom[0];
            this.A2CloseButton1.Customization = "";
            this.A2CloseButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.A2CloseButton1.Image = null;
            this.A2CloseButton1.IsCloseButton = true;
            this.A2CloseButton1.Location = new System.Drawing.Point(238, 7);
            this.A2CloseButton1.Name = "A2CloseButton1";
            this.A2CloseButton1.NoRounding = false;
            this.A2CloseButton1.Size = new System.Drawing.Size(23, 23);
            this.A2CloseButton1.TabIndex = 248;
            this.A2CloseButton1.Text = "A2CloseButton1";
            this.A2CloseButton1.Transparent = true;
            // 
            // Eli1
            // 
            this.Eli1.BorderRadius = 9;
            this.Eli1.TargetControl = this;
            // 
            // Item_Qty_TxtBox
            // 
            this.Item_Qty_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Item_Qty_TxtBox.AutoRoundedCorners = true;
            this.Item_Qty_TxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.Item_Qty_TxtBox.BorderRadius = 16;
            this.Item_Qty_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Item_Qty_TxtBox.DefaultText = "";
            this.Item_Qty_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Item_Qty_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Item_Qty_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Item_Qty_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Item_Qty_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Item_Qty_TxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Item_Qty_TxtBox.ForeColor = System.Drawing.Color.DimGray;
            this.Item_Qty_TxtBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Item_Qty_TxtBox.IconLeft")));
            this.Item_Qty_TxtBox.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.Item_Qty_TxtBox.Location = new System.Drawing.Point(59, 56);
            this.Item_Qty_TxtBox.Name = "Item_Qty_TxtBox";
            this.Item_Qty_TxtBox.PasswordChar = '\0';
            this.Item_Qty_TxtBox.PlaceholderText = "Item Quantity";
            this.Item_Qty_TxtBox.SelectedText = "";
            this.Item_Qty_TxtBox.Size = new System.Drawing.Size(144, 34);
            this.Item_Qty_TxtBox.TabIndex = 246;
            this.Item_Qty_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Item_Qty_TxtBox.TextChanged += new System.EventHandler(this.Item_Qty_TxtBox_TextChanged);
            this.Item_Qty_TxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Item_Qty_TxtBox_KeyDown);
            // 
            // Snackbar
            // 
            this.Snackbar.AllowDragging = false;
            this.Snackbar.AllowMultipleViews = true;
            this.Snackbar.ClickToClose = true;
            this.Snackbar.DoubleClickToClose = true;
            this.Snackbar.DurationAfterIdle = 3000;
            this.Snackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.ErrorOptions.ActionBorderRadius = 5;
            this.Snackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Snackbar.ErrorOptions.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Snackbar.ErrorOptions.IconLeftMargin = 12;
            this.Snackbar.FadeCloseIcon = false;
            this.Snackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Snackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.InformationOptions.ActionBorderRadius = 5;
            this.Snackbar.InformationOptions.ActionFont = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Snackbar.InformationOptions.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Snackbar.InformationOptions.IconLeftMargin = 12;
            this.Snackbar.Margin = 10;
            this.Snackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.Snackbar.MaximumViews = 7;
            this.Snackbar.MessageRightMargin = 15;
            this.Snackbar.MessageTopMargin = 0;
            this.Snackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.Snackbar.ShowBorders = false;
            this.Snackbar.ShowCloseIcon = true;
            this.Snackbar.ShowIcon = true;
            this.Snackbar.ShowShadows = true;
            this.Snackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.SuccessOptions.ActionBorderRadius = 5;
            this.Snackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Snackbar.SuccessOptions.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Snackbar.SuccessOptions.IconLeftMargin = 12;
            this.Snackbar.ViewsMargin = 7;
            this.Snackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.WarningOptions.ActionBorderRadius = 5;
            this.Snackbar.WarningOptions.ActionFont = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Snackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Snackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Snackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Snackbar.WarningOptions.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Snackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Snackbar.WarningOptions.IconLeftMargin = 12;
            this.Snackbar.ZoomCloseIcon = true;
            // 
            // AddNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 141);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Yes_Btn);
            this.Controls.Add(this.A2CloseButton1);
            this.Controls.Add(this.Item_Qty_TxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNumber";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label Label5;
        internal Guna.UI2.WinForms.Guna2GradientButton Yes_Btn;
        internal A7MD_Library.NewControls.A2CloseButton A2CloseButton1;
        internal Guna.UI2.WinForms.Guna2Elipse Eli1;
        internal Guna.UI2.WinForms.Guna2TextBox Item_Qty_TxtBox;
        public Bunifu.UI.WinForms.BunifuSnackbar Snackbar;
    }
}