// See https://aka.ms/new-console-template for more information

using denemeafa;

Person person1 = new();

Yeniden:
Console.Clear();

Console.WriteLine("Notu hesaplanacak ogrencının bılgıleri.");
Console.WriteLine("Ad:");
string ad = Console.ReadLine();
Console.WriteLine("Soyad:");
string soyad = Console.ReadLine();

Console.WriteLine("Not 1:");
person1.Not1= decimal.Parse(Console.ReadLine());
Console.WriteLine("Not 2:");
person1.Not2= decimal.Parse(Console.ReadLine());
Console.WriteLine("Not 3:");
person1.Not3 = decimal.Parse(Console.ReadLine());


person1.Hesap(ad, soyad, person1.Not1, person1.Not2, person1.Not3);

Console.WriteLine("Yeni ogrencı ıcın entr yapınız");
Console.ReadLine();

goto Yeniden;