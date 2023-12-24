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
   
    public partial class Add : Form
    {
        MonthCalendar monthCalendar = new MonthCalendar();

        Query controller;
        public Add()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.AddLib(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text)); 
        }
        private void DynamicMonthCalendar_DateSelected (object sender, DateRangeEventArgs e)
        {
            textBox3.Text = e.Start.ToShortDateString().ToString();
            this.Controls.Remove(monthCalendar);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Add(monthCalendar);
            monthCalendar.DateSelected += new DateRangeEventHandler(this.DynamicMonthCalendar_DateSelected);
        }
    }
}
