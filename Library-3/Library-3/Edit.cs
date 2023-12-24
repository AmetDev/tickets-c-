using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_3
{
    public partial class Edit : Form
    {
        Query controller;
        MonthCalendar monthCalendar = new MonthCalendar();
        int ID1;
        public Edit(int ID, string author, string name, string date, int count)
        {

            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            ID1 = ID;
            textBox1.Text = author;
            textBox2.Text = name;
            textBox3.Text = date;
            textBox4.Text= Convert.ToString(count);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.EditLib(ID1, textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Add(monthCalendar);
            monthCalendar.DateSelected += new DateRangeEventHandler (this.MonthCalendar_DateSelected);
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox3.Text = e.Start.ToShortDateString().ToString();
            this.Controls.Remove(monthCalendar);

        }
    }
}
