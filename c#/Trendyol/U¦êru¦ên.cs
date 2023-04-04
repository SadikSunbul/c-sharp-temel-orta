using System;
namespace Trendyol
{
    public class Ürün:BaseClass
    {
        public Ürün()
        {
        }
        public string Marka { get; set; }
        public string Model { get; set; }

        private decimal _alışFiyatı;
        public decimal AlışFiyatı
        { get
            {
                return this._alışFiyatı;
            }
            set
            {
                if (value>0)
                {
                    this._alışFiyatı = value;
                    Console.WriteLine("alış fıaytınız kaydedildi");
                }
                else
                {
                    Console.WriteLine("Alış fıyatı 0 dan buyuk olmalı");
                }
            }
        } // 0 buyuk

        private decimal _satışFiyatı;
        public decimal SatışFiyatı
        {
            get
            {
                return this._satışFiyatı;
            }
            set
            {
                if (_alışFiyatı<value)
                {
                    this._alışFiyatı = value;
                    Console.WriteLine("Satış fıyatı eklendi");
                }
                else
                {
                    Console.WriteLine("satış fıyatı alıs fıyatından buyuk olmalı");
                }
            }
        } //alıstan buyuk


        public decimal KanpanyalıFiyat { get; set; } //satıstan kucuk olmalı
    }
}

