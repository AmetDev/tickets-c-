using AVTOGARAJ.Controller;
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

namespace AVTOGARAJ
{
    public partial class Form1 : Form
    {
        Query controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "авто_гаражDataSet.Машина". При необходимости она может быть перемещена или удалена.
            this.машинаTableAdapter.Fill(this.авто_гаражDataSet.Машина);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.FormClosed += Add_FormClosed;
            add.Show();
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            controller.Delete(ID);
            dataGridView1.DataSource = controller.UpdateFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            DataTable dt =  controller.UpdateFirstForUpdate(ID);
            string marka = Convert.ToString(dt.Rows[0]["Марка"]);
            string date = Convert.ToString(dt.Rows[0]["Год"]);
            int number = Convert.ToInt32(dt.Rows[0]["номер_двигателя"]);
            int price = Convert.ToInt32(dt.Rows[0]["цена"]);
            Edit edit = new Edit(ID, marka, date, price,  number);
            edit.FormClosed += Add_FormClosed;
            edit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text.Trim();
            if (search != "")
            {
                DataTable searching = controller.Seacrh(search);
                dataGridView1.DataSource = searching;
                textBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Не введены данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = controller.UpdateFirst();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateFirst();
        }
    }
}
