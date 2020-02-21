using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Syntax to connect MS Sql Server 2014 with C#
            //Data Source=Servername; Initial Catalog=DBName; Integrated Security=True;

            SqlConnection aa = new SqlConnection("Data Source=FAHAD-PC;Initial Catalog=InvoiceDb;Integrated Security=True");
            aa.Open();
            MessageBox.Show("DB started");
            SqlDataAdapter com = new SqlDataAdapter("SELECT * FROM Customer", aa);
            DataTable dtb = new DataTable();
            com.Fill(dtb);
            dataGridView1.DataSource = dtb;
        }
    }
}
