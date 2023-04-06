using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_6_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,start, end, increase, reserve, sum = 0;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lutfen deger giriniz");
            }

            else
            {
                start = Convert.ToInt32(textBox1.Text);
                end = Convert.ToInt32(textBox2.Text);
                increase = Convert.ToInt32(textBox3.Text);

                if (start > end) 
                {
                    reserve = start;
                    start = end;
                    end = reserve;

                    if (increase <= 0)
                    {
                        MessageBox.Show("Artis miktari 0 veya kucuk olamaz");
                    }

                    else
                    {
                        if (listBox1.Items.Count >= 1)
                        {
                            listBox1.Items.Clear();

                            for (i = start; i <= end; i += increase)
                            {
                                sum = sum + i;

                                listBox1.Items.Add(i);
                            }
                            label1.Text = "Toplam :" + sum;
                        }

                        else
                        {
                            for (i = start; i <= end; i += increase)
                            {
                                sum = sum + i;

                                listBox1.Items.Add(i);
                            }
                            label1.Text = "Toplam :" + sum;
                        }
                    }
                }

                else
                {
                    if (increase <= 0)
                    {
                        MessageBox.Show("Artis miktari 0 veya kucuk olamaz");
                    }

                    else
                    {
                        if (listBox1.Items.Count >= 1)
                        {
                            listBox1.Items.Clear();

                            for (i = start; i <= end; i += increase)
                            {
                                sum = sum + i;

                                listBox1.Items.Add(i);
                            }
                            label1.Text = "Toplam :" + sum;
                        }

                        else
                        {
                            for (i = start; i <= end; i += increase)
                            {
                                sum = sum + i;

                                listBox1.Items.Add(i);
                            }
                            label1.Text = "Toplam :" + sum;
                        }
                    }
                }
            }
        }

        
    }
}
