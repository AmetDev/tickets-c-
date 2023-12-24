using AVTOGARAJ.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVTOGARAJ
{
    public partial class Edit : Form
    {
        Query controller;
        int ID1;
        public Edit(int ID, string marka, string date, int price, int nubmer)
        {

            InitializeComponent();
            ID1 = ID;
            controller = new Query(ConnectionString.ConnStr);
            textBox1.Text = marka;
            textBox2.Text = date;
            textBox3.Text = Convert.ToString(price);
            textBox4.Text = Convert.ToString(nubmer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Edit(ID1, textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
        }
    }
}
