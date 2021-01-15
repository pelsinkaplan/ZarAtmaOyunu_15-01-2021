using System;
using System.Collections.Generic;
using System.Text;

namespace ZarAtmaOyunu
{
    class Oyuncu
    {
        public Oyuncu()
        {

        }

        public Oyuncu(string ad, int bakiye)
        {
            Ad = ad;
            Bakiye = bakiye;
        }

        public string Ad { get; set; }

        public int Bakiye { get; set; }

        public Zar OyuncununZari { get; set; }

        public Bahis OyuncununBahisi { get; set; }

        public void Oyna()
        {
            OyuncununZari.At();
        }

        public void BahisKoy(int maxBahis)
        {
            OyuncununBahisi.Oyna(maxBahis);
        }
    }
}
