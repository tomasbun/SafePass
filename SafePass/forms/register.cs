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
            this.Hide();
            Control control_form = new Control();
            control_form.ShowDialog();
            this.Close();
        }
    }
}
