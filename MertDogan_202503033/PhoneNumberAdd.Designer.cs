
namespace MertDogan_202503033
{
    partial class PhoneNumberAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneNumberAdd));
            this.lblRegID = new System.Windows.Forms.Label();
            this.lblRegPhoneNumber = new System.Windows.Forms.Label();
            this.lblRegName = new System.Windows.Forms.Label();
            this.lblRegSurname = new System.Windows.Forms.Label();
            this.lblRegType = new System.Windows.Forms.Label();
            this.pnlRegType = new System.Windows.Forms.Panel();
            this.rjrbtnRegCompany = new RJControls.RJConpanents.RJRadioButton();
            this.rjrbtnRegMale = new RJControls.RJConpanents.RJRadioButton();
            this.rjrbtnRegFemale = new RJControls.RJConpanents.RJRadioButton();
            this.grpBoxpcBoxRegImage = new System.Windows.Forms.GroupBox();
            this.pcBoxRegImage = new System.Windows.Forms.PictureBox();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rjtxtBoxRegID = new RJconpanents.RJtextBox();
            this.rjtxtBoxRegPhoneNumber = new RJconpanents.RJtextBox();
            this.rjtxtBoxRegName = new RJconpanents.RJtextBox();
            this.rjtxtBoxRegSurname = new RJconpanents.RJtextBox();
            this.rjtxtBoxRegEmail = new RJconpanents.RJtextBox();
            this.rjcmBoxRegCountry = new RJControls.RJConpanents.RJComboBox();
            this.rjbtnRegAdd = new RJControls.RJConpanents.RJButton();
            this.rjbtnRegUpdate = new RJControls.RJConpanents.RJButton();
            this.rjbtnRegImage = new RJControls.RJConpanents.RJButton();
            this.pnlRegAddTop = new System.Windows.Forms.Panel();
            this.pnlRegType.SuspendLayout();
            this.grpBoxpcBoxRegImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxRegImage)).BeginInit();
            this.pnlRegAddTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegID
            // 
            this.lblRegID.AutoSize = true;
            this.lblRegID.Location = new System.Drawing.Point(122, 71);
            this.lblRegID.Name = "lblRegID";
            this.lblRegID.Size = new System.Drawing.Size(26, 18);
            this.lblRegID.TabIndex = 0;
            this.lblRegID.Text = "ID:";
            // 
            // lblRegPhoneNumber
            // 
            this.lblRegPhoneNumber.AutoSize = true;
            this.lblRegPhoneNumber.Location = new System.Drawing.Point(21, 111);
            this.lblRegPhoneNumber.Name = "lblRegPhoneNumber";
            this.lblRegPhoneNumber.Size = new System.Drawing.Size(127, 18);
            this.lblRegPhoneNumber.TabIndex = 0;
            this.lblRegPhoneNumber.Text = "Telefon Numarası:";
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(118, 146);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(30, 18);
            this.lblRegName.TabIndex = 0;
            this.lblRegName.Text = "Ad:";
            // 
            // lblRegSurname
            // 
            this.lblRegSurname.AutoSize = true;
            this.lblRegSurname.Location = new System.Drawing.Point(95, 189);
            this.lblRegSurname.Name = "lblRegSurname";
            this.lblRegSurname.Size = new System.Drawing.Size(53, 18);
            this.lblRegSurname.TabIndex = 0;
            this.lblRegSurname.Text = "Soyad:";
            // 
            // lblRegType
            // 
            this.lblRegType.AutoSize = true;
            this.lblRegType.Location = new System.Drawing.Point(70, 278);
            this.lblRegType.Name = "lblRegType";
            this.lblRegType.Size = new System.Drawing.Size(78, 18);
            this.lblRegType.TabIndex = 0;
            this.lblRegType.Text = "Kayıt Türü:";
            // 
            // pnlRegType
            // 
            this.pnlRegType.Controls.Add(this.rjrbtnRegCompany);
            this.pnlRegType.Controls.Add(this.rjrbtnRegMale);
            this.pnlRegType.Controls.Add(this.rjrbtnRegFemale);
            this.pnlRegType.Location = new System.Drawing.Point(155, 269);
            this.pnlRegType.Name = "pnlRegType";
            this.pnlRegType.Size = new System.Drawing.Size(228, 37);
            this.pnlRegType.TabIndex = 5;
            // 
            // rjrbtnRegCompany
            // 
            this.rjrbtnRegCompany.AutoSize = true;
            this.rjrbtnRegCompany.CheckedColor = System.Drawing.Color.DarkOrange;
            this.rjrbtnRegCompany.Location = new System.Drawing.Point(154, 7);
            this.rjrbtnRegCompany.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjrbtnRegCompany.Name = "rjrbtnRegCompany";
            this.rjrbtnRegCompany.Size = new System.Drawing.Size(73, 22);
            this.rjrbtnRegCompany.TabIndex = 9;
            this.rjrbtnRegCompany.TabStop = true;
            this.rjrbtnRegCompany.Text = "Sabit";
            this.rjrbtnRegCompany.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjrbtnRegCompany.UseVisualStyleBackColor = true;
            this.rjrbtnRegCompany.CheckedChanged += new System.EventHandler(this.Type_CheckedChanged);
            // 
            // rjrbtnRegMale
            // 
            this.rjrbtnRegMale.AutoSize = true;
            this.rjrbtnRegMale.CheckedColor = System.Drawing.Color.DarkSlateGray;
            this.rjrbtnRegMale.Location = new System.Drawing.Point(78, 7);
            this.rjrbtnRegMale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjrbtnRegMale.Name = "rjrbtnRegMale";
            this.rjrbtnRegMale.Size = new System.Drawing.Size(76, 22);
            this.rjrbtnRegMale.TabIndex = 9;
            this.rjrbtnRegMale.TabStop = true;
            this.rjrbtnRegMale.Text = "Erkek";
            this.rjrbtnRegMale.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjrbtnRegMale.UseVisualStyleBackColor = true;
            this.rjrbtnRegMale.CheckedChanged += new System.EventHandler(this.Type_CheckedChanged);
            // 
            // rjrbtnRegFemale
            // 
            this.rjrbtnRegFemale.AutoSize = true;
            this.rjrbtnRegFemale.CheckedColor = System.Drawing.Color.DarkViolet;
            this.rjrbtnRegFemale.Location = new System.Drawing.Point(3, 7);
            this.rjrbtnRegFemale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjrbtnRegFemale.Name = "rjrbtnRegFemale";
            this.rjrbtnRegFemale.Size = new System.Drawing.Size(75, 22);
            this.rjrbtnRegFemale.TabIndex = 9;
            this.rjrbtnRegFemale.TabStop = true;
            this.rjrbtnRegFemale.Text = "Kadın";
            this.rjrbtnRegFemale.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjrbtnRegFemale.UseVisualStyleBackColor = true;
            this.rjrbtnRegFemale.CheckedChanged += new System.EventHandler(this.Type_CheckedChanged);
            // 
            // grpBoxpcBoxRegImage
            // 
            this.grpBoxpcBoxRegImage.Controls.Add(this.pcBoxRegImage);
            this.grpBoxpcBoxRegImage.Location = new System.Drawing.Point(400, 56);
            this.grpBoxpcBoxRegImage.Name = "grpBoxpcBoxRegImage";
            this.grpBoxpcBoxRegImage.Size = new System.Drawing.Size(101, 128);
            this.grpBoxpcBoxRegImage.TabIndex = 9;
            this.grpBoxpcBoxRegImage.TabStop = false;
            this.grpBoxpcBoxRegImage.Text = "Resim";
            // 
            // pcBoxRegImage
            // 
            this.pcBoxRegImage.Location = new System.Drawing.Point(32, 24);
            this.pcBoxRegImage.Name = "pcBoxRegImage";
            this.pcBoxRegImage.Size = new System.Drawing.Size(51, 88);
            this.pcBoxRegImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxRegImage.TabIndex = 4;
            this.pcBoxRegImage.TabStop = false;
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Location = new System.Drawing.Point(94, 230);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(54, 18);
            this.lblRegEmail.TabIndex = 0;
            this.lblRegEmail.Text = "E-Mail:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(501, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(41, 25);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rjtxtBoxRegID
            // 
            this.rjtxtBoxRegID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxRegID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxRegID.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxRegID.BorderSize = 2;
            this.rjtxtBoxRegID.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxRegID.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxRegID.Location = new System.Drawing.Point(154, 52);
            this.rjtxtBoxRegID.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxRegID.MaxLength = 32767;
            this.rjtxtBoxRegID.Multiline = false;
            this.rjtxtBoxRegID.Name = "rjtxtBoxRegID";
            this.rjtxtBoxRegID.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxRegID.PasswordChar = false;
            this.rjtxtBoxRegID.Size = new System.Drawing.Size(228, 37);
            this.rjtxtBoxRegID.TabIndex = 22;
            this.rjtxtBoxRegID.Texts = "";
            this.rjtxtBoxRegID.UnderlinedStyle = true;
            // 
            // rjtxtBoxRegPhoneNumber
            // 
            this.rjtxtBoxRegPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxRegPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxRegPhoneNumber.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxRegPhoneNumber.BorderSize = 2;
            this.rjtxtBoxRegPhoneNumber.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxRegPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxRegPhoneNumber.Location = new System.Drawing.Point(270, 92);
            this.rjtxtBoxRegPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxRegPhoneNumber.MaxLength = 32767;
            this.rjtxtBoxRegPhoneNumber.Multiline = false;
            this.rjtxtBoxRegPhoneNumber.Name = "rjtxtBoxRegPhoneNumber";
            this.rjtxtBoxRegPhoneNumber.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxRegPhoneNumber.PasswordChar = false;
            this.rjtxtBoxRegPhoneNumber.Size = new System.Drawing.Size(112, 37);
            this.rjtxtBoxRegPhoneNumber.TabIndex = 1;
            this.rjtxtBoxRegPhoneNumber.Texts = "";
            this.rjtxtBoxRegPhoneNumber.UnderlinedStyle = true;
            this.rjtxtBoxRegPhoneNumber._TextChanged += new System.EventHandler(this.rjtxtBoxRegNamePhone__TextChanged);
            this.rjtxtBoxRegPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtxtBoxRegPhoneNumber_KeyPress);
            // 
            // rjtxtBoxRegName
            // 
            this.rjtxtBoxRegName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxRegName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxRegName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxRegName.BorderSize = 2;
            this.rjtxtBoxRegName.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxRegName.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxRegName.Location = new System.Drawing.Point(155, 136);
            this.rjtxtBoxRegName.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxRegName.MaxLength = 32767;
            this.rjtxtBoxRegName.Multiline = false;
            this.rjtxtBoxRegName.Name = "rjtxtBoxRegName";
            this.rjtxtBoxRegName.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxRegName.PasswordChar = false;
            this.rjtxtBoxRegName.Size = new System.Drawing.Size(228, 37);
            this.rjtxtBoxRegName.TabIndex = 2;
            this.rjtxtBoxRegName.Texts = "";
            this.rjtxtBoxRegName.UnderlinedStyle = true;
            this.rjtxtBoxRegName._TextChanged += new System.EventHandler(this.rjtxtBoxRegNamePhone__TextChanged);
            // 
            // rjtxtBoxRegSurname
            // 
            this.rjtxtBoxRegSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxRegSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxRegSurname.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxRegSurname.BorderSize = 2;
            this.rjtxtBoxRegSurname.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxRegSurname.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxRegSurname.Location = new System.Drawing.Point(155, 176);
            this.rjtxtBoxRegSurname.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxRegSurname.MaxLength = 32767;
            this.rjtxtBoxRegSurname.Multiline = false;
            this.rjtxtBoxRegSurname.Name = "rjtxtBoxRegSurname";
            this.rjtxtBoxRegSurname.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxRegSurname.PasswordChar = false;
            this.rjtxtBoxRegSurname.Size = new System.Drawing.Size(228, 37);
            this.rjtxtBoxRegSurname.TabIndex = 3;
            this.rjtxtBoxRegSurname.Texts = "";
            this.rjtxtBoxRegSurname.UnderlinedStyle = true;
            // 
            // rjtxtBoxRegEmail
            // 
            this.rjtxtBoxRegEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjtxtBoxRegEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjtxtBoxRegEmail.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.rjtxtBoxRegEmail.BorderSize = 2;
            this.rjtxtBoxRegEmail.Font = new System.Drawing.Font("Alata", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjtxtBoxRegEmail.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxtBoxRegEmail.Location = new System.Drawing.Point(155, 216);
            this.rjtxtBoxRegEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtBoxRegEmail.MaxLength = 32767;
            this.rjtxtBoxRegEmail.Multiline = false;
            this.rjtxtBoxRegEmail.Name = "rjtxtBoxRegEmail";
            this.rjtxtBoxRegEmail.Padding = new System.Windows.Forms.Padding(7);
            this.rjtxtBoxRegEmail.PasswordChar = false;
            this.rjtxtBoxRegEmail.Size = new System.Drawing.Size(228, 37);
            this.rjtxtBoxRegEmail.TabIndex = 4;
            this.rjtxtBoxRegEmail.Texts = "";
            this.rjtxtBoxRegEmail.UnderlinedStyle = true;
            // 
            // rjcmBoxRegCountry
            // 
            this.rjcmBoxRegCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjcmBoxRegCountry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjcmBoxRegCountry.BorderSize = 2;
            this.rjcmBoxRegCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcmBoxRegCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rjcmBoxRegCountry.ForeColor = System.Drawing.Color.DimGray;
            this.rjcmBoxRegCountry.IconColor = System.Drawing.Color.Red;
            this.rjcmBoxRegCountry.Items.AddRange(new object[] {
            "+1",
            "+93",
            "+49",
            "+376",
            "+244",
            "+672",
            "+54",
            "+355",
            "+297",
            "+247",
            "+61",
            "+43",
            "+994",
            "+973",
            "+880",
            "+375",
            "+32",
            "+501",
            "+229",
            "+971",
            "+44\t",
            "+591",
            "+387",
            "+267",
            "+55\t",
            "+246",
            "+673",
            "+359",
            "+226",
            "+257",
            "+975",
            "+238",
            "+350",
            "+213",
            "+253",
            "+682",
            "+599",
            "+235",
            "+420",
            "+86\t",
            "+45\t",
            "+670",
            "+593",
            "+240",
            "+503",
            "+62\t",
            "+291",
            "+374",
            "+372",
            "+268",
            "+251",
            "+500",
            "+298",
            "+212",
            "+679",
            "+225",
            "+63\t",
            "+970",
            "+358",
            "+33\t",
            "+594",
            "+689",
            "+241",
            "+220",
            "+233",
            "+224",
            "+245",
            "+299",
            "+502",
            "+592",
            "+27\t",
            "+357",
            "+82\t",
            "+211",
            "+995",
            "+509",
            "+385",
            "+91\t",
            "+31\t",
            "+504",
            "+852",
            "+964",
            "+98\t",
            "+353",
            "+34\t",
            "+972",
            "+46\t",
            "+41\t",
            "+39\t",
            "+354",
            "+81\t",
            "+855",
            "+237",
            "+382",
            "+974",
            "+254",
            "+996",
            "+686",
            "+57\t",
            "+269",
            "+242",
            "+243",
            "+383",
            "+506",
            "+965",
            "+850",
            "+53\t",
            "+870",
            "+881",
            "+882",
            "+883",
            "+856",
            "+266",
            "+371",
            "+231",
            "+218",
            "+423",
            "+370",
            "+961",
            "+352",
            "+36\t",
            "+261",
            "+853",
            "+389",
            "+265",
            "+960",
            "+60\t",
            "+223",
            "+356",
            "+692",
            "+230",
            "+262",
            "+52\t",
            "+20\t",
            "+691",
            "+976",
            "+373",
            "+377",
            "+222",
            "+258",
            "+95\t",
            "+264",
            "+674",
            "+977",
            "+227",
            "+234",
            "+505",
            "+683",
            "+47\t",
            "+236",
            "+998",
            "+92\t",
            "+680",
            "+507",
            "+675",
            "+595",
            "+51\t",
            "+48\t",
            "+351",
            "+40\t",
            "+250",
            "+7\t",
            "+290",
            "+590",
            "+508",
            "+685",
            "+378",
            "+239",
            "+221",
            "+248",
            "+381",
            "+232",
            "+65\t",
            "+421",
            "+386",
            "+677",
            "+252",
            "+94\t",
            "+249",
            "+597",
            "+963",
            "+966",
            "+56\t",
            "+992",
            "+255",
            "+66\t",
            "+886",
            "+228",
            "+690",
            "+676",
            "+216",
            "+688",
            "+90\t",
            "+993",
            "+256",
            "+380",
            "+968",
            "+598",
            "+962",
            "+678",
            "+379",
            "+58\t",
            "+84\t",
            "+681",
            "+967",
            "+687",
            "+64\t",
            "+30\t",
            "+260",
            "+263"});
            this.rjcmBoxRegCountry.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjcmBoxRegCountry.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjcmBoxRegCountry.Location = new System.Drawing.Point(153, 99);
            this.rjcmBoxRegCountry.MinimumSize = new System.Drawing.Size(50, 25);
            this.rjcmBoxRegCountry.Name = "rjcmBoxRegCountry";
            this.rjcmBoxRegCountry.Padding = new System.Windows.Forms.Padding(2);
            this.rjcmBoxRegCountry.Size = new System.Drawing.Size(109, 30);
            this.rjcmBoxRegCountry.Sorted = false;
            this.rjcmBoxRegCountry.TabIndex = 0;
            this.rjcmBoxRegCountry.Texts = "";
            this.rjcmBoxRegCountry.OnSelectedValueChanged += new System.EventHandler(this.rjcmBoxRegCountry_OnSelectedValueChanged);
            // 
            // rjbtnRegAdd
            // 
            this.rjbtnRegAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjbtnRegAdd.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.rjbtnRegAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnRegAdd.BorderRadius = 10;
            this.rjbtnRegAdd.BorderSize = 0;
            this.rjbtnRegAdd.FlatAppearance.BorderSize = 0;
            this.rjbtnRegAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnRegAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjbtnRegAdd.Location = new System.Drawing.Point(155, 327);
            this.rjbtnRegAdd.Name = "rjbtnRegAdd";
            this.rjbtnRegAdd.Size = new System.Drawing.Size(110, 35);
            this.rjbtnRegAdd.TabIndex = 23;
            this.rjbtnRegAdd.Text = "Ekle";
            this.rjbtnRegAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rjbtnRegAdd.UseVisualStyleBackColor = false;
            this.rjbtnRegAdd.Click += new System.EventHandler(this.rjbtnRegAdd_Click);
            // 
            // rjbtnRegUpdate
            // 
            this.rjbtnRegUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.rjbtnRegUpdate.BackGroundColor = System.Drawing.Color.DarkOrange;
            this.rjbtnRegUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnRegUpdate.BorderRadius = 10;
            this.rjbtnRegUpdate.BorderSize = 0;
            this.rjbtnRegUpdate.FlatAppearance.BorderSize = 0;
            this.rjbtnRegUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnRegUpdate.ForeColor = System.Drawing.Color.Black;
            this.rjbtnRegUpdate.Location = new System.Drawing.Point(273, 327);
            this.rjbtnRegUpdate.Name = "rjbtnRegUpdate";
            this.rjbtnRegUpdate.Size = new System.Drawing.Size(110, 35);
            this.rjbtnRegUpdate.TabIndex = 23;
            this.rjbtnRegUpdate.Text = "Güncelle";
            this.rjbtnRegUpdate.TextColor = System.Drawing.Color.Black;
            this.rjbtnRegUpdate.UseVisualStyleBackColor = false;
            this.rjbtnRegUpdate.Click += new System.EventHandler(this.rjbtnRegUpdate_Click);
            // 
            // rjbtnRegImage
            // 
            this.rjbtnRegImage.BackColor = System.Drawing.Color.Red;
            this.rjbtnRegImage.BackGroundColor = System.Drawing.Color.Red;
            this.rjbtnRegImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnRegImage.BorderRadius = 10;
            this.rjbtnRegImage.BorderSize = 0;
            this.rjbtnRegImage.FlatAppearance.BorderSize = 0;
            this.rjbtnRegImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnRegImage.ForeColor = System.Drawing.Color.Black;
            this.rjbtnRegImage.Location = new System.Drawing.Point(454, 190);
            this.rjbtnRegImage.Name = "rjbtnRegImage";
            this.rjbtnRegImage.Size = new System.Drawing.Size(47, 31);
            this.rjbtnRegImage.TabIndex = 24;
            this.rjbtnRegImage.Text = "...";
            this.rjbtnRegImage.TextColor = System.Drawing.Color.Black;
            this.rjbtnRegImage.UseVisualStyleBackColor = false;
            this.rjbtnRegImage.Click += new System.EventHandler(this.rjbtnRegImage_Click);
            // 
            // pnlRegAddTop
            // 
            this.pnlRegAddTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.pnlRegAddTop.Controls.Add(this.btnCancel);
            this.pnlRegAddTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegAddTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRegAddTop.Name = "pnlRegAddTop";
            this.pnlRegAddTop.Size = new System.Drawing.Size(542, 25);
            this.pnlRegAddTop.TabIndex = 25;
            this.pnlRegAddTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRegAddTop_MouseDown);
            this.pnlRegAddTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRegAddTop_MouseMove);
            this.pnlRegAddTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlRegAddTop_MouseUp);
            // 
            // PhoneNumberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(542, 397);
            this.Controls.Add(this.pnlRegAddTop);
            this.Controls.Add(this.rjbtnRegImage);
            this.Controls.Add(this.rjbtnRegUpdate);
            this.Controls.Add(this.rjbtnRegAdd);
            this.Controls.Add(this.rjcmBoxRegCountry);
            this.Controls.Add(this.rjtxtBoxRegPhoneNumber);
            this.Controls.Add(this.rjtxtBoxRegEmail);
            this.Controls.Add(this.rjtxtBoxRegSurname);
            this.Controls.Add(this.rjtxtBoxRegName);
            this.Controls.Add(this.rjtxtBoxRegID);
            this.Controls.Add(this.grpBoxpcBoxRegImage);
            this.Controls.Add(this.pnlRegType);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.lblRegType);
            this.Controls.Add(this.lblRegSurname);
            this.Controls.Add(this.lblRegName);
            this.Controls.Add(this.lblRegPhoneNumber);
            this.Controls.Add(this.lblRegID);
            this.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhoneNumberAdd";
            this.Text = "PhoneNumberAdd";
            this.Load += new System.EventHandler(this.PhoneNumberAdd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PhoneNumberAdd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PhoneNumberAdd_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PhoneNumberAdd_MouseUp);
            this.pnlRegType.ResumeLayout(false);
            this.pnlRegType.PerformLayout();
            this.grpBoxpcBoxRegImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxRegImage)).EndInit();
            this.pnlRegAddTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegID;
        private System.Windows.Forms.Label lblRegPhoneNumber;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.Label lblRegSurname;
        private System.Windows.Forms.Label lblRegType;
        private System.Windows.Forms.GroupBox grpBoxpcBoxRegImage;
        public System.Windows.Forms.Panel pnlRegType;
        public System.Windows.Forms.PictureBox pcBoxRegImage;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.Button btnCancel;
        public RJconpanents.RJtextBox rjtxtBoxRegID;
        public RJconpanents.RJtextBox rjtxtBoxRegPhoneNumber;
        public RJconpanents.RJtextBox rjtxtBoxRegName;
        public RJconpanents.RJtextBox rjtxtBoxRegSurname;
        public RJconpanents.RJtextBox rjtxtBoxRegEmail;
        public RJControls.RJConpanents.RJComboBox rjcmBoxRegCountry;
        private RJControls.RJConpanents.RJRadioButton rjrbtnRegCompany;
        private RJControls.RJConpanents.RJRadioButton rjrbtnRegMale;
        private RJControls.RJConpanents.RJRadioButton rjrbtnRegFemale;
        public RJControls.RJConpanents.RJButton rjbtnRegAdd;
        public RJControls.RJConpanents.RJButton rjbtnRegUpdate;
        public RJControls.RJConpanents.RJButton rjbtnRegImage;
        private System.Windows.Forms.Panel pnlRegAddTop;
    }
}