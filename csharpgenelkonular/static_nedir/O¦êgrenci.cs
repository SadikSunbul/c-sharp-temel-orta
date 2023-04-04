using System;
namespace static_nedir
{
    public class Ögrenci
    {
        public Ögrenci()
        {

        }
        public string Isim { get; set; }
        public string Soyİsim { get; set; }
        public string EmailAdres { get; set; }

        public  void Test1()
        {
            Console.WriteLine("nesne ornegı alındıktan sonra calısan metotur");
            Test2(); //burada statıc olmayan bır metot da statıc olan bır metodu cagırabılır
        }

        public static void Test2()
        {
            Console.WriteLine("nesne ornegi alınmadan kullanıla bilir");
            //burada statıc olan metot statıc olmayan bır etotdu cagırmaz
            //sadece statıc olanları cagırabılır
        }
    }
}

