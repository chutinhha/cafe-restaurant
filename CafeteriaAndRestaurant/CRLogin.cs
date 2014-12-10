using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeteriaAndRestaurant.BLL;
using CafeteriaAndRestaurant.DAL.Models;

namespace CafeteriaAndRestaurant
{
    public partial class CRLogin : Form
    {
        public CRLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is required", "Message");
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required", "Message");
            }
            else
            {
                CheckLoginDto checkedLogin = new CheckLoginDto();
                DALCheckedLogin checkedLoginAPI = new DALCheckedLogin();
                checkedLogin = checkedLoginAPI.CheckedLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (!checkedLogin.IsSuccess)
                {
                    MessageBox.Show(checkedLogin.Message, "Message");
                    return;
                }
                CRMain frm = new CRMain();
                frm.ShowDialog();
            }
        }
    }
}
