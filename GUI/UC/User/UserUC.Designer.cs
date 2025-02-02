namespace ColorOasisSystem.GUI.UC
{
    partial class UserUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUC));
            this.Browse_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Username_Pic = new A7MD_Library.Pictures.A2PictureboxPro();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Userpermissioncmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ID_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Retype_Password_Txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_Txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Restore_Word_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.User_NametxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.User_NameEntxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.User_Phone_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Username_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse_Btn
            // 
            this.Browse_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Browse_Btn.Animated = true;
            this.Browse_Btn.AutoRoundedCorners = true;
            this.Browse_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Browse_Btn.BorderRadius = 15;
            this.Browse_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browse_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.Browse_Btn.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_Btn.ForeColor = System.Drawing.Color.White;
            this.Browse_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Browse_Btn.ImageSize = new System.Drawing.Size(15, 15);
            this.Browse_Btn.IndicateFocus = true;
            this.Browse_Btn.Location = new System.Drawing.Point(602, 313);
            this.Browse_Btn.Name = "Browse_Btn";
            this.Browse_Btn.Size = new System.Drawing.Size(113, 32);
            this.Browse_Btn.TabIndex = 435;
            this.Browse_Btn.Text = "استعراض";
            this.Browse_Btn.TextOffset = new System.Drawing.Point(-5, 0);
            this.Browse_Btn.UseTransparentBackground = true;
            this.Browse_Btn.Click += new System.EventHandler(this.Browse_Btn_Click);
            // 
            // Username_Pic
            // 
            this.Username_Pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_Pic.BackColor = System.Drawing.Color.Transparent;
            this.Username_Pic.Border = false;
            this.Username_Pic.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Username_Pic.BorderWidth = 0;
            this.Username_Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Username_Pic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Username_Pic.ErrorImage")));
            this.Username_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Username_Pic.Image")));
            this.Username_Pic.ImageActive = null;
            this.Username_Pic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Username_Pic.InitialImage = ((System.Drawing.Image)(resources.GetObject("Username_Pic.InitialImage")));
            this.Username_Pic.Location = new System.Drawing.Point(603, 196);
            this.Username_Pic.Name = "Username_Pic";
            this.Username_Pic.Shape = A7MD_Library.A2_Library.Helping.picShape.Round;
            this.Username_Pic.Size = new System.Drawing.Size(111, 111);
            this.Username_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Username_Pic.SquareSize = true;
            this.Username_Pic.TabIndex = 436;
            this.Username_Pic.TabStop = false;
            this.Username_Pic.Zoom = 10;
            this.Username_Pic.Click += new System.EventHandler(this.Browse_Btn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(178, 345);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 430;
            this.label7.Text = "تاكيد كلمه المرور";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(456, 347);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 429;
            this.label8.Text = "كلمه المرور";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(216, 273);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 427;
            this.label2.Text = "الصلاحيات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(440, 273);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 426;
            this.label6.Text = "كلمه الاسترجاع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Userpermissioncmbx
            // 
            this.Userpermissioncmbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Userpermissioncmbx.Animated = true;
            this.Userpermissioncmbx.AutoRoundedCorners = true;
            this.Userpermissioncmbx.BackColor = System.Drawing.Color.Transparent;
            this.Userpermissioncmbx.BorderColor = System.Drawing.Color.DarkGray;
            this.Userpermissioncmbx.BorderRadius = 17;
            this.Userpermissioncmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Userpermissioncmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Userpermissioncmbx.DropDownWidth = 106;
            this.Userpermissioncmbx.FocusedColor = System.Drawing.Color.DodgerBlue;
            this.Userpermissioncmbx.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Userpermissioncmbx.Font = new System.Drawing.Font("Cairo", 8F);
            this.Userpermissioncmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Userpermissioncmbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.Userpermissioncmbx.ItemHeight = 30;
            this.Userpermissioncmbx.Location = new System.Drawing.Point(95, 300);
            this.Userpermissioncmbx.Name = "Userpermissioncmbx";
            this.Userpermissioncmbx.Size = new System.Drawing.Size(199, 36);
            this.Userpermissioncmbx.TabIndex = 423;
            this.Userpermissioncmbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Userpermissioncmbx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Enabled = false;
            this.Label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new System.Drawing.Point(438, 202);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(89, 23);
            this.Label3.TabIndex = 421;
            this.Label3.Text = "اسم المستخدم";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ID_TxtBox.Location = new System.Drawing.Point(346, 158);
            this.ID_TxtBox.MaxLength = 30;
            this.ID_TxtBox.Name = "ID_TxtBox";
            this.ID_TxtBox.PasswordChar = '\0';
            this.ID_TxtBox.PlaceholderText = "Enter Store Name";
            this.ID_TxtBox.SelectedText = "";
            this.ID_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.ID_TxtBox.TabIndex = 420;
            this.ID_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            this.ID_TxtBox.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Enabled = false;
            this.Label1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Gray;
            this.Label1.Location = new System.Drawing.Point(486, 133);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(41, 23);
            this.Label1.TabIndex = 419;
            this.Label1.Text = "الاسم";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTxtBox.AutoRoundedCorners = true;
            this.UserNameTxtBox.BorderRadius = 17;
            this.UserNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxtBox.DefaultText = "";
            this.UserNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.UserNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("UserNameTxtBox.IconRight")));
            this.UserNameTxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.UserNameTxtBox.Location = new System.Drawing.Point(346, 229);
            this.UserNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.PasswordChar = '\0';
            this.UserNameTxtBox.PlaceholderText = "ادخل اسم المستخدم";
            this.UserNameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserNameTxtBox.SelectedText = "";
            this.UserNameTxtBox.Size = new System.Drawing.Size(200, 36);
            this.UserNameTxtBox.TabIndex = 437;
            this.UserNameTxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Retype_Password_Txtbox
            // 
            this.Retype_Password_Txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Retype_Password_Txtbox.AutoRoundedCorners = true;
            this.Retype_Password_Txtbox.BorderRadius = 17;
            this.Retype_Password_Txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Retype_Password_Txtbox.DefaultText = "";
            this.Retype_Password_Txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Retype_Password_Txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Retype_Password_Txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Retype_Password_Txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Retype_Password_Txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Retype_Password_Txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Retype_Password_Txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Retype_Password_Txtbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Retype_Password_Txtbox.IconLeft")));
            this.Retype_Password_Txtbox.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Retype_Password_Txtbox.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.Retype_Password_Txtbox.IconRight = ((System.Drawing.Image)(resources.GetObject("Retype_Password_Txtbox.IconRight")));
            this.Retype_Password_Txtbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Retype_Password_Txtbox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.Retype_Password_Txtbox.Location = new System.Drawing.Point(95, 371);
            this.Retype_Password_Txtbox.Name = "Retype_Password_Txtbox";
            this.Retype_Password_Txtbox.PasswordChar = '●';
            this.Retype_Password_Txtbox.PlaceholderText = "اعد ادخال كلمه المرور";
            this.Retype_Password_Txtbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Retype_Password_Txtbox.SelectedText = "";
            this.Retype_Password_Txtbox.Size = new System.Drawing.Size(200, 36);
            this.Retype_Password_Txtbox.TabIndex = 440;
            this.Retype_Password_Txtbox.TextOffset = new System.Drawing.Point(3, 0);
            this.Retype_Password_Txtbox.UseSystemPasswordChar = true;
            // 
            // Password_Txtbox
            // 
            this.Password_Txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_Txtbox.AutoRoundedCorners = true;
            this.Password_Txtbox.BorderRadius = 17;
            this.Password_Txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Txtbox.DefaultText = "";
            this.Password_Txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_Txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_Txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password_Txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Txtbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password_Txtbox.IconLeft")));
            this.Password_Txtbox.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Password_Txtbox.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.Password_Txtbox.IconRight = ((System.Drawing.Image)(resources.GetObject("Password_Txtbox.IconRight")));
            this.Password_Txtbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Txtbox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.Password_Txtbox.Location = new System.Drawing.Point(346, 371);
            this.Password_Txtbox.Name = "Password_Txtbox";
            this.Password_Txtbox.PasswordChar = '●';
            this.Password_Txtbox.PlaceholderText = "ادخل كلمه المرور";
            this.Password_Txtbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Password_Txtbox.SelectedText = "";
            this.Password_Txtbox.Size = new System.Drawing.Size(200, 36);
            this.Password_Txtbox.TabIndex = 439;
            this.Password_Txtbox.TextOffset = new System.Drawing.Point(3, 0);
            this.Password_Txtbox.UseSystemPasswordChar = true;
            // 
            // Restore_Word_TxtBox
            // 
            this.Restore_Word_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Restore_Word_TxtBox.AutoRoundedCorners = true;
            this.Restore_Word_TxtBox.BorderRadius = 17;
            this.Restore_Word_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Restore_Word_TxtBox.DefaultText = "";
            this.Restore_Word_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Restore_Word_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Restore_Word_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Restore_Word_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Restore_Word_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Restore_Word_TxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.Restore_Word_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Restore_Word_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("Restore_Word_TxtBox.IconRight")));
            this.Restore_Word_TxtBox.Location = new System.Drawing.Point(346, 300);
            this.Restore_Word_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Restore_Word_TxtBox.Name = "Restore_Word_TxtBox";
            this.Restore_Word_TxtBox.PasswordChar = '\0';
            this.Restore_Word_TxtBox.PlaceholderText = "ادخل كلمه الاستعاده";
            this.Restore_Word_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Restore_Word_TxtBox.SelectedText = "";
            this.Restore_Word_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.Restore_Word_TxtBox.TabIndex = 438;
            this.Restore_Word_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // User_NametxtBox
            // 
            this.User_NametxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_NametxtBox.AutoRoundedCorners = true;
            this.User_NametxtBox.BorderRadius = 17;
            this.User_NametxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_NametxtBox.DefaultText = "";
            this.User_NametxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User_NametxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User_NametxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_NametxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_NametxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_NametxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.User_NametxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_NametxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("User_NametxtBox.IconRight")));
            this.User_NametxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.User_NametxtBox.Location = new System.Drawing.Point(346, 158);
            this.User_NametxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User_NametxtBox.MaxLength = 5;
            this.User_NametxtBox.Name = "User_NametxtBox";
            this.User_NametxtBox.PasswordChar = '\0';
            this.User_NametxtBox.PlaceholderText = "ادخل الاسم";
            this.User_NametxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.User_NametxtBox.SelectedText = "";
            this.User_NametxtBox.Size = new System.Drawing.Size(200, 36);
            this.User_NametxtBox.TabIndex = 441;
            this.User_NametxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(227, 133);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 421;
            this.label4.Text = "الاسم ج";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_NameEntxtBox
            // 
            this.User_NameEntxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_NameEntxtBox.AutoRoundedCorners = true;
            this.User_NameEntxtBox.BorderRadius = 17;
            this.User_NameEntxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_NameEntxtBox.DefaultText = "";
            this.User_NameEntxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User_NameEntxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User_NameEntxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_NameEntxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_NameEntxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_NameEntxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.User_NameEntxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_NameEntxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("User_NameEntxtBox.IconRight")));
            this.User_NameEntxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.User_NameEntxtBox.Location = new System.Drawing.Point(95, 158);
            this.User_NameEntxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User_NameEntxtBox.MaxLength = 30;
            this.User_NameEntxtBox.Name = "User_NameEntxtBox";
            this.User_NameEntxtBox.PasswordChar = '\0';
            this.User_NameEntxtBox.PlaceholderText = "ادخل الاسم ج";
            this.User_NameEntxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.User_NameEntxtBox.SelectedText = "";
            this.User_NameEntxtBox.Size = new System.Drawing.Size(200, 36);
            this.User_NameEntxtBox.TabIndex = 437;
            this.User_NameEntxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(210, 202);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 421;
            this.label5.Text = "رقم الهاتف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Phone_TxtBox
            // 
            this.User_Phone_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_Phone_TxtBox.AutoRoundedCorners = true;
            this.User_Phone_TxtBox.BorderRadius = 17;
            this.User_Phone_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Phone_TxtBox.DefaultText = "";
            this.User_Phone_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User_Phone_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User_Phone_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Phone_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Phone_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Phone_TxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.User_Phone_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Phone_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("User_Phone_TxtBox.IconRight")));
            this.User_Phone_TxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.User_Phone_TxtBox.Location = new System.Drawing.Point(95, 229);
            this.User_Phone_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User_Phone_TxtBox.MaxLength = 11;
            this.User_Phone_TxtBox.Name = "User_Phone_TxtBox";
            this.User_Phone_TxtBox.PasswordChar = '\0';
            this.User_Phone_TxtBox.PlaceholderText = "ادخل رقم الهاتف";
            this.User_Phone_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.User_Phone_TxtBox.SelectedText = "";
            this.User_Phone_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.User_Phone_TxtBox.TabIndex = 442;
            this.User_Phone_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.User_Phone_TxtBox);
            this.Controls.Add(this.User_NametxtBox);
            this.Controls.Add(this.User_NameEntxtBox);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.Retype_Password_Txtbox);
            this.Controls.Add(this.Password_Txtbox);
            this.Controls.Add(this.Restore_Word_TxtBox);
            this.Controls.Add(this.Browse_Btn);
            this.Controls.Add(this.Username_Pic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Userpermissioncmbx);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ID_TxtBox);
            this.Controls.Add(this.Label1);
            this.Logoimage = ((System.Drawing.Image)(resources.GetObject("$this.Logoimage")));
            this.LogoLabel = "المستخدمين";
            this.MasterUCLock = false;
            this.Name = "UserUC";
            this.Size = new System.Drawing.Size(810, 540);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.ID_TxtBox, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.Userpermissioncmbx, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Username_Pic, 0);
            this.Controls.SetChildIndex(this.Browse_Btn, 0);
            this.Controls.SetChildIndex(this.Restore_Word_TxtBox, 0);
            this.Controls.SetChildIndex(this.Password_Txtbox, 0);
            this.Controls.SetChildIndex(this.Retype_Password_Txtbox, 0);
            this.Controls.SetChildIndex(this.UserNameTxtBox, 0);
            this.Controls.SetChildIndex(this.User_NameEntxtBox, 0);
            this.Controls.SetChildIndex(this.User_NametxtBox, 0);
            this.Controls.SetChildIndex(this.User_Phone_TxtBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Username_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Button Browse_Btn;
        internal A7MD_Library.Pictures.A2PictureboxPro Username_Pic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        internal Guna.UI2.WinForms.Guna2ComboBox Userpermissioncmbx;
        private System.Windows.Forms.Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox ID_TxtBox;
        private System.Windows.Forms.Label Label1;
        internal Guna.UI2.WinForms.Guna2TextBox UserNameTxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox Retype_Password_Txtbox;
        internal Guna.UI2.WinForms.Guna2TextBox Password_Txtbox;
        internal Guna.UI2.WinForms.Guna2TextBox Restore_Word_TxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox User_NametxtBox;
        private System.Windows.Forms.Label label4;
        internal Guna.UI2.WinForms.Guna2TextBox User_NameEntxtBox;
        private System.Windows.Forms.Label label5;
        internal Guna.UI2.WinForms.Guna2TextBox User_Phone_TxtBox;
    }
}
