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
    public partial class HR : Form
    {
        public Form1 reference_to_form1 { get; set; }
        public Employee reference_to_employee { get; set; }
        public Vehicle reference_to_vehicle { get; set; }
        public HR()
        {
            InitializeComponent();
        }

        private void HR_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HR_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_form1.Show();
            this.Hide();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.reference_to_HR = this;
            emp.Show();
            this.Hide();
        }

        private void buttonVehicle_Click(object sender, EventArgs e)
        {
            Vehicle veh = new Vehicle();
            veh.reference_to_HR = this;
            veh.Show();
            this.Hide();
        }
    }
}
