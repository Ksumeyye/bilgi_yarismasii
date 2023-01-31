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
                richTextBox1.Text = "T�rkiye'nin ba�kenti neresidir?";
                btnA.Text = "Bursa";
                btnB.Text = "Ankara";
                btnC.Text = "�stanbul";
                btnD.Text = "�zmir";
                label1.Text = "Ankara";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "A�a��dakilerden hangisi bir say�n�n k�p� de�ildir?";
                btnA.Text = "11";
                btnB.Text = "125";
                btnC.Text = "8";
                btnD.Text = "729";
                label1.Text = "11";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "K�p�n ka� kenar� vard�r?";
                btnA.Text = "3";
                btnB.Text = "4";
                btnC.Text = "5";
                btnD.Text = "6";
                label1.Text = "6";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "A�a��dakilerden illerimizden hangisi ege b�lgesinde yer al�r?";
                btnA.Text = "Afyon";
                btnB.Text = "Samsun";
                btnC.Text = "U�ak";
                btnD.Text = "Boz�y�k";
                label1.Text = "U�ak";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "T�rkiye'nin en g�neyinde hangi il vard�r?";
                btnA.Text = "Antalya";
                btnB.Text = "Hatay";
                btnC.Text = "�anl�urfa";
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
                MessageBox.Show("Bravo!"+ "\n" + "�yi �� Ba�ard�n." + "\n" + "Do�ru: " + dogru + "\n" + "Yanl��:0 ");
            }
            if (dogru >=1 && dogru<5 && soruno<6)
            {
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��: " + yanlis + "\n" + "Haz�r M�s�n�z? Bir Sonraki Soruya Ge�tiniz.");
            }
            else if (soruno>5 && soruno<7)
            {
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��: " + yanlis + "\n" + "Yar��ma Bitmi�tir.");
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