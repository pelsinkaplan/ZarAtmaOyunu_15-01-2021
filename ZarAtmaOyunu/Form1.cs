using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            *   Bu oyunda iki oyuncu vardır.
            *   Her oyuncunun bir zarı vardır.
            *   Oyuncular zar atar.
            *   Zarlar karşılaştırılır.
            *   Büyük atan kazananır.
            *   
            *   Nesneler:
            *   -Oyun
            *   -Oyuncu
            *   -Zar
            */
        }

        Oyun zarOyunu = new Oyun();

        private void buttonOyuncu1AdEkle_Click(object sender, EventArgs e)
        {
            zarOyunu.BirinciOyuncu = new Oyuncu(textBoxOyuncu1Ad.Text, 100);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            zarOyunu.BirinciOyuncu.OyuncununBahisi = new Bahis();
            labelOyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;
            labelOyuncu1Bakiye.Text = zarOyunu.BirinciOyuncu.Bakiye.ToString();
        }

        private void buttonOyuncu2AdEkle_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu = new Oyuncu(textBoxOyuncu2Ad.Text, 100);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            zarOyunu.IkinciOyuncu.OyuncununBahisi = new Bahis();
            labelOyuncu2Ad.Text = zarOyunu.IkinciOyuncu.Ad;
            zarOyunu.IkinciOyuncu.Bakiye = 100;
            labelOyuncu2Bakiye.Text = zarOyunu.IkinciOyuncu.Bakiye.ToString();
        }

        private void buttonOyuncu1_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            buttonOyuncu1.Enabled = false;
            buttonOyuncu2.Enabled = true;
            zarOyunu.BirinciOyuncuBahisVer();
            labelOyuncu1Bahis.Text = zarOyunu.BirinciOyuncu.OyuncununBahisi.Miktar.ToString();
        }

        private void buttonOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();
            buttonOyuncu1.Enabled = true;
            buttonOyuncu2.Enabled = false;
            Oyuncu kazananOyuncu = zarOyunu.Karsilastir();
            Oyuncu kaybedenOyuncu = new Oyuncu();
            zarOyunu.IkinciOyuncuBahisVer();
            labelOyuncu2Bahis.Text = zarOyunu.IkinciOyuncu.OyuncununBahisi.Miktar.ToString();

            if (kazananOyuncu != null)
            {
                labelKazanan.Text = $"{kazananOyuncu.Ad} {kazananOyuncu.OyuncununZari.Deger} atarak oyunu kazandı!";
                if (zarOyunu.BirinciOyuncu == kazananOyuncu)
                {
                    kaybedenOyuncu = zarOyunu.IkinciOyuncu;
                    zarOyunu.BirinciOyuncu.Bakiye = zarOyunu.BirinciOyuncu.Bakiye + zarOyunu.IkinciOyuncu.OyuncununBahisi.Miktar;
                    zarOyunu.IkinciOyuncu.Bakiye = zarOyunu.IkinciOyuncu.Bakiye - zarOyunu.IkinciOyuncu.OyuncununBahisi.Miktar;
                }
                else
                {
                    kaybedenOyuncu = zarOyunu.BirinciOyuncu;
                    zarOyunu.IkinciOyuncu.Bakiye = zarOyunu.IkinciOyuncu.Bakiye + zarOyunu.BirinciOyuncu.OyuncununBahisi.Miktar;
                    zarOyunu.BirinciOyuncu.Bakiye = zarOyunu.BirinciOyuncu.Bakiye - zarOyunu.BirinciOyuncu.OyuncununBahisi.Miktar;
                }

                labelOyuncu1Bakiye.Text = zarOyunu.BirinciOyuncu.Bakiye.ToString();
                labelOyuncu2Bakiye.Text = zarOyunu.IkinciOyuncu.Bakiye.ToString();
            }
            else
                labelKazanan.Text = "Berabere!";
            if (zarOyunu.BirinciOyuncu.Bakiye <= 0 || zarOyunu.IkinciOyuncu.Bakiye <= 0)
            {
                buttonOyuncu1.Enabled = false;
                buttonOyuncu2.Enabled = false;
                labelKazanan.Text = $"-> {kazananOyuncu.Ad} <- \nÜzülme {kaybedenOyuncu.Ad}! Kumarda kaybeden aşkta kazanır!";
            }
        }
    }
}
