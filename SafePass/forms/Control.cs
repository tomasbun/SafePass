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
using System.Diagnostics;

namespace SafePass
{
    public partial class Control : MaterialSkin.Controls.MaterialForm  {
        List<Record> all_records = new List<Record>();

        public Control()
        {
            InitializeComponent();
                       
            if (!File.Exists(Program.file_location()))
            {
                File.Create(Program.file_location()).Close();
                Program.Encryptfile(Program.file_location(), Program.filename);
            }
            current_user_lbl.Text += Program.filename;
            Update_listview();
        }

        //---------------------- events --------------------------------------

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Add_form add_form = new Add_form(true);
            add_form.ShowDialog();
            Update_listview();
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
                    Program.name = item.SubItems[0].Text;
                    Program.username = item.SubItems[1].Text;
                    Program.password = item.SubItems[2].Text;
                    Add_form add_form = new Add_form(false);
                    add_form.ShowDialog();
                }
                Update_listview();
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            Program.Decryptfile(Program.file_location(), Program.filename);   // here
            //Process.Start("notepad.exe", file_path);
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = Program.file_location()
            };

            process.Start();
            process.WaitForExit();

            Program.Encryptfile(Program.file_location(), Program.filename);   // here
            Update_listview();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {

                ListView.CheckedIndexCollection checkedItems = listView1.CheckedIndices;
                while (checkedItems.Count != 0)
                {
                    var myitem = listView1.Items[checkedItems[0]];
                    all_records.RemoveAll(x => (x.GetName() == myitem.SubItems[0].Text) && (x.GetUsername() == myitem.SubItems[1].Text) && (x.GetPassword() == myitem.SubItems[2].Text));
                    listView1.Items.RemoveAt(checkedItems[0]);
                }

                Program.Decryptfile(Program.file_location(), Program.filename);       /// here

                using (StreamWriter newTask = new StreamWriter(Program.file_location(), false))
                {
                    foreach (Record r in all_records)
                         newTask.WriteLine(r.Display_details());
                    
                }

                Program.Encryptfile(Program.file_location(), Program.filename);     // here

                Update_listview();
            }
        }     

        //-------------------- methods ----------------------------------------

        public void Update_listview()
        {
            all_records.Clear();
            listView1.Items.Clear();

            Program.Decryptfile(Program.file_location(), Program.filename);          // here

            List<string> lines = File.ReadAllLines(Program.file_location()).ToList();
            records_lbl.Text = "Number of records: " + lines.Count();
            foreach (string line in lines)
            {
                string[] data = line.Split(' ');
                Record new_record = new Record(data[0].Trim(), data[1].Trim(), data[2].Trim());
                all_records.Add(new_record);

                ListViewItem list_view_row = new ListViewItem(new_record.GetName());
                list_view_row.SubItems.Add(new_record.GetUsername());
                list_view_row.SubItems.Add(new_record.GetPassword());
                listView1.Items.Add(list_view_row);
            }

            Program.Encryptfile(Program.file_location(), Program.filename);            // here

        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void search_txtbox_Click(object sender, EventArgs e)
        {
            search_txtbox.Text = "";
        }

       
    }
}
