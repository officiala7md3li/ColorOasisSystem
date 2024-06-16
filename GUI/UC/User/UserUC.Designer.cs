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
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ID_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.User_Name_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Retype_Password_Txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_Txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Restore_Word_TxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label7.Location = new System.Drawing.Point(189, 312);
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
            this.label8.Location = new System.Drawing.Point(458, 312);
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
            this.label2.Location = new System.Drawing.Point(189, 239);
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
            this.label6.Location = new System.Drawing.Point(458, 239);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 426;
            this.label6.Text = "كلمه الاسترجاع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ComboBox1.Animated = true;
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.DropDownWidth = 106;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.DodgerBlue;
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Cairo", 8F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(95, 265);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(199, 36);
            this.guna2ComboBox1.TabIndex = 423;
            this.guna2ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2ComboBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Enabled = false;
            this.Label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new System.Drawing.Point(188, 166);
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
            this.ID_TxtBox.Location = new System.Drawing.Point(346, 191);
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
            this.Label1.Location = new System.Drawing.Point(486, 166);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(41, 23);
            this.Label1.TabIndex = 419;
            this.Label1.Text = "الاسم";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Name_TxtBox
            // 
            this.User_Name_TxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_Name_TxtBox.AutoRoundedCorners = true;
            this.User_Name_TxtBox.BorderRadius = 17;
            this.User_Name_TxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Name_TxtBox.DefaultText = "";
            this.User_Name_TxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User_Name_TxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User_Name_TxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Name_TxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Name_TxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Name_TxtBox.Font = new System.Drawing.Font("Cairo", 9F);
            this.User_Name_TxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Name_TxtBox.IconRight = ((System.Drawing.Image)(resources.GetObject("User_Name_TxtBox.IconRight")));
            this.User_Name_TxtBox.IconRightOffset = new System.Drawing.Point(3, 0);
            this.User_Name_TxtBox.Location = new System.Drawing.Point(95, 191);
            this.User_Name_TxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User_Name_TxtBox.Name = "User_Name_TxtBox";
            this.User_Name_TxtBox.PasswordChar = '\0';
            this.User_Name_TxtBox.PlaceholderText = "ادخل اسم المستخدم";
            this.User_Name_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.User_Name_TxtBox.SelectedText = "";
            this.User_Name_TxtBox.Size = new System.Drawing.Size(200, 36);
            this.User_Name_TxtBox.TabIndex = 437;
            this.User_Name_TxtBox.TextOffset = new System.Drawing.Point(3, 0);
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
            this.Retype_Password_Txtbox.Location = new System.Drawing.Point(95, 337);
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
            this.Password_Txtbox.Location = new System.Drawing.Point(346, 338);
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
            this.Restore_Word_TxtBox.Location = new System.Drawing.Point(346, 264);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 17;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Cairo", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconRight")));
            this.guna2TextBox1.IconRightOffset = new System.Drawing.Point(3, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(346, 191);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "ادخل اسم المستخدم";
            this.guna2TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 441;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.User_Name_TxtBox);
            this.Controls.Add(this.Retype_Password_Txtbox);
            this.Controls.Add(this.Password_Txtbox);
            this.Controls.Add(this.Restore_Word_TxtBox);
            this.Controls.Add(this.Browse_Btn);
            this.Controls.Add(this.Username_Pic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ComboBox1);
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
            this.Controls.SetChildIndex(this.guna2ComboBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.Username_Pic, 0);
            this.Controls.SetChildIndex(this.Browse_Btn, 0);
            this.Controls.SetChildIndex(this.Restore_Word_TxtBox, 0);
            this.Controls.SetChildIndex(this.Password_Txtbox, 0);
            this.Controls.SetChildIndex(this.Retype_Password_Txtbox, 0);
            this.Controls.SetChildIndex(this.User_Name_TxtBox, 0);
            this.Controls.SetChildIndex(this.guna2TextBox1, 0);
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
        internal Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox ID_TxtBox;
        private System.Windows.Forms.Label Label1;
        internal Guna.UI2.WinForms.Guna2TextBox User_Name_TxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox Retype_Password_Txtbox;
        internal Guna.UI2.WinForms.Guna2TextBox Password_Txtbox;
        internal Guna.UI2.WinForms.Guna2TextBox Restore_Word_TxtBox;
        internal Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
