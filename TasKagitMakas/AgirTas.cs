using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class AgirTas : Tas
    {
        public double sicaklik { get; set; }

        public AgirTas(double dayaniklilik, double seviyePuani, double katilik, double sicaklik) : base(dayaniklilik, seviyePuani, katilik)
        {
            this.sicaklik = sicaklik;
        }
        public AgirTas()
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
                etki = Calculations.TasEtkisiHesapla(0, ozelkagit.nufuz, this.katilik, kalinlik: ozelkagit.kalinlik, sicaklik: this.sicaklik);
            }

            else if (x is Kagit kagit)
            {
                etki = Calculations.TasEtkisiHesapla(0, kagit.nufuz, this.katilik, sicaklik: this.sicaklik);
            }

            else if (x is UstaMakas ustamakas)
            {
                etki = Calculations.TasEtkisiHesapla(ustamakas.keskinlik, 0, this.katilik, direnc: ustamakas.direnc, sicaklik: this.sicaklik);
            }

            else if (x is Makas makas)
            {
                etki = Calculations.TasEtkisiHesapla(makas.keskinlik, 0, this.katilik, sicaklik: this.sicaklik);
            }

            return etki;

        }

        public override string ToString()
        {
            return "Ağır Taş";
        }

    }
}
