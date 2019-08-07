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
        string file_path = @"c:\safepass\userdata.txt";
        int number_of_files = 0;
        List<User> all_users = new List<User>();

        public login()
        {
            InitializeComponent();
            if (Directory.Exists(directory_path))
                number_of_files = Directory.GetFiles(directory_path).Length;
            
            if ( (!Directory.Exists(directory_path)) || (number_of_files == 0) || (!File.Exists(file_path)) )
            {
                Directory.CreateDirectory(directory_path);
                File.Create(file_path);
                MessageBox.Show("No profiles detected please register first! " + number_of_files );
                this.Hide();
                register register_form = new register();
                register_form.ShowDialog();
                this.Close();
            }
            else
                read_users();

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

        private void username_txtbox_Enter(object sender, EventArgs e)
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

        private void password_txtbox_Enter(object sender, EventArgs e)
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
            foreach (User u in all_users)
            {
                if ( (u.GetUsername() == username_txtbox.Text) && (u.GetPassword() == password_txtbox.Text) )
                {
                    this.Hide();
                    Control control_form = new Control(username_txtbox.Text);
                    control_form.ShowDialog();
                    this.Close();
                }
            }
            MessageBox.Show("Username or password incorect!");
        }

        private void register_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register_form = new register();
            register_form.ShowDialog();
            this.Close();
        }
        
        private void read_users()
        {
            String[] lines = File.ReadAllLines(file_path);
            foreach (string line in lines)
            {
                string[] details = line.Split(' ');
                User new_user = new User(details[0], details[1]);
                all_users.Add(new_user);
            }
        }

        
    }
}
