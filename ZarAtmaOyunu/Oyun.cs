using System;
using System.Collections.Generic;
using System.Text;

namespace ZarAtmaOyunu
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }

        public Oyuncu IkinciOyuncu { set; get; }

        public Bahis IkinciOyuncuBahis { set; get; }

        public Bahis BirinciOyuncuBahis { set; get; }

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkinciOyuncuZarAt()
        {
            IkinciOyuncu.Oyna();
        }

        public void BirinciOyuncuBahisVer()
        {

            BirinciOyuncu.BahisKoy(BirinciOyuncu.Bakiye);
        }

        public void IkinciOyuncuBahisVer()
        {
            IkinciOyuncu.BahisKoy(IkinciOyuncu.Bakiye);
        }

        public Oyuncu Karsilastir()
        {
            if (BirinciOyuncu.OyuncununZari.Deger > IkinciOyuncu.OyuncununZari.Deger)
                return BirinciOyuncu;
            else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
                return IkinciOyuncu;
            else
                return null;
        }
    }
}
