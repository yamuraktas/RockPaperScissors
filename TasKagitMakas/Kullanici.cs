using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    public class Kullanici : Oyuncu
    {

        public Kullanici(string oyuncuID, string oyuncuAdi, double skor) : base(oyuncuAdi, oyuncuAdi, skor)
        {
        }
        public Kullanici()
        {
        }

        public override Nesne nesneSec(int index = 0)
        {
            var nesne = oyuncuNesneleri[index];
            sonSecilenNesneIndex = index;
            oyuncuNesneleriSecilmeyenler.Remove(nesne);
            return nesne;
        }
    }
}
