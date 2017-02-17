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
        }

        private void Employee_Load(object sender, EventArgs e)
        {

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
                MySqlCommand comm = new MySqlCommand("INSERT INTO employee(eName,eType,eBday,eLicense,eCivStatus,uName,pWord,eStatus) VALUES('" +
                    textBox1.Text + "','" + comboBox1.SelectedIndex + "','" +
                    dateTimePicker1.Value.ToString("YYYY-MM-DD") + "','" + textBox2.Text + "','" +
                    comboBox2.SelectedIndex + "','" + textBox3.Text + "','" + textBox4.Text + "','" + 
                    textBox5.Text +"','" + comboBox3.SelectedIndex + "')", conn);                
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.ToString());
            }
        }
    }
}
