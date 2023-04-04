// See https://aka.ms/new-console-template for more information



using otel_resepsiyon;

string cevap;

do
{
    Console.Clear();
    DataBase.Menü();
    Console.WriteLine("Cıkmak ıstıyorsanız H yazınız Devam Etmek için E");
     cevap = Console.ReadLine().ToUpper();
} while (cevap=="E");


Müsteri m1 = new Müsteri();
m1.İsim = "hawlıuqw";
m1.Soyisim = "hkasçfhwel";
