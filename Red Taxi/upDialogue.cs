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
    public partial class upDialogue : Form
    {
        Form z;
        int choice;
        DataGridViewCellCollection yawaka;
        MySqlConnection conn;
        public upDialogue(Form x, int number,DataGridViewCellCollection LAMAN)
        {
            InitializeComponent();
            z = x;
            choice = number;
            yawaka = LAMAN;
            conn = new MySqlConnection("Server=localhost;Database=redtaxi;Uid=root;Pwd=root;");
        }

        private void upDialogue_Load(object sender, EventArgs e)
        {
            panel2.Visible = choice != 1;
            panel1.Visible = choice == 1;
            if(choice==1)
            {
                textBoxPNumber.Text = yawaka["plateNum"].Value.ToString();
                comboBoxVehicle.SelectedIndex = int.Parse(yawaka["vehicleType"].Value.ToString());
                textBoxCNumber.Text= yawaka["chasisNumber"].Value.ToString();
                textBoxBAmount.Text= yawaka["boundaryAmount"].Value.ToString();
                comboBoxStatus.SelectedIndex= int.Parse(yawaka["vStatus"].Value.ToString());
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            z.Show();
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           /* if(choice==1)
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE vehicles SET plateNum='" + textBoxPNumber.Text + "',vehicleType='" +
                        comboBoxVehicle.SelectedIndex+ "',chasisNumber='" + textBoxCNumber.Text + "',boundaryAmount='" + textBoxBAmount.Text + "',vStatus=" +
                        comboBoxStatus.SelectedIndex  + " WHERE vID=" + yawaka["vID"].Value.ToString(), conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Rifrish();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Please contact ...");
                    conn.Close();
                }
                textBoxPNumber.Text

            }*/
        }
    }
}
