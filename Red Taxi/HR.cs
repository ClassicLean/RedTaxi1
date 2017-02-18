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
        int oldxsize = 0;
        int oldysize = 0;
        int increm = -1;
        public HR()
        {
            InitializeComponent();
            panel3.Size = new Size(0, 0);
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
            int yawa = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            increm = increm * -1;
            timer1.Start();
            yawa++;
            if (yawa == 10)
            {
                MessageBox.Show("yawa ka, undangi na");
                yawa = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Size = new Size(oldxsize+=8*increm, oldysize+=80*increm);
            if (oldxsize >= 136 && oldysize >= 191 && increm > 0)
            {
                timer1.Stop();
            }
            else if (oldxsize == 0 && oldysize == 0)
            {
                timer1.Stop();
            }
        }
    }
}
