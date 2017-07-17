using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;//ilk önce textboxla gireceğimiz sayıyı belirtiyoruz
            int sayac = 0;
            sayı = Convert.ToInt32(textBox1.Text);

            for (int i = 2; i < sayı; i++)//Bu döngüde kendisi ve 1 olmaması için döngüyü bu şekil yapıyoruz
            {
                if (sayı % i == 0)//eğer sayının 2 ve kendısı arasında başka bir böleni var ise;
                {
                    sayac++;//sayacı 1 artırıyoruz

                }
                if (sayac == 0) //eğer bölümü yok ise sayaç sıfırda kalır ve sayac sıfırıle eşit ise
                { 
                    label2.Text = sayı + ".Sayı Asaldır."; //sayı asal değildir kendisiyle ve 1den başka sayıya bölünemez
                }
                else 
                {
                    label2.Text = sayı + ".Sayı Asal Değildir."; //eğer sayaç 1 ve yüksekse demekki başka bir sayıya bölünebilir bu sayıda asal değildir.
                
                }
            }
               


            }
        }
    }

