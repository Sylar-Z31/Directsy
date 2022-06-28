using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertDogan_202503033
{
    /// <summary>
    /// SignUp Panel
    /// </summary>

    public partial class SignUp : Form
    {
        //Variables and objects
        static Login login;
        static DataGridView dgv;
        bool formMoving = false;
        bool IsLoginToSign = false;
        Point startPoint = new Point(0, 0);


        //Constructors
        public SignUp(Login _login, bool _IsLoginToSign)
        {
            login = _login;
            IsLoginToSign = _IsLoginToSign;
            InitializeComponent();
        }
        public SignUp(DataGridView _dgv)
        {
            dgv = _dgv;
            InitializeComponent();
        }

        //Non-Event Methods
        private void BtnSignControl()
        {
            if (rjtxtBoxSignName.Texts == string.Empty || rjtxtBoxSignSurname.Texts == string.Empty ||
                rjtxtBoxSignUserName.Texts == string.Empty || rjtxtBoxSignPassword.Texts == string.Empty || rjtxtBoxSignEmail.Texts == string.Empty)
                rjbtnSignUp.Enabled = false;
            else
                rjbtnSignUp.Enabled = true;
        }
        private void PasswordSecurityControl()
        {
            byte result = default;

            if (rjtxtBoxSignPassword.Texts.IsThereUpper()) result++;
            if (rjtxtBoxSignPassword.Texts.IsThereLower()) result++;
            if (rjtxtBoxSignPassword.Texts.IsThereNumber()) result++;
            if (rjtxtBoxSignPassword.Texts.IsTherePunctuation()) result++;

            if (rjtxtBoxSignPassword.Texts.Length >= 8)
            {
                if (result == 1)
                    rjtxtBoxSignPassword.ForeColor = Color.DarkRed;
                else if (result == 2)
                    rjtxtBoxSignPassword.ForeColor = Color.DarkOrange;
                else if (result == 3)
                    rjtxtBoxSignPassword.ForeColor = Color.Yellow; // kaldırılabilir
                else if (result == 4)
                    rjtxtBoxSignPassword.ForeColor = Color.Green;
            }
            else
                rjtxtBoxSignPassword.ForeColor = Color.DarkRed;
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            //
            //All rjtxtBoxes
            //
            rjtxtBoxSignName.MaxLength = 15;
            rjtxtBoxSignName.UnderlinedStyle = true;
            rjtxtBoxSignName.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxSignName.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxSignName.BorderFocusColor = Color.SeaGreen;

            rjtxtBoxSignSurname.MaxLength = 15;
            rjtxtBoxSignSurname.UnderlinedStyle = true;
            rjtxtBoxSignSurname.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxSignSurname.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxSignSurname.BorderFocusColor = Color.SeaGreen;

            rjtxtBoxSignUserName.MaxLength = 15;
            rjtxtBoxSignUserName.UnderlinedStyle = true;
            rjtxtBoxSignUserName.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxSignUserName.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxSignUserName.BorderFocusColor = Color.SeaGreen;

            rjtxtBoxSignPassword.MaxLength = 16;
            rjtxtBoxSignPassword.UnderlinedStyle = true;
            rjtxtBoxSignPassword.PasswordChar = true;
            rjtxtBoxSignPassword.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxSignPassword.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxSignPassword.BorderFocusColor = Color.SeaGreen;

            rjtxtBoxSignEmail.MaxLength = 50;
            rjtxtBoxSignEmail.UnderlinedStyle = true;
            rjtxtBoxSignEmail.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxSignEmail.BorderColor = Color.FromArgb(24, 58, 114);
            rjtxtBoxSignEmail.BorderFocusColor = Color.SeaGreen;
            //
            //toolTipName
            //
            toolTipName.ToolTipIcon = ToolTipIcon.Info;
            toolTipName.ToolTipTitle = "Bilgi";
            toolTipName.InitialDelay = 200;
            toolTipName.ReshowDelay = 300;
            toolTipName.AutoPopDelay = 2000;
            toolTipName.SetToolTip(rjtxtBoxSignName, "ismin maksimum uzunluğu 15 olmalıdır.");
            //
            //toolTipSurname
            //
            toolTipName.ToolTipIcon = ToolTipIcon.Info;
            toolTipName.ToolTipTitle = "Bilgi";
            toolTipName.InitialDelay = 200;
            toolTipName.ReshowDelay = 300;
            toolTipName.AutoPopDelay = 2000;
            toolTipName.SetToolTip(rjtxtBoxSignSurname, "Soyismin maksimum uzunluğu 15 olmalıdır.");
            //
            //toolTipUserName
            //
            toolTipName.ToolTipIcon = ToolTipIcon.Info;
            toolTipName.ToolTipTitle = "Bilgi";
            toolTipName.InitialDelay = 200;
            toolTipName.ReshowDelay = 300;
            toolTipName.AutoPopDelay = 2000;
            toolTipName.SetToolTip(rjtxtBoxSignUserName, "Kullanıcı adının maksimum uzunluğu 15 olmalıdır.");
            //
            //toolTipPassword
            //
            toolTipName.ToolTipIcon = ToolTipIcon.Info;
            toolTipName.ToolTipTitle = "Bilgi";
            toolTipName.InitialDelay = 200;
            toolTipName.ReshowDelay = 300;
            toolTipName.AutoPopDelay = 2000;
            toolTipName.SetToolTip(rjtxtBoxSignPassword, "Kullanıcı şifresin en az 8 en fazla 16 karakterden oluşmalıdır.");
            //
            //toolTipMail
            //
            toolTipName.ToolTipIcon = ToolTipIcon.Info;
            toolTipName.ToolTipTitle = "Bilgi";
            toolTipName.InitialDelay = 200;
            toolTipName.ReshowDelay = 300;
            toolTipName.AutoPopDelay = 2000;
            toolTipName.SetToolTip(rjtxtBoxSignEmail, "Email uzunluğu maksimum 50 karakter olmalıdır");
            //
            //toolTipReturnLogin
            //
            toolTipReturnLogin.ToolTipIcon = ToolTipIcon.None;
            toolTipReturnLogin.ToolTipTitle = string.Empty;
            toolTipReturnLogin.InitialDelay = 200;
            toolTipReturnLogin.ReshowDelay = 300;
            toolTipReturnLogin.AutoPopDelay = 2000;
            toolTipReturnLogin.SetToolTip(btnSignCancel, "Giriş paneline dön");
            //
            //btnSignCancel
            //
            btnSignCancel.FlatAppearance.BorderSize = 0;
            btnSignCancel.FlatAppearance.MouseOverBackColor = Color.Tomato;
            //
            //rjbtnSignUp
            //
            rjbtnSignUp.Enabled = false;
        }

        //Event Methods
        private void rjbtnSignUp_Click(object sender, EventArgs e)
        {
            Login.UserName = rjtxtBoxSignUserName.Texts;
            Login.Password = rjtxtBoxSignPassword.Texts;

            if (rjtxtBoxSignPassword.ForeColor != Color.DarkRed)
                RegProcessClass.RegAdd(this, IsLoginToSign, dgv, rjtxtBoxSignUserName, rjtxtBoxSignPassword, rjtxtBoxSignEmail, rjtxtBoxSignName, rjtxtBoxSignSurname);
            else
                MessageBox.Show("Parola Çok Zayıf", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSignCancel_Click(object sender, EventArgs e)
        {
            if (!HomePage.admin)
            {
                this.Close();
                login.Show();
            }
            else
                this.Close();
        }
        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void SignUp_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void rjtxtBoxSignPassword__TextChanged(object sender, EventArgs e)
        {
            BtnSignControl();
            PasswordSecurityControl();
        }
        private void rjtxtBoxesSignSpaceControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }
        private void rjtxtBoxesControl__TextChanged(object sender, EventArgs e)
        {
            BtnSignControl();
        }
    }
    //ExtensionMenager For Password Security
    public static class ExtensionMenager
    {
        public static bool IsThereNumber(this string text)
        {
            foreach (char item in text)
            {
                if (Char.IsDigit(item))
                    return true;
            }
            return false;
        }
        public static bool IsThereUpper(this string text)
        {
            foreach (char item in text)
            {
                if (Char.IsUpper(item))
                    return true;
            }
            return false;
        }
        public static bool IsThereLower(this string text)
        {
            foreach (char item in text)
            {
                if (Char.IsLower(item))
                    return true;
            }
            return false;
        }
        public static bool IsTherePunctuation(this string text)
        {
            foreach (char item in text)
            {
                if (Char.IsPunctuation(item))
                    return true;
            }
            return false;
        }
        public static bool IsThereSymbol(this string text)
        {
            foreach (char item in text)
            {
                if (Char.IsSymbol(item))
                    return true;
            }
            return false;
        }
    }
}
