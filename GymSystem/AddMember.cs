using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymSystem
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-3TTOKDJR\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True;Pooling=False");
        private void AddMember_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == ""|| AgeTb.Text =="")
            {
                MessageBox.Show("Está faltando informações!");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MemberTbl values('" + NameTb.Text + "', '" + PhoneTb.Text + "','" + AgeTb.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + AmountTb.Text + "','" + TimingCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro adicionado com sucesso!");
                    Con.Close();
                    AmountTb.Text = "";
                    AgeTb.Text = "";
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.Text = "";
                    TimingCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }
    }
}
