using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loginform
{
    public partial class frm_login : Form
    {
        string username = "anuj";
        string password = "Thapa";

        public frm_login()
        {
            InitializeComponent();
            txb_password.PasswordChar = '*';
            txb_password.MaxLength = 5;
        }
        public void passowrdCheck()
        {
            if (username == tbx_username.Text && password == txb_password.Text)
            { 
                this.Hide();
                frm_main main = new frm_main();
                main.Show();
            }
            else
            {
                lbl_error.Text = "please check user name and password";

            }
        }
        private void button1_Click(object sender, EventArgs e)
            {
            passowrdCheck();
            }

            private void tbx_username_TextChanged(object sender, EventArgs e)
            {

            }
            private void txb_password_TextChanged(object sender, EventArgs e)
            {

            }
            private void btn_clear_Click(object sender, EventArgs e)
            {
                txb_password.Clear();
                tbx_username.Clear();
            }
        }
    }

