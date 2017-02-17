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
    public partial class Operator : Form
    {
        public Form1 reference_to_form1 { get; set; }
        public Assign reference_to_assign { get; set; }
        public Operator()
        {
            InitializeComponent();
        }

        private void Operator_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Operator_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference_to_form1.Show();
            //Hide();
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            Assign ass = new Assign();
            ass.reference_to_operator = this;
            ass.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
