namespace bilgi_yarismasii
{
    public partial class text1 : Form
    {
        public text1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnC.Text;
            if (label1.Text==label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnD.Text;
            if (label1.Text==label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            lblSoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye'nin baþkenti neresidir?";
                btnA.Text = "Bursa";
                btnB.Text = "Ankara";
                btnC.Text = "Ýstanbul";
                btnD.Text = "Ýzmir";
                label1.Text = "Ankara";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aþaðýdakilerden hangisi bir sayýnýn küpü deðildir?";
                btnA.Text = "11";
                btnB.Text = "125";
                btnC.Text = "8";
                btnD.Text = "729";
                label1.Text = "11";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Küpün kaç kenarý vardýr?";
                btnA.Text = "3";
                btnB.Text = "4";
                btnC.Text = "5";
                btnD.Text = "6";
                label1.Text = "6";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Aþaðýdakilerden illerimizden hangisi ege bölgesinde yer alýr?";
                btnA.Text = "Afyon";
                btnB.Text = "Samsun";
                btnC.Text = "Uþak";
                btnD.Text = "Bozüyük";
                label1.Text = "Uþak";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Türkiye'nin en güneyinde hangi il vardýr?";
                btnA.Text = "Antalya";
                btnB.Text = "Hatay";
                btnC.Text = "Þanlýurfa";
                btnD.Text = "Gaziantep";
                label1.Text = "Hatay";
            }
            if (soruno == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }
            if (dogru == 5)
            {
                MessageBox.Show("Bravo!"+ "\n" + "Ýyi Ýþ Baþardýn." + "\n" + "Doðru: " + dogru + "\n" + "Yanlýþ:0 ");
            }
            if (dogru >=1 && dogru<5 && soruno<6)
            {
                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ: " + yanlis + "\n" + "Hazýr Mýsýnýz? Bir Sonraki Soruya Geçtiniz.");
            }
            else if (soruno>5 && soruno<7)
            {
                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ: " + yanlis + "\n" + "Yarýþma Bitmiþtir.");
            }
           
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnB.Text;
            if (label1.Text==label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label2.Text = btnA.Text;
            if(label1.Text==label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}