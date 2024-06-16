using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorOasisSystem.Entities;
using ColorOasisSystem.Helper;
using ColorOasisSystem.GUI.HelpingProgram;

namespace ColorOasisSystem.GUI.Login
{
    public partial class LoginForm : Form
    {

        UserRepo user;
        public LoginForm()
        {            
            MainMenuForm mainMenuForm = new MainMenuForm();

            InitializeComponent();
            Banner_Image.BackColor = this.BackColor;            
            mainMenuForm.Visible = true;
            mainMenuForm.Visible = false;
            user = new UserRepo();
            this.BringToFront();
        }



        private async void Login_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username_TxtBox.Text) || string.IsNullOrWhiteSpace(Username_TxtBox.Text))
            {
                Username_TxtBox.Focus();
                Username_TxtBox.Select();
                MyHelper.SnackbarShow(this, this.Snackbar, "يرجي ادخال اسم المستخدم", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            if (string.IsNullOrEmpty(Pass_txt.Text) || string.IsNullOrWhiteSpace(Pass_txt.Text))
            {
                Pass_txt.Focus();
                Pass_txt.Select();
                MyHelper.SnackbarShow(this,this.Snackbar, "يرجي ادخال كلمة المرور", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            try
            {
               
                User TrueUser =await user.ValidateUser(Username_TxtBox.Text, Pass_txt.Text);
                //MainMenuForm mainMenu=new MainMenuForm(TrueUser);
                //mainMenu.Show();
                Username_TxtBox.Clear();
                Pass_txt.Clear();
                MyHelper.OpenForm<MainMenuForm>(TrueUser);
                Hide();
            }
            catch (Exception ex)
            {
                // Handle the exception
                if (ex.Message == "No Record in Database")
                {
                    // Handle the case where there are no records in the database
                    BunifuPages2.SetPage("Add User");
                    Banner_Image.Image = Insta_Icon.InitialImage;
                    MyHelper.SnackbarShow(this, this.Snackbar, "لايوجد مستخدمين سيتم تحويلك لاضافه مستخدم جديد",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
                else if (ex.Message == "User Not Found")
                {
                    // Handle the case where the user was not found
                    MyHelper.SnackbarShow(this, this.Snackbar, "المستخدم غير موجود");
                }
                else
                {
                    // Handle other exceptions
                    MyHelper.SnackbarShow( this, this.Snackbar, "An error occurred: " + ex.Message);
                }
            }

        }


        private void Frgt_Pswrd_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Password Recovery");
            Banner_Image.Image = Wbsit_Icon.ErrorImage;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Exit Page");
            Banner_Image.Image = Insta_Icon.ErrorImage;
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Login Page");
            Banner_Image.Image = Wbsit_Icon.InitialImage;
            Restore_Wrd_Txt.Clear();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quick_Access_Btn_Click(object sender, EventArgs e)
        {
            BunifuPages2.SetPage("Login Page");
            Banner_Image.Image = Wbsit_Icon.InitialImage;
            Restore_Wrd_Txt.Clear();
        }

        private async void Restore_Btn_Click(object sender, EventArgs e)
        {   //BunifuPages2.SetPage("Password Recovered");
            BunifuPages2.SetPage("Login Page");
            User recoveredUser =await user.GetByRecoveryWord(Restore_Wrd_Txt.Text);
            if (recoveredUser != null)
            {
                MyHelper.OpenForm<MainMenuForm>(recoveredUser);
                Hide();
                Restore_Wrd_Txt.Clear();
            }
            else
            {
                MyHelper.SnackbarShow(this, this.Snackbar, "ادخل كلمه الاستعاده الصحيحه",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

        }

        private void Pass_txt_OnIconLeftClick(object sender, EventArgs e)
        {
            if ((Pass_txt.IconLeft).Equals(Fb_Icon.InitialImage))
            {
                Pass_txt.IconLeft = Fb_Icon.ErrorImage;
                Pass_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Pass_txt.IconLeft = Fb_Icon.InitialImage;
                Pass_txt.UseSystemPasswordChar = true;
            }

            Pass_txt.Validate();
            Pass_txt.Refresh();

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

        private void Pass_txt_IconLeftClick(object sender, EventArgs e)
        {
            Password_Eye(ref Pass_txt);
        }

        private void Fb_Icon_Click(object sender, EventArgs e)
        {
            MyHelper.SnackbarShow(this, this.Snackbar, "Ahmed", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
        }

        private void Wbsit_Icon_Click(object sender, EventArgs e)
        {
            MyHelper.SnackbarShow( this, this.Snackbar, "Ahmed",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
        }

        private void Insta_Icon_Click(object sender, EventArgs e)
        {
            MyHelper.SnackbarShow(this, this.Snackbar, "Ahmed Ali", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            WaitLoaderForm waitLoader= new WaitLoaderForm(this,new SetConnection(), 10);
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            MyHelper.CloseForm<Form1>();

        }

        private async void Add_New_User_Btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = Username_Add_TextBox.Text;
            user.UserName = Add_Username_TextBox.Text;
            user.RecoverWord = Add_User_Recovery_TextBox.Text;
            user.Password = Add_User_Password_TextBox.Text;
            user.Phone = "00000000000";
            user.IsActive=true;
            user.IsDeleted = false;
            bool IsSuccess= await this.user.Add(user);
            if (IsSuccess)
            {
                User TrueUser = await this.user.ValidateUser(user.UserName, user.Password);

                MyHelper.OpenForm<MainMenuForm>(TrueUser);
                Hide();
            }
        }
    }
}
