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
    /// ChartStatistics Panel
    /// </summary>

    public partial class ChartStatistics : Form
    {
        //Variables and objects
        bool formMoving = false;
        Point startPoint = new Point(0, 0);

        //Constructor
        public ChartStatistics()
        {
            InitializeComponent();
        }

        //Load
        private void ChartStatistics_Load(object sender, EventArgs e)
        {
            //
            //graphic
            //
            int all = RegProcessClass.RegStatistics().Item1;
            int man = RegProcessClass.RegStatistics().Item2;
            int woman = RegProcessClass.RegStatistics().Item3;
            int constant = RegProcessClass.RegStatistics().Item4;
            int notAdminCount = RegProcessClass.RegStatistics().Item5;

            if (!HomePage.admin)
            {
                if (all != 0)
                {
                    lblStatisticsCountAll.Text = all.ToString();
                    if (man > 0)
                        chart1.Series["PhoneType"].Points.AddXY("Erkek", man);
                    if (woman > 0)
                        chart1.Series["PhoneType"].Points.AddXY("Kadın", woman);
                    if (constant > 0)
                        chart1.Series["PhoneType"].Points.AddXY("Sabit", constant);
                }
                else
                    lblStatisticsCountAll.Text = "Kayıt Yok";
            }
            else
                lblStatisticsCountAll.Text = notAdminCount.ToString();
            //
            //this
            //
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1E1E1");
            this.Icon = Properties.Resources.Directsy;
            //
            //btnStatisticsCancel
            //
            btnStatisticsCancel.FlatAppearance.BorderSize = 0;
            btnStatisticsCancel.FlatAppearance.MouseOverBackColor = Color.Tomato;
        }

        //Event Methods
        private void btnStatisticsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formMoving = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formMoving = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMoving)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}
