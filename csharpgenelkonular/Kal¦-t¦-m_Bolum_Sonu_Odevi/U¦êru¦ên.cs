using System;
namespace Kalıtım_Bolum_Sonu_Odevi
{
    public class Ürün: BaseClass
    {
        public Ürün()
        {
        }
        public string Marka { get; set; } //kontrol  belırtmıs oldugumuz markalar ıcerısındekı urunler eklene bılecek baska bı urun eklenemıycek
        public string Model { get; set; }


        private decimal _alisFıyat;
        public decimal AlisFıyat {
            get { return this._alisFıyat; }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Aliş fıyatı 0 dan küçük veya eşit olamaz...");
                }
                else
                {
                    _alisFıyat = value;
                }
            }
        }  //0 dan kucuk olmamalı

        private decimal _satısFıyatı;
        public decimal SatısFıyatı {
            get { return this._satısFıyatı; }
            set
            {
                if (value<_alisFıyat)
                {
                    Console.WriteLine("ürünün satış fıaytı alış fıyatından kucuk olamaz");
                }
                else
                {
                    _satısFıyatı = value;
                }
            }
        } //alısfıyatından dusuk olamaz

        private decimal _kampanyaFıyatı;
        public decimal KanpanyaFıyat {
            get { return _kampanyaFıyatı; }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("kanpanya Aliş fıyatı 0 dan küçük veya eşit olamaz.. ");
                }
            }
            } //sıfırdan kucuk olamaz


    }
}

