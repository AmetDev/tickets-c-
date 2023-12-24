using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtostand3
{
   
    public partial class Edit : Form
    {

        Query controller;
        int ID1;
        public Edit(int ID, int count, string name, int count_max, int price, string city)
        {
            InitializeComponent();
            ID1 = ID;
            textBox1.Text = Convert.ToString(count);
            textBox2.Text = Convert.ToString(name);
            textBox3.Text = Convert.ToString(count_max);
            textBox4.Text = Convert.ToString(price);
            textBox5.Text = Convert.ToString(city);
            controller = new Query(ConnectionString.ConnStr);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            controller.EditAvto(Convert.ToInt32(ID1), Convert.ToInt32(textBox1.Text), Convert.ToString(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToString(textBox5.Text));
        }
    }
}
