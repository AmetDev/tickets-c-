using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tovar.Controller;

namespace Tovar
{
    public partial class Edit : Form
    {
        Query controller;
        int ID1;
        public Edit(int ID, string name, int number, int count, int price)

        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            textBox1.Text = name;
            textBox2.Text = Convert.ToString(number);
            textBox3.Text = Convert.ToString(count);
            textBox4.Text = Convert.ToString(price);
            ID1 = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.UpdateTovar(ID1, textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле ввода не может содержать цифр");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
                MessageBox.Show("Поле ввода е может содержать букв");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле ввода е может содержать букв");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле ввода е может содержать букв");
            }
        }
    }
}
