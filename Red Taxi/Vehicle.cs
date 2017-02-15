using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Taxi
{
    public partial class Vehicle : Form
    {
        public HR reference_to_HR { get; set; }
        public Vehicle()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_HR.Show();
            this.Hide();
        }
    }
}
