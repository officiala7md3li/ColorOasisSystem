using ColorOasisSystem.GUI.Login;
using ColorOasisSystem.Helper;
using ColorOasisSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.GUI.UC;

namespace ColorOasisSystem.GUI
{
    public partial class MainMenuForm : Form
    {
        private User CurrentUser_ = new User();
        public User CurrentUser
        {
            get { return CurrentUser_; }
            set
            {
                CurrentUser_ = value;
                Invalidate();
                Refresh();
            }
        }
        public MainMenuForm()
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
            InitializeComponent();
            LoadFormAsync();
        }

        private async void LoadFormAsync()
        {
            // Display a loading indicator

            try
            {
                // Load your form asynchronously
                await Task.Run(() =>
                {
                    // Load heavy GUI components or perform other time-consuming tasks here
                    // For example:
                    System.Threading.Thread.Sleep(5000); // Simulating heavy work
                });

                // Update GUI after loading
                //UpdateGUIAfterLoading();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Hide loading indicator
            }
        }
        public MainMenuForm(User user)
        {
            InitializeComponent();
            CurrentUser=user;
        }
        public void MainMenuAssign(User user)
        {
            CurrentUser = user;
            WindowState = FormWindowState.Normal;
            Show();
            BringToFront();
        }

        #region Helping Popup Menu

        void Change_Check_Popup_Menu(bool EnablePop = true)
        {
            // If (EnablePop) Then Popup_Menu.SuspendLayout();
            // If Not EnablePop Then Popup_Menu.Visible = EnablePop;
            // Popup_Menu.Enabled = EnablePop;
            // Users_Popup_Menu.RightToLeft = RightToLeft.Yes;
            // Users_Popup_Menu.Enabled = EnablePop;
            // Section_Popup_Menu.Enabled = EnablePop;
            // Logout_Popup_Menu.Enabled = EnablePop;
            Popup_Menu.Enabled = EnablePop;
            Popup_Menu_TMR.Enabled = EnablePop;
            Popup_Menu.Visible = EnablePop;
            if (EnablePop)
            {
                Popup_Menu.BringToFront();
                Popup_Menu.Location = new Point(A2SGradSlider1.Location.X + A2SGradSlider1.Width, Username_Shw_lbl.Top);
                A2SAnimator1.StandardAnimate(Popup_Menu, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideDown, 50);
                Cursor.Position = new Point(Popup_Menu.Parent.PointToScreen(Popup_Menu.Location).X - (Popup_Menu.Size.Width / 2), Popup_Menu.Parent.PointToScreen(Popup_Menu.Location).Y + 17);
                // Popup_Menu.BringToFront();
                // Popup_Menu.ResumeLayout(False);
                // Popup_Menu.PerformLayout();
                // Popup_Menu.Refresh();
            }
        }

        private void All_Button_in_Popup_Menu_Popup_Menu_MouseHover(object sender, EventArgs e)
        {
            Popup_Menu_TMR.Stop(); // Stop the timer 
        }

        private void All_Button_in_Popup_Menu_MouseLeave(object sender, EventArgs e)
        {
            Popup_Menu_TMR.Start(); // Start the timer to close the popup menu after 1500ms
        }

        private void Popup_Menu_TMR_Tick(object sender, EventArgs e)
        {
            Users_Popup_Menu.RightToLeft = RightToLeft.No;
            Popup_Menu_TMR.Stop(); // Stop the timer 
            Change_Check_Popup_Menu(false); // Change the Checking Mode of all button in the Popup Menu
                                            // Slideanime.HideSync(Popup_Menu)
            Popup_Menu.Enabled = false;
            Popup_Menu.Hide(); // Hide the Popup Menu
        }

        #endregion

