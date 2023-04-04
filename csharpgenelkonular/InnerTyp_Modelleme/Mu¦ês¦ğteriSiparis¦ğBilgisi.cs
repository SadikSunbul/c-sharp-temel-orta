using System;
namespace InnerTyp_Modelleme
{
    public class MüşteriSiparişBilgisi
    {
        
        public string SiparişNumarası { get; set; }

        public Ürün[] ürüns;

        public MüşteriSiparişBilgisi()
        {
            ürüns = new Ürün[2];

        }

        public void MüşteriSiparişBilgisiTestMetot()
        {
            Console.WriteLine("MüşteriSiparişBilgisiTestMetot");
        }
    }
}

