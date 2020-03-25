using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obs_Mail_Gönderme
{
    public partial class Form1 : Form
    {
        #region Tanımlamalar

        Personel personel = new Personel();
        Öğrenci öğrenci = new Öğrenci();


        public static string[] personelno = new string[20];
        public static string[] personelşifre = new string[20];
        public static string[] öğrencino = new string[20];
        public static string[] öğrencişifre = new string[20];
        public static string[] öğrencimail = new string[20];
        public static string[] mailşifre = new string[20];


        #endregion

        #region Değişkenler

        public static string personelnoo,personelşifree,öğrencinoo,öğrencişifree;


        #endregion

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personelno[0] = "1111";
            personelşifre[0] = "1111";
            öğrencino[0] = "1111";
            öğrencişifre[0] = "1111";
            öğrencimail[0] = "muratbilginer09@gmail.com";
            mailşifre[0] = "xenon2600";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int d = 0;
            int b = -1;
            int c = -1;

            personelnoo = textBox1.Text;
            personelşifree = textBox2.Text;

            foreach (string no in personelno)
            {
                b++;

                if (personelnoo==no)
                {
                    a++;
                    break;
                }
            }

            foreach (string sifre in personelşifre)
            {
                c++;
                if (personelşifree == sifre)
                {
                    d++;
                    break;
                }
            }

            if (b==c && a!=0)
            {
                this.Hide();
                personel.ShowDialog();
                this.Show();
            }

            else
            {
                label5.Text = "Yanlış Personel No veya Şifre girdiniz.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0, f=0, g=-1, h=-1;

            öğrencinoo = textBox3.Text;
            öğrencişifree = textBox4.Text;

            foreach (string no in öğrencino)
            {
                g++;

                if (öğrencinoo == no)
                {
                    k++;
                    break;
                }
            }

            foreach (string sifre in öğrencişifre)
            {
                h++;
                if (öğrencişifree == sifre)
                {
                    f++;
                    break;
                }
            }

            if (g == h && k != 0)
            {
                this.Hide();
                öğrenci.ShowDialog();
                this.Show();
            }

            else
            {
                label6.Text = "Yanlış Öğrenci No veya Şifre girdiniz.";
            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
