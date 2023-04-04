using System;
namespace Partial_Class_Nedir
{
    public class Müşteri
    {
        public Müşteri()
        {
        }
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyİsim { get; set; }
        public string Email { get; set; }

        public int yeniKayıt( Müşteri m)
        {
            Console.WriteLine("database kaydı yapıldı");
            return 1;
        }

        public int kayıtGuncelle(Müşteri m)
        {
            Console.WriteLine("musterı kaydı guncellendı");
            return 1;

        }

        public int kayıtSıl(Müşteri m)
        {
            Console.WriteLine("müşteri kaydı sılındı");
            return 1;
        }
    }
}

