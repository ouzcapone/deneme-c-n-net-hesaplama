using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_ıcın_net_hesaplama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double trDogru, felDogru, trhDogru, dınDogru, cogDogru;//Doğru sayısı için değişkenler
            double tryanlis, felyanlis, trhyanlis, dınyanlis, cogyanlis;//Bütün yanlışlar için degişkenler
            double trnet, felnet, trhnet, dınnet, cogonet, genelnet;//Hers için ve toplam bütün netler için değişkenler
            trDogru = Convert.ToDouble(textBox1.Text);
            tryanlis = Convert.ToDouble(textBox2.Text);
            trnet = (trDogru - (tryanlis / 4));
            textBox3.Text = trnet.ToString();//Edebiyat net
            felDogru = Convert.ToDouble(textBox4.Text);
            felyanlis = Convert.ToDouble(textBox5.Text);
            felnet = (felDogru - (felyanlis / 4));
            textBox6.Text = felnet.ToString();//Felsefe Net
            trhDogru = Convert.ToDouble(textBox7.Text);
            trhyanlis = Convert.ToDouble(textBox8.Text);
            trhnet = (trhDogru - (trhyanlis / 4));
            textBox9.Text = trhnet.ToString();//Tarih Net
            dınDogru = Convert.ToDouble(textBox10.Text);
            dınyanlis = Convert.ToDouble(textBox11.Text);
            dınnet = (dınDogru - (dınyanlis / 4));
            textBox12.Text = dınnet.ToString();//Din <Üniversite sınavında niye din soruyolar aq> Net
            cogDogru = Convert.ToDouble(textBox13.Text);
            cogyanlis = Convert.ToDouble(textBox14.Text);
            cogonet = (cogDogru - (cogyanlis / 4));
            textBox15.Text = cogonet.ToString();//Biyoloji Net
            genelnet = (trDogru + felDogru + trhDogru + dınDogru + cogDogru - ((tryanlis + felyanlis + trhyanlis + dınyanlis + cogyanlis) / 4));//Bütün genel netleri hesaplamak için
            label10.Text = genelnet.ToString();//Toplam Bütün net
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            y.Show();
            this.Hide();
        }
    }
}
