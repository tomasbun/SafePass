using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace SafePass
{
    public partial class Add_form : Form
    {
        string myfile;
        string var_name;
        string var_username;
        string var_password;

        public Add_form(string file_path, string name, string username, string password)
        {
            InitializeComponent();
            myfile = file_path;
            var_name = name;
            var_username = username;
            var_password = password;
            name_txtbox.Text = name;
            username_txtbox.Text = username;
            password_txtbox.Text = password;

            if (name_txtbox.Text == "Name" && username_txtbox.Text == "Username" && password_txtbox.Text == "Password")
            {
                confirm_btn.Text = "Add";
            }
            else
            {
                confirm_btn.Text = "Update";
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (confirm_btn.Text == "Add")
            {
                using (StreamWriter file = new StreamWriter(myfile, true))
                {
                    file.WriteLine(name_txtbox.Text + " " + username_txtbox.Text + " " + password_txtbox.Text);
                }
                this.Close();
            }
            else
            {
                Record new_record = null;
                List<Record> all_records = new List<Record>();
                List<string> lines = File.ReadAllLines(myfile).ToList();
                foreach (string line in lines)
                {
                    string[] data = line.Split(' ');
                    if (data[0] == var_name && data[1] == var_username && data[2] == var_password)
                    {
                        new_record = new Record(name_txtbox.Text, username_txtbox.Text, password_txtbox.Text);
                    }
                    else
                    {
                        new_record = new Record(data[0].Trim(), data[1].Trim(), data[2].Trim());
                    }
                    all_records.Add(new_record);
                }

                File.WriteAllText(myfile, "");
                
                using (StreamWriter file = new StreamWriter(myfile, true))
                    
                {
                    foreach (Record r in all_records)
                    {

                        file.WriteLine(r.GetName() + " " + r.GetUsername() + " " + r.GetPassword());
                    }
                }
                this.Close();


            }
                
        }
    }
}
