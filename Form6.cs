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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Close();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {






        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        protected void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if(textBox11.Text != null)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox9.ReadOnly = true;
            button7.Enabled = true;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;

            using (FileStream file = new FileStream("C:\\Users\\t00686038\\Downloads\\GesiStep1.txt", FileMode.Create))
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    write.WriteLine(label1.Text + ": " + textBox4.Text);
                    write.WriteLine(label2.Text + ": " + textBox3.Text);
                    write.WriteLine(label3.Text + ": " + textBox10.Text);
                    write.WriteLine(label4.Text + ": " + textBox7.Text);
                    write.WriteLine(label5.Text + ": " + textBox8.Text);
                    write.WriteLine(label6.Text + ": " + textBox9.Text);
                    write.WriteLine(label7.Text + ": " + textBox2.Text);
                    write.WriteLine(label8.Text + ": " + textBox5.Text);
                    write.WriteLine(label9.Text + ": " + textBox6.Text);
                    write.WriteLine(label10.Text + ": " + textBox15.Text);
                    write.WriteLine(textBox11.Text);
                    write.WriteLine(textBox12.Text);
                    write.WriteLine(textBox13.Text);
                }
            }
                
            {

            }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(FileStream file1 = new FileStream("C:\\Users\\t00686038\\Downloads\\GesiStep1.txt", FileMode.Open))
            {
                using(StreamReader r = new StreamReader(file1))
                {
                    while (r.EndOfStream)
                    {
                        String line = r.ReadLine();
                        textBox10.Text = line;
                        
                        // Can't get other texts to other boxes
                    }
                }
                
            }
        }
    }
    }

