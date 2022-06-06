using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Algo está errado");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Algo está errado");
            }
        }
    }
}
