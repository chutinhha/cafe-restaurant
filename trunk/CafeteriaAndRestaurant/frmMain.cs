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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCafeteria frmcf = new frmCafeteria();
            frmcf.ProductFromId = 1;
            frmcf.Show();
            frmMain frmmain = new frmMain();
            frmmain.Enabled = false;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (pnMain.Controls["frmCafeteria"] == null)
            {
                pnMain.Controls.Clear();
                frmCafeteria frmcafe = new frmCafeteria();
                frmcafe.TopLevel = false;
                pnMain.Controls.Add(frmcafe);
                frmcafe.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmcafe.Dock = DockStyle.Fill;
                frmcafe.Show();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (pnMain.Controls["frmRestaurant"] == null)
            {
                pnMain.Controls.Clear();
                frmRestaurant frmres = new frmRestaurant();
                frmres.TopLevel = false;
                pnMain.Controls.Add(frmres);
                frmres.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmres.Dock = DockStyle.Fill;
                frmres.Show();
            }
        }
    }
}
