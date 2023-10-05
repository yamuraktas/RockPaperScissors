using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class Tas : Nesne
    {
        public double katilik { set; get; }

        public Tas(double dayaniklilik, double seviyePuani, double katilik) : base(dayaniklilik, seviyePuani)
        {
            this.katilik = katilik;
        }
        public Tas()
        {
        }

        public override void nesnePuaniGoster()
        {

        }

        public override double etkiHesapla(Nesne x)
        {
            double etki = 0;
            if (x is AgirTas agirtas)
            {
                etki = 0.4;
            }
            else if (x is Tas tas)
            {
                etki = 0.2;
            }

            else if (x is OzelKagit ozelkagit)
            {
                etki = Calculations.TasEtkisiHesapla(0, ozelkagit.nufuz, this.katilik, kalinlik: ozelkagit.kalinlik);
            }

            else if (x is Kagit kagit)
            {
                etki = Calculations.TasEtkisiHesapla(0, kagit.nufuz, this.katilik);
            }

            else if (x is UstaMakas ustamakas)
            {
                etki = Calculations.TasEtkisiHesapla(ustamakas.keskinlik, 0, this.katilik, direnc: ustamakas.direnc);
            }

            else if (x is Makas makas)
            {
                etki = Calculations.TasEtkisiHesapla(makas.keskinlik, 0, this.katilik);
            }

            return etki;
        }

        public override string ToString()
        {
            return "Taş";
        }

    }
}
