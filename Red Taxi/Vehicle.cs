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
    public partial class Vehicle : Form
    {
        public HR reference_to_HR { get; set; }
        public MySqlConnection conn;
        int vehicle_type = 0;
        int status = 0;

        public Vehicle()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=redtaxi;Uid=root;Pwd=root;");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            Rifrish();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_HR.Show();
            Hide();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do you want to insert new vehicle information ?'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (r == DialogResult.Yes)
                {
                    Checker();
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO vehicles(plateNum,vehicleType,chasisNumber,boundaryAmount, vStatus) VALUES('" + 
                        textBoxPNumber.Text + "','" + vehicle_type + "','" + 
                        textBoxCNumber.Text + "','" + textBoxBAmount.Text + "','" + 
                        status + "')", conn);
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

        public void Checker()
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

            if (comboBoxStatus.Text == "Active")
            {
                status = 0;
            }

            else if (comboBoxStatus.Text == "Repair")
            {
                status = 1;
            }

            else if (comboBoxStatus.Text == "Decomission")
            {
                status = 2;
            }
        }

        private void Rifrish()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM vehicles", conn);
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
            if (textBoxSearch.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM vehicles WHERE vehicleType = " + textBoxSearch.Text, conn);
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

            else
            {
                Rifrish();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            upDialogue ups=new upDialogue(this, 1);
        }
    }
}
