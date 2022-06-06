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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-3TTOKDJR\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True;Pooling=False");
        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Mname from MemberTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mname", typeof(string));
            dt.Load(rdr);
            NameCB.ValueMember = "Mname";
            NameCB.DataSource = dt;
            Con.Close();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTbl where PMember='"+SearchName.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //NameCb.Text = "";
            AmountTb.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }
        int key = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameCB.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Falta informação !");
            }
            else
            {
                string payperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PMember='"+NameCB.SelectedValue.ToString()+"'and PMonth= '"+payperiode+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Já pago este mês");
                }
                else
                {
                    string query = "insert into PaymentTbl values ('" + payperiode + "', '" + NameCB.SelectedValue.ToString() + "'," + AmountTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Valor pago com sucesso");
                }
                Con.Close();
                populate();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
