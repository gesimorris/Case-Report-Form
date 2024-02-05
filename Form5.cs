using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Report_Form
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            using (FileStream file = new FileStream("C:\\Users\\t00686038\\Downloads\\GesiStep5.txt", FileMode.Append))
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    write.WriteLine(label1.Text + ": " + textBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form5 f5 = new Form5();
            f5.Close();
            this.Hide();
            f1.Show();
        }
    }
}
