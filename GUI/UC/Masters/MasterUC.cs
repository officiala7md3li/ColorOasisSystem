using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using ColorOasisSystem.GUI.HelpingProgram;
using ColorOasisSystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorOasisSystem.GUI.UC
{
    public partial class MasterUC : UserControl
    {

        public MasterUC()
        {
            InitializeComponent();
        }
        private bool masterUCLockValue = true;
        public bool MasterUCLock
        {
            get { return masterUCLockValue; }
            set
            {
                masterUCLockValue = value;
                DisableLockBtn.Visible = value;
                if (value)
                    DisableLockBtn.BringToFront();
                Invalidate();
            }
        }
        public Image Logoimage
        {
            get
            { return LogoPic.Image; }
            set
            {
                LogoPic.Image = value;
                Invalidate();
                MyHelper.CenterControlsOnScreen(this.Width,LogoLbl ,LogoPic );
                LogoPic.Refresh();
            }
        }
        public string LogoLabel
        {
            get { return LogoLbl.Text; }
            set
            {
                //logoLabel = value;
                LogoLbl.Text = value;
                MyHelper.CenterControlsOnScreen(this.Width,LogoLbl, LogoPic );
                Invalidate();
            }
        }

        private bool edit_ = false;
        public bool EditDataCheck
        {
            get { return edit_; }
            set
            {
                edit_ = value;
                Invalidate();
            }
        }

        #region Main Buttons Visible
        private bool newBtnVisible_ = true;
        public bool NewBtnVisible
        {
            get { return newBtnVisible_; }
            set
            {
                newBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool saveBtnVisible_ = false;
        public bool SaveBtnVisible
        {
            get { return saveBtnVisible_; }
            set
            {
                saveBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool editBtnVisible_ = false;
        public bool EditBtnVisible
        {
            get { return editBtnVisible_; }
            set
            {
                editBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool deleteBtnVisible_ = false;
        public bool DeleteBtnVisible
        {
            get { return deleteBtnVisible_; }
            set
            {
                deleteBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool searchBtnVisible_ = false;
        public bool SearchBtnVisible
        {
            get { return searchBtnVisible_; }
            set
            {
                searchBtnVisible_ = value;
                Invalidate();
            }
        }

        private bool saveAsVisible_ = false;
        public bool PrintBtnVisible
        {
            get { return saveAsVisible_; }
            set
            {
                saveAsVisible_ = value;
                Invalidate();
            }
        }
        #endregion

        public virtual void BackAction() { }

        public virtual void NewData()
        {
            EditDataCheck = false;
        }

        public virtual void LoadData(int ItemID) { }

        public virtual void ZoomData() { }

        public virtual void SetData() { }

        public virtual void SaveData()
        {
            popMessage("تمت عملية حفظ البيانات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            NewData();
        }

        public virtual void EditData()
        {
            popMessage("تمت عملية التعديل على البيانات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            EditDataCheck = false;
            NewData();
        }

        public virtual void DeleteData()
        {
            popMessage("تمت عملية حذف البيانات بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
            NewData();
        }

        public virtual void SaveAsData()
        {
            popMessage(  "تمت عملية حفظ البيانات خارجياً بنجاح", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5);
        }
        public virtual void Search_Data()
        {
           // Wait_Loader_Form.TransparentBG(Main_Menu, Search_Form, Main_Menu.Form_Dock.BorderRadius);
        }

        public virtual void EnableChanged() { }

        public virtual void DisableChanged()
        {

        }
        private void DisableLockBtn_Click(object sender, EventArgs e)
        {


            popMessage("لا تمتلك الصلاحيه الكافيه لمعاينه الشاشه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
        }

        #region "Change Enable and visible Properties"
        void ChangeEnableOptions(bool newEnable = true, bool saveEnable = true, bool editEnable = true, bool deleteEnable = true, bool searchEnable = true)
        {
            New_Btn.Enabled = NewBtnVisible;
            Save_Btn.Enabled = SaveBtnVisible;
            if (edit_)
            {
                Save_Btn.Enabled = EditBtnVisible;
            }
            if (edit_)
            {
                Delete_Btn.Enabled = DeleteBtnVisible;
            }
            Search_Btn.Enabled = SearchBtnVisible;
        }

        void ChangeVisibilityOptions(bool visibility = true)
        {
            New_Btn.Visible = NewBtnVisible;
            Save_Btn.Visible = SaveBtnVisible;
            if (edit_)
            {
                Save_Btn.Visible = EditBtnVisible;
            }
            if (edit_)
            {
                Delete_Btn.Visible = DeleteBtnVisible;
            }
            Delete_Btn.Location = Guna2Button3.Location;
            Search_Btn.Location = Guna2Button1.Location;
            if (!edit_)
            {
                Search_Btn.Location = Delete_Btn.Location;
                if (!deleteBtnVisible_)
                {
                    Search_Btn.Location = Delete_Btn.Location;
                }
            }
            else if (edit_ && !editBtnVisible_)
            {
                Search_Btn.Location = Guna2Button3.Location;
                Delete_Btn.Location = Save_Btn.Location;
            }
            Search_Btn.Visible = SearchBtnVisible;

        }
        #endregion
        #region Showing Action Buttons
        private void Option_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeVisibilityOptions();
                A2SAnimator1.StandardAnimate(New_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Save_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Delete_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                A2SAnimator1.StandardAnimate(Search_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Options_Tmr.Start();
                Refresh();
                //Cursor.Position = new Point((Main_Menu.DesktopLocation.X) + (Location.X) + (New_Btn.Location.X) + (New_Btn.Size.Width / 2), (Main_Menu.DesktopLocation.Y) + (Location.Y) + (New_Btn.Location.Y) + (New_Btn.Size.Height / 2));
                Cursor.Position = new Point(New_Btn.Parent.PointToScreen(New_Btn.Location).X + (New_Btn.Size.Width / 2), New_Btn.Parent.PointToScreen(New_Btn.Location).Y + (New_Btn.Size.Height / 2));
            }
            catch (Exception ex)
            {
            }
        }

        private void Options_Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                Options_Tmr.Stop();
                A2SAnimator1.StandardAnimate(New_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                New_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Save_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Save_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Delete_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Delete_Btn.Visible = false;
                A2SAnimator1.StandardAnimate(Search_Btn, A7MD_Library.NewComponent.A2SAnimator.StandardAnimation.SlideUp, 15);
                Search_Btn.Visible = false;
            }
            catch (Exception ex)
            {
                New_Btn.Visible = false;
                Save_Btn.Visible = false;
                Delete_Btn.Visible = false;
                Search_Btn.Visible = false;
            }
        }

        private void Action_Buttons_MouseLeave(object sender, EventArgs e)
        {
            Options_Tmr.Start();
        }

        private void Action_Buttons_MouseHover(object sender, EventArgs e)
        {
            Options_Tmr.Stop();
        }
        #endregion

        #region "Actions Buttons Click Properties"
        private void New_Btn_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (!edit_)
            {
                SaveData();
            }
            else
            {
                EditData();
                EditDataCheck = false;
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            Search_Data();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Visible = false;
            Enabled = false;
            //My.Settings.Previous_UC = this;
            //My.MySettings.Default.Previous_UC = this;
            //My.Settings.Save();
            //BackAction();
        }

        private void Master_UC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (Save_Btn.Enabled)
                {
                    Save_Btn.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                New_Btn.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (Delete_Btn.Enabled)
                {
                    Delete_Btn.PerformClick();
                }
            }

            else if (e.KeyCode == Keys.F4)
            {
                if (Search_Btn.Enabled)
                {
                    Search_Btn.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Back_Button.PerformClick();
            }
        }

        private void Master_UC_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                EnableChanged();
            }
            else
            {
                if (Properties.Settings.Default.EnableUC)
                {
                    DisableChanged();
                }
            }
        }

        private void Disable_Lock_Btn_Click(object sender, EventArgs e)
        {


            popMessage( "لا تمتلك الصلاحيه الكافيه لمعاينه الشاشه", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
        }

        #endregion

        private void MasterUC_SizeChanged(object sender, EventArgs e)
        {
            Option_Btn.Location = new Point(Option_Btn.Location.X, this.Size.Height - 39);
            if (!(this.Size.Height> 540))
            {
                New_Btn.Location = new Point(New_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Save_Btn.Location = new Point(Save_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Delete_Btn.Location = new Point(Delete_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Search_Btn.Location = new Point(Search_Btn.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Guna2Button1.Location = new Point(Guna2Button1.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
                Guna2Button3.Location = new Point(Guna2Button3.Location.X, Option_Btn.Top - (Option_Btn.Height / 2));
            }
        }
        public List<T> SearchByProperty<T>(List<T> sourceList, string searchProperty, string searchValue)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(searchProperty, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
            {
                popMessage($"Property '{searchProperty}' not found.",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return new List<T>();
            }

            return sourceList.Where(x => propertyInfo.GetValue(x)?.ToString()?.Contains(searchValue) == true).ToList();
        }
        public List<string> DisplayAvailableProperties<T>()
        {
            List<string> result = new List<string>();
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                result.Add(property.Name);
            }
            return result;
        }
        public bool ValidateString(Guna.UI2.WinForms.Guna2TextBox textBox,string ErrorCaption)
        {
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                
                popMessage(  ErrorCaption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5);
                textBox.Focus();
                textBox.Select();
                return false;
            }
            return true;
        }
        public virtual void popMessage(string Caption, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes messageTypes, int timerDelay=5)
        {
            MainMenuForm MainForm_Var= Application.OpenForms.OfType<MainMenuForm>().FirstOrDefault();
            MyHelper.SnackbarShow(MainForm_Var, MainForm_Var.Snackbar, Caption, messageTypes, timerDelay);
        }
    }
}
