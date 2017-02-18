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
        public upDialogue(Form x, int number,DataGridViewCellCollection LAMAN)
        {
            InitializeComponent();
            z = x;
            choice = number;
            yawaka = LAMAN;
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
            if(choice==1)
            {
                ///textBoxPNumber.Text;

            }
        }
    }
}
