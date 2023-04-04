using System;

namespace delegate_2.vıdeo
{
    class Program
    {
        delegate void ekranayaz(string isim, string soyisim);

        static void Main(string[] args)
        {
            ekranayaz Testı = new ekranayaz(test2); //var olan bır metodu kullanarak ıcıne eklemek 

            //isimsiz metot kullanımı
            ekranayaz Testıı = new ekranayaz(delegate (string Isım, string Soyisim)
            {
                Console.WriteLine(Isım + " " + Soyisim);
            });

            //lamda expresın kullanımı
            ekranayaz test3 = (string Isım, string Soyisim) =>
            {
                Console.WriteLine(Isım + " " + Soyisim);
            };

            Testı("sadık", "sünbül");
            Testıı("sadık", "sünbül");
            test3("sadık", "sünbül");


            Console.ReadLine();
        }

        static void test2(string Isım,string Soyisim)
        {
            Console.WriteLine(Isım+" "+Soyisim);
        }
    }
}

