
namespace MertDogan_202503033
{
    partial class PasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReset));
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblReNewPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rjtxtBoxNewPassword = new RJconpanents.RJtextBox();
            this.rjtxtBoxReNewPassword = new RJconpanents.RJtextBox();
            this.rjbtnChangePassword = new RJControls.RJConpanents.RJButton();
            this.SuspendLayout();
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.Location = new System.Drawing.Point(311, 78);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(77, 24);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Yeni Şifre:";
            // 
            // lblReNewPassword
            // 
            this.lblReNewPassword.AutoSize = true;
            this.lblReNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblReNewPassword.Font = new System.Drawing.Font("Alata", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReNewPassword.Location = new System.Drawing.Point(255, 118);
            this.lblReNewPassword.Name = "lblReNewPassword";
            this.lblReNewPassword.Size = new System.Drawing.Size(133, 24);
            this.lblReNewPassword.TabIndex = 0;
            this.lblReNewPassword.Text = "Yeni Şifre(Tekrar):";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(544, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(41, 25);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            this.btnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseMove);
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseUp);
            // 
            // rjtxtBoxNewPassword
            // 
            this.rjtxtBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxNewPassword.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxNewPassword.BorderSize = 2;
            this.rjtxtBoxNewPassword.Font = new System.Drawing.Font("Alata", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxNewPassword.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxNewPassword.Location = new System.Drawing.Point(400, 69);
            this.rjtxtBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxNewPassword.MaxLength = 32767;
            this.rjtxtBoxNewPassword.Multiline = false;
            this.rjtxtBoxNewPassword.Name = "rjtxtBoxNewPassword";
            this.rjtxtBoxNewPassword.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxNewPassword.PasswordChar = true;
            this.rjtxtBoxNewPassword.Size = new System.Drawing.Size(121, 28);
            this.rjtxtBoxNewPassword.TabIndex = 0;
            this.rjtxtBoxNewPassword.Texts = "";
            this.rjtxtBoxNewPassword.UnderlinedStyle = true;
            this.rjtxtBoxNewPassword._TextChanged += new System.EventHandler(this.rjtxtBoxNewPassword__TextChanged);
            this.rjtxtBoxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtxtBoxesSpaceResetControl_KeyPress);
            // 
            // rjtxtBoxReNewPassword
            // 
            this.rjtxtBoxReNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxReNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxReNewPassword.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxReNewPassword.BorderSize = 2;
            this.rjtxtBoxReNewPassword.Font = new System.Drawing.Font("Alata", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxReNewPassword.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxReNewPassword.Location = new System.Drawing.Point(400, 110);
            this.rjtxtBoxReNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxReNewPassword.MaxLength = 32767;
            this.rjtxtBoxReNewPassword.Multiline = false;
            this.rjtxtBoxReNewPassword.Name = "rjtxtBoxReNewPassword";
            this.rjtxtBoxReNewPassword.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxReNewPassword.PasswordChar = true;
            this.rjtxtBoxReNewPassword.Size = new System.Drawing.Size(121, 28);
            this.rjtxtBoxReNewPassword.TabIndex = 1;
            this.rjtxtBoxReNewPassword.Texts = "";
            this.rjtxtBoxReNewPassword.UnderlinedStyle = true;
            this.rjtxtBoxReNewPassword._TextChanged += new System.EventHandler(this.rjtxtBoxReNewPassword__TextChanged);
            this.rjtxtBoxReNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtxtBoxesSpaceResetControl_KeyPress);
            // 
            // rjbtnChangePassword
            // 
            this.rjbtnChangePassword.BackColor = System.Drawing.Color.Orange;
            this.rjbtnChangePassword.BackGroundColor = System.Drawing.Color.Orange;
            this.rjbtnChangePassword.BorderColor = System.Drawing.Color.Orange;
            this.rjbtnChangePassword.BorderRadius = 2;
            this.rjbtnChangePassword.BorderSize = 1;
            this.rjbtnChangePassword.FlatAppearance.BorderSize = 0;
            this.rjbtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnChangePassword.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjbtnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.rjbtnChangePassword.Location = new System.Drawing.Point(441, 149);
            this.rjbtnChangePassword.Name = "rjbtnChangePassword";
            this.rjbtnChangePassword.Size = new System.Drawing.Size(80, 29);
            this.rjbtnChangePassword.TabIndex = 2;
            this.rjbtnChangePassword.Text = "Değiştir";
            this.rjbtnChangePassword.TextColor = System.Drawing.Color.Black;
            this.rjbtnChangePassword.UseVisualStyleBackColor = false;
            this.rjbtnChangePassword.Click += new System.EventHandler(this.rjbtnChangePassword_Click);
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 220);
            this.Controls.Add(this.rjbtnChangePassword);
            this.Controls.Add(this.rjtxtBoxReNewPassword);
            this.Controls.Add(this.rjtxtBoxNewPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblReNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordReset";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblReNewPassword;
        private System.Windows.Forms.Button btnCancel;
        private RJconpanents.RJtextBox rjtxtBoxNewPassword;
        private RJconpanents.RJtextBox rjtxtBoxReNewPassword;
        private RJControls.RJConpanents.RJButton rjbtnChangePassword;
    }
}