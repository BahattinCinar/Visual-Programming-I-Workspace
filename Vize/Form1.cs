using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Vize_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult exit;

            exit = MessageBox.Show("cikmak istiyor musunuz", "Cikis ekrani", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i=0,baslangic, bitis, mod, toplam = 0, hata=0, kulsayi, yedek;

            if(textBox1.Text == "")
            {
                MessageBox.Show("Baslangic sayisini girmediniz");
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bitis sayisini girmediniz");
            }

            else
            {
                baslangic = Convert.ToInt32(textBox1.Text);
                bitis = Convert.ToInt32(textBox2.Text);

                for(; ; )
                {
                    i++;
                    
                    if (hata == 3 || toplam >= 300 || toplam <= -200)
                    {
                        Application.Exit();
                    }

                    kulsayi = Convert.ToInt32(Interaction.InputBox(i + ". Sayinizi giriniz(0 girerseniz isleminiz sonlanir)", "Sayi giris ekrani", "0", 125, 125));

                    mod = kulsayi % 2;

                    
                    if (kulsayi == 0)
                    {
                        break;
                    }

                    else if (baslangic > bitis)
                    {
                        yedek = baslangic;
                        baslangic = bitis;
                        bitis = yedek;

                        if (kulsayi < baslangic || kulsayi > bitis)
                        {
                            hata++;
                            MessageBox.Show("Hatali giris yaptiniz. " + (3 - hata) + " kadar hakkiniz kaldi");
                        }

                        else if (mod == 0)
                        {
                            toplam = toplam + kulsayi;
                        }

                        else if (mod == 1)
                        {
                            toplam = toplam - kulsayi;
                        }

                        listBox1.Items.Add(i + ". Sayi girisi sonuclari");
                        listBox1.Items.Add(i + ". Girilen sayinin toplami : " + toplam);
                        listBox1.Items.Add("toplam hata miktari" + hata);
                        listBox1.Items.Add("Kalan Hata Miktariniz : " + (3 - hata));
                        listBox1.Items.Add("------------------------------------------");
                    }

                    else
                    {
                        if (kulsayi < baslangic || kulsayi > bitis)
                        {
                            hata++;
                            MessageBox.Show("Hatali giris yaptiniz. " + (3 - hata) + " kadar hakkiniz kaldi");
                        }

                        else if (mod == 0)
                        {
                            toplam = toplam + kulsayi;
                        }

                        else if (mod == 1)
                        {
                            toplam = toplam - kulsayi;
                        }

                        listBox1.Items.Add(i + ". Sayi girisi sonuclari");
                        listBox1.Items.Add(i + ". Girilen sayinin toplami : " + toplam);
                        listBox1.Items.Add("toplam hata miktari" + hata);
                        listBox1.Items.Add("Kalan Hata Miktariniz : " + (3 - hata));
                        listBox1.Items.Add("------------------------------------------");
                    }
                }
            }
        }
    }
}
