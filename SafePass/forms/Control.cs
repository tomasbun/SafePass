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
    public partial class Control : Form
    {
        string file_path;
        List<Record> all_records = new List<Record>();

        public Control(string username)
        {
            file_path = @"c:\safepass\" + username + ".txt";
            //string file_path = @"c:\safepass\" + ComputeSha256Hash(username) + ".txt";

            InitializeComponent();
            
            if (!File.Exists(file_path))
            {
                File.Create(file_path).Close();   
            }
            current_user_lbl.Text += username;

            Update_listview();



        }

        //---------------------- events ------------------------

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Add_form add_form = new Add_form(file_path, "Name", "Username", "Password");
            add_form.ShowDialog();
            Update_listview();
        }

        //-------------------- methods -------------------------

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Update_listview()
        {
            all_records.Clear();
            List<string> lines = File.ReadAllLines(file_path).ToList();
            foreach (string line in lines)
            {
                string[] data = line.Split(' ');
                Record new_record = new Record(data[0].Trim(), data[1].Trim(), data[2].Trim());
                all_records.Add(new_record);
            }

            listView1.Items.Clear();
            foreach (Record r in all_records)
            {
                ListViewItem list_view_row = new ListViewItem(r.GetName());
                list_view_row.SubItems.Add(r.GetUsername());
                list_view_row.SubItems.Add(r.GetPassword());
                listView1.Items.Add(list_view_row);
            }

        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Record r in all_records)
            {
                if (r.GetName().Contains(search_txtbox.Text) || r.GetUsername().Contains(search_txtbox.Text)
                    || r.GetPassword().Contains(search_txtbox.Text))
                {
                    ListViewItem list_view_row = new ListViewItem(r.GetName());
                    list_view_row.SubItems.Add(r.GetUsername());
                    list_view_row.SubItems.Add(r.GetPassword());
                    listView1.Items.Add(list_view_row);
                } 
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    //MessageBox.Show(item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                    Add_form add_form = new Add_form(file_path, item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);
                    add_form.ShowDialog();
                }
                Update_listview();

            }
        }
    }
}
