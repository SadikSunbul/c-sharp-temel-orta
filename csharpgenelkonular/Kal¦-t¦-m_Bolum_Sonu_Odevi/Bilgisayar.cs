using System;
namespace Kalıtım_Bolum_Sonu_Odevi
{
    public sealed class Bilgisayar:Ürün //sealed metodu baska bı clasa kalıtılamasın demek
    {
        public Bilgisayar()
        {
        }
        public string İşlemci { get; set; }
        public string Ram { get; set; }
        public string EkranKartı { get; set; }

    }
}

