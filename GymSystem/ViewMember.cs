using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-3TTOKDJR\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True;Pooling=False");

        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewMember_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();

        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTbl where MName ='" + SearchName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            filterByName();
        }
    }
}
