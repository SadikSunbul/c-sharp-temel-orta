using System;
namespace static_personel_uygulaması
{
    public class Personel
    {
        public Personel()
        {
            Console.WriteLine("her orneklemede calısan metot ");
        }
        static Personel()
        {
            domainAdresi = "firmam.com";
        }

        public static string domainAdresi = "firmam.com";
        public string Isim { get; set; }
        public string SoyIsim { get; set; }


        private string _emailAdresi;

        public string EmailAdresi
        {
            get
            {
                return this._emailAdresi;
            }
            set
            {                                               //personel clasının ıcerısındekı domaını cagırdık 
                this._emailAdresi =String.Format( value.ToLower() + "@" + Personel.domainAdresi);
            }
        }

        public int cinsiyet { get; set; }

        

    }
}

