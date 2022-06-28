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
    /// PasswordReset Panel
    /// </summary>
    public partial class PasswordReset : Form
    {
        //Variables and objects
        static string email;
        bool formMoving = false;
        Point startPoint = new Point(0, 0);

        //Constuctor
        public PasswordReset(RJconpanents.RJtextBox _email)
        {
            email = _email.Texts;
            InitializeComponent();
        }

        //Non-Event Methods
        private void PasswordSecurityControl()
        {
            byte result = default;

            if (rjtxtBoxNewPassword.Texts.IsThereUpper()) result++;
            if (rjtxtBoxNewPassword.Texts.IsThereLower()) result++;
            if (rjtxtBoxNewPassword.Texts.IsThereNumber()) result++;
            if (rjtxtBoxNewPassword.Texts.IsTherePunctuation()) result++;

            if (rjtxtBoxNewPassword.Texts.Length >= 8)
            {

                if (result == 1)
                {
                    rjbtnChangePassword.Enabled = false;
                    rjtxtBoxNewPassword.ForeColor = Color.DarkRed;
                }
                else if (result == 2)
                {
                    rjbtnChangePassword.Enabled = true;
                    rjtxtBoxNewPassword.ForeColor = Color.DarkOrange;
                }
                else if (result == 3)
                {
                    rjbtnChangePassword.Enabled = true;
                    rjtxtBoxNewPassword.ForeColor = Color.Yellow; // kaldırılabilir
                }
                else if (result == 4)
                {
                    rjbtnChangePassword.Enabled = true;
                    rjtxtBoxNewPassword.ForeColor = Color.Green;
                }
            }
            else
            {
                rjbtnChangePassword.Enabled = false;
                rjtxtBoxNewPassword.ForeColor = Color.DarkRed;
            }
        }

        //Load
        private void PasswordReset_Load(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            ToolTip t2 = new ToolTip();
            // 0
            t1.ToolTipIcon = ToolTipIcon.Info;
            t1.ToolTipTitle = "Bilgi";
            t1.InitialDelay = 200;
            t1.ReshowDelay = 300;
            t1.AutoPopDelay = 2000;
            t1.SetToolTip(rjtxtBoxNewPassword, "Şifre en az 8 karakterden oluşmalıdır. Maksimum uzunluğu 16 olmalıdır");
            // 1
            t2.ToolTipIcon = ToolTipIcon.Info;
            t2.ToolTipTitle = "Bilgi";
            t2.InitialDelay = 200;
            t2.ReshowDelay = 300;
            t2.AutoPopDelay = 2000;
            t2.SetToolTip(rjtxtBoxNewPassword, "Şifre en az 8 karakterden oluşmalıdır. Maksimum uzunluğu 16 olmalıdır");
            //
            //btnCancel
            //
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.Tomato;
            //
            //txtBoxNewPassword and txtBoxReNewPassword
            //
            rjtxtBoxNewPassword.MaxLength = 16;
            rjtxtBoxNewPassword.PasswordChar = true;
            rjtxtBoxNewPassword.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxNewPassword.UnderlinedStyle = true;
            rjtxtBoxNewPassword.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxNewPassword.BorderColor = Color.FromArgb(24, 58, 114);

            rjtxtBoxReNewPassword.MaxLength = 16;
            rjtxtBoxReNewPassword.PasswordChar = true;
            rjtxtBoxReNewPassword.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxReNewPassword.UnderlinedStyle = true;
            rjtxtBoxReNewPassword.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxReNewPassword.BorderColor = Color.FromArgb(24, 58, 114);

        }

        //Event Methods
        private void rjbtnChangePassword_Click(object sender, EventArgs e)
        {
            if (rjtxtBoxNewPassword.Texts == rjtxtBoxReNewPassword.Texts)
            {
                RegProcessClass.RegPasswordUpdate(rjtxtBoxNewPassword, email);
                this.Close();
                Login login = new Login();
                login.Show();
            }
            else
                MessageBox.Show("Girmiş olduğunuz şifreler uyuşmuyor. Lütfen tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void rjtxtBoxNewPassword__TextChanged(object sender, EventArgs e)
        {
            PasswordSecurityControl();
        }
        private void rjtxtBoxReNewPassword__TextChanged(object sender, EventArgs e)
        {
            PasswordSecurityControl();
        }
        private void rjtxtBoxesSpaceResetControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }
    }
}
