using System;
namespace Trendyol
{
    public class BaseClass
    {
        private static int sayac=1;
        public BaseClass()
        {
            this._id = sayac;
            sayac = sayac + 1;
        }

        private int _id;
        public int Id
        {
            get
            {
                return this._id;
            }

           private set
            {
                //buraya atama yapılmıycak cunku yukarıda otamatık bır sekılde ataması yapıldı
            }
        }

        public string _barkod;
        public string Barkod
        {
            get
            {
                return this._barkod;
            }
            set
            {
                bool kontrol2 = SanalDataBase.BarkodKontrol(value);
                if (kontrol2)
                {
                    Console.WriteLine("Barkod numarası Kullanılmıs yenı bır kod deneyınız...");
                }
                else
                {
                    this._barkod = value;
                    Console.WriteLine("barkod numarası basarılı bır sekılde kaydedıldı...");
                }
            }
            }




        public DateTime OlusturmaTarıhı { get; set; }
        public DateTime GüncellemeTarihi { get; set; }
        public bool Silindi { get; set; }

    }
}

