using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanicinin_girdigi_koltuk_numarasiyla_otobuste_yer_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seatno, sec, over, bustype;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lutfen deger giriniz");
            }

            else
            {
                bustype = Convert.ToInt32(textBox1.Text);
                seatno = Convert.ToInt32(textBox2.Text);

                if (radioButton1.Checked == true)
                {
                    if (Convert.ToInt32(textBox1.Text) < 2 || Convert.ToInt32(textBox1.Text) > 4)
                    {
                        MessageBox.Show("Yanlis otobus formati girdiniz. Lutfen tekrar kontrol ederek giriniz( 2 , 3 , 4 )");
                    }

                    else
                    {
                        over = seatno % bustype;
                        sec = seatno / bustype;

                        if (over == 0)
                        {
                            label2.Text = "Sag cam kenari " + sec + ". siradasiniz";
                        }

                        else if (over == 1)
                        {
                            sec = sec + 1;

                            label2.Text = "sol cam kenari " + sec + ". siradasiniz";
                        }

                        else if (over == 2)
                        {
                            sec = sec + 1;

                            label2.Text = "sol koridor kenari " + sec + ". siradasiniz";
                        }

                        else
                        {
                            sec = sec + 1;

                            label2.Text = "Sag koridor kenari " + sec + ". siradasiniz";
                        }
                    }
                }

                else if (radioButton2.Checked == true)
                {
                    if (Convert.ToInt32(textBox1.Text) < 4 || Convert.ToInt32(textBox1.Text) > 8 || Convert.ToInt32(textBox1.Text) == 5 || Convert.ToInt32(textBox1.Text) == 7)
                    {
                        MessageBox.Show("Yanlis otobus formati girdiniz. Lutfen tekrar kontrol ederek giriniz( 4 , 6 , 8 )");
                    }

                    else
                    {
                        over = seatno % bustype;
                        sec = seatno / bustype;

                        if (bustype == 4)
                        {
                            if (seatno <= 29 && seatno > 0)
                            {
                                if (over == 0)
                                {
                                    label2.Text = "1. kat Sag cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 1)
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat sol cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 2)
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat sol koridor kenari " + sec + ". siradasiniz";
                                }

                                else
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat Sag koridor kenari " + sec + ". siradasiniz";
                                }
                            }

                            else if (seatno <= 58 && seatno > 29)
                            {
                                if (over == 0)
                                {
                                    label2.Text = "2. kat Sag cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 1)
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat sol cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 2)
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat sol koridor kenari " + sec + ". siradasiniz";
                                }

                                else
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat Sag koridor kenari " + sec + ". siradasiniz";
                                }
                            }

                            else
                            {
                                MessageBox.Show("Bu otobus formatinda maksimum 58 koltuk bulunmaktadir. Lutfen koltuk numaranizi kontrol ediniz");
                            }
                        }

                        else if (bustype == 6)
                        {
                            if (seatno <= 41)
                            {
                                if (over == 0)
                                {
                                    label2.Text = "1. kat Sag cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 1)
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat sol cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 2)
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat sol koridor kenari " + sec + ". siradasiniz";
                                }

                                else
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat Sag koridor kenari " + sec + ". siradasiniz";
                                }
                            }

                            else if (seatno <= 82 && seatno > 41)
                            {
                                if (over == 0)
                                {
                                    label2.Text = "2. kat Sag cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 1)
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat sol cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 2)
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat sol koridor kenari " + sec + ". siradasiniz";
                                }

                                else
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat Sag koridor kenari " + sec + ". siradasiniz";
                                }
                            }

                            else
                            {
                                MessageBox.Show("Bu otobus formatinda maksimum 82 koltuk bulunmaktadir. Lutfen koltuk numaranizi kontrol ediniz");
                            }
                        }

                        else
                        {
                            if (seatno <= 55)
                            {
                                if (over == 0)
                                {
                                    label2.Text = "1. kat Sag cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 1)
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat sol cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 2)
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat sol koridor kenari " + sec + "siradasiniz";
                                }

                                else
                                {
                                    sec = sec + 1;

                                    label2.Text = "1. kat Sag koridor kenari " + sec + ". siradasiniz";
                                }
                            }

                            else if (seatno <= 110 && seatno > 55)
                            {
                                if (over == 0)
                                {
                                    label2.Text = "2. kat Sag cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 1)
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat sol cam kenari " + sec + ". siradasiniz";
                                }

                                else if (over == 2)
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat sol koridor kenari " + sec + ". siradasiniz";
                                }

                                else
                                {
                                    sec = sec + 1;

                                    label2.Text = "2. kat Sag koridor kenari " + sec + ". siradasiniz";
                                }
                            }

                            else
                            {
                                MessageBox.Show("Bu otobus formatinda maksimum 110 koltuk bulunmaktadir. Lutfen koltuk numaranizi kontrol ediniz");
                            }
                        }
                    }
                     
                }

                else
                {
                    MessageBox.Show("Lutfen otobus bicimi seciniz");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";label2.Text = ""; textBox2.Text = ""; 
            
            if (radioButton1.Checked == true) 
            { 
                radioButton1.Checked = false;
            }

            else
            {
                radioButton2.Checked = false;
            }
        }
    }
}
