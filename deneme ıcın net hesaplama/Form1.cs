namespace deneme_ıcın_net_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double matDogru, geoDogru, fızDogru, kımDogru, bıyoDogru;//Doğru sayısı ve Toplam bütün Doğrular için için değişkenler
            double matyanlis, geoyanlis, fızyanlis, kımyanlis, bıyoyanlis;//Her Ders ve Toplam bütün yanlışlar için degişken
            double matnet, geonet, fıznet, kımnet, bıyonet, genelnet;//Hers için ve toplam bütün netler için değişkenler
            matDogru = Convert.ToDouble(textBox1.Text);
            matyanlis = Convert.ToDouble(textBox2.Text);
            matnet = (matDogru - (matyanlis / 4));
            textBox3.Text = matnet.ToString();//Matematik net
            geoDogru = Convert.ToDouble(textBox4.Text);
            geoyanlis = Convert.ToDouble(textBox5.Text);
            geonet = (geoDogru - (geoyanlis / 4));
            textBox6.Text = geonet.ToString();//Geometri Net
            fızDogru = Convert.ToDouble(textBox7.Text);
            fızyanlis = Convert.ToDouble(textBox8.Text);
            fıznet = (fızDogru - (fızyanlis / 4));
            textBox9.Text = fıznet.ToString();//Fizik Net
            kımDogru = Convert.ToDouble(textBox10.Text);
            kımyanlis = Convert.ToDouble(textBox11.Text);
            kımnet = (kımDogru - (kımyanlis / 4));
            textBox12.Text = geonet.ToString();//Kimya Net
            bıyoDogru = Convert.ToDouble(textBox13.Text);
            bıyoyanlis = Convert.ToDouble(textBox14.Text);
            bıyonet = (bıyoDogru - (bıyoyanlis / 4));
            textBox15.Text = geonet.ToString();//Biyoloji Net
            genelnet = (matDogru + geoDogru + fızDogru + kımDogru + bıyoDogru - ((matyanlis + geoyanlis + fızyanlis + kımyanlis + bıyoyanlis) / 4));//Bütün genel netleri hesaplamak için
            label10.Text = genelnet.ToString();//Toplam Bütün net
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 y = new Form3();
            y.Show();
            this.Hide();
        }
    }
}