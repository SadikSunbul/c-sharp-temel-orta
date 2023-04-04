// See https://aka.ms/new-console-template for more information


using metod_odev;

string ogrencıadı = string.Empty;
string ogrencısoyadı = string.Empty;
decimal not1 = 0;
decimal not2 = 0;
decimal not3 = 0; ;
decimal ortalama = 0;

Console.WriteLine("merhaba ortalamasını hesaplamak ıstedoıgınız ogrencının bılgılerı nı gırınız:");

Console.WriteLine("Ad:");
ogrencıadı = Console.ReadLine();

Console.WriteLine("Soyadı");
ogrencısoyadı = Console.ReadLine();

Console.WriteLine("Not 1:");
not1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Not 2:");
not2 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Not 3:");
not3 = decimal.Parse(Console.ReadLine());


Ogrenci o = new();
o.Hesapla(ogrencıadı,ogrencısoyadı,not1, not2);  //burada not3 metodu gırılmezse sorun olusturur bunu gırılmesede olur yapmak lazım
                                        //hata kalktı burada cunku decimal not3=45 yaptık suan not3 yerıne dırek 45 alıyor

Console.ReadLine();
  
