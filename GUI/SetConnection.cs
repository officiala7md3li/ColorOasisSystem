using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace ColorOasisSystem.GUI
{
    public partial class SetConnection : Form
    {
        private string S_Back = "";
        private SqlConnection Con = new SqlConnection();
        private Server Server_Name_ = new Server();
        private SqlConnectionStringBuilder Con_String_Builder = new SqlConnectionStringBuilder();
        private ServerConnection Server_Con = new ServerConnection();
        private string Server_Name = "";
        public string ServerName


        {
            get { return Server_Name; }
            set { Server_Name = value; }
        }

        private string DataBase_Name = "";
        public string DataBaseName
        {
            get { return DataBase_Name; }
            set { DataBase_Name = value; }
        }

        private bool Auth_Method;
        public bool AuthMethod
        {
            get { return Auth_Method; }
            set { Auth_Method = value; }
        }

        private string SQL_login_Name;
        public string SQLLoginName
        {
            get { return SQL_login_Name; }
            set { SQL_login_Name = value; }
        }

        private string SQL_login_Password;

        public SetConnection()
        {
            // This call is required by the designer.
             InitializeComponent();
            // Add any initialization after the InitializeComponent() call.
        }

        public string SQLloginPassword
        {
            get { return SQL_login_Password; }
            set { SQL_login_Password = value; }
        }

        private void Pass_txt_IconRightClick(object sender, EventArgs e)
        {
            if (Pass_txt.IconRight == Close_Btn.Image)
            {
                Pass_txt.IconRight = Mini_Btn.Image;
                Pass_txt.UseSystemPasswordChar = true;
            }
            else
            {
                Pass_txt.IconRight = Close_Btn.Image;
                Pass_txt.UseSystemPasswordChar = false;
            }
        } //Show and hide Password


        private void Win_Auth_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Win_Auth");
            AuthMethod = true;
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Discard_Btn_Click(object sender, EventArgs e)
        {
            Banner_Image.Hide();
            SQL_Page.SetPage(S_Back);
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            S_Back = SQL_Page.Page.Text;
            SQL_Page.SetPage("Exit Page");
            Banner_Image.BringToFront();
            Banner_Image.Show();
        }

        private void SQL_Auth_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("SQL_Auth");
            AuthMethod = false;
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Selection");
        }

        private void Back_2_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("SQL_Auth");
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (Validatation(SQL_Servername_TxtBox.Text))
            {
                if (Validatation(SQL_Port_Num_TxtBox.Text))
                {
                    ServerName = SQL_Servername_TxtBox.Text + "," + SQL_Port_Num_TxtBox.Text;
                }
                else
                {
                    ServerName = SQL_Servername_TxtBox.Text;
                }
            }
            else
            {
                Snackbar.Show(this, "Please Enter The Server Name and The Port No.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            if (Validatation(SQL_DataBasename_TxtBox.Text))
            {
                DataBaseName = SQL_DataBasename_TxtBox.Text;
            }
            else
            {
                Snackbar.Show(this, "Please Enter The DataBase Name", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            SQL_Page.SetPage("Continue_SQL_Auth");
        }

        private void Test_Connection_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con = new SqlConnection(Properties.Settings.Default.ConnectionString);
                Con.Open();
                Snackbar.Show(this, "Connection done Successfully", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            }
            catch (Exception )
            {
                Snackbar.Show(this, "Connection Failed", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void Save_Settings_Btn_Click(object sender, EventArgs e)
        {
            if (Validatation(Username_TxtBox.Text))
            {
                SQLLoginName = Username_TxtBox.Text;
            }
            else
            {
                Snackbar.Show(this, "Please Enter The User Name", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            if (Validatation(Pass_txt.Text))
            {
                SQLloginPassword = Pass_txt.Text;
            }
            else
            {
                Snackbar.Show(this, "Please Enter The Password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            try
            {
                Server_Con = new ServerConnection(Server_Name);
                Server_Name_ = new Server(Server_Con);
                Con_String_Builder = new SqlConnectionStringBuilder
                {
                    DataSource = Server_Name,
                    InitialCatalog = DataBase_Name,
                    IntegratedSecurity = Auth_Method,
                    UserID = SQL_login_Name,
                    Password = SQL_login_Password,
                    ConnectTimeout = 180,
                    MultipleActiveResultSets = true
                };
                Properties.Settings.Default.Server_Name = Server_Name;
                Properties.Settings.Default.DB_Name = DataBase_Name;
                Properties.Settings.Default.Auth_Method = Auth_Method;
                Properties.Settings.Default.SQL_login_Name = SQL_login_Name;
                Properties.Settings.Default.SQL_login_Password = SQL_login_Password;
                Con = new SqlConnection(Con_String_Builder.ConnectionString);
                Properties.Settings.Default["ConnectionString"] = Con_String_Builder.ConnectionString;
                Properties.Settings.Default.Save();
                //DB_Connection.Connection_Open();
                Snackbar.Show(this, "Connection data Saved Successfully", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            }
            catch (Exception )
            {
                // Handle exception
            }
            finally
            {
                //DB_Connection.Connection_Close();
            }
        }

        public bool Validatation(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Authenticate_with_Server_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Selection");
        }

        private void Connect_Database_File_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Connect Database File");
        }

        private void Create_Database_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Selection");
        }

        private void Back_Action_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Action_Take");
        }

        private void Back2_Action_Btn_Click(object sender, EventArgs e)
        {
            SQL_Page.SetPage("Action_Take");
        }

        private void Win_Save_Settings_Btn_Click(object sender, EventArgs e)
        {
            if (Validatation(Win_Servername_TxtBox.Text))
            {
                if (Validatation(Win_Port_Num_TxtBox.Text))
                {
                    ServerName = Win_Servername_TxtBox.Text + "," + Win_Port_Num_TxtBox.Text;
                }
                else
                {
                    ServerName = Win_Servername_TxtBox.Text;
                }
            }
            else
            {
                Snackbar.Show(this, "Please Enter The Server Name and The Port No.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            if (Validatation(Win_DataBasename_TxtBox.Text))
            {
                DataBaseName = Win_DataBasename_TxtBox.Text;
            }
            else
            {
                Snackbar.Show(this, "Please Enter The DataBase Name", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }
            try
            {
                Server_Con = new ServerConnection(Server_Name);
                Server_Name_ = new Server(Server_Con);
                Con_String_Builder = new SqlConnectionStringBuilder
                {
                    DataSource = Server_Name,
                    InitialCatalog = DataBase_Name,
                    IntegratedSecurity = Auth_Method,
                    ConnectTimeout = 120
                };
                Properties.Settings.Default.Server_Name = Server_Name;
                Properties.Settings.Default.DB_Name = DataBase_Name;
                Properties.Settings.Default.Auth_Method = Auth_Method;
                Properties.Settings.Default.SQL_login_Name = SQL_login_Name;
                Properties.Settings.Default.SQL_login_Password = SQL_login_Password;
                Con = new SqlConnection(Con_String_Builder.ConnectionString);
                Properties.Settings.Default["ConnectionString"] = Con_String_Builder.ConnectionString;
                Properties.Settings.Default.Save();
                Snackbar.Show(this, "Connection data Saved Successfully", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            }
            catch (Exception)
            {
                // Handle exception
            }
        }
    }


}
