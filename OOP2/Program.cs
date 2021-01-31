using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekmusteri = new GercekMusteri();
            gercekmusteri.Adi = "Engin";
            gercekmusteri.Soyadi = "Demiroğ";
            gercekmusteri.Id = 1;
            gercekmusteri.MüşteriNo = "1234";
            gercekmusteri.TcNo = "4321";
            TuzelMusteri tuzelmusteri = new TuzelMusteri();
            tuzelmusteri.Id = 2;
            tuzelmusteri.MüşteriNo = "5678";
            tuzelmusteri.SirketAdi = "kodlama io";
            tuzelmusteri.VergiNo = "98";
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.ekle(gercekmusteri);
            musterimanager.ekle(tuzelmusteri);
            musterimanager.ekle(musteri1);
            musterimanager.ekle(musteri2);
        }
    }
}
