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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "LiuLiu" && textBox2.Text == "123")
            {
                this.Hide();
                Main a = new Main();
                a.Show();
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบชื่อผู้ใช้และรหัสผ่าน");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
