using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class UstaMakas : Makas
    {
        public double direnc { get; set; }

        public UstaMakas(double dayaniklilik, double seviyePuani, double keskinlik, double direnc) : base(dayaniklilik, seviyePuani, keskinlik)
        {
            this.direnc = direnc;
        }
        public UstaMakas()
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
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik, 0, agirtas.katilik, direnc: this.direnc, sicaklik: agirtas.sicaklik);
            }
            else if (x is Tas tas)
            {
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik, 0, tas.katilik, direnc: this.direnc);
            }

            else if (x is OzelKagit ozelkagit)
            {
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik, ozelkagit.nufuz, 0, direnc: this.direnc, kalinlik: ozelkagit.kalinlik);
            }

            else if (x is Kagit kagit)
            {
                etki = Calculations.MakasEtkisiHesapla(this.keskinlik, kagit.nufuz, 0, direnc: this.direnc);
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
            return "Usta Makas";
        }
    }
}
