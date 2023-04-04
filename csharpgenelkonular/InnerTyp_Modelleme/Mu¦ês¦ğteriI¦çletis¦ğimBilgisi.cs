using System;
namespace InnerTyp_Modelleme
{
    public class MüşteriİletişimBilgisi
    {
        public MüşteriİletişimBilgisi()
        {
        }
        public int İletişimTip { get; set; } //717770001 mobil 0002 sabithat
        public string Numara { get; set; }
        public string AlanKodu { get; set; }
        public bool AktifPasif { get; set; }

        public void MüşteriİletişimBilgisiTest()
        {
            Console.WriteLine("MüşteriİletişimBilgisiTest");
        }
    }
}

