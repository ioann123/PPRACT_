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
using System.Data.SqlClient;
using System.Data.Common;

namespace PPRACT
{
    public partial class inf : Form
    {
        //dataGridView1.AutoGenerateColumns = true;
        static string conStr = "Data Source=ILONA18\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True";
        DataContext context = new DataContext(conStr);
        //SQLiteConnection dbConnection = new SQLiteConnection("Data Source=ILONA18\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
        //dbConnection.Open();

        public inf()
        {
            InitializeComponent();
            Table<n> nomer = context.GetTable<n>();
            dataGridView1.DataSource = context.GetTable<n>().ToList();
            //dataGridView1.DataSource = null;
            //dataGridView1.Columns.Clear();
            //dataGridView1.Rows.Clear();
            //n adp = new n { ("SELECT client, additionalServices FROM  Fname, Services where Services = Services", dbConnection) };
            //DataTable dt = new DataTable();
            //adp.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dbConnection.Close();
        }

        private void inf_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<n> nomer = null;
            switch (comboBox1.SelectedIndex)
            {
                case 0: nomer = context.GetTable<n>().Where(x => x.Price <=1500 && x.Price > 0).ToList(); break;
                case 1: nomer = context.GetTable<n>().Where(x => x.Price <= 2000 && x.Price > 1500).ToList(); break;
                case 2: nomer = context.GetTable<n>().Where(x => x.Price <=3000 && x.Price >2000).ToList(); break;
                case 3: nomer = context.GetTable<n>().Where(x => x.Price <=3500 && x.Price > 3000).ToList(); break;
                case 4: nomer = context.GetTable<n>().Where(x => x.Price <= 3500 && x.Price > 0).ToList(); break;
            }
            dataGridView1.DataSource = nomer;
        }
    }
}
