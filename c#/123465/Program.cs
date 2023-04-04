// See https://aka.ms/new-console-template for more information



using _123465;

Bilgisayar b1 = new()
{
    Marka = "msı",
    Model = "r2",
    Alişfıyatı = 1000,
    SatışFıyatı = 1200,
    KanpanyalıFiyat = 1100,
    Barkod = "123adaf",
    EkranKartı = "RTX360",
    Ram = "16gm msı",
    İşlemci = "i7",

};
Console.WriteLine("----kayıt b1-----");

SanalDataBase.ÜrünEkle(b1);

Console.WriteLine("---- urun ekle b1------");
Bilgisayar b2 = new()
{
    Marka = "msı",
    Model = "r2",
    Alişfıyatı = 1000,
    SatışFıyatı = 1200,
    KanpanyalıFiyat = 1100,
    Barkod = "123adaf",
    EkranKartı = "RTX360",
    Ram = "16gm msı",
    İşlemci = "i7",

};

Console.WriteLine("-----kayıt b2 -----");
SanalDataBase.ÜrünEkle(b2);

Console.WriteLine("------ urun ekle b2-------");

Console.ReadLine();