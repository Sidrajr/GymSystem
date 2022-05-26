using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.Show();
            this.Hide();
        }
    }
}
