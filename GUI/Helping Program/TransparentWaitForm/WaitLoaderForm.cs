using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.HelpingProgram
{
    /// <summary>
    /// Class transparentBg1.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class WaitLoaderForm : Form
    {        

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormLauncher_Tick(object sender, EventArgs e)
        {
            FormLauncher.Stop();
            _child.TopMost = true;
            _child.StartPosition = FormStartPosition.CenterParent;
            _child.ShowInTaskbar = false;
            _child.ShowIcon = false;
            if (_child is CMessageBox cMessage)
            {
                DialogResult = _child.ShowDialog();
            }
            else
            {
                _child.ShowDialog();
            }
            Close();
        }




        /// <summary>
        /// The child
        /// </summary>
        Form _child = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="transparentBg"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="child">The child.</param>
        /// <param name="ellipseraduis">The ellipse.</param>
        public WaitLoaderForm(Form parent, Form child, int ellipseraduis)
        {
            InitializeComponent();
            this.Location = parent.Location;
            this.Size = parent.Size;
            _child = child;
            Eli1.BorderRadius = ellipseraduis;
            parent.TopMost = true;
            //FormLauncher.Start();
            DialogResult = this.ShowDialog();
            parent.TopMost = false;

        }
        public WaitLoaderForm(Form child)
        {
            InitializeComponent();
            _child = child;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }


        /// <summary>
        /// Handles the Load event of the transparentForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void transparentForm_Load(object sender, EventArgs e)
        {


        }


    }


}
