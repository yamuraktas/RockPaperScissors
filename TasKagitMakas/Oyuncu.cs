using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public abstract class Oyuncu
    {
        public List<Nesne> oyuncuNesneleri = new List<Nesne>();
        protected List<Nesne> oyuncuNesneleriSecilmeyenler = new List<Nesne>();
        public String oyuncuID { get; set; }
        public String oyuncuAdi { get; set; }
        public double skor { get; set; }
        protected int sonSecilenNesneIndex { get; set; }
        public Oyuncu(String oyuncuID, String oyuncuAdi, double skor)
        {
            Oyuncu1NesneleriniAyarla();
            oyuncuNesneleriSecilmeyenler = oyuncuNesneleri.ToList();
        }
        public Oyuncu()
        {
        }

        public virtual double skorGoster()
        {
            skor = 0;
            for (int i = 0; i < oyuncuNesneleri.Count; i++)
            {
                Nesne nesne = oyuncuNesneleri[i];
                skor += nesne.dayaniklilik;
            }
            return skor;
        }

        public Nesne SonSecilenNesneGoster()
        {
            return oyuncuNesneleri[sonSecilenNesneIndex];
        }

        public void SecilmeyenlerDizisiniSifirla()
        {
            oyuncuNesneleriSecilmeyenler = oyuncuNesneleri.ToList();
        }
        public virtual Nesne nesneSec(int index = 0)
        {
            return null;
        }

        public void NesneTerfiEttirmeVeDayaniklilikKontrol()
        {
            for (int i = 0; i < oyuncuNesneleri.Count; i++)
            {
                Nesne nesne = oyuncuNesneleri[i];
                if (nesne.seviyePuani > 30)
                {
                    if (nesne is Tas tas)
                    {
                        Nesne agirTas = new AgirTas(tas.dayaniklilik, tas.seviyePuani, tas.katilik, 2);
                        oyuncuNesneleri.RemoveAt(i);
                        oyuncuNesneleri.Insert(i, agirTas);
                    }
                    else if (nesne is Kagit kagit)
                    {
                        Nesne ozelKagit = new OzelKagit(kagit.dayaniklilik, kagit.seviyePuani, kagit.nufuz, 2);
                        oyuncuNesneleri.RemoveAt(i);
                        oyuncuNesneleri.Insert(i, ozelKagit);
                    }
                    else if (nesne is Makas makas)
                    {
                        Nesne ustaMakas = new UstaMakas(makas.dayaniklilik, makas.seviyePuani, makas.keskinlik, 2);
                        oyuncuNesneleri.RemoveAt(i);
                        oyuncuNesneleri.Insert(i, ustaMakas);
                    }

                }

            }
        }
        private void Oyuncu1NesneleriniAyarla()
        {
            Tas tas1 = new Tas(20, 0, 2);
            Tas tas2 = new Tas(20, 0, 2);
            Tas tas3 = new Tas(20, 0, 2);
            Tas tas4 = new Tas(20, 0, 2);
            Tas tas5 = new Tas(20, 0, 2);

            Kagit kagit1 = new Kagit(20, 0, 2);
            Kagit kagit2 = new Kagit(20, 0, 2);
            Kagit kagit3 = new Kagit(20, 0, 2);
            Kagit kagit4 = new Kagit(20, 0, 2);
            Kagit kagit5 = new Kagit(20, 0, 2);

            Makas makas1 = new Makas(20, 0, 2);
            Makas makas2 = new Makas(20, 0, 2);
            Makas makas3 = new Makas(20, 0, 2);
            Makas makas4 = new Makas(20, 0, 2);
            Makas makas5 = new Makas(20, 0, 2);

            oyuncuNesneleri.Add(tas1);
            oyuncuNesneleri.Add(tas2);
            oyuncuNesneleri.Add(tas3);
            oyuncuNesneleri.Add(tas4);
            oyuncuNesneleri.Add(tas5);
            oyuncuNesneleri.Add(kagit1);
            oyuncuNesneleri.Add(kagit2);
            oyuncuNesneleri.Add(kagit3);
            oyuncuNesneleri.Add(kagit4);
            oyuncuNesneleri.Add(kagit5);
            oyuncuNesneleri.Add(makas1);
            oyuncuNesneleri.Add(makas2);
            oyuncuNesneleri.Add(makas3);
            oyuncuNesneleri.Add(makas4);
            oyuncuNesneleri.Add(makas5);
        }


    }
}