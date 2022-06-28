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
using System.Threading;
using System.Collections;
using System.IO;

namespace MertDogan_202503033
{
    /// <summary>
    /// PhoneNumberAdd Panel
    /// </summary>
    public partial class PhoneNumberAdd : Form
    {
        //Variables and objects
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public static string ImagePath = Path.Combine(projectPath, "Resources\\user.png");
        public static DataGridView dgvAdd;
        public static int LastID = 0;
        bool formMoving = false;
        Point startPoint = new Point(0, 0);


        //Constructor have parameter
        public PhoneNumberAdd(DataGridView dgv)
        {
            dgvAdd = dgv;
            InitializeComponent();
        }

        //Constructor haven't parameter
        public PhoneNumberAdd()
        {
            InitializeComponent();
        }

        //Non-Event Methods
        bool IsCheckedRadioB(Panel pnl)
        {
            foreach (RJControls.RJConpanents.RJRadioButton item in pnl.Controls)
                if (item.Checked)
                    return true;
            return false;
        }
        void SortedComboBox()
        {
            List<int> items = new List<int>();
            foreach (string item in rjcmBoxRegCountry.Items)
                items.Add(Convert.ToInt32(item.Substring(1)));

            int i = 0;
            int j = 0;
            bool devam = true; // devam isimli flag kullanarak buublesortun daha performanslı olmasını sagladık
            int temp = 0;

            while (i < items.Count && devam) // size kadar ve ilk döngüde degisiklik yoksa devam 0 olacagından dolayı sıralanmıs bir dizide performans saglamıs olacak
            {
                devam = false;
                for (j = 0; j < items.Count - 1; j++)
                {
                    if (items[j] > items[j + 1]) // swap islemi
                    {
                        temp = items[j + 1];
                        items[j + 1] = items[j];
                        items[j] = temp;

                        // çok kullandıgımız icin fonka cevirmek daha iyi

                        devam = true; // eger herhangi bir degisiklik olursa döngü devam etmeli
                    }
                }
                i++;
            }
            for (int k = 0; k < items.Count; k++)
            {
                rjcmBoxRegCountry.Items[k] = items[k].ToString().PadLeft(items[k].ToString().Length + 1, '+');
            }
        }

        //Load
        private void PhoneNumberAdd_Load(object sender, EventArgs e)
        {
            //
            //rjcmBoxRegCountry
            //
            SortedComboBox();
            rjcmBoxRegCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            //rjtxtBoxRegName
            //
            rjtxtBoxRegName.MaxLength = 20;
            rjtxtBoxRegName.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxRegName.UnderlinedStyle = true;
            rjtxtBoxRegName.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxRegName.BorderColor = Color.FromArgb(24, 58, 114);
            //
            //rjtxtBoxRegSurname
            //
            rjtxtBoxRegSurname.MaxLength = 20;
            rjtxtBoxRegSurname.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxRegSurname.UnderlinedStyle = true;
            rjtxtBoxRegSurname.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxRegSurname.BorderColor = Color.FromArgb(24, 58, 114);
            //
            //rjtxtBoxRegPhoneNumber
            //
            rjtxtBoxRegPhoneNumber.MaxLength = 12;
            rjtxtBoxRegPhoneNumber.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxRegPhoneNumber.UnderlinedStyle = true;
            rjtxtBoxRegPhoneNumber.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxRegPhoneNumber.BorderColor = Color.FromArgb(24, 58, 114);
            //
            //rjtxtBoxRegID
            //
            rjtxtBoxRegID.Enabled = false;
            rjtxtBoxRegID.BackColor = Color.FromArgb(225, 225, 225);
            rjtxtBoxRegID.UnderlinedStyle = true;
            rjtxtBoxRegID.BorderFocusColor = Color.SeaGreen;
            rjtxtBoxRegID.BorderColor = Color.FromArgb(24, 58, 114);
            //
            //rjbtnRegAdd
            //
            rjbtnRegAdd.Enabled = false;
            rjbtnRegAdd.FlatStyle = FlatStyle.Flat;
            //
            //rjbtnRegUpdate
            //
            rjbtnRegUpdate.Enabled = false;
            rjbtnRegUpdate.FlatStyle = FlatStyle.Flat;
            //
            //btnRegImage
            //
            rjbtnRegImage.FlatStyle = FlatStyle.Flat;
            //
            //pcBoxImage
            //
            pcBoxRegImage.Dock = DockStyle.Fill;
            pcBoxRegImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBoxRegImage.Image = Properties.Resources.user;
            //
            //this
            //
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Event Methods
        private void rjbtnRegAdd_Click(object sender, EventArgs e)
        {
            RegProcessClass.RegAdd(dgvAdd, pnlRegType, rjcmBoxRegCountry, rjtxtBoxRegID, rjtxtBoxRegName, rjtxtBoxRegSurname, rjtxtBoxRegPhoneNumber, rjtxtBoxRegEmail);
            rjbtnRegUpdate.Enabled = true;
        }
        private void rjbtnRegUpdate_Click(object sender, EventArgs e)
        {
            RegProcessClass.RegUpdate(dgvAdd, pnlRegType, rjcmBoxRegCountry, rjtxtBoxRegID, rjtxtBoxRegName, rjtxtBoxRegSurname, rjtxtBoxRegPhoneNumber, rjtxtBoxRegEmail);
        }
        private void rjbtnRegImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows), // Optional
                Title = "Bir Görsel Seç",
                DefaultExt = "PNG",
                Filter = "Görseller (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
                AddExtension = true,
                AutoUpgradeEnabled = true,
                DereferenceLinks = true,
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcBoxRegImage.ImageLocation = openFileDialog1.FileName;
                ImagePath = openFileDialog1.FileName;
            }
            else
                pcBoxRegImage.Image = Properties.Resources.user;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PhoneNumberAdd_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void PhoneNumberAdd_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void PhoneNumberAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void pnlRegAddTop_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void pnlRegAddTop_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void pnlRegAddTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void rjcmBoxRegCountry_OnSelectedValueChanged(object sender, EventArgs e)
        {
            if ((rjcmBoxRegCountry.SelectedIndex >= 0 && IsCheckedRadioB(pnlRegType)) && (rjtxtBoxRegName.Texts != string.Empty && rjtxtBoxRegPhoneNumber.Texts != string.Empty))
                rjbtnRegAdd.Enabled = true;
            else
                rjbtnRegAdd.Enabled = false;
        }
        private void Type_CheckedChanged(object sender, EventArgs e)
        {
            if ((rjcmBoxRegCountry.SelectedIndex >= 0 && IsCheckedRadioB(pnlRegType)) && (rjtxtBoxRegName.Texts != string.Empty && rjtxtBoxRegPhoneNumber.Texts != string.Empty))
                rjbtnRegAdd.Enabled = true;
            else
                rjbtnRegAdd.Enabled = false;
        }
        private void rjtxtBoxRegNamePhone__TextChanged(object sender, EventArgs e)
        {
            if ((rjcmBoxRegCountry.SelectedIndex >= 0 && IsCheckedRadioB(pnlRegType)) && (rjtxtBoxRegName.Texts != string.Empty && rjtxtBoxRegPhoneNumber.Texts != string.Empty))
                rjbtnRegAdd.Enabled = true;
            else
                rjbtnRegAdd.Enabled = false;
        }
        private void rjtxtBoxRegPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
