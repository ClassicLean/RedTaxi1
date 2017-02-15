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
        public Operator reference_to_operator { get; set; }
        public MySqlConnection conn;
        int vehicle_type = 0;

        public Assign()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=10.4.42.236;Database=redtaxi;Uid=root;Pwd=root;");
        }

        private void Assign_Load(object sender, EventArgs e)
        {
            Rifrish();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Assign_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_operator.Show();
            this.Hide();
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
            
            try
            {
                DialogResult r = MessageBox.Show("Do you want to record driver '" + textBoxDriver.Text + "'?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (r == DialogResult.Yes)
                {
                    lmfao();
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO oncall(vehicle,driver,note) VALUES('" + vehicle_type + "','" +
                        int.Parse(textBoxDriver.Text) + "','" + textBoxNote.Text + "')", conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                }
                Rifrish();
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        public void lmfao()
        {
            /*
             * 
                Single motorcycle
                Tricycle
                Common
                Van
                Mini Truck
             * */
            if (comboBoxVehicle.Text == "Single motorcycle")
            {
                vehicle_type = 0;
            }

            else if (comboBoxVehicle.Text == "Tricycle")
            {
                vehicle_type = 1;
            }

            else if (comboBoxVehicle.Text == "Common")
            {
                vehicle_type = 2;
            }

            else if (comboBoxVehicle.Text == "Van")
            {
                vehicle_type = 3;
            }

            else if (comboBoxVehicle.Text == "Mini Truck")
            {
                vehicle_type = 4;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM oncall WHERE driver = " + textBoxSearch.Text, conn);
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
    }
}
