namespace ColorOasisSystem.GUI.HelpingProgram
{
    partial class CMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMessageBox));
            this.Eli1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Message_Lbl = new System.Windows.Forms.Label();
            this.No_Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Yes_Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.A2CloseButton1 = new A7MD_Library.NewControls.A2CloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Eli1
            // 
            this.Eli1.BorderRadius = 9;
            this.Eli1.TargetControl = this;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(141, 14);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(30, 23);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 247;
            this.PictureBox2.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Enabled = false;
            this.Label5.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Label5.Location = new System.Drawing.Point(103, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 18);
            this.Label5.TabIndex = 246;
            this.Label5.Text = "رساله";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Message_Lbl
            // 
            this.Message_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Message_Lbl.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Bold);
            this.Message_Lbl.ForeColor = System.Drawing.Color.Gray;
            this.Message_Lbl.Location = new System.Drawing.Point(7, 48);
            this.Message_Lbl.Name = "Message_Lbl";
            this.Message_Lbl.Size = new System.Drawing.Size(260, 44);
            this.Message_Lbl.TabIndex = 245;
            this.Message_Lbl.Text = "Do you Want To Exit?\r\nDo you Want To Exit?";
            this.Message_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // No_Btn
            // 
            this.No_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.No_Btn.BackColor = System.Drawing.Color.Transparent;
            this.No_Btn.BorderRadius = 16;
            this.No_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.No_Btn.FillColor = System.Drawing.Color.Transparent;
            this.No_Btn.FillColor2 = System.Drawing.Color.Transparent;
            this.No_Btn.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Btn.ForeColor = System.Drawing.Color.DimGray;
            this.No_Btn.Location = new System.Drawing.Point(34, 99);
            this.No_Btn.Name = "No_Btn";
            this.No_Btn.PressedColor = System.Drawing.Color.DarkGray;
            this.No_Btn.Size = new System.Drawing.Size(81, 33);
            this.No_Btn.TabIndex = 243;
            this.No_Btn.Text = "No";
            this.No_Btn.Click += new System.EventHandler(this.No_Btn_Click);
            // 
            // Yes_Btn
            // 
            this.Yes_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Yes_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.BorderRadius = 16;
            this.Yes_Btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.Yes_Btn.BorderThickness = 1;
            this.Yes_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yes_Btn.FillColor = System.Drawing.Color.Transparent;
            this.Yes_Btn.FillColor2 = System.Drawing.Color.Transparent;
            this.Yes_Btn.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.Location = new System.Drawing.Point(143, 99);
            this.Yes_Btn.Name = "Yes_Btn";
            this.Yes_Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Yes_Btn.Size = new System.Drawing.Size(100, 33);
            this.Yes_Btn.TabIndex = 244;
            this.Yes_Btn.Text = "Yes";
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
            this.A2CloseButton1.Location = new System.Drawing.Point(254, 8);
            this.A2CloseButton1.Name = "A2CloseButton1";
            this.A2CloseButton1.NoRounding = false;
            this.A2CloseButton1.Size = new System.Drawing.Size(23, 23);
            this.A2CloseButton1.TabIndex = 242;
            this.A2CloseButton1.Text = "A2CloseButton1";
            this.A2CloseButton1.Transparent = true;
            this.A2CloseButton1.Click += new System.EventHandler(this.A2CloseButton1_Click);
            // 
            // CMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Message_Lbl);
            this.Controls.Add(this.No_Btn);
            this.Controls.Add(this.Yes_Btn);
            this.Controls.Add(this.A2CloseButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Elipse Eli1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Message_Lbl;
        internal Guna.UI2.WinForms.Guna2GradientButton No_Btn;
        internal Guna.UI2.WinForms.Guna2GradientButton Yes_Btn;
        internal A7MD_Library.NewControls.A2CloseButton A2CloseButton1;
    }
}