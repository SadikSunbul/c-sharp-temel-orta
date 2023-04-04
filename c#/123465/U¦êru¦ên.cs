using System;
namespace _123465
{
    public class Ürün:BaseClass
    {
        public Ürün()
        {
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Alişfıyatı { get; set; }
        public decimal SatışFıyatı { get; set; }
        public decimal KanpanyalıFiyat { get; set; }
    }
}

