namespace ColorOasisSystem.GUI.UC
{
    partial class PaymentsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsUC));
            this.SuspendLayout();
            // 
            // PaymentsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Logoimage = ((System.Drawing.Image)(resources.GetObject("$this.Logoimage")));
            this.LogoLabel = "المدفوعات";
            this.MasterUCLock = false;
            this.Name = "PaymentsUC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
