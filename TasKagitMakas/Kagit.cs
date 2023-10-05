using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class Kagit : Nesne
    {
        public double nufuz { get; set; }
        public Kagit(double dayaniklilik, double seviyePuani, double nufuz) : base(dayaniklilik, seviyePuani)
        {
            this.nufuz = nufuz;
        }
        public Kagit()
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
                 etki = Calculations.KagitEtkisiHesapla(0, this.nufuz, agirtas.katilik,sicaklik: agirtas.sicaklik);
            }
            else if (x is Tas tas)
            {
               etki = Calculations.KagitEtkisiHesapla(0, this.nufuz,tas.katilik);
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
                etki = Calculations.KagitEtkisiHesapla(ustamakas.keskinlik,this.nufuz,0, direnc: ustamakas.direnc);
            }

            else if (x is Makas makas)
            {
                etki = Calculations.KagitEtkisiHesapla(makas.keskinlik,this.nufuz,0);
            }

            return etki;
        }

        public override string ToString()
        {
            return "Kağıt";
        }
    }
}
