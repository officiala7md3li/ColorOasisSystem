namespace ColorOasisSystem.GUI.UC
{
    partial class AddDropDownUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDropDownUC));
            this.Label1 = new System.Windows.Forms.Label();
            this.New_Name_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ID_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.New_NameEn_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Enabled = false;
            this.Label1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(492, 137);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(96, 23);
            this.Label1.TabIndex = 404;
            this.Label1.Text = "اضافة اسم جديد";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_Name_TxtBox
            // 
            this.New_Name_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_Name_TxtBox.AutoRoundedCorners = true;
            this.New_Name_TxtBox.BorderRadius = 21;
            this.New_Name_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.New_Name_TxtBox.DefaultText = "";
            this.New_Name_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.New_Name_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.New_Name_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.New_Name_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.New_Name_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.New_Name_TxtBox.Font = new System.Drawing.Font("Cairo", 11F);
            this.New_Name_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.New_Name_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("New_Name_TxtBox.IconRight")));
            this.New_Name_TxtBox.IconRightOffset = new System.Drawing.Point(7, 0);
            this.New_Name_TxtBox.Location = new System.Drawing.Point(190, 164);
            this.New_Name_TxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.New_Name_TxtBox.Name = "New_Name_TxtBox";
            this.New_Name_TxtBox.PasswordChar = '\0';
            this.New_Name_TxtBox.PlaceholderText = "ادخل الاسم";
            this.New_Name_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.New_Name_TxtBox.SelectedText = "";
            this.New_Name_TxtBox.Size = new System.Drawing.Size(430, 45);
            this.New_Name_TxtBox.TabIndex = 403;
            // 
            // ID_TxtBox
            // 
            this.ID_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID_TxtBox.AutoRoundedCorners = true;
            this.ID_TxtBox.BorderRadius = 17;
            this.ID_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_TxtBox.DefaultText = "";
            this.ID_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_TxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID_TxtBox.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.ID_TxtBox.Location = new System.Drawing.Point(305, 167);
            this.ID_TxtBox.Name = "ID_TxtBox";
            this.ID_TxtBox.PasswordChar = '\0';
            this.ID_TxtBox.PlaceholderText = "Enter Store Name";
            this.ID_TxtBox.SelectedText = "";
            this.ID_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.ID_TxtBox.TabIndex = 405;
            this.ID_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            this.ID_TxtBox.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(492, 223);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 407;
            this.label2.Text = "اضافة اسم جديد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_NameEn_TxtBox
            // 
            this.New_NameEn_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_NameEn_TxtBox.AutoRoundedCorners = true;
            this.New_NameEn_TxtBox.BorderRadius = 21;
            this.New_NameEn_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.New_NameEn_TxtBox.DefaultText = "";
            this.New_NameEn_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.New_NameEn_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.New_NameEn_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.New_NameEn_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.New_NameEn_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.New_NameEn_TxtBox.Font = new System.Drawing.Font("Cairo", 11F);
            this.New_NameEn_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.New_NameEn_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("New_NameEn_TxtBox.IconRight")));
            this.New_NameEn_TxtBox.IconRightOffset = new System.Drawing.Point(7, 0);
            this.New_NameEn_TxtBox.Location = new System.Drawing.Point(190, 250);
            this.New_NameEn_TxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.New_NameEn_TxtBox.Name = "New_NameEn_TxtBox";
            this.New_NameEn_TxtBox.PasswordChar = '\0';
            this.New_NameEn_TxtBox.PlaceholderText = "ادخل الاسم ج";
            this.New_NameEn_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.New_NameEn_TxtBox.SelectedText = "";
            this.New_NameEn_TxtBox.Size = new System.Drawing.Size(430, 45);
            this.New_NameEn_TxtBox.TabIndex = 406;
            // 
            // AddDropDownUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.New_NameEn_TxtBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.New_Name_TxtBox);
            this.Controls.Add(this.ID_TxtBox);
            this.Logoimage = ((System.Drawing.Image)(resources.GetObject("$this.Logoimage")));
            this.LogoLabel = "النوع";
            this.MasterUCLock = false;
            this.Name = "AddDropDownUC";
            this.Controls.SetChildIndex(this.ID_TxtBox, 0);
            this.Controls.SetChildIndex(this.New_Name_TxtBox, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.New_NameEn_TxtBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        internal Guna.UI2.WinForms.Guna2TextBox New_Name_TxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox ID_TxtBox;
        private System.Windows.Forms.Label label2;
        internal Guna.UI2.WinForms.Guna2TextBox New_NameEn_TxtBox;
    }
}
