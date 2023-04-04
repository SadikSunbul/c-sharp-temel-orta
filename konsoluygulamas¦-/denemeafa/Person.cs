using System;
namespace denemeafa
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Not1 { get; set; }
        public decimal Not2 { get; set; }
        public decimal Not3 { get; set; }

        public void Hesap(string ad,string soyad,decimal not1,decimal not2,decimal not3)
        {
            Console.WriteLine("Ögrencinin bilgileri");
            Console.WriteLine("AD Soyad:{0} {1}",ad,soyad);
            decimal sonuc = (not1 + not3 + not2) / 3;
            Console.WriteLine("Ortalamanız :"+sonuc);

            if (sonuc<45)
            {
                Console.WriteLine("Klaınız....");

            }
            else
            {
                Console.WriteLine("Geçtiniz....");
            }
        }
        
    }
    
}

