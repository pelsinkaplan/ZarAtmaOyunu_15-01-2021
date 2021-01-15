using System;
using System.Collections.Generic;
using System.Text;

namespace ZarAtmaOyunu
{
    class Zar
    {

        public int Deger { get; set; }

        public void At()
        {
            Random random = new Random();
            Deger = random.Next(1, 7);
        }
    }
}
