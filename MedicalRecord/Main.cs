using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalRecord
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login b = new Login();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Record c = new Record();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Register d = new Register();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Reserve f = new Reserve();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Report g = new Report();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Search h = new Search();
            h.Show();
        }
    }
}
