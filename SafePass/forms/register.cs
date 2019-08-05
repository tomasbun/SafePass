using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class register : Form
    {
        public register()
        {
            // do you see this?
            // what about this?
            // and this?
            // its me again
            InitializeComponent();

        }



        private void login_lbl_MouseLeave(object sender, EventArgs e)
        {
            login_lbl.ForeColor = Color.DimGray;
        }

        private void login_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            login_lbl.ForeColor = Color.Teal;
        }

        private void login_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login_form = new login();
            login_form.ShowDialog();
            this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text.Length < 5 ) 
            {
                MessageBox.Show("Username must be at least 5 characters long");
            }
            else if (password_txtbox.Text != repeat_password_txtbox.Text)
            {
                MessageBox.Show("Password do not match!");
            }
            else
            {
                this.Hide();
                Control control_form = new Control();
                control_form.ShowDialog();
                this.Close();

            }
            
        }

        private void username_txtbox_Click(object sender, EventArgs e)
        {
            if (username_txtbox.Text == "Username")
            {
                username_txtbox.Text = "";
                username_txtbox.ForeColor = Color.Black;
            }

            if ((password_txtbox.Text == "") || (repeat_password_txtbox.Text == ""))
            {
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
        }

        private void password_txtbox_Click(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "Password")
            {
                password_txtbox.Text = "";
                password_txtbox.ForeColor = Color.Black;
            }

            if (username_txtbox.Text == "")
            {
                username_txtbox.Text = "Username";
                username_txtbox.ForeColor = Color.DarkGray;
            }
        }

        private void repeat_password_txtbox_Click(object sender, EventArgs e)
        {
            if (repeat_password_txtbox.Text == "Repeat password")
            {
                repeat_password_txtbox.Text = "";
                repeat_password_txtbox.ForeColor = Color.Black;
            }

            if (username_txtbox.Text == "")
            {
                username_txtbox.Text = "Username";
                username_txtbox.ForeColor = Color.DarkGray;
            }
        }
    }
}
