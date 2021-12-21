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
    public partial class dobavl : Form
    {
        static string conStr = "Data Source=ILONA18\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True";
        DataContext context = new DataContext(conStr);
   
        public dobavl()
        {
            InitializeComponent();
            Table<cl> clien = context.GetTable<cl>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl NewService = new cl { Fname = textBox1.Text, Name = textBox2.Text, Lname = textBox3.Text, Dateofbirth = Convert.ToDateTime(textBox4.Text), Town = textBox5.Text, Adress = textBox6.Text, Telephone = Convert.ToInt32(textBox7.Text), Passport = textBox8.Text, NomerID = Convert.ToInt32(textBox9.Text) };
            context.GetTable<cl>().InsertOnSubmit(NewService);
            context.SubmitChanges();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
