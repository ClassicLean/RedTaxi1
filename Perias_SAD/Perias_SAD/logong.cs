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
    public partial class logong : Form
    {
        public MySqlConnection conn;
        public logong()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad_db;Uid=root;Pwd=root;");
        }

        private void logong_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            if (user.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("The user must supply the necessary fields");
            }
            else
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_accounts WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if ("0".Equals(dt.Rows[0]["account_status"].ToString()))
                    {
                        if (dt.Rows.Count > 0)
                        {
                            main next2 = new main(this, dt);
                            Hide();
                            next2.Show();

                        }
                        else
                        {
                            MessageBox.Show("The user credentials are incorrect.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inactive account, Please contact local Administrator");
                    }
                    conn.Close();
                }
                catch (Exception x44)
                {
                    MessageBox.Show(x44.ToString());
                    conn.Close();
                }
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
