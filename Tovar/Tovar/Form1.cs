using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tovar.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Tovar
{
    public partial class Form1 : Form
    {
        Query controller;

        public Form1()
        {
            controller = new Query(ConnectionString.ConnStr);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "склад_товаровDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.склад_товаровDataSet.Товар);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.FormClosed += Add_FormClosed;
            add.Show();
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateVoid();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            controller.DeleteTover(ID);
            dataGridView1.DataSource =  controller.UpdateVoid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
           DataTable dataTable =  controller.UpdateVoidForUpdate(ID);
            string name = Convert.ToString(dataTable.Rows[0]["Наименование"]);
            int number = Convert.ToInt32(dataTable.Rows[0]["Номер"]);
            int count = Convert.ToInt32(dataTable.Rows[0]["Количество"]);
            int price = Convert.ToInt32(dataTable.Rows[0]["Цена"]);
            Edit edit = new Edit(ID,  name,  number,  count,  price);
            edit.FormClosed += Add_FormClosed;
            edit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
