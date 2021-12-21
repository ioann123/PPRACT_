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
    public partial class bronir : Form
    {
        static string conStr = "Data Source=ILONA18\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True";
        DataContext context = new DataContext(conStr);
        public bronir()
        {
            InitializeComponent();
            Table<reserv> rez = context.GetTable<reserv>();
            dataGridView1.DataSource = rez.ToList();
            dataGridView1.DataSource = context.GetTable<reserv>().ToList();
        }

        private void bronir_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prDataSet.additionalServices". При необходимости она может быть перемещена или удалена.
            this.additionalServicesTableAdapter.Fill(this.prDataSet.additionalServices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.prDataSet.client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reserv reservat = new reserv { Client = Convert.ToInt32(comboBox1.SelectedValue), Date_check_in = Convert.ToDateTime(dateTimePicker1.Value), Date_eviction = Convert.ToDateTime(dateTimePicker2.Value), additionalServices = Convert.ToInt32(comboBox3.SelectedValue), Cost = Convert.ToInt32(textBox1.Text) };
            context.GetTable<reserv>().InsertOnSubmit(reservat);
            context.SubmitChanges();
            dataGridView1.DataSource = context.GetTable<reserv>().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ud = MessageBox.Show("Вы точно хотите удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (ud == DialogResult.Yes)
            {
                reserv currentAccount = context.GetTable<reserv>().FirstOrDefault(
                x => x.ID == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                context.GetTable<reserv>().DeleteOnSubmit(currentAccount);
                context.SubmitChanges();
                dataGridView1.DataSource = context.GetTable<reserv>().ToList();
            }
        }
    }
}
