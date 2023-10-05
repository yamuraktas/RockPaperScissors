using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        Oyuncu oyuncu1;
        Oyuncu oyuncu2;

        int toplamHamleSayisi = 10;
        int oyunModu = 0;
        Timer timer;
        public Form1(int mode, int toplamHamle)
        {
            oyunModu = mode;
            toplamHamleSayisi = toplamHamle;
            InitializeComponent();
            listView1.View = View.Details;

            if (mode == 0)
            {
                oyuncu1 = new Kullanici("1", "Kullanici", 0);
                oyuncu2 = new Bilgisayar("2", "Bilgisayar", 0);
            }
            if (mode == 1)
            {
                oyuncu1 = new Bilgisayar("1", "Bilgisayar", 0);
                oyuncu2 = new Bilgisayar("2", "Bilgisayar", 0);

                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            lblSkor1.Text = oyuncu1.skorGoster().ToString();
            lblSkor2.Text = oyuncu2.skorGoster().ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            HamleYap(0, null);
        }

        int hamleSayisi = 0;
        List<Button> pasifEdilenButonlar = new List<Button>();
        bool oyunBittiMi = false;
        private void HamleYap(int index, Button button)
        {
            if (oyunBittiMi) return;
            hamleSayisi++;

            if (oyunModu == 0)
            {

                if (hamleSayisi % 5 != 0)
                {
                    button.Enabled = false;
                    pasifEdilenButonlar.Add(button);

                }
                else
                {
                    for (int i = 0; i < pasifEdilenButonlar.Count; i++)
                    {
                        pasifEdilenButonlar[i].Enabled = true;
                    }
                    pasifEdilenButonlar.Clear();
                    oyuncu2.SecilmeyenlerDizisiniSifirla();
                }

            }
            else
            {
                
                if (hamleSayisi % 5 == 0)
                {
                    oyuncu1.SecilmeyenlerDizisiniSifirla();
                    oyuncu2.SecilmeyenlerDizisiniSifirla();
                }
            }

            Nesne oyuncuSecilenNesne = oyuncu1.nesneSec(index);

            Nesne bilgisayarSecilenNesne = oyuncu2.nesneSec();

            double etki2 = oyuncuSecilenNesne.etkiHesapla(bilgisayarSecilenNesne);
            oyuncuSecilenNesne.durumGuncelle(etki2);
            double etki1 = bilgisayarSecilenNesne.etkiHesapla(oyuncuSecilenNesne);
            bilgisayarSecilenNesne.durumGuncelle(etki1);
            string kazanan = null;

            if (etki2 >= etki1)
            {
                kazanan = "Oyuncu1";
                oyuncuSecilenNesne.seviyePuaniGuncelle(20);
            }
            else
            {
                kazanan = "Oyuncu2";
                bilgisayarSecilenNesne.seviyePuaniGuncelle(20);
            }

            oyuncu1.NesneTerfiEttirmeVeDayaniklilikKontrol();
            oyuncu2.NesneTerfiEttirmeVeDayaniklilikKontrol();

            Nesne skor1 = oyuncu1.SonSecilenNesneGoster();
            Nesne skor2 = oyuncu2.SonSecilenNesneGoster();

            
            string[] row = { skor1.ToString(), skor2.ToString(),kazanan, skor1.dayaniklilik.ToString(),skor1.seviyePuani.ToString(),etki1.ToString(),
             skor2.dayaniklilik.ToString(),skor2.seviyePuani.ToString(),etki2.ToString() };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);

            double oyuncu1Skor = oyuncu1.skorGoster();
            double oyuncu2Skor = oyuncu2.skorGoster();
            lblSkor1.Text = oyuncu1Skor.ToString();
            lblSkor2.Text = oyuncu2Skor.ToString();


            if (hamleSayisi == toplamHamleSayisi || hamleSayisi == oyuncu1.oyuncuNesneleri.Count)
            {
                oyunBittiMi = true;
                lblSonuc.Text = "Oyun Bitti. ";
                if (oyuncu1Skor > oyuncu2Skor)
                    lblSonuc.Text += "Kazanan Oyuncu 1";
                else if (oyuncu1Skor < oyuncu2Skor)
                    lblSonuc.Text += "Kazanan Oyuncu 2";
                else lblSonuc.Text += "Berabere";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1Tas1_Click(object sender, EventArgs e)
        {
            HamleYap(0, (Button)sender);
        }

        private void btn2Tas2_Click(object sender, EventArgs e)
        {
            HamleYap(1, (Button)sender);
        }

        private void btn3Tas3_Click(object sender, EventArgs e)
        {
            HamleYap(2, (Button)sender);
        }

        private void btn4Tas4_Click(object sender, EventArgs e)
        {
            HamleYap(3, (Button)sender);
        }

        private void btn5Tas5_Click(object sender, EventArgs e)
        {
            HamleYap(4, (Button)sender);
        }

        private void btn6Kagit1_Click(object sender, EventArgs e)
        {
            HamleYap(5, (Button)sender);
        }

        private void btn7Kagit2_Click(object sender, EventArgs e)
        {
            HamleYap(6, (Button)sender);
        }

        private void btn8Kagit3_Click(object sender, EventArgs e)
        {
            HamleYap(7, (Button)sender);
        }

        private void btn9Kagit4_Click(object sender, EventArgs e)
        {
            HamleYap(8, (Button)sender);
        }

        private void btn10Kagit5_Click(object sender, EventArgs e)
        {
            HamleYap(9, (Button)sender);
        }

        private void btn11Makas1_Click(object sender, EventArgs e)
        {
            HamleYap(10, (Button)sender);
        }

        private void btn12Makas2_Click(object sender, EventArgs e)
        {
            HamleYap(11, (Button)sender);
        }

        private void btn13Makas3_Click(object sender, EventArgs e)
        {
            HamleYap(12, (Button)sender);
        }

        private void btn14Makas4_Click(object sender, EventArgs e)
        {
            HamleYap(13, (Button)sender);
        }

        private void btn15Makas5_Click(object sender, EventArgs e)
        {
            HamleYap(14, (Button)sender);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //uygulamanin komple kapanmasini sagliyormus
            Process.GetCurrentProcess().Kill();
        }
    }
}
