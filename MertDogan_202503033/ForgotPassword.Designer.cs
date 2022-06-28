
namespace MertDogan_202503033
{
    partial class ForgotPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePasswordCancel = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.timerForgot = new System.Windows.Forms.Timer(this.components);
            this.lblForgotTime = new System.Windows.Forms.Label();
            this.toolTipReturnLogin = new System.Windows.Forms.ToolTip(this.components);
            this.rjtxtBoxForgotMail = new RJconpanents.RJtextBox();
            this.rjtxtBoxForgotCode = new RJconpanents.RJtextBox();
            this.rjbtnForgotSendCode = new RJControls.RJConpanents.RJButton();
            this.rjbtnForgotNext = new RJControls.RJConpanents.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(252, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen şifre sıfırlama kodunun gönderileceği E-posta adresini giriniz.";
            // 
            // btnChangePasswordCancel
            // 
            this.btnChangePasswordCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePasswordCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePasswordCancel.BackgroundImage")));
            this.btnChangePasswordCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangePasswordCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChangePasswordCancel.FlatAppearance.BorderSize = 0;
            this.btnChangePasswordCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnChangePasswordCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePasswordCancel.Location = new System.Drawing.Point(544, 0);
            this.btnChangePasswordCancel.Name = "btnChangePasswordCancel";
            this.btnChangePasswordCancel.Size = new System.Drawing.Size(41, 23);
            this.btnChangePasswordCancel.TabIndex = 15;
            this.btnChangePasswordCancel.UseVisualStyleBackColor = false;
            this.btnChangePasswordCancel.Click += new System.EventHandler(this.btnChangePasswordCancel_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(257, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 24);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-Posta:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCode.Location = new System.Drawing.Point(288, 161);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 24);
            this.lblCode.TabIndex = 17;
            this.lblCode.Text = "Kod:";
            // 
            // timerForgot
            // 
            this.timerForgot.Tick += new System.EventHandler(this.timerForgot_Tick);
            // 
            // lblForgotTime
            // 
            this.lblForgotTime.AutoSize = true;
            this.lblForgotTime.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotTime.Location = new System.Drawing.Point(442, 118);
            this.lblForgotTime.Name = "lblForgotTime";
            this.lblForgotTime.Size = new System.Drawing.Size(0, 18);
            this.lblForgotTime.TabIndex = 19;
            // 
            // rjtxtBoxForgotMail
            // 
            this.rjtxtBoxForgotMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxForgotMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxForgotMail.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxForgotMail.BorderSize = 2;
            this.rjtxtBoxForgotMail.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxForgotMail.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxForgotMail.Location = new System.Drawing.Point(341, 77);
            this.rjtxtBoxForgotMail.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxForgotMail.MaxLength = 32767;
            this.rjtxtBoxForgotMail.Multiline = false;
            this.rjtxtBoxForgotMail.Name = "rjtxtBoxForgotMail";
            this.rjtxtBoxForgotMail.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxForgotMail.PasswordChar = false;
            this.rjtxtBoxForgotMail.Size = new System.Drawing.Size(211, 37);
            this.rjtxtBoxForgotMail.TabIndex = 0;
            this.rjtxtBoxForgotMail.Texts = "";
            this.rjtxtBoxForgotMail.UnderlinedStyle = true;
            this.rjtxtBoxForgotMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtxtBoxesSpaceForgotControl_KeyPress);
            // 
            // rjtxtBoxForgotCode
            // 
            this.rjtxtBoxForgotCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxForgotCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxForgotCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtxtBoxForgotCode.BorderSize = 2;
            this.rjtxtBoxForgotCode.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxForgotCode.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxForgotCode.Location = new System.Drawing.Point(341, 154);
            this.rjtxtBoxForgotCode.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxForgotCode.MaxLength = 32767;
            this.rjtxtBoxForgotCode.Multiline = false;
            this.rjtxtBoxForgotCode.Name = "rjtxtBoxForgotCode";
            this.rjtxtBoxForgotCode.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxForgotCode.PasswordChar = false;
            this.rjtxtBoxForgotCode.Size = new System.Drawing.Size(80, 37);
            this.rjtxtBoxForgotCode.TabIndex = 2;
            this.rjtxtBoxForgotCode.Texts = "";
            this.rjtxtBoxForgotCode.UnderlinedStyle = true;
            this.rjtxtBoxForgotCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtxtBoxesSpaceForgotControl_KeyPress);
            // 
            // rjbtnForgotSendCode
            // 
            this.rjbtnForgotSendCode.BackColor = System.Drawing.Color.Orange;
            this.rjbtnForgotSendCode.BackGroundColor = System.Drawing.Color.Orange;
            this.rjbtnForgotSendCode.BorderColor = System.Drawing.Color.Orange;
            this.rjbtnForgotSendCode.BorderRadius = 2;
            this.rjbtnForgotSendCode.BorderSize = 1;
            this.rjbtnForgotSendCode.FlatAppearance.BorderSize = 0;
            this.rjbtnForgotSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnForgotSendCode.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjbtnForgotSendCode.ForeColor = System.Drawing.Color.Black;
            this.rjbtnForgotSendCode.Location = new System.Drawing.Point(341, 118);
            this.rjbtnForgotSendCode.Name = "rjbtnForgotSendCode";
            this.rjbtnForgotSendCode.Size = new System.Drawing.Size(80, 29);
            this.rjbtnForgotSendCode.TabIndex = 1;
            this.rjbtnForgotSendCode.Text = "Gönder";
            this.rjbtnForgotSendCode.TextColor = System.Drawing.Color.Black;
            this.rjbtnForgotSendCode.UseVisualStyleBackColor = false;
            this.rjbtnForgotSendCode.Click += new System.EventHandler(this.rjbtnForgotSendCode_Click);
            // 
            // rjbtnForgotNext
            // 
            this.rjbtnForgotNext.BackColor = System.Drawing.Color.DarkGreen;
            this.rjbtnForgotNext.BackGroundColor = System.Drawing.Color.DarkGreen;
            this.rjbtnForgotNext.BorderColor = System.Drawing.Color.DarkGreen;
            this.rjbtnForgotNext.BorderRadius = 2;
            this.rjbtnForgotNext.BorderSize = 1;
            this.rjbtnForgotNext.FlatAppearance.BorderSize = 0;
            this.rjbtnForgotNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnForgotNext.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjbtnForgotNext.ForeColor = System.Drawing.Color.Black;
            this.rjbtnForgotNext.Location = new System.Drawing.Point(428, 161);
            this.rjbtnForgotNext.Name = "rjbtnForgotNext";
            this.rjbtnForgotNext.Size = new System.Drawing.Size(80, 29);
            this.rjbtnForgotNext.TabIndex = 3;
            this.rjbtnForgotNext.Text = "İlerle";
            this.rjbtnForgotNext.TextColor = System.Drawing.Color.Black;
            this.rjbtnForgotNext.UseVisualStyleBackColor = false;
            this.rjbtnForgotNext.Click += new System.EventHandler(this.rjbtnForgotNext_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 220);
            this.Controls.Add(this.rjbtnForgotNext);
            this.Controls.Add(this.rjbtnForgotSendCode);
            this.Controls.Add(this.rjtxtBoxForgotCode);
            this.Controls.Add(this.rjtxtBoxForgotMail);
            this.Controls.Add(this.lblForgotTime);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnChangePasswordCancel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgotPassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForgotPassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ForgotPassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePasswordCancel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Timer timerForgot;
        private System.Windows.Forms.Label lblForgotTime;
        public System.Windows.Forms.ToolTip toolTipReturnLogin;
        private RJconpanents.RJtextBox rjtxtBoxForgotMail;
        private RJconpanents.RJtextBox rjtxtBoxForgotCode;
        private RJControls.RJConpanents.RJButton rjbtnForgotSendCode;
        private RJControls.RJConpanents.RJButton rjbtnForgotNext;
    }
}