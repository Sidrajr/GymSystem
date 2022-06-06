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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if ( key == 0)
            {
                MessageBox.Show("Selecione um membro para deletar!");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro deletado com sucesso!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text== "" || AgeTb.Text == ""|| AmountTb.Text == "" || GenderCb.Text =="" || TimingCb.Text== "")
            {
                MessageBox.Show("Falta informação!");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTbl set MName='" + NameTb.Text + "', MPhone='" + PhoneTb.Text + "',MGen='" + GenderCb.Text + "',MAge=" + AgeTb.Text + ",MAmount=" + AmountTb.Text + ",MTimimg='" + TimingCb.Text + "'where MId =" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro atualizado com sucesso!");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
