namespace ColorOasisSystem.GUI.UC
{
    partial class SettingsMasterUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMasterUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.SaveSettings_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Option_Btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Options_Tmr = new System.Windows.Forms.Timer(this.components);
            this.A2SAnimator1 = new A7MD_Library.NewComponent.A2SAnimator();
            this.SuspendLayout();
            // 
            // SaveSettings_Btn
            // 
            this.SaveSettings_Btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveSettings_Btn.Animated = true;
            this.SaveSettings_Btn.AutoRoundedCorners = true;
            this.SaveSettings_Btn.BackColor = System.Drawing.Color.Transparent;
            this.SaveSettings_Btn.BorderRadius = 16;
            this.SaveSettings_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveSettings_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.SaveSettings_Btn.Font = new System.Drawing.Font("Cairo", 8.999999F);
            this.SaveSettings_Btn.ForeColor = System.Drawing.Color.White;
            this.SaveSettings_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SaveSettings_Btn.ImageSize = new System.Drawing.Size(15, 15);
            this.SaveSettings_Btn.IndicateFocus = true;
            this.SaveSettings_Btn.Location = new System.Drawing.Point(332, 380);
            this.SaveSettings_Btn.Name = "SaveSettings_Btn";
            this.SaveSettings_Btn.Size = new System.Drawing.Size(147, 35);
            this.SaveSettings_Btn.TabIndex = 380;
            this.SaveSettings_Btn.Text = "حفظ الاعدادات";
            this.SaveSettings_Btn.UseTransparentBackground = true;
            this.SaveSettings_Btn.Visible = false;
            this.SaveSettings_Btn.Click += new System.EventHandler(this.SaveSettings_Btn_Click);
            this.SaveSettings_Btn.MouseEnter += new System.EventHandler(this.SaveSettingsMouseEnterHover);
            this.SaveSettings_Btn.MouseLeave += new System.EventHandler(this.SaveSettings_Btn_MouseLeave);
            this.SaveSettings_Btn.MouseHover += new System.EventHandler(this.SaveSettingsMouseEnterHover);
            // 
            // Option_Btn
            // 
            this.Option_Btn.AllowAnimations = true;
            this.Option_Btn.AllowMouseEffects = true;
            this.Option_Btn.AllowToggling = false;
            this.Option_Btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Option_Btn.AnimationSpeed = 200;
            this.Option_Btn.AutoGenerateColors = false;
            this.Option_Btn.AutoRoundBorders = true;
            this.Option_Btn.AutoSizeLeftIcon = true;
            this.Option_Btn.AutoSizeRightIcon = true;
            this.Option_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Option_Btn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.Option_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Option_Btn.BackgroundImage")));
            this.Option_Btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option_Btn.ButtonText = "";
            this.Option_Btn.ButtonTextMarginLeft = 0;
            this.Option_Btn.ColorContrastOnClick = 45;
            this.Option_Btn.ColorContrastOnHover = 45;
            this.Option_Btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Option_Btn.CustomizableEdges = borderEdges1;
            this.Option_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Option_Btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Option_Btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Option_Btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Option_Btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.Option_Btn.Font = new System.Drawing.Font("Cairo", 8.999999F);
            this.Option_Btn.ForeColor = System.Drawing.Color.White;
            this.Option_Btn.IconLeft = null;
            this.Option_Btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Option_Btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Option_Btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Option_Btn.IconMarginLeft = 11;
            this.Option_Btn.IconPadding = 15;
            this.Option_Btn.IconRight = ((System.Drawing.Image)(resources.GetObject("Option_Btn.IconRight")));
            this.Option_Btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Option_Btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Option_Btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Option_Btn.IconSize = 25;
            this.Option_Btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.Option_Btn.IdleBorderRadius = 33;
            this.Option_Btn.IdleBorderThickness = 1;
            this.Option_Btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(152)))));
            this.Option_Btn.IdleIconLeftImage = null;
            this.Option_Btn.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("Option_Btn.IdleIconRightImage")));
            this.Option_Btn.IndicateFocus = true;
            this.Option_Btn.Location = new System.Drawing.Point(380, 431);
            this.Option_Btn.Name = "Option_Btn";
            this.Option_Btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Option_Btn.OnDisabledState.BorderRadius = 50;
            this.Option_Btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option_Btn.OnDisabledState.BorderThickness = 1;
            this.Option_Btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Option_Btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Option_Btn.OnDisabledState.IconLeftImage = null;
            this.Option_Btn.OnDisabledState.IconRightImage = null;
            this.Option_Btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.Option_Btn.onHoverState.BorderRadius = 50;
            this.Option_Btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option_Btn.onHoverState.BorderThickness = 1;
            this.Option_Btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(199)))), ((int)(((byte)(162)))));
            this.Option_Btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Option_Btn.onHoverState.IconLeftImage = null;
            this.Option_Btn.onHoverState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("Option_Btn.onHoverState.IconRightImage")));
            this.Option_Btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.Option_Btn.OnIdleState.BorderRadius = 50;
            this.Option_Btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option_Btn.OnIdleState.BorderThickness = 1;
            this.Option_Btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(163)))), ((int)(((byte)(103)))));
            this.Option_Btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Option_Btn.OnIdleState.IconLeftImage = null;
            this.Option_Btn.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("Option_Btn.OnIdleState.IconRightImage")));
            this.Option_Btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(89)))));
            this.Option_Btn.OnPressedState.BorderRadius = 50;
            this.Option_Btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option_Btn.OnPressedState.BorderThickness = 1;
            this.Option_Btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(135)))), ((int)(((byte)(89)))));
            this.Option_Btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Option_Btn.OnPressedState.IconLeftImage = null;
            this.Option_Btn.OnPressedState.IconRightImage = null;
            this.Option_Btn.Size = new System.Drawing.Size(50, 50);
            this.Option_Btn.TabIndex = 401;
            this.Option_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Option_Btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Option_Btn.TextMarginLeft = 0;
            this.Option_Btn.TextPadding = new System.Windows.Forms.Padding(-5, 0, 5, 0);
            this.Option_Btn.UseDefaultRadiusAndThickness = true;
            this.Option_Btn.Click += new System.EventHandler(this.Option_Btn_Click);
            // 
            // Options_Tmr
            // 
            this.Options_Tmr.Interval = 2500;
            this.Options_Tmr.Tick += new System.EventHandler(this.Options_Tmr_Tick);
            // 
            // SettingsMasterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.Option_Btn);
            this.Controls.Add(this.SaveSettings_Btn);
            this.Logoimage = ((System.Drawing.Image)(resources.GetObject("$this.Logoimage")));
            this.LogoLabel = "الاعدادات";
            this.Name = "SettingsMasterUC";
            this.Controls.SetChildIndex(this.SaveSettings_Btn, 0);
            this.Controls.SetChildIndex(this.Option_Btn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Guna.UI2.WinForms.Guna2Button SaveSettings_Btn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Option_Btn;
        internal System.Windows.Forms.Timer Options_Tmr;
        internal A7MD_Library.NewComponent.A2SAnimator A2SAnimator1;
    }
}
