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
    public partial class redactcs : Form
    {
        static string conStr = "Data Source=ILONA18\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True";
        DataContext context = new DataContext(conStr);
        Form2 form2;
        public redactcs(Form2 form)
        {
            InitializeComponent();
            form2 = form;
            cl currentClient = context.GetTable<cl>().FirstOrDefault(
x => x.ID == Convert.ToInt32(form2.dataGridView1.CurrentRow.Cells[0].Value));
            textBox1.Text = currentClient.Fname;
            textBox2.Text = Convert.ToString(currentClient.Name);
            textBox3.Text = Convert.ToString(currentClient.Lname);
            textBox4.Text = Convert.ToString(currentClient.Dateofbirth);
            textBox5.Text = Convert.ToString(currentClient.Town);
            textBox6.Text = currentClient.Adress;
            textBox7.Text = Convert.ToString(currentClient.Telephone);
            textBox8.Text = Convert.ToString(currentClient.Passport);
            textBox9.Text = Convert.ToString(currentClient.NomerID);
            Table<cl> client = context.GetTable<cl>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl currentClient = context.GetTable<cl>().FirstOrDefault(
x => x.ID == Convert.ToInt32(form2.dataGridView1.CurrentRow.Cells[0].Value));
            currentClient.Fname = textBox1.Text;
            currentClient.Name = textBox2.Text;
            currentClient.Lname = textBox3.Text;
            currentClient.Dateofbirth = Convert.ToDateTime(textBox4.Text);
            currentClient.Town = textBox5.Text;
            currentClient.Adress = textBox6.Text;
            currentClient.Telephone = Convert.ToInt32(textBox7.Text);
            currentClient.Passport = textBox8.Text;
            currentClient.NomerID = Convert.ToInt32(textBox9.Text);
            context.SubmitChanges();
            Table<cl> client = context.GetTable<cl>();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
