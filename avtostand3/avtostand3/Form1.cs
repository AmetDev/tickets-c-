using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static avtostand3.GlobalVariables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace avtostand3
{
    public partial class Form1 : Form
    {
        Query controller;
        public static int MiGlobalVariable;
      
        public Form1(bool name)
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtostandDataSet.автостоянка". При необходимости она может быть перемещена или удалена.
            this.автостоянкаTableAdapter.Fill(this.avtostandDataSet.автостоянка);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add ss = new Add();
            ss.FormClosing += SecondForm_Closing;
            ss.Show();
          
           
        }
        private void SecondForm_Closing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateAvto();
            MessageBox.Show("Форма будет закрыта");
        }
        private void SecondForm_Closing1(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateAvto();
            MessageBox.Show("Форма будет закрыта");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.DeleteAvto(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            dataGridView1.DataSource = controller.UpdateAvto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID= int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            DataTable dt = controller.GetUpdate(ID);
      
                Edit d2 = new Edit(ID, Convert.ToInt32(dt.Rows[0]["количество_машин"]), Convert.ToString(dt.Rows[0]["название_стоянок"]), Convert.ToInt32(dt.Rows[0]["допустимое_количество"]), Convert.ToInt32(dt.Rows[0]["плата"]), Convert.ToString(dt.Rows[0]["город"]));
                d2.FormClosing += SecondForm_Closing1;
                d2.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
