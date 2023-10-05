using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    class Bilgisayar : Oyuncu
    {
        static Random random = new Random();
        public Bilgisayar(string oyuncuID, string oyuncuAdi, double skor) : base(oyuncuID, oyuncuAdi, skor)
        {
        }
        public Bilgisayar()
        {
        }
        public override Nesne nesneSec(int index = 0)
        {
            //iki tane dizimiz. biri tum nesneler, digeri ise secilmeyen nesnelerin tutuldugu dizi.
            //bu diziler oyuncu sinifi icinde tanimlanmistir. her nesne secildiginde secilmeyenler dizisinden silinir.
            //cunku bilgisayar diziden random eleman secerken bu diziden eleman secer. bunun sebebi ise ayni elemani tekrar secmesini engellemektir.
            int secilenNesneIndex = random.Next(0, oyuncuNesneleriSecilmeyenler.Count - 1);
            sonSecilenNesneIndex = secilenNesneIndex;
            Nesne secilenNesne = oyuncuNesneleriSecilmeyenler[secilenNesneIndex];
            oyuncuNesneleriSecilmeyenler.Remove(secilenNesne);
            return secilenNesne;
        }
    }

}
