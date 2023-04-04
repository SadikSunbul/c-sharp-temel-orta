using System;
namespace Kalıtım_Bolum_Sonu_Odevi
{
    public class BaseClass
    {
        
        public static int sayac = 1; //ilk olustugu zaman 1 degerını tutsun dedık
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
           private set //dısarıdan bır deger gırılmesını engelledık  //private dedıgımız ıcın burdan degr alamaz
            {
                //bır sayac ıcerısındekı degrden faydalanmak ıstıyıruz
               // this._id = sayac;
               // sayac = sayac + 1; //statıc tarafta duran degrıde guncelleye bılırız
               //set alanı prıvate olarak ısaretlendıgı ıcın deger atılamıyor 
            }
        }//kontrol

        private string _barkod;
        public string Barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolısleme = SanalDataBase.dbBarkodKontrol(value);
                if (!kontrolısleme) //bulamadım
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal data base ıcerısınde bu barkod degrı daha once gırılmıstır.");
                }
            }
        } //kontrol

        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullanıcı { get; set; }

        public DateTime GüncellemeTarihi { get; set; }
        public int GüncelleyenKullanıcı { get; set; }

        public bool silindi { get; set; }

    }
}

