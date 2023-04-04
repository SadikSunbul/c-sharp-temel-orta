using System;
namespace InnerTyp_Modelleme
{
    public class Müşteri
    {
        
        #region tekil olarak kullanılan field 
        public int MusteriId { get; set; }
        public string İsim { get; set; }
        public string Soyİsim { get; set; }
        public string TcKimlikno { get; set; }
        public DateTime Olusturmatarihi { get; set; }
        public int KullanıcıId { get; set; }
        #endregion

        #region Inner Typ gerektiren field lar  -------->//birden fazla adresi olabilir

        public MüşteriAdres[] müşteriAdresleri; //musterı nesnesının ıcerısınde musterı adres nesnesını bır koleksıyon olarak tanımlamıs olduk
        //bırden fazla musterı adresını tanımlaya bılcez
        public MüşteriİletişimBilgisi[] müşteriİletişimBilgileri;
        public MüşteriSiparişBilgisi[] müşteriSiparişBilgileri;
        #endregion

        public Müşteri()
        {
            müşteriAdresleri = new MüşteriAdres[5];  //ınner typ dekı atadıgımız degrı yazıyoruz ve newleyoruz new leme yapmazsak program.cs dekı
                                                     //odlarımız calısmaz cunku bellekte yenı adres acamadık
            müşteriİletişimBilgileri = new MüşteriİletişimBilgisi[5];
            müşteriSiparişBilgileri = new MüşteriSiparişBilgisi[10];
        }
    }
}

