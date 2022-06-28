using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MertDogan_202503033
{
    /// <summary>
    /// Login Panel
    /// </summary>

    public partial class Login : Form
    {
        //Variables and objects
        public static string UserName;
        public static string Password;
        public static bool IsLoginToSign = false;
        public static NotifyIcon notifyIconLogin = new NotifyIcon();
        bool formMoving = false;
        Point startPoint = new Point(0, 0);

        //Constructor
        public Login()
        {
            InitializeComponent();
            contextMenuStripLogin.Renderer = new MyRenderer();
        }

        //Non-Event Methods
        private void BtnLoginControl()
        {
            if (rjtxtBoxLoginUserName.Texts == string.Empty || rjtxtBoxLoginPassword.Texts == string.Empty)
                rjbtnLogin.Enabled = false;
            else
                rjbtnLogin.Enabled = true;
        }

        //Load
        private void Login_Load(object sender, EventArgs e)
        {
            //
            //toolTipUserName
            //
            toolTipUserName.ToolTipIcon = ToolTipIcon.Info;
            toolTipUserName.ToolTipTitle = "Bilgi";
            toolTipUserName.InitialDelay = 200;
            toolTipUserName.ReshowDelay = 300;
            toolTipUserName.AutoPopDelay = 2000;
            toolTipUserName.SetToolTip(rjtxtBoxLoginUserName, "Kullanıcı adının maksimum uzunluğu 15 olmalıdır");
            //
            //toolTipPassword
            //
            toolTipPassword.ToolTipIcon = ToolTipIcon.Info;
            toolTipPassword.ToolTipTitle = "Bilgi";
            toolTipPassword.InitialDelay = 200;
            toolTipPassword.ReshowDelay = 300;
            toolTipPassword.AutoPopDelay = 2000;
            toolTipPassword.SetToolTip(rjtxtBoxLoginPassword, "Şifre en az 8 karakterden oluşmalıdır. Maksimum uzunluğu 16 olmalıdır");
            //
            //toolTipBtnCancel
            //
            toolTipBtnCancel.ToolTipIcon = ToolTipIcon.None;
            toolTipBtnCancel.ToolTipTitle = string.Empty;
            toolTipBtnCancel.InitialDelay = 200;
            toolTipBtnCancel.ReshowDelay = 300;
            toolTipBtnCancel.AutoPopDelay = 2000;
            toolTipBtnCancel.SetToolTip(btnCancel, "Kapat");
            //
            //toolTipBtnHide
            //
            toolTipBtnHide.ToolTipIcon = ToolTipIcon.None;
            toolTipBtnHide.ToolTipTitle = string.Empty;
            toolTipBtnHide.InitialDelay = 200;
            toolTipBtnHide.ReshowDelay = 300;
            toolTipBtnHide.AutoPopDelay = 2000;
            toolTipBtnHide.SetToolTip(btnHide, "Küçült");
            //
            //rjtxtBoxLoginUserName
            //
            rjtxtBoxLoginUserName.Focus();
            rjtxtBoxLoginUserName.MaxLength = 15;
            rjtxtBoxLoginUserName.UnderlinedStyle = true;
            rjtxtBoxLoginUserName.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxLoginUserName.BorderFocusColor = Color.SeaGreen;
            //
            //rjtxtBoxLoginPassword
            //
            rjtxtBoxLoginPassword.MaxLength = 16;
            rjtxtBoxLoginPassword.UnderlinedStyle = true;
            rjtxtBoxLoginPassword.PasswordChar = true;
            rjtxtBoxLoginPassword.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxLoginPassword.BorderFocusColor = Color.SeaGreen;
            //
            //pcBoxLogKeyImage
            //
            pcBoxLogKeyImage.BackColor = Color.FromArgb(225, 225, 225);
            //
            //pcBoxLogUserNameImage
            //
            pcBoxLogUserNameImage.BackColor = Color.FromArgb(225, 225, 225);
            //
            //rjbtnLogin
            //
            rjbtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLoginControl();
            //
            //btnCancel
            //
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.Tomato;
            //
            //btnHide
            //
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatAppearance.MouseOverBackColor = Color.Gray;
            //
            //linklblSignUp
            //
            linklblSignUp.ActiveLinkColor = Color.Tomato;
            //
            //linklblForgotPassword
            //
            linklblForgotPassword.ActiveLinkColor = Color.Tomato;
            //
            //notifyIconLogin
            //
            if (notifyIconLogin.Visible == false)
            {
                notifyIconLogin.Visible = true;
                notifyIconLogin.Icon = Properties.Resources.Directsy;
                notifyIconLogin.Text = "Directsy";
                notifyIconLogin.ContextMenuStrip = contextMenuStripLogin;
            }
            //
            //contextMenuStripLogin
            //
            contextMenuStripLogin.ShowImageMargin = false;
        }

        //Event Methods
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Directsy Uygulamasını Kapatmak İstediğinize Emin misiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                notifyIconLogin.Visible = false;
                Application.Exit();
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void rjbtnLogin_Click(object sender, EventArgs e)
        {
            UserName = rjtxtBoxLoginUserName.Texts;
            Password = rjtxtBoxLoginPassword.Texts;

            RegProcessClass.RegLogin(this, rjtxtBoxLoginUserName, rjtxtBoxLoginPassword);
        }
        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsLoginToSign = true;
            SignUp signUp = new SignUp(this, IsLoginToSign);
            this.Hide();
            signUp.Show();
        }
        private void linklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(this);
            this.Hide();
            forgotPassword.Show();
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void rjtxtBoxesControl__TextChanged(object sender, EventArgs e)
        {
            BtnLoginControl();
        }
        private void rjtxtBoxesSpaceControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            public MyColors()
            {
                base.UseSystemColors = false;
            }
            public override Color MenuItemSelected
            {
                // when the menu is selected
                get { return Color.FromArgb(64, 64, 64); }
            }
        }
    }
}