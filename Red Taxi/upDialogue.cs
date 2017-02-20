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
        bool choice;
        DataGridViewCellCollection yawaka;
        MySqlConnection conn;
        String vID;
        public upDialogue(Form x, bool number, DataGridViewCellCollection LAMAN)
        {
            InitializeComponent();
            z = x;
            choice = number;
            yawaka = LAMAN;

            conn = new MySqlConnection("Server=172.22.10.202;Database=redtaxi;Uid=root;Pwd=root;");
        }

        private void upDialogue_Load(object sender, EventArgs e)
        {
            panel2.Visible = !choice;
            panel1.Visible = choice;
            if (choice)
            {
                textBoxPNumber.Text = yawaka["plateNum"].Value.ToString();
                comboBoxVehicle.SelectedIndex = int.Parse(yawaka["vehicleType"].Value.ToString());
                textBoxCNumber.Text = yawaka["chasisNumber"].Value.ToString();
                textBoxBAmount.Text = yawaka["boundaryAmount"].Value.ToString();
                comboBoxStatus.SelectedIndex = int.Parse(yawaka["vStatus"].Value.ToString());
                vID = yawaka["vID"].Value.ToString();
            }
            else
            {
                textBox1.Text = yawaka["eName"].Value.ToString();
                textBox2.Text = yawaka["eLicense"].Value.ToString();
                textBox3.Text = yawaka["uName"].Value.ToString();
                textBox4.Text = yawaka["pWord"].Value.ToString();
                dateTimePicker1.Text = yawaka["eBday"].Value.ToString();
                comboBox1.SelectedIndex = int.Parse(yawaka["eType"].Value.ToString());
                comboBox2.SelectedIndex = int.Parse(yawaka["eCivStatus"].Value.ToString());
                comboBox3.SelectedIndex = int.Parse(yawaka["eStatus"].Value.ToString());
                vID = yawaka["eID"].Value.ToString();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            z.Show();
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                MySqlCommand comm;
                if (choice)
                {
                    comm = new MySqlCommand("UPDATE vehicles SET plateNum='" + textBoxPNumber.Text + "',vehicleType='" +
                        comboBoxVehicle.SelectedIndex + "',chasisNumber='" + textBoxCNumber.Text + "',boundaryAmount='" + textBoxBAmount.Text + "',vStatus=" +
                        comboBoxStatus.SelectedIndex + " WHERE vID=" + vID, conn);
                    comm.ExecuteNonQuery();
                    if (comboBoxStatus.SelectedIndex!=0)
                    {
                        comm = new MySqlCommand("UPDATE oncall set status=1,arrivedTime=CURRENT_TIMESTAMP WHERE vehicle=" + vID, conn);
                        comm.ExecuteNonQuery();
                    }
                }
                else
                {
                    comm = new MySqlCommand("UPDATE employee SET eName='"+ textBox1.Text + "', eLicense='"+
                    textBox2.Text+"', uName='" + textBox3.Text + "', pword='" + textBox4.Text + "',eBday='"+ 
                    dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',eType='"+comboBox1.SelectedIndex+
                    "', eCivStatus='"+comboBox2.SelectedIndex+ "',eStatus = '" + comboBox3.SelectedIndex+
                    "' WHERE eID=" + vID, conn);
                    comm.ExecuteNonQuery();
                    if (comboBox3.SelectedIndex != 0)
                    {
                        comm = new MySqlCommand("UPDATE oncall set status=1,arrivedTime=CURRENT_TIMESTAMP WHERE driver=" + vID, conn);
                        comm.ExecuteNonQuery();
                    }
                }
                conn.Close();
                buttonLogout_Click(sender, e);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
        }
    }
}
