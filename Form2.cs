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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox23.ReadOnly = true;
            textBox24.ReadOnly = true;
            textBox25.ReadOnly = true;
            checkBox2.Enabled = false;
            checkBox1.Enabled = false;

            using (FileStream file = new FileStream("C:\\Users\\t00686038\\Downloads\\GesiStep2.txt", FileMode.Append))
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    write.WriteLine(label2.Text + ": " + textBox4.Text);
                    write.WriteLine(label3.Text + ": " + textBox5.Text);
                    write.WriteLine(label1.Text + ": " + textBox3.Text);
                    write.WriteLine(textBox23.Text);
                    write.WriteLine(textBox24.Text);
                    write.WriteLine(textBox25.Text);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Close();
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Close();
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
