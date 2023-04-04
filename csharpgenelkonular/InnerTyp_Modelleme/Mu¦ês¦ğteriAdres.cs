using System;
namespace InnerTyp_Modelleme
{
    public class MüşteriAdres
    {
        
        public string AdresTipi { get; set; }
        public string İl { get; set; }
        public string İlce { get; set; }
        public string Adres { get; set; }

        public MüşteriAdres()
        {
            Console.WriteLine("müşteri adresi yapıcı metodu calıstı.");
        }
        public void MşteriAdresTestMetot()
        {
            Console.WriteLine("MşteriAdresTestMetot");
        }
    }
}

