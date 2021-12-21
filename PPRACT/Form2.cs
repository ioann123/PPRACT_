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
    public partial class Form2 : Form
    {
        static string conStr = "Data Source=ILONA18\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True";
        public int id;
        DataContext context = new DataContext(conStr);
        public Form2(bool isAdmin)
        {
            InitializeComponent();
            if (isAdmin == true)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;

            }
            Table<cl> client = context.GetTable<cl>();
            dataGridView1.DataSource = client.ToList();
            dataGridView1.DataSource = context.GetTable<cl>().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ud = MessageBox.Show("Вы точно хотите удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (ud == DialogResult.Yes)
            {
                cl currentAccount = context.GetTable<cl>().FirstOrDefault(
                x => x.ID == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                context.GetTable<cl>().DeleteOnSubmit(currentAccount);
                context.SubmitChanges();
                dataGridView1.DataSource = context.GetTable<cl>().ToList();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.prDataSet.client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dobavl d = new dobavl();
            d.ShowDialog();
            dataGridView1.DataSource = context.GetTable<cl>().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var f = context.GetTable<cl>().Where(x => x.NomerID.Contains(comboBox1.SelectedValue);
            //dataGridView1.DataSource = f.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redactcs f3 = new redactcs(this);
            f3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bronir f3 = new bronir();
            f3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var f = context.GetTable<cl>().Where(x => x.Town.Contains(textBox1.Text));
            dataGridView1.DataSource = f.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
