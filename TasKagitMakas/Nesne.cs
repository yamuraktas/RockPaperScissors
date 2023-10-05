using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public abstract class Nesne
    {
        public double dayaniklilik { get; set; }
        public double seviyePuani { get; set; }

        public Nesne(double dayaniklilik , double seviyePuani)
        {
            this.dayaniklilik = dayaniklilik;
            this.seviyePuani = seviyePuani;
        }

        public Nesne()
        {
        }
        public virtual void nesnePuaniGoster()
        {
        }

        public virtual double etkiHesapla(Nesne x)
        {
            return 0;
        }

        public virtual void durumGuncelle(double etki)
        {
            dayaniklilik -= etki;
        }
        public virtual void seviyePuaniGuncelle(double puan)
        {
            seviyePuani += puan;
        }
    }
}
