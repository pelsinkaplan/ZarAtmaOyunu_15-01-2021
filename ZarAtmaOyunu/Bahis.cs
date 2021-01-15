using System;
using System.Collections.Generic;
using System.Text;

namespace ZarAtmaOyunu
{
    class Bahis
    {

        public int Miktar { get; set; }

        public void Oyna(int maxBahis)
        {
            Random random = new Random();
            Miktar = random.Next(1, maxBahis + 1);
        }
    }
}
