using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_3
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "библиотекаDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.библиотекаDataSet.Книга);

        }
        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateLib();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.FormClosing += FormClosing;
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.RemoveLib(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            dataGridView1.DataSource = controller.UpdateLib();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            DataTable dt = controller.UpdateLibFor(ID);
            //dt.Rows[0]["количество_машин"]
            Edit edit  = new Edit(ID, Convert.ToString(dt.Rows[0]["автор"]), Convert.ToString(dt.Rows[0]["Название"]), Convert.ToString(dt.Rows[0]["Год"]), Convert.ToInt32(dt.Rows[0]["Страниц"]));
            edit.FormClosing += FormClosing;
            edit.Show();

        }
    }
}
