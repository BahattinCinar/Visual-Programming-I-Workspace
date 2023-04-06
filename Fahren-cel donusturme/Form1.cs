using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cel_Fah_convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fah, cel, value;

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Bir islem turu seciniz");
            }

            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lutfen deger alanini bos gecmeyiniz");
            }
            
            else 
            {
                if (radioButton1.Checked == true)
                {
                    cel = Convert.ToInt32(textBox1.Text);

                    fah = (cel * 9 / 5) + 32;

                    label4.Text = cel.ToString();
                    label5.Text = fah.ToString();
                    
                    if(label7.Text != "")
                    {
                        label6.Text = "";
                        label7.Text = "";
                    }
                }

            else if (radioButton2.Checked == true)
                {
                    fah = Convert.ToInt32(textBox1.Text);

                    cel = (fah - 32) * 5 / 9;

                    label4.Text = cel.ToString();
                    label5.Text = fah.ToString();
                    
                    if (label7.Text != "")
                    {
                        label6.Text = "";
                        label7.Text = "";
                    }
                }

                else
                {
                    value = Convert.ToInt32(textBox1.Text);

                    fah = (value * 9 / 5) + 32;

                    cel = (value - 32) * 5 / 9;

                    label4.Text = cel.ToString();
                    label5.Text = fah.ToString();
                    label6.Text = "Girdiginiz deger = ";
                    label7.Text = value.ToString();
                }
            }

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
