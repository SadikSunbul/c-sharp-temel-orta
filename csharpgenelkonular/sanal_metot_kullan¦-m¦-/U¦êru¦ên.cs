using System;
namespace sanal_metot_kullanımı
{
    public class Ürün:BaseClass
    {
        public Ürün()
        {
            Console.WriteLine("ürün");
        }
        public override void EkranaYaz(string data) //bunun basesı vardı ama sen bunu overıd ettın 
        {
            //  base.EkranaYaz(data);  //base anahtar kelımesı BaseClas ı gosterır

            Console.WriteLine("ürün sınıfı --> "+data);
        }
    }
}

