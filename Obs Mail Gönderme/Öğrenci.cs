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
    public partial class Öğrenci : Form
    {
        public Öğrenci()
        {
            InitializeComponent();
        }

        private void Öğrenci_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.öğrencinoo;
            label3.Text = Personel.mailgönderildimi.ToString();
        }
    }
}
