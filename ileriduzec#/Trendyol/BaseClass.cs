using System;
namespace Trendyol
{
    public class BaseClass
    {
        int sayac = 1;
        public BaseClass()
        {
            id = sayac;
            olusturmaTarihi = DateTime.Now;
            güncellemTarihi = DateTime.Now;
            sayac = sayac + 1;
        }
        private int id { get;  set; }

        public string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrol1 = SanalDataBase.BarkodKontrol(value);
                if (kontrol1)
                {
                    Console.WriteLine("Girdiğiniz barkod onceden kullanılmış");
                }
                else
                {
                    _barkod = value;
                    Console.WriteLine("Barkod kodunuz kaydedilmiş");
                }

            }
        }

        private DateTime olusturmaTarihi { get; set; }
        private DateTime güncellemTarihi { get; set; }
        public bool  silindi { get; set; }

    }
}

