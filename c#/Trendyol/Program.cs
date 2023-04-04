// See https://aka.ms/new-console-template for more information



using Trendyol;

Bilgisayar b1 = new()
{
    Marka = "msi",
    Model = "r23",
    Ram = "16gb",
    İşlemci = "i7",
    AlışFiyatı = 1000,
    SatışFiyatı = 1200,
    KanpanyalıFiyat = 1100,
    Barkod = "1234567890"

};
Console.WriteLine("--------");
Bilgisayar b2 = new()
{
    Marka = "msi",
    Model = "r23",
    Ram = "16gb",
    İşlemci = "i7",
    AlışFiyatı = 1000,
    SatışFiyatı = 1200,
    KanpanyalıFiyat = 1100,
    Barkod = "1234567890"

};
Console.WriteLine("--------");
Bilgisayar b3 = new()
{
    Marka = "msi",
    Model = "r23",
    Ram = "16gb",
    İşlemci = "i7",
    AlışFiyatı = 1000,
    SatışFiyatı = 1200,
    KanpanyalıFiyat = 1100,
    Barkod = "1234560989890"

};
Console.WriteLine("--------");

SanalDataBase.ÜrünEkle(b1);
Console.WriteLine("-----------");

SanalDataBase.ÜrünEkle(b2);

Console.WriteLine("---------");
SanalDataBase.ÜrünEkle(b3);

Console.ReadLine();