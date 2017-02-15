using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Perias_SAD
{
    public partial class userMan : Form
    {
        Form ambotjuddd = new Form();
        public MySqlConnection conn;
        public int status;
        public int activ;
        int idLamao;
        public userMan(Form ambotnaoi)
        {
            InitializeComponent();
            ambotjuddd = ambotnaoi;
            conn = new MySqlConnection("Server=localhost;Database=sad_db;Uid=root;Pwd=root;");

        }
        private void Rifrish()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_accounts", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["account_id"].Visible = false;
                dataGridView1.Columns["fn"].HeaderText = "Firstname";
                dataGridView1.Columns["mn"].HeaderText = "Middlename";
                dataGridView1.Columns["ln"].HeaderText = "Lastname";
                dataGridView1.Columns["username"].HeaderText = "Username";
                dataGridView1.Columns["password"].HeaderText = "Password";
                dataGridView1.Columns["account_type"].HeaderText = "Account Type";
                dataGridView1.Columns["account_status"].HeaderText = "Account Status";
                conn.Close();
            }
            catch (Exception ee)
            {
                //MessageBox.Show("Nah!");
                conn.Close();
            }
        }
        private void userMan_Load(object sender, EventArgs e)
        {
            status = 1;
            activ = 1;
            Rifrish();
            radioButton1.Checked = true;
            radioButton6.Checked = true;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void userMan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ambotjuddd.Show();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO tbl_accounts (fn,mn,ln,username,password,account_type,account_status) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'," + status + "," + activ + ")", conn);
                comm.ExecuteNonQuery();
                conn.Close();
                Rifrish();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please contact ...");
                conn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            status = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            status = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            activ = 0;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            activ = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE tbl_accounts SET fn='" + textBox1.Text + "',mn='" +
                    textBox2.Text + "',ln='" + textBox5.Text + "',username='" + textBox6.Text + "',password='" +
                    textBox7.Text + "',account_type=" + status + ",account_status=" + activ + " WHERE account_id=" + idLamao, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                Rifrish();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please contact ...");
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            idLamao = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["account_id"].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["fn"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["mn"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["ln"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
            if ("1".Equals(dataGridView1.Rows[e.RowIndex].Cells["account_type"].Value.ToString()))
                radioButton2.Checked = true;
            else
                radioButton1.Checked = true;
            if ("1".Equals(dataGridView1.Rows[e.RowIndex].Cells["account_status"].Value.ToString()))
                radioButton5.Checked = true;
            else
                radioButton6.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
