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

namespace Perias_SAD
{
    public partial class main : Form
    {
        Form upper = new Form();
        DataTable lmfoaooo = new DataTable();
        public main(Form loginDaw, DataTable SAMANIIIII)
        {
            InitializeComponent();
            upper = loginDaw;
            lmfoaooo = SAMANIIIII;
        }

        private void main_Load(object sender, EventArgs e)
        {
            if ("0".Equals(lmfoaooo.Rows[0]["account_type"].ToString()))
                button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            upper.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userMan next2 = new userMan(this);
            Hide();
            next2.Show();
        }
    }
}
