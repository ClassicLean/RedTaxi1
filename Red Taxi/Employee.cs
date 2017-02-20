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
        string empName;
        int employeeType = 0;
        int civilStatus = 0;
        int employeeID = 0;
        string id;
        string uName;

        public Employee(string b)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=172.22.10.202;Database=redtaxi;Uid=root;Pwd=root;");
            empName = b;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            comboBoxeType.Text = "";
            comboBoxcStatus.Text = "";
            Rifrish();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_HR.Show();
            this.Hide();
        }
        private void Rifrish()
        {
            try
            {
                conn = new MySqlConnection("Server=172.22.10.202;Database=redtaxi;Uid=root;Pwd=root;");
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM employee where eName != '"+empName+"'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["eID"].Visible = false;
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do you want to create user '" + textBoxeName.Text + "'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (r == DialogResult.Yes && checkDuplicates() && checkText())
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO employee " +
                        "VALUES(NULL, '" + textBoxeName.Text.ToLower() + "','" + comboBoxeType.SelectedIndex + "','" +
                        dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBoxlNumber.Text + "','" +
                        comboBoxcStatus.SelectedIndex + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" +
                        "0')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    textBoxeName.Clear();
                    comboBoxeType.Text = "";
                    comboBoxcStatus.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    textBoxlNumber.Clear();
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    Rifrish();
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.ToString());
            }
        }
       

        private Boolean checkDuplicates()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM employee WHERE uName = '" + textBoxUsername.Text + "';", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt1 = new DataTable();
                adp.Fill(dt1);
                conn.Close();
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Username taken");
                }

                else
                {
                    return true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }

            return false;
        }

        private Boolean checkText()
        {

            if (textBoxeName.Text == "" || comboBoxeType.Text == "" || textBoxlNumber.Text == "" 
                || comboBoxcStatus.Text == "" || textBoxUsername.Text == "" || 
                textBoxPassword.Text == "" )
                MessageBox.Show("Please fill out required fields");
            else
                return true;
            return false;

        }
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            upDialogue ups = new upDialogue(this, false, dataGridView1.Rows[e.RowIndex].Cells);
            ups.Show();
            Hide();
        }

        private void buttonInsert_VisibleChanged(object sender, EventArgs e)
        {
            Rifrish();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
