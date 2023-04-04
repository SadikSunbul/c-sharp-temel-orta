using System;
namespace Trendyol
{
    public class Ürün:BaseClass
    {
        public Ürün()
        {
        }
        public string marka { get; set; }
        public string model { get; set; }

        private decimal _alışfiyatı;
        public decimal alışFıyatı
        {
            get
            {
                return _alışfiyatı;
            }
            set
            {
                if (value>0)
                {
                    _alışfiyatı = value;
                    Console.WriteLine("alıs degerı kaydedıldı...");
                }
                else
                {
                    Console.WriteLine("alıs degerı 0 dan kucuk olamaz...");
                }
            }
        }//0 dan buyuk

        private decimal _satışfıyatı;
        public decimal satışFşyatı
        {
            get
            {
                return _satışfıyatı;
            }
            set
            {
                if (_alışfiyatı>value)
                {
                    Console.WriteLine("Alıs fıyatından az olamaz");
                }
                else
                {
                    _satışfıyatı = value;
                    Console.WriteLine("alıs fıyatı kaydedıldi");
                }
            }
        }//alıstan az olmalı

        private decimal _kanpanyalıFiyat;
        public decimal kanpanyalıFiyat
        {
            get
            {
                return _kanpanyalıFiyat;
            }
            set
            {
                if (value>0)
                {
                    _kanpanyalıFiyat = value;
                    Console.WriteLine("kanpanya fıyatı kaydedıldı..");
                }
                else
                {
                    Console.WriteLine("kanpanya fıyatı 0 dan buyuk olmalı...");
                }
            }
        }//0 dan buyuk
    }
}

