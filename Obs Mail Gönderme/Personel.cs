using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Net.Sockets;

namespace Obs_Mail_Gönderme
{
    public partial class Personel : Form
    {
        #region Değişkenler

        int a = 1;
        public static int mailgönderildimi = 0;

        #endregion

        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" &&textBox3.Text!="" &&textBox4.Text!="")
            {
                Form1.öğrencino[a]=textBox1.Text;
                Form1.öğrencişifre[a]=textBox1.Text;
                Form1.öğrencimail[a]=textBox1.Text;
                Form1.mailşifre[a]=textBox1.Text;
                label5.Text = "Kayıt Başarılı";
                a++;
            }

            else
            {
                label5.Text = "Boş alan bıramazsınız";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MailMessage Mesaj = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("mrt_bilginer@hotmail.com", "gelisim2600");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;

            Mesaj.To.Add("muratbilginer09@gmail.com");
            Mesaj.From = new MailAddress("mrt_bilginer@hotmail.com");
            Mesaj.Subject = "Test";
            Mesaj.Body = "Test";
            smtp.Send(Mesaj);


            //for (int i = 0; i < Form1.öğrencino.Length; i++)
            //{
            //    if (Form1.öğrencimail[i]!=null)
            ////    {
            //        try
            //        {

            //            SmtpClient baglanti = new SmtpClient();
            //            MailMessage mesaj = new MailMessage();
            //            mesaj.To.Add("mbilginer@industryolog.com");// niz herhangi bir hesap, hotmail, isim@alanadi.com  vs hesap farketmez
            //            mesaj.From = new MailAddress("muratbilginer09@gmail.com"); //nderi yapılacak, gmail hesabı
            //            mesaj.Subject = textBox5.Text;
            //            mesaj.IsBodyHtml = true;
            //            mesaj.Body = richTextBox1.Text;

            //            NetworkCredential guvenligonderi = new NetworkCredential("muratbilginer09@gmail.com","xenon2600");//kullanıcı adı ve şifreniz

            //            baglanti.Credentials = guvenligonderi;

            //            baglanti.Port = 587; //gmail port nurası Türkiye için 587

            //            baglanti.Host = "smtp.gmail.com";

            //            baglanti.EnableSsl = true;
            //            baglanti.Send(mesaj);
            //        }
            //        catch (Exception)
            //        {

                       
                        
            //        }  
            //    }

            //    else
            //    {
            //        mailgönderildimi++;
            //        break;
                    
            //    }
               
            //}
        }
    }
}
