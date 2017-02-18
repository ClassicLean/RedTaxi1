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
        int SearchType = 0;
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
            comboBoxStatus.Text = "";
            comboBoxVehicle.Text = "";
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
                        textBoxCNumber.Text + "','" + textBoxBAmount.Text + "',0)", conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    textBoxPNumber.Clear();
                    comboBoxVehicle.SelectedIndex = 0;
                    textBoxBAmount.Clear();
                    textBoxCNumber.Clear();
                    comboBoxStatus.SelectedIndex = 0;
                    comboBoxVehicle.Text = "";
                    comboBoxStatus.Text = "";
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
            
             
            if (comboBoxVehicle.Text.Equals("") || comboBoxStatus.Text.Equals("")|| textBoxCNumber.Text.Equals("")|| textBoxPNumber.Text.Equals("")|| textBoxBAmount.Text.Equals(""))
            {
                MessageBox.Show("Please input values in all fields");
                throw new Exception("jepoydhizon");
            }

            else 
            {
                vehicle_type = comboBoxVehicle.SelectedIndex;
                status = comboBoxStatus.SelectedIndex;
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
                dataGridView1.Columns["vID"].Visible = false;
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
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM vehicles WHERE plateNum LIKE '" + textBoxSearch.Text+"%'", conn);
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

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchType = comboBoxSearch.SelectedIndex;
            comboBox1.Visible = SearchType == 1;
            textBoxSearch.Clear();
            textBoxSearch.Visible = SearchType != 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM vehicles WHERE vehicleType =" + comboBox1.SelectedIndex, conn);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            upDialogue ups = new upDialogue(this, 1, dataGridView1.Rows[e.RowIndex].Cells);
            ups.Show();
            Hide();
        }
    }
}
