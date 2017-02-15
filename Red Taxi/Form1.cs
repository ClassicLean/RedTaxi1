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
namespace Red_Taxi
{
    public partial class Form1 : Form
    {
        public MySqlConnection conn;
        public HR reference_to_HR { get; set; }
        public Operator reference_to_operator { get; set; }

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=10.4.42.236;Database=redtaxi;Uid=root;Pwd=root;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand("SELECT * FROM employee WHERE uName = '" + textBoxUser.Text + "' AND pWord = '" + textBoxPass.Text + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                string fn, ln, type;

                if (dt.Rows.Count == 1)
                {
                   
                    type = dt.Rows[0]["eType"].ToString();

                    Checker(type);
                }
                else if (textBoxUser.Text == "" || textBoxPass.Text == "")
                {
                    MessageBox.Show("The user must supply the necessary fields.");
                }

                else
                {
                    MessageBox.Show("The user credentials are incorrect.");
                }


                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nerror: " + ee);
                conn.Close();
            }
        }
        public void Checker(string a)
        {
             /*
             0 = hr 
             1 = operator
             2 = driver
             */

            if (a == "0")
            {
                HR hr = new HR();
                hr.Show();
                hr.reference_to_form1 = this;
                this.Hide();
            }

            else if( a == "1")
            {
                Operator operate = new Operator();
                operate.Show();
                operate.reference_to_form1 = this;
                this.Hide();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rifrish()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_users", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void textBoxUser_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUser.Text = "";
        }

        private void textBoxPass_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPass.Text = "";
        }
    }
}
