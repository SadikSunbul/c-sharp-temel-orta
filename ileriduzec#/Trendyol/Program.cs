// See https://aka.ms/new-console-template for more information


using Trendyol;

Ürün a1 = new()
{
    model = "msı",
    marka = "fsa",
    alışFıyatı = 1000,
    satışFşyatı = 1100,
    kanpanyalıFiyat = 1010,
    barkod = "123feae"
};
Console.WriteLine("-----a1----");
SanalDataBase.ürünEkle(a1);
Console.WriteLine("----------");

Ürün a2 = new()
{
    model = "msı",
    marka = "fsa",
    alışFıyatı = 1000,
    satışFşyatı = 1100,
    kanpanyalıFiyat = 1010,
    barkod = "123feae"
};

Console.WriteLine("------a2-----");
SanalDataBase.ürünEkle(a2);
Console.WriteLine("--------------");  
Console.ReadLine();      