using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public static class Calculations
    {
        static double a = 0.2;
        public static double MakasEtkisiHesapla(double keskinlik, double nufuz, double katilik,
            double direnc = 1, double kalinlik = 1, double sicaklik = 1)
        {
            double etki = 0;
            etki =
                (keskinlik * direnc)
                /
                ((a * nufuz * kalinlik) + (1 - a) * katilik * sicaklik);
            return etki;
        }

        public static double KagitEtkisiHesapla(double keskinlik, double nufuz, double katilik,
           double direnc = 1, double kalinlik = 1, double sicaklik = 1)
        {
            double etki = 0;
            etki =
                (nufuz * kalinlik)
                /
                ((a * katilik * sicaklik) + (1 - a) * keskinlik * direnc);
            return etki;
        }

        public static double TasEtkisiHesapla(double keskinlik, double nufuz, double katilik,
           double direnc = 1, double kalinlik = 1, double sicaklik = 1)
        {
            double etki = 0;
            etki =
                (katilik * sicaklik)
                /
                ((a * keskinlik * direnc) + (1 - a) * nufuz * kalinlik);
            return etki;
        }
    }
}
