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
    public partial class dialogSel : Form
    {
        public MySqlConnection conn;
        private int SearchType;
        public string[] Results = new string[2];
        Assign upper;
        public dialogSel(Assign x)
        {
            InitializeComponent();
            upper = x;
            conn = new MySqlConnection("Server=172.22.10.202;Database=redtaxi;Uid=root;Pwd=root;");
        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchType = comboBoxVehicle.SelectedIndex;
            comboBox1.Visible = SearchType == 2;
            comboBox1.SelectedIndex = 0;
            textBoxSearch.Clear();
            textBoxSearch.Visible = SearchType != 2;
            magikero();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                try
                {
                    MySqlCommand comm;
                    conn.Open();
                    string searchMaster3000="";
                    switch (SearchType)
                    {
                        case 0:
                            searchMaster3000= "plateNum LIKE '" + textBoxSearch.Text + "%'";
                            break;
                        case 1:
                            searchMaster3000 = "chasisNumber LIKE '" +textBoxSearch.Text + "%'";
                            break;
                        default:
                            throw new Exception();
                    }
                    comm = new MySqlCommand("SELECT vId,plateNum,vehicleType,chasisNumber,boundaryAmount FROM vehicles WHERE "+searchMaster3000+" AND "+
                        "vStatus=0 AND vID IN (select eVehicle from employee) AND vID NOT IN (select vehicle from oncall where status = 0)", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ee)
                {
                    //MessageBox.Show(ee.ToString());
                    conn.Close();
                }
            }
            else
            {
                magikero();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Results[0]=dataGridView1.Rows[e.RowIndex].Cells["vID"].Value.ToString();
            Results[1] = dataGridView1.Rows[e.RowIndex].Cells["plateNum"].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            upper.Show();
            Close();
        }

        private void buttonVSel_Click(object sender, EventArgs e)
        {
            if (Results.Length > 0)
            {
                upper.valuePassed = Results;
                upper.onlySelSHouldCall();
            }
            button2_Click(sender, e);
        }

        private void dialogSel_Load(object sender, EventArgs e)
        {
            magikero();
        }
        private void magikero()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("select * from vehicles where vID IN (select eVehicle from employee) AND vID NOT IN (select vehicle from oncall where status = 0)", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                dataGridView1.ClearSelection();
            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT vId,plateNum,vehicleType,chasisNumber,boundaryAmount FROM vehicles WHERE vehicleType = " + comboBox1.SelectedIndex + " AND " +
                        "vStatus=0 AND vID IN (select eVehicle from employee) AND vID NOT IN (select vehicle from oncall where status = 0)", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Results.Length > 0)
            {
                upper.valuePassed = Results;
                upper.onlySelSHouldCall();
            }
            button2_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e);
        }
    }
}
