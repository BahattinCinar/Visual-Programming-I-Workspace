using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziyi_ters_cevirme_algoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res, num1, num2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Sayi girmeyi unuttunuz. Lutfen sayi giriniz");
            }

            else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false) 
            {
                MessageBox.Show("Hangi islem yapmak istediginizi secmediniz. Lutfen seciniz");
            }

            else
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                

                if (radioButton2.Checked == true)
                {
                    res = num1 + num2;

                    label4.Text = "Sonucunuz :" + res;
                }

                else if (radioButton1.Checked == true)
                {
                    res = num1 - num2;

                    label4.Text = "Sonucunuz :" + res;
                }

                else if (radioButton4.Checked == true)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Bolum kismi 0 olamaz");
                    }
                    
                    else
                    {
                        res = num1 / num2;

                        label4.Text = "Sonucunuz :" + res;
                    }   
                }

                else
                {
                    res = num1 * num2;

                    label4.Text = "Sonucunuz :" + res;
                }
            }
        }
        
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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
