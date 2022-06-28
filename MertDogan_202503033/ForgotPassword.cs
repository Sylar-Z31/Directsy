using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertDogan_202503033
{
    /// <summary>
    /// ForgotPassword Panel
    /// </summary>
    
    public partial class ForgotPassword : Form
    {
        //Variables and objects
        int minute = 2, second = 59;
        static int result;
        static Login login;
        bool formMoving = false;
        Point startPoint = new Point(0, 0);

        //Constructor
        public ForgotPassword(Login _login)
        {
            login = _login;
            InitializeComponent();
        }

        //Non-Event Methods
        static int CodeGeneration()
        {
            Random rnd = new Random();
            result = rnd.Next(100000, 999999);

            return result;
        }
        public static void EmailSend(string toWho, string subject = "Güvenlik Kodu")
        {
            string body = "Şifre Sıfırlama Kodu: " + CodeGeneration().ToString();

            Encoding encoding = Encoding.UTF8;

            MailAddress mailAddress = new MailAddress(toWho, toWho, encoding);
            MailAddress mailFrom = new MailAddress("companydirectsy@gmail.com", "Directsy", encoding);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = mailFrom;
            //mailMessage.To.Add(mailAddress);
            //mailMessage.CC.Add(""); Email alan kişi bu liste iceriisnde tanımlı olan kişi veya kişileri görebilir.
            mailMessage.Bcc.Add(mailAddress); // Bu alanda kişi eklenen kişileri göremez.
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;


            SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net", 587); // 25 olarakta deneyebiliriz
                                                                              // eğer sirketiniz exchange sunucusu üzerinden gönderim yapacaksa
            smtpClient.Credentials = new System.Net.NetworkCredential("apikey", "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");
            smtpClient.EnableSsl = false;
            smtpClient.Send(mailMessage);
        }

        //Load 
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            //
            //btnForgotNext
            //
            rjbtnForgotNext.Enabled = false;
            //
            //rjtxtBoxForgotCode
            //
            rjtxtBoxForgotCode.Enabled = false;
            rjtxtBoxForgotCode.MaxLength = 6;
            rjtxtBoxForgotCode.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxForgotCode.UnderlinedStyle = true;
            rjtxtBoxForgotCode.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxForgotCode.BorderColor = Color.FromArgb(24, 58, 114);
            //
            //rjtxtBoxForgotMail
            //
            rjtxtBoxForgotMail.MaxLength = 50;
            rjtxtBoxForgotMail.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxForgotMail.UnderlinedStyle = true;
            rjtxtBoxForgotMail.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxForgotMail.BorderColor = Color.FromArgb(24, 58, 114);
            //
            //timerForgot
            //
            timerForgot.Interval = 1000;
            //
            //btnChangePasswordCancel
            //
            btnChangePasswordCancel.FlatAppearance.BorderSize = 0;
            btnChangePasswordCancel.FlatAppearance.MouseOverBackColor = Color.Tomato;
            //
            //toolTipReturnLogin
            //
            toolTipReturnLogin.ToolTipIcon = ToolTipIcon.None;
            toolTipReturnLogin.ToolTipTitle = string.Empty;
            toolTipReturnLogin.InitialDelay = 200;
            toolTipReturnLogin.ReshowDelay = 300;
            toolTipReturnLogin.AutoPopDelay = 2000;
            toolTipReturnLogin.SetToolTip(btnChangePasswordCancel, "Giriş paneline dön");

        }

        //Event Methods
        private void rjbtnForgotSendCode_Click(object sender, EventArgs e)
        {
            RegProcessClass.RegSearch(rjtxtBoxForgotMail);

            if (RegProcessClass.itSend == true)
            {
                rjbtnForgotSendCode.Enabled = false;
                rjtxtBoxForgotCode.Enabled = true;
                rjbtnForgotNext.Enabled = true;
                timerForgot.Start();
                lblForgotTime.Text = (minute + ":" + second).ToString();
            }
        }
        private void btnChangePasswordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //Login login = new Login();
            login.Show();
        }
        private void rjbtnForgotNext_Click(object sender, EventArgs e)
        {
            if (rjtxtBoxForgotCode.Texts == result.ToString())
            {
                this.Hide();
                PasswordReset passwordReset = new PasswordReset(rjtxtBoxForgotMail);
                passwordReset.Show();
            }
        }
        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void ForgotPassword_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void ForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void timerForgot_Tick(object sender, EventArgs e)
        {
            if (second == 0 && minute > 0)
            {
                second = 59;
                minute--;
                if (second < 10)
                    lblForgotTime.Text = (minute + ":0" + second).ToString();
                else
                    lblForgotTime.Text = (minute + ":" + second).ToString();
            }
            else if (second == 0 && minute == 0)
            {
                lblForgotTime.Text = (minute + ":0" + second).ToString();
                rjbtnForgotSendCode.Enabled = true;
                rjbtnForgotNext.Enabled = false;
                rjtxtBoxForgotCode.Enabled = false;
                timerForgot.Stop();
            }
            else
            {
                second--;
                if (second < 10)
                    lblForgotTime.Text = (minute + ":0" + second).ToString();
                else
                    lblForgotTime.Text = (minute + ":" + second).ToString();
            }
        }
        private void rjtxtBoxesSpaceForgotControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
                e.Handled = true;
        }
    }
}
