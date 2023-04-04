using System;
namespace metotlar._1.matamatıkselişlemler
{
    public class Matematik
    {
        //topla
        public decimal ToplamaIslemi(decimal sayı1,decimal sayı2)
        {
            decimal sonuc = sayı1 + sayı2;
            return sonuc;
        }
        //cıkar
        public decimal CıkarmaIslemi(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 - sayı2;
            return sonuc;
        }
        //bolme
        public decimal BolmeIslemi(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 / sayı2;
            return sonuc;
        }
        //carpma
        public decimal Carpmaslemi(decimal sayı1, decimal sayı2)
        {
            decimal sonuc = sayı1 * sayı2;
            return sonuc;
        }
        public void Menü()
        {
            Console.Clear();
            Console.WriteLine("****Menü*****");
            Console.WriteLine("1-toplama");
            Console.WriteLine("2-cıkarma");
            Console.WriteLine("3-çarpma");
            Console.WriteLine("4-bolme");
            Console.WriteLine("Lğtfen değer seçiniz:");

        }

        public void sonucuekranayazdır(decimal kullanıcısayı1,decimal kullanıcısayı2,decimal sonuc,string operators)
        {
            Console.WriteLine("{0}{1}{2}={3}",kullanıcısayı1,operators,kullanıcısayı2,sonuc);
        }
    }
}

