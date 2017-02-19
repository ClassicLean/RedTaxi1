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
        private bool userCheck = true, passCheck = true;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=redtaxi;Uid=root;Pwd=root;");
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
                if (dt.Rows.Count == 1)
                {
                    Checker(dt.Rows[0]["eType"].ToString(), dt.Rows[0]["eName"].ToString());
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
        public void Checker(string a,string b)
        {
            /*
            0 = hr 
            1 = operator
            2 = driver
            */

            if (a == "0")
            {
                HR hr = new HR(b);
                hr.Show();
                hr.reference_to_form1 = this;
                this.Hide();
            }

            else if (a == "1")
            {
                Assign ass = new Assign(b);
                ass.login_ref = this;
                ass.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You are not authorized to login the system, \n\tcontact HR for more info", "Authorization error");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, new EventArgs());
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (userCheck)
            {
                textBoxUser.Text = "";
                textBoxUser.Font = new Font("Roboto", 8, FontStyle.Regular);
                textBoxUser.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (passCheck)
            {
                textBoxPass.Text = "";
                textBoxPass.Font = new Font("Wingdings", 8, FontStyle.Regular);
                textBoxPass.PasswordChar = 'l';
                textBoxPass.ForeColor = Color.DimGray;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            userCheck = textBoxUser.Text.Equals("");
            if (userCheck)
            {
                textBoxUser.Text = "Username";
                textBoxUser.Font = new Font("Roboto Light", 8, FontStyle.Italic);
                textBoxUser.ForeColor = Color.FromArgb(148, 165, 165);
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            passCheck = textBoxPass.Text.Equals("");
            if (passCheck)
            {
                textBoxPass.Text = "Password";
                textBoxPass.PasswordChar = '\0';
                textBoxPass.Font = new Font("Roboto Light", 8, FontStyle.Italic);
                textBoxPass.ForeColor = Color.FromArgb(148, 165, 165);
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, new EventArgs());
        }
    }
}
