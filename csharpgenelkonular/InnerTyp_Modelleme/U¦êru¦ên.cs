using System;
namespace InnerTyp_Modelleme
{
    public class Ürün
    {
        public Ürün()
        {
            Console.WriteLine("yapıcı metot calıstı.");
        }
        public int UrunId { get; set; }
        public string Tanım { get; set; }
        public decimal Fiyat { get; set; }

        public void UrunTestMetot()
        {
            Console.WriteLine("UurnTestMetot");
        }
    }
}