        private void Show_Hide_PopupMenu(object sender, EventArgs e)
        {
            Change_Check_Popup_Menu();
        }
        public DialogResult CustomMessage(string messageLbl = "", string trueText = "نعم", string falseText = "لا")
        {
            // Create an instance of WaitLoaderForm passing the current instance of MainMenuForm
            WaitLoaderForm waitLoader = new WaitLoaderForm(this, new CMessageBox(messageLbl, trueText, falseText), Elli1.BorderRadius);
            // Return the dialog result from waitLoader form
            return waitLoader.DialogResult;
        }
        #region Top Buttons
        private void A2CloseButton1_Click(object sender, EventArgs e)
        {
            Showing_Page_On_Screen();
        }

        private void A2MaxiButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void A2MiniButton1_Click(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromRectangle(this.Bounds).WorkingArea.Size;
            FormWindowState windowState = this.WindowState;
            if (windowState != FormWindowState.Normal)
            {
                if (windowState == FormWindowState.Maximized)
                {
                    Form_Dock.BorderRadius = 7;
                    this.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                Form_Dock.BorderRadius = 0;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion


        #region Main Menu Slider
        #region Helping Main Menu Slider
        private void Menu_Icon_Click(object sender, EventArgs e)
        {
            if (A2SGradSlider1.Collapsed == true)
            {
                try
                {
                    Username_Pic.Visible = true;
                    Username_Pic.Location = new Point(3, 55);
                                   Username_Pic.Size = new Size(42, 42);
}
                catch (Exception ex)
                {
                    // Handle any exceptions if necessary
                }
            }
            else
            {
                Username_Pic.Visible = false;
                Username_Pic.Size = new Size(78,78);
                           Username_Pic.Location = new Point(101, 61);
}

            // If the Main Slider is Collapsed Change the Size of the User Picture (Username_Pic) and its location
            // A2SAnimator1.StandardAnimate(Username_Pic, Ahmed_Library.A2SAnimator.StandardAnimation.SlideRight, 100);
            Username_Pic.Show();
            Popup_Menu.Hide();
            Popup_Menu.Enabled = false;
            this.Refresh();
        }
        #endregion

        #endregion

        #region Pages Over Form
        #region Exit and Helping Exit
        public void Showing_Page_On_Screen(bool Visible_Bool = false, bool Pic_Visible_Bool = false, string Selected_Page = "Exit Page")
        {
            // If (!Visible_Bool)
            // {
            //     foreach (UserControl UC in Controls.OfType<UserControl>())
            //     {
            //         UC.Hide();
            //         UC.Dock = DockStyle.None;
            //         UC.Enabled = false;
            //     }
            // }

            if (!Visible_Bool)
            {
                BunifuPages2.SetPage(Selected_Page);
            }

            A2SGradSlider1.Visible = Visible_Bool;
            TLP.Visible = Visible_Bool;
            // Change_Language_Btn.Visible = Visible_Bool;
            Support_pnl.Visible = Visible_Bool;

            if (!Visible_Bool)
            {
                Popup_Menu.Visible = Visible_Bool;
            }

            BunifuPages2.Visible = !Visible_Bool;
            Exit_PictureBox.Visible = !Pic_Visible_Bool;
            BunifuPages2.Dock = DockStyle.Fill;
            BunifuPages2.Enabled = !Visible_Bool;
            Exit_PictureBox.Enabled = !Pic_Visible_Bool;

            if (!Pic_Visible_Bool)
            {
                Exit_PictureBox.BringToFront();
            }

            Invalidate();
            Refresh();
        }

        private void Dispose_System_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "LoginForm").FirstOrDefault();
            if (null != frm)
            {
                frm.Show();
                frm = null;
            }
            else
            {
                LoginForm loginForm    = new LoginForm();
                loginForm.Show();
            }
            Change_Check_Popup_Menu(false);
            HidePnlCheck();
            Showing_Page_On_Screen(true, true);
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            Showing_Page_On_Screen(true, true);
            // Selected_UC(My.Settings.Previous_UC, sender);
        }
        #endregion

        #region Camera
        #region Helping Camera
        #endregion

        #region Camera Section
        private void Back_From_Camera_Btn_Click(object sender, EventArgs e)
        {
            Showing_Page_On_Screen(true, true);
        }

        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "";
            ofd.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";
            ofd.Title = "Choose Picture";
            ofd.RestoreDirectory = true;
            ofd.SupportMultiDottedExtensions = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Pic_View.Image = Image.FromFile(ofd.FileName);
                CMessageBox cMessageBox = new CMessageBox();
                cMessageBox.Change_Btn_Names(this, Form_Dock.BorderRadius, "هل تريد حفظ الصورة؟");

                if (cMessageBox.DialogResult == DialogResult.Yes)
                {
                    Showing_Page_On_Screen(true, true);
                    Properties.Settings.Default.Image_Capture.Image = (Image)Pic_View.Image.Clone();
                    Pic_View.Image = Pic_View.ErrorImage;
                }
            }
        }
        #endregion // Open The Camera Section
        #endregion

        #region Proceed to Users
        private void Proceed_to_Users_Btn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(Auth_Pass_txt.Text) || string.IsNullOrWhiteSpace(Auth_Pass_txt.Text))
            //{
            //    Messages.SnackbarShow(Snackbar, this, "ادخل كلمة المرور", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
            //    return;
            //}
            //todo: Uncomment it

            //if (Auth_Pass_txt.Text == CurrentUser_.Password)
            //{
                SelectedUC(Properties.Settings.Default.PermissionNeededUC);
                Invalidate();
                Showing_Page_On_Screen(true, true);
                Refresh();
                Auth_Pass_txt.IconLeft = Fb_Icon.ErrorImage;
                Auth_Pass_txt.UseSystemPasswordChar = true;
                Auth_Pass_txt.Clear();
            //}
            //else
            //{
            //    Messages.SnackbarShow(Snackbar, this, "ادخل كلمة المرور بطريقة صحيحه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
            //}
        }

        private void Auth_Pass_txt_IconLeftClick(object sender, EventArgs e)
        {
            Password_Eye(ref Auth_Pass_txt);
        }

        private void Auth_Pass_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Proceed_to_Users_Btn.PerformClick();
            }
        }

        private void Password_Eye(ref Guna.UI2.WinForms.Guna2TextBox Textbox_object)
        {
            if ((Textbox_object.IconLeft).Equals(Fb_Icon.InitialImage))
            {
                Textbox_object.IconLeft = Fb_Icon.ErrorImage;
                Textbox_object.UseSystemPasswordChar = true;
            }
            else
            {
                Textbox_object.IconLeft = Fb_Icon.InitialImage;
                Textbox_object.UseSystemPasswordChar = false;
                Textbox_object.PasswordChar = '\0';
            }
        }
        #endregion
        #endregion
        void HidePnlCheck()
        {
            SidePanel.Hide();

            foreach (Guna.UI2.WinForms.Guna2Button UC in A2SGradSlider1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                UC.Checked = false;
            }
        }
        #region Choosing UC and Button
        public void SelectedUC(UserControl selectedUC)
        {
            try
            {
                selectedUC.BringToFront();

                foreach (UserControl uc in Controls.OfType<UserControl>())
                {
                    uc.Hide();
                    uc.Dock = DockStyle.None;
                    uc.Enabled = false;
                }

                selectedUC.Dock = DockStyle.Fill;
                selectedUC.Enabled = true;
                selectedUC.Visible = true;

                if (selectedUC is MasterUC masterUC)
                {
                    masterUC.NewData();
                    // masterUC.PrintBtnVisible = 0;
                    masterUC.EditDataCheck = false;
                }

               Properties.Settings.Default.Current_UC = selectedUC;
               Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary
            }
        }

        // Overloaded method for Master_UC type
        void SelectedUC(MasterUC selectedUC)
        {
            try
            {
                selectedUC.BringToFront();

                foreach (UserControl uc in Controls.OfType<UserControl>())
                {
                    uc.Hide();
                    uc.Dock = DockStyle.None;
                    uc.Enabled = false;
                }

                selectedUC.NewData();
                selectedUC.Dock = DockStyle.Fill;
                selectedUC.Enabled = true;
                selectedUC.Visible = true;

                // masterUC.PrintBtnVisible = 0;
                selectedUC.EditDataCheck = false;

               Properties.Settings.Default.Current_UC = selectedUC;
               Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary
            }
        }


        // Sub SelectedButton(object selectedBtn)
        // {
        //     // SidePanel.Visible = False;
        //     // SidePanel.Top = selectedBtn.Top;
        //     // SidePanel.Height = selectedBtn.Height;
        //     // SidePanel.Show();
        // }
        #endregion

        private void Main_Slider_Payments_Btn_Click(object sender, EventArgs e)
        {
            //SelectedUC(branchUC1);
        }

        private void Main_Slider_Visits_Btn_Click(object sender, EventArgs e)
        {
            //SelectedUC(medicationUC1);
        }

        private void Settings_Popup_Menu_Click(object sender, EventArgs e)
        {
            if (CurrentUser_.Position == "مؤقت" || CurrentUser_.Position =="Admin"||  string.IsNullOrEmpty(CurrentUser_.Position))
            {
                Message_Lbl.Text = "من فضلك " + Auth_Pass_txt.PlaceholderText + "، " + Username_Shw_lbl.Text;
                Auth_Pic.Image = Username_Pic.Image;
                //todo:Uncomment
                //Properties.Settings.Default.PermissionNeededUC = settingsUC1;
                Properties.Settings.Default.Save();
                Showing_Page_On_Screen(false, true, "Auth_For_Account");
                Change_Check_Popup_Menu(false);
                HidePnlCheck();
            }
            else
            {
                MyHelper.SnackbarShow( this, this.Snackbar, "انت لاتملك الصلاحيه الكافيه للدخول لتلك الصفحه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                Main_Menu_Home_Btn.PerformClick();
            }
        }

        private void Permission_Popup_Menu_Click(object sender, EventArgs e)
        {
            if (CurrentUser_.Position == "مؤقت" || CurrentUser_.Position == "Admin" || string.IsNullOrEmpty(CurrentUser_.Position))
            {
                Message_Lbl.Text = "من فضلك " + Auth_Pass_txt.PlaceholderText + "، " + Username_Shw_lbl.Text;
                Auth_Pic.Image = Username_Pic.Image;
                //todo:uncomment
                //Properties.Settings.Default.PermissionNeededUC = userUC1;
                Properties.Settings.Default.Save();
                Showing_Page_On_Screen(false, true, "Auth_For_Account");
                Change_Check_Popup_Menu(false);
                HidePnlCheck();
            }
            else
            {
                MyHelper.SnackbarShow(this, this.Snackbar, "انت لاتملك الصلاحيه الكافيه للدخول لتلك الصفحه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                Main_Menu_Home_Btn.PerformClick();
            }

        }

        private void Section_Popup_Menu_Click(object sender, EventArgs e)
        {
            if (CurrentUser_.Position == "مؤقت" || CurrentUser_.Position == "Admin" || string.IsNullOrEmpty(CurrentUser_.Position))
            {
                Message_Lbl.Text = "من فضلك " + Auth_Pass_txt.PlaceholderText + "، " + Username_Shw_lbl.Text;
                Auth_Pic.Image = Username_Pic.Image;
                //todo:uncomment
                //Properties.Settings.Default.PermissionNeededUC = branchUC1;
                Properties.Settings.Default.Save();
                Showing_Page_On_Screen(false, true, "Auth_For_Account");
                Change_Check_Popup_Menu(false);
                HidePnlCheck();
            }
            else
            {
                MyHelper.SnackbarShow(this, this.Snackbar, "انت لاتملك الصلاحيه الكافيه للدخول لتلك الصفحه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                Main_Menu_Home_Btn.PerformClick();
            }

        }

        private void Main_Menu_Home_Btn_Click(object sender, EventArgs e)
        {
            //todo:uncomment
            //SelectedUC(welcomeUC1);

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            //todo:uncomment
            //SelectedUC(welcomeUC1);
        }
    }
}
