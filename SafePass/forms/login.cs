using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class login : Form
    {
        // testing
        string directory_path = @"c:\safepass";
        int number_of_files = 0;

        public login()
        {
            InitializeComponent();
            if (Directory.Exists(directory_path))
                number_of_files = Directory.GetFiles(directory_path).Length;
                       

            if ( (!Directory.Exists(directory_path)) || (number_of_files == 0) )
            {
                Directory.CreateDirectory(directory_path);
                MessageBox.Show("No profiles detected please register first!");
                this.Hide();
                register register_form = new register();
                register_form.ShowDialog();
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


            if (password_txtbox.Text == "")
            {
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
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

        private void register_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            register_lbl.ForeColor = Color.Teal;
        }

        private void register_lbl_MouseLeave(object sender, EventArgs e)
        {
            register_lbl.ForeColor = Color.DimGray;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Control control_form = new Control();
            control_form.ShowDialog();
            this.Close();
        }

        private void register_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register_form = new register();
            register_form.ShowDialog();
            this.Close();
        }
    }
}
