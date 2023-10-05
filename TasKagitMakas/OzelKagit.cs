using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class OzelKagit : Kagit
    {
        public double kalinlik { get; set; }
        public OzelKagit(double dayaniklilik, double seviyePuani, double nufuz, double kalinlik) : base(dayaniklilik, seviyePuani, nufuz)
        {
            this.kalinlik = kalinlik;
        }

        public OzelKagit()
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
                etki = Calculations.KagitEtkisiHesapla(0, this.nufuz, agirtas.katilik, kalinlik: this.kalinlik, sicaklik: agirtas.sicaklik);
            }
            else if (x is Tas tas)
            {
                etki = Calculations.KagitEtkisiHesapla(0, this.nufuz, tas.katilik, kalinlik: this.kalinlik);
            }

            else if (x is OzelKagit ozelkagit)
            {
                etki = 0.4;
            }

            else if (x is Kagit kagit)
            {
                etki = 0.2;
            }

            else if (x is UstaMakas ustamakas)
            {
                etki = Calculations.KagitEtkisiHesapla(ustamakas.keskinlik, this.nufuz, 0, direnc: ustamakas.direnc, kalinlik: this.kalinlik);
            }

            else if (x is Makas makas)
            {
                etki = Calculations.KagitEtkisiHesapla(makas.keskinlik, this.nufuz, 0, kalinlik: this.kalinlik);
            }

            return etki;
        }
        public override string ToString()
        {
            return "Özel Kağıt";
        }
    }
}
