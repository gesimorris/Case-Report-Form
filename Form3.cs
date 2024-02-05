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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            using (FileStream file = new FileStream("C:\\Users\\t00686038\\Downloads\\GesiStep3.txt", FileMode.Append))
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    write.WriteLine(label1.Text + ": " + textBox6.Text);
                    write.WriteLine(label2.Text + ": " + textBox7.Text);
                    write.WriteLine(label3.Text + ": " + textBox8.Text);
                    write.WriteLine(label4.Text + ": " + textBox9.Text);
                    write.WriteLine(label5.Text + ": " + textBox10.Text);
                    write.WriteLine(label6.Text + ": " + textBox16.Text);
                    write.WriteLine(label10.Text + ": " + textBox17.Text);
                    write.WriteLine(textBox18.Text);
                    write.WriteLine(textBox19.Text);
                    write.WriteLine(textBox20.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Close();
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
