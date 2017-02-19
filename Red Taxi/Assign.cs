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
    public partial class Assign : Form
    {
        public Form1 login_ref;
        public MySqlConnection conn;
        public String[] valuePassed;
        int increm = -1;
        public Assign(string b)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=redtaxi;Uid=root;Pwd=root;");
            label8.Text = b;
        }

        private void Assign_Load(object sender, EventArgs e)
        {
            Rifrish();
            buttonRecord.BackColor = Color.FromArgb(38, 186, 154);
            buttonRecord.Enabled = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Assign_FormClosing(object sender, FormClosingEventArgs e)
        {
            login_ref.Show();
            Hide();
        }

        private void Rifrish()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM oncall", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            buttonView.BackColor = Color.FromArgb(247, 93, 89);
            buttonRecord.BackColor = Color.FromArgb(38, 186, 154);
            buttonRecord.Enabled = false;
            buttonView.Enabled = true;
            increm = 1;
            timer1.Start();
            Rifrish();
        }

        public void vTypeChecker()
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            buttonRecord.BackColor = Color.FromArgb(247, 93, 89);
            buttonView.BackColor = Color.FromArgb(38, 186, 154);
            buttonRecord.Enabled = true;
            buttonView.Enabled = false;
            increm = -1;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVSel_Click(object sender, EventArgs e)
        {
            Hide();
            dialogSel sakyanan = new dialogSel(this);
            sakyanan.Show();
        }
        public void onlySelSHouldCall()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT eName FROM employee WHERE eID NOT IN(SELECT driver FROM oncall where status=0) AND eVehicle = " + valuePassed[0], conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                comboBoxDriver.DisplayMember = "eName";
                comboBoxDriver.DataSource = dt;
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
            textBox1.Text = valuePassed[1];
            comboBoxDriver.Enabled = true;
            button2.Enabled = true;
        }
        int oldxsize = 223;
        int oldysize = 58;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ambot();
            if (oldxsize >= 233 && increm > 0)
            {
                timer1.Stop();
            }
            else if (oldxsize <= -144)
            {
                timer1.Stop();
            }
        }
        private void ambot()
        {
            panel3.Location = new Point(oldxsize += 29 * increm, oldysize);
            panel5.Location = new Point((oldxsize + 266), 302);
            panel1.Location = new Point((oldxsize + 318), 26);
            panel4.Location = new Point((oldxsize - 102), 280);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT eID FROM employee WHERE eName = '" + comboBoxDriver.Text + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                string x = dt.Rows[0]["eID"].ToString();
                conn.Close();
                conn.Open();
                comm = new MySqlCommand("INSERT INTO oncall VALUES (Null," + valuePassed[0] + "," + x + ",CURRENT_TIMESTAMP,NULL,'" + textBoxNote.Text + "',0,0)", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.ToString());
            }
        }

        private void dataGridView1_CellContentDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString().Equals("0"))
            {
                DialogResult r = MessageBox.Show("Do you want to mark this assignemnt complete?'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE onCall SET status=1,arrivedTime=CURRENT_TIMESTAMP", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Rifrish();
                }
            }
        }
    }
}