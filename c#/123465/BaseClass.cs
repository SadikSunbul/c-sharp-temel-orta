using System;
namespace _123465
{
    public class BaseClass
    {
        int sayac = 1;
        public BaseClass()
        {
            Id = sayac;
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
                //otamatık atama yapıcaz
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
                bool kontrol = SanalDataBase.BarkodKontrol(value);
                if (kontrol==true)
                {
                    Console.WriteLine("bu barkod daha önce alınmış");
                    
                }
                else
                {
                    this._barkod = value;
                    Console.WriteLine("barkod kodunuz kaydedıldı (eşsiz)");
                }
            }
        }

        public DateTime OlusturmaTarıhı { get; set; }
        public DateTime GuncellemeTarıhı { get; set; }
        public bool Silindi { get; set; }
    }
}

