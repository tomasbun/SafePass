﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SafePass
{
    public partial class login : Form
    {
        // testing
        string directory_path = @"c:\safepass";
        string file_path = @"c:\safepass\userdata.txt";
        string key = "robertas";
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
                var myfile = File.Create(file_path);
                myfile.Close();
                File.WriteAllText(file_path, "admin 1234");
                Encryptfile(file_path, key);

                MessageBox.Show("No profiles detected please register first! ");
                repeat_password_txtbox.TabStop = true;
                panel1.Height = 125;
                button1.Text = "Register";
                button2.Text = "Login";
                button2.Enabled = false;
                
            }
            else
            {
                read_users();   
            }
            username_txtbox.Focus();

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
                if (username_txtbox.Text.Length < 5 )
                {
                    MessageBox.Show("Username has to be at least 5 characters long");
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
                    Decryptfile(file_path, key);
                    File.WriteAllText(file_path, username_txtbox.Text.Trim() + " " + password_txtbox.Text.Trim());
                    Encryptfile(file_path, key);
                    MessageBox.Show("Registration successful!");
                    this.Hide();
                    Control control_form = new Control(username_txtbox.Text);
                    control_form.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                foreach (User u in all_users)
                {
                    if ((u.GetUsername() == username_txtbox.Text) && (u.GetPassword() == password_txtbox.Text))
                    {
                        this.Hide();
                        Control control_form = new Control(username_txtbox.Text);
                        control_form.ShowDialog();
                        this.Close();
                    }
                }
                MessageBox.Show("Username or password incorect!");
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

        //------------------------- methods -------------------------------------------------

        private void read_users()
        {
            Decryptfile(file_path, key);
            String[] lines = File.ReadAllLines(file_path);
            foreach (string line in lines)
            {
                string[] details = line.Split(' ');
                User new_user = new User(details[0], details[1]);
                all_users.Add(new_user);
            }
            Encryptfile(file_path, key);
        }

        static void Encryptfile(string filepath, string key)
        {
            byte[] plainContent = File.ReadAllBytes(filepath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;


                using (var memStream = new MemoryStream())
                {
                     CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filepath, memStream.ToArray());
                    MessageBox.Show("Encryption succesfull");
                }

            }

        }

        static void Decryptfile(string filepath, string key)
        {
            byte[] encrypted = File.ReadAllBytes(filepath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;


                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(),
                       CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filepath, memStream.ToArray());
                    MessageBox.Show("Decryption succesfull");
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Decryptfile(file_path, key);
        }
    }
}
