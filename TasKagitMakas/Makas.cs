using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class Makas : Nesne
    {
        public double keskinlik { get; set; }
        public Makas(double dayaniklilik, double seviyePuani, double keskinlik) : base(dayaniklilik, seviyePuani)
        {
            this.keskinlik = keskinlik;
        }
        public Makas()
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
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik, 0,agirtas.katilik,sicaklik:agirtas.sicaklik);
            }
            else if (x is Tas tas)
            {
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik, 0, tas.katilik);
            }

            else if (x is OzelKagit ozelkagit)
            {
               etki = Calculations.MakasEtkisiHesapla(this.keskinlik, ozelkagit.nufuz, 0, kalinlik:ozelkagit.kalinlik);
            }

            else if (x is Kagit kagit)
            {
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik,kagit.nufuz, 0);
            }

            else if (x is UstaMakas ustamakas)
            {
                 etki = 0.4;
            }

            else if (x is Makas makas)
            {
                etki = 0.2;
            }

            return etki;
        }

        public override string ToString()
        {
            return "Makas";
        }
    }
}
