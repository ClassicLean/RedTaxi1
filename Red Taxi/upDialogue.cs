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
    public partial class upDialogue : Form
    {
        Form z;
        int choice;
        public upDialogue(Form x, int number)
        {
            InitializeComponent();
            z = x;
            choice = number;
        }

        private void upDialogue_Load(object sender, EventArgs e)
        {
            if(choice==1)
            {
                panel2.Hide();
            }
            else
            {
                panel1.Hide();
            }
        }
    }
}
