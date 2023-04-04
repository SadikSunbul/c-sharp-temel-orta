// See https://aka.ms/new-console-template for more information

Random x = new Random();

int sayi1 = x.Next(50); //0’dan 50’ye kadar rastgele sayı üretir. 50 dahil değildir.
int sayi2 = x.Next(50, 100); //50 ile 100 arasında rastgele bir sayı üretir. 100 dahil değildir.


Console.WriteLine(sayi1);
Console.WriteLine(sayi2);
