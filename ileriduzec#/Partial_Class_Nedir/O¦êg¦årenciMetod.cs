using System;
namespace Partial_Class_Nedir
{
    public partial class Öğrenci  //partıal dedıgımız ogrencı clasının bır parcasısın dedık
    {
        public int yenıKayıt(Öğrenci o)
        {
            Console.WriteLine("kayıt ıslemı basarılı");
            return 1;
        }

        public int kayıtGuncelle(Öğrenci o)
        {
            Console.WriteLine("kayıt guncellendı");
            return 1;
        }

        public  int kayıtsıl(Öğrenci o)
        {
            Console.WriteLine("kayıt sılındı");
            return 1;
        }
    }
}

