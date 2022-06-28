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
using RJconpanents;
using System.Threading;

namespace MertDogan_202503033
{
    /// <summary>
    /// HomePage Panel
    /// </summary>

    public partial class HomePage : Form
    {
        //Variables and objects
        public static int userID = 0;
        public static bool admin;
        static string UserName;
        int rowIndex = 0;
        bool formMoving = false;
        Point startPoint = new Point(0, 0);
        Login login = new Login();

        //Constructor
        public HomePage(int _UserID) //+
        {
            userID = _UserID;
            InitializeComponent();
            menuStripHomePage.Renderer = new MyRenderer();
            RegProcessClass.ConnectionCase(); //Baglantı kontrolu yapılacak
        }
        public HomePage(bool _admin, string _UserName) //+
        {
            admin = _admin;
            UserName = _UserName;
            InitializeComponent();
            menuStripHomePage.Renderer = new MyRenderer();
            RegProcessClass.ConnectionCase(); //Baglantı kontrolu yapılacak
        }

        //Non-Event Methods
        void ButtonFlatStyle()
        {
            foreach (Button item in grpBoxProcess.Controls)
            {
                item.FlatStyle = FlatStyle.Flat;
                item.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E488F");
                item.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E1E1E1");
            }
        }
        public static void DataGridUpdateList(DataGridView dgv) //+
        {
            dgv.Columns.Clear();

            if (!admin)
            {
                var sql = string.Format("SELECT * FROM Tbl_Registry WHERE UserID = {0} ORDER BY RegName ASC", userID);
                RegProcessClass.GridFill(dgv, sql);
            }
            else
            {
                var sql = string.Format("SELECT * FROM Tbl_LoginUser WHERE UserName <> '{0}' AND IsAdmin <> 1  ORDER BY UserName ASC", UserName);
                RegProcessClass.GridFill(dgv, sql);
            }

            DatagridStyle(dgv);
        }
        static void DatagridStyle(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            if (!admin)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[5].Visible = false;
                dgv.Columns[7].Visible = false;
                dgv.Columns[1].HeaderText = "İsim";
                dgv.Columns[1].Width = 150;
                dgv.Columns[2].HeaderText = "Soyisim";
                dgv.Columns[2].Width = 150;
                dgv.Columns[3].HeaderText = "Telefon Numarası";
                dgv.Columns[3].Width = 150;
                dgv.Columns[4].HeaderText = "Kayıt Tipi";
                dgv.Columns[4].Width = 50;
                dgv.Columns[6].HeaderText = "E-Mail";
                dgv.Columns[6].Width = 250; 
            }
            else
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[2].Visible = false;
                dgv.Columns[4].Visible = false;
                dgv.Columns[1].HeaderText = "Kullanıcı Adı";
                dgv.Columns[1].Width = 150;
                dgv.Columns[3].HeaderText = "E-Mail";
                dgv.Columns[3].Width = 300;
                dgv.Columns[5].HeaderText = "İsim";
                dgv.Columns[5].Width = 150;
                dgv.Columns[6].HeaderText = "Soyisim";
                dgv.Columns[6].Width = 150;
            }
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false; // hide last line of datagridview
        }

        //Load
        public void HomePage_Load(object sender, EventArgs e) //+
        {
            //
            //lblHomePageTittle
            //
            lblHomePageTittle.ForeColor = Color.FromArgb(225, 225, 225);
            //
            //menuStripHomePage
            //
            menuStripHomePage.BackColor = Color.FromArgb(24, 58, 114);
            menuStripHomePage.ForeColor = Color.FromArgb(225, 225, 225);

            foreach (ToolStripMenuItem menuItem in menuStripHomePage.Items)
            {
                ((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
                menuItem.DropDown.BackColor = Color.FromArgb(31, 31, 46);
                menuItem.DropDown.ForeColor = Color.FromArgb(225, 225, 225);
            }
            //
            //contextMenuStripHomePage
            //
            contextMenuStripHomePage.ForeColor = Color.White;
            //
            //rjtxtBoxSearching
            //
            rjtxtBoxSearching.ForeColor = Color.Red;
            //
            //rjbtnRegSend & rjbtnStatistics & rjbtnNumberDeleteAll
            //
            if (admin)
            {
                rjbtnRegSend.Visible = false;
                rjcmBoxUsersOther.Visible = false;
                rjbtnNumberDeleteAll.Visible = false;
                rjbtnStatistics.Location = new Point(rjbtnNumberDeleteAll.Location.X, rjbtnNumberDeleteAll.Location.Y);
            }
            //
            //cmBoxUsersOther
            //
            rjcmBoxUsersOther.BackColor = Color.FromArgb(225, 225, 225);
            rjcmBoxUsersOther.BorderColor = Color.FromArgb(24, 58, 114);
            rjcmBoxUsersOther.BorderSize = 2;
            rjcmBoxUsersOther.IconColor = Color.Red;

            var sqlForallUserwithoutlogged = string.Format("SELECT * FROM Tbl_LoginUser where ID <> {0} AND IsAdmin <> {1}", userID, 1); // Default not admin
            RegProcessClass.GridFillAllUser(rjcmBoxUsersOther, sqlForallUserwithoutlogged);
            //
            //GridFill
            //
            DataGridUpdateList(dataGridView1);
            //
            //ButtonFlatStyle
            //
            ButtonFlatStyle();
            //
            //dataGridView1
            //
            DatagridStyle(dataGridView1);
            //
            //rjbtnNumberDelete
            //
            rjbtnNumberDelete.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E1E1E1");
            rjbtnNumberDelete.Enabled = false;
            //
            //this
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1E1E1");
            this.MinimumSize = new Size(989, 514);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.Directsy;
            //
            //btnHomePageClose
            //
            ToolTip toolTipHomePageClose = new ToolTip()
            {
                InitialDelay = 200,
                ReshowDelay = 300,
                AutoPopDelay = 2000
            };
            toolTipHomePageClose.SetToolTip(btnHomePageClose, "Çıkış");

            btnHomePageClose.FlatAppearance.BorderSize = 0;
            btnHomePageClose.FlatAppearance.MouseOverBackColor = Color.Tomato;
            //
            //btnHomePageHide
            //
            ToolTip toolTipHomePageHide = new ToolTip()
            {
                InitialDelay = 200,
                ReshowDelay = 300,
                AutoPopDelay = 2000
            };
            toolTipHomePageHide.SetToolTip(btnHomePageHide, "Küçült");

            btnHomePageHide.FlatAppearance.BorderSize = 0;
            btnHomePageHide.FlatAppearance.MouseOverBackColor = Color.Gray;
            //
            //rjbtnToggleDark
            //
            ToolTip toolTipHomePageBtnToggle = new ToolTip()
            {
                InitialDelay = 200,
                ReshowDelay = 300,
                AutoPopDelay = 2000
            };
            toolTipHomePageClose.SetToolTip(rjbtnToggleDark, "Karanlık Mod");
        }
        //Event Methods
        private void rjbtnList_Click(object sender, EventArgs e)
        {
            DataGridUpdateList(dataGridView1); //RegProcessClass.GridFill(dataGridView1, "select RegID, RegName, RegSurname, RegNumberPhone, RegType, RegImagePath from Tbl_Registry");
        }
        private void rjbtnNumberAdd_Click(object sender, EventArgs e)
        {
            if (!admin)
            {
                PhoneNumberAdd phoneNumberAdd = new PhoneNumberAdd(dataGridView1);
                phoneNumberAdd.Show();
            }
            else
            {
                SignUp signUp = new SignUp(dataGridView1);
                signUp.Show();
            }

        }
        private void rjbtnNumberDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstediğinze Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                RegProcessClass.RegDelete(dataGridView1, admin);
        }
        private void rjbtnNumberDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm Kayıtları Silmek İstediğinze Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                RegProcessClass.RegDeleteAll(dataGridView1, admin);
        }
        private void rjbtnRegSend_Click(object sender, EventArgs e)
        {
            var selectedUser = ((System.Data.DataRowView)rjcmBoxUsersOther.SelectedItem).Row.ItemArray[0];
            DialogResult result = MessageBox.Show("Uygulama içerisindeki rehberiniz seçtiğiniz kullanıcıya aktarılacak. Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                RegProcessClass.RegAddForSendCopy(dataGridView1, (int)selectedUser);
                DataGridUpdateList(dataGridView1);
            }
        }
        private void rjbtnStatistics_Click(object sender, EventArgs e)
        {
            ChartStatistics chartStatistics = new ChartStatistics();
            chartStatistics.Show();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!admin)
            {
                PhoneNumberAdd phoneNumberAdd = new PhoneNumberAdd(dataGridView1);
                phoneNumberAdd.Show();

                int chosen = dataGridView1.SelectedCells[0].RowIndex;
                string[] phoneSplit = dataGridView1.Rows[chosen].Cells[3].Value.ToString().Split('-');

                phoneNumberAdd.rjtxtBoxRegID.Texts = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
                phoneNumberAdd.rjtxtBoxRegName.Texts = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
                phoneNumberAdd.rjtxtBoxRegSurname.Texts = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
                phoneNumberAdd.rjcmBoxRegCountry.Texts = phoneSplit[0];
                phoneNumberAdd.rjcmBoxRegCountry.SelectedItem = phoneSplit[0];
                phoneNumberAdd.rjtxtBoxRegPhoneNumber.Texts = phoneSplit[1];
                foreach (RadioButton item in phoneNumberAdd.pnlRegType.Controls)
                    if (item.Text == dataGridView1.Rows[chosen].Cells[4].Value.ToString())
                        item.Checked = true;
                phoneNumberAdd.pcBoxRegImage.ImageLocation = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
                phoneNumberAdd.rjtxtBoxRegEmail.Texts = dataGridView1.Rows[chosen].Cells[6].Value.ToString();

                // PhoneNumberAdd UpdateButton
                phoneNumberAdd.rjbtnRegUpdate.Enabled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rjbtnNumberDelete.Enabled = true;
        }
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripHomePage.Show(this.dataGridView1, e.Location);
                contextMenuStripHomePage.Show(Cursor.Position);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstediğinze Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                RegProcessClass.RegDelete(dataGridView1, admin);
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneNumberAdd phoneNumberAdd = new PhoneNumberAdd();
            phoneNumberAdd.Show();

            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            string[] phoneSplit = dataGridView1.Rows[chosen].Cells[3].Value.ToString().Split('-');

            phoneNumberAdd.rjtxtBoxRegID.Texts = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            phoneNumberAdd.rjtxtBoxRegName.Texts = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            phoneNumberAdd.rjtxtBoxRegSurname.Texts = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            phoneNumberAdd.rjcmBoxRegCountry.Texts = phoneSplit[0];
            phoneNumberAdd.rjtxtBoxRegPhoneNumber.Texts = phoneSplit[1];
            foreach (RadioButton item in phoneNumberAdd.pnlRegType.Controls)
                if (item.Text == dataGridView1.Rows[chosen].Cells[4].Value.ToString())
                    item.Checked = true;
            phoneNumberAdd.pcBoxRegImage.ImageLocation = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }
        private void rjtxtBoxSearching__TextChanged(object sender, EventArgs e)
        {
            RegProcessClass.RegSearch(dataGridView1, rjtxtBoxSearching);
        }
        private void rjtxtBoxSearching_Click(object sender, EventArgs e)
        {
            try
            {
                RegProcessClass.con.Open();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { RegProcessClass.con.Close(); }
        }
        private void rjtxtBoxSearching_Leave(object sender, EventArgs e)
        {
            try
            {
                RegProcessClass.con.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void HomePage_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void HomePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void pnlHomePage_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void pnlHomePage_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void pnlHomePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void menuStripHomePage_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void menuStripHomePage_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void menuStripHomePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void btnHomePageCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
        private void btnHomePageHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void linklblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumu Kapatmak İstediğinize Emin misiniz ? Giriş Paneline Yönlendiriliceksiniz. ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                admin = false;
                this.Close();
                login.Show();
            }
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.WindowState = FormWindowState.Normal;
        }
        private void rjbtnToggleDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rjbtnToggleDark.Checked)
            {
                this.BackColor = Color.FromArgb(31, 31, 46);
                rjtxtBoxSearching.BackColor = Color.FromArgb(31, 31, 46);
                rjtxtBoxSearching.BorderColor = Color.Red;
                grpBoxProcess.ForeColor = Color.FromArgb(225, 225, 225);
                grpBoxDirectory.ForeColor = Color.FromArgb(225, 225, 225);
                lblHomePageTittle.ForeColor = Color.Black;
                pictureBoxSearch.Image = Properties.Resources.searchwhite;
            }
            else
            {
                this.BackColor = Color.FromArgb(225, 225, 225);
                rjtxtBoxSearching.BackColor = Color.FromArgb(225, 225, 225);
                rjtxtBoxSearching.BorderColor = Color.FromArgb(24, 58, 114);
                lblHomePageTittle.ForeColor = Color.FromArgb(225, 225, 225);
                grpBoxProcess.ForeColor = Color.Black;
                grpBoxDirectory.ForeColor = Color.Black;
                pictureBoxSearch.Image = Properties.Resources.search;
            }
        }
        private void DownloadGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegProcessClass.ExportGridTopPDF(dataGridView1, "Rehber");
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
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(31, 31, 46); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(31, 31, 46); }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(31, 31, 46); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(31, 31, 46); }
            }
            public override Color MenuBorder
            {
                get { return Color.FromArgb(31, 31, 46); }
            }
        }


    }
}
