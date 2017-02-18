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
    public partial class Employee : Form
    {
        public HR reference_to_HR { get; set; }
        public MySqlConnection conn;
        public Employee()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=redtaxi;Uid=root;Pwd=root;");
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_HR.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO employee "+
                    "VALUES(NULL, '" + textBox1.Text.ToLower() + "','" + comboBox1.SelectedIndex + "','" +
                    dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox2.Text + "','" +
                    comboBox2.SelectedIndex + "','" + textBox3.Text + "','" + textBox4.Text + "','" +
                    "0')", conn);                
                comm.ExecuteNonQuery();
                conn.Close();
                textBox1.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Value= DateTime.Now;
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.ToString());
            }
        }
    }
}
