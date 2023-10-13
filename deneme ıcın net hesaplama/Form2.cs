using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_ıcın_net_hesaplama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int saniye = 60;
        int dakika = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dakika = Convert.ToInt32(textBox1.Text);
            this.BackColor = Color.Green;
        }

        private void lblSaniye_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            saniye = saniye - 1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                this.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            y.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
            this.Close();
        }
    }
}
