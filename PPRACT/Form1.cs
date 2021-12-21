using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace PPRACT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inf f2 = new inf();
            f2.ShowDialog();
        }

        private void Вход_Click(object sender, EventArgs e)
        {
            string login = "f";
            string password = "123";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                Form2 f2 = new Form2(true);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
