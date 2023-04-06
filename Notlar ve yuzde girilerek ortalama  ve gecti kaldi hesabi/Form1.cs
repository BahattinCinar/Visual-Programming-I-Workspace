using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workspace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, vizeyuz, final, finalyuz, a, b, c, odev, odevyuz;

            vize = Convert.ToByte( textBox1.Text);
            vizeyuz = Convert.ToByte( textBox3.Text );
            final = Convert.ToByte( textBox2.Text );
            finalyuz = Convert.ToByte(textBox4.Text);
            odev = Convert.ToByte( textBox5.Text );

            a = finalyuz + vizeyuz;
            b = ((vize * vizeyuz) + (final * finalyuz))/100;
            
            if (final < 0 || final > 100 || finalyuz < 0 || finalyuz > 100 || vize < 0 || vize > 100 || vizeyuz < 0 || vizeyuz > 100 )
            {
                MessageBox.Show("degerlerinizi kontrol ediniz (100 den küçük 0 dan büyük olması lazım)");
            }
            else
            {
                if (a < 100)
                {
                    odevyuz = 100 - a;

                    b = b + (odev * odevyuz) / 100;

                    if (b >= 49.5)
                    {
                        label7.Text = "Tebrikler " + b + "ortalama ile gectiniz";
                    }

                    else
                    {
                        c = 50 - b;

                        label7.Text = "Üzgünüm malesef " + c + " puanla kaçırdınız. Ortalamanız :" + b;
                    }

                }

                else
                {

                    if (b >= 49.5)
                    {
                        label7.Text = "Tebrikler " + b + "ortalama ile gectiniz";
                    }

                    else
                    {
                        c = 50 - b;

                        label7.Text = "Üzgünüm malesef " + c + " puanla kaçırdınız. Ortalamanız :" + b;
                    }

                }
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
