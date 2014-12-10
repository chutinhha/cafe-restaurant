using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaAndRestaurant
{
    public partial class CRMain : Form
    {

        public CRMain()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (pnMain.Controls["CRCafeteria"] == null)
            {
                pnMain.Controls.Clear();
                CRCafeteria frmcafe = new CRCafeteria(1);
                frmcafe.TopLevel = false;
                pnMain.Controls.Add(frmcafe);
                frmcafe.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmcafe.Dock = DockStyle.Fill;
                frmcafe.Show();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (pnMain.Controls["CRRestaurant"] == null)
            {
                pnMain.Controls.Clear();
                CRRestaurant frmres = new CRRestaurant(2);
                frmres.TopLevel = false;
                pnMain.Controls.Add(frmres);
                frmres.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmres.Dock = DockStyle.Fill;
                frmres.Show();
            }
        }


        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls["CRAddCategory"] == null)
            {
                pnMain.Controls.Clear();
                CRAddCategory frmaddcategory = new CRAddCategory();
                frmaddcategory.TopLevel = false;
                pnMain.Controls.Add(frmaddcategory);
                frmaddcategory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmaddcategory.Dock = DockStyle.Fill;
                frmaddcategory.Show();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls["CRAddProduct"] == null)
            {
                pnMain.Controls.Clear();
                CRAddProduct frmaddproduct = new CRAddProduct();
                frmaddproduct.TopLevel = false;
                pnMain.Controls.Add(frmaddproduct);
                frmaddproduct.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmaddproduct.Dock = DockStyle.Fill;
                frmaddproduct.Show();
            }
        }


        private void CRMain_Load(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls["CRStatistic"] == null)
            {
                pnMain.Controls.Clear();
                CRStatistic CRStatistic = new CRStatistic();
                CRStatistic.TopLevel = false;
                pnMain.Controls.Add(CRStatistic);
                CRStatistic.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                CRStatistic.Dock = DockStyle.Fill;
                CRStatistic.Show();
            }
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            CRLogin login = new CRLogin();
            login.ShowDialog();
        }


    }
}
