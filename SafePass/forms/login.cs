using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SafePass
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
          
        public login()
        {
            InitializeComponent();

            //newform new_form = new newform();
            //new_form.ShowDialog();
                                                  
            if (!File.Exists(Program.file_location()))
            {
                Directory.CreateDirectory(Program.directory_path);
                File.WriteAllText(Program.file_location(), Program.EncryptData(Program.filename + " 1234" +
                                      DateTime.Now.ToString("MM/dd/yyyy"), Program.filename) + "\n");

                MessageBox.Show("No profiles detected please register first! ");
                repeat_password_txtbox.TabStop = true;
                panel1.Height = 125;
                button1.Text = "Register";
                button2.Text = "Login";
                button2.Enabled = false;
            }
            username_txtbox.Select();
           
        }

       //------------------------- events ---------------------------------------------------

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

            if (repeat_password_txtbox.Text == "")
            {
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
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
            if (repeat_password_txtbox.Text == "")
            {
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
        }
        
        private void repeat_password_txtbox_Enter(object sender, EventArgs e)
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
            if (password_txtbox.Text == "")
            {
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Register")
            {
                if (username_txtbox.Text.Length < 8 )
                {
                    MessageBox.Show("Username has to be at least 8 characters long");
                }
                else if (username_txtbox.Text.Contains(' ') || password_txtbox.Text.Contains(' '))
                {
                    MessageBox.Show("No spaces allowed");
                }
                else if (password_txtbox.Text != repeat_password_txtbox.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else
                {
                    
                    using (StreamWriter file = new StreamWriter(Program.file_location(), true))
                        file.WriteLine(Program.EncryptData(username_txtbox.Text.Trim() + " " + password_txtbox.Text.Trim() +
                            " "+ DateTime.Now.ToString("MM/dd/yyyy"), username_txtbox.Text.Trim()));
                    
                    Program.filename = username_txtbox.Text;
                    MessageBox.Show("Registration successful!");

                    this.Hide();
                    Control control_form = new Control();
                    control_form.ShowDialog();
                    this.Close();
                    
                }
            }
            else
            {
                String[] lines = File.ReadAllLines(Program.file_location());
                foreach (string line in lines)
                {
                    string n = Program.DecryptData_nopadding(line, username_txtbox.Text);
                    if ( n.Trim().Contains(' ') )
                    {
                        string[] details = Program.DecryptData(line, username_txtbox.Text).Split();
                        if ((details[0] == username_txtbox.Text) && (details[1] == password_txtbox.Text))
                        {
                            Program.filename = username_txtbox.Text;
                            this.Hide();
                            Control control_form = new Control();
                            control_form.ShowDialog();
                            this.Close();
                        }
                    }

                }
                MessageBox.Show("Username or password incorect");
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Register")
            {
                panel1.Height = 125;
                button1.Text = "Register";
                button2.Text = "Login";
                repeat_password_txtbox.TabStop = true;
                username_txtbox.Focus();
                username_txtbox.Text = "";
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
            else
            {
                panel1.Height = 84;
                button1.Text = "Login";
                button2.Text = "Register";
                repeat_password_txtbox.TabStop = false;
                username_txtbox.Focus();
                username_txtbox.Text = "";
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.BlueGrey900,         // under top and buttons     
                MaterialSkin.Primary.BlueGrey900,         //top
                MaterialSkin.Primary.Red500,          // unknown
                MaterialSkin.Accent.Amber700,         // underline textbox, chekbox
                MaterialSkin.TextShade.WHITE);
        }        
    }
}
