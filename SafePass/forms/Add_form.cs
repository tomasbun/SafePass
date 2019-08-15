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
        
        

        public Add_form(bool add)
        {
            InitializeComponent();
            if (!add)
            {
                confirm_btn.Text = "Update";
                name_txtbox.Text = Program.name;
                username_txtbox.Text = Program.username;
                password_txtbox.Text = Program.password;
            }
                 
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            Program.Decryptfile(Program.file_location(), Program.filename);   // here

            if (confirm_btn.Text == "Add")
            {
                if (name_txtbox.Text == "Name" && username_txtbox.Text == "Username" && password_txtbox.Text == "Password")
                {
                    var confirmResult = MessageBox.Show("Are you sure about this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (StreamWriter file = new StreamWriter(Program.file_location(), true))
                            file.WriteLine(name_txtbox.Text + " " + username_txtbox.Text + " " + password_txtbox.Text);
                    }
                }
                else
                {
                    using (StreamWriter file = new StreamWriter(Program.file_location(), true))
                        file.WriteLine(name_txtbox.Text + " " + username_txtbox.Text + " " + password_txtbox.Text);    
                }  
            }
            else
            {
                List<string> lines = File.ReadAllLines(Program.file_location()).ToList();
                int index = lines.IndexOf(Program.name +" "+ Program.username +" "+ Program.password);
                lines[index] = name_txtbox.Text + " " + username_txtbox.Text + " " + password_txtbox.Text;
               
                using (StreamWriter newTask = new StreamWriter(Program.file_location(), false))
                {
                    foreach (string line in lines)
                          newTask.WriteLine(line); 
                }  
            }

            Program.Encryptfile(Program.file_location(), Program.filename);  //here
            this.Close();

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
