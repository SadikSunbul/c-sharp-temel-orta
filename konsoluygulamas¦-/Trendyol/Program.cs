// See https://aka.ms/new-console-template for more information


using Trendyol;
Console.WriteLine("-----q------");
Televizyon q = new Televizyon()
{
    Model = "lqwe1",
    Marka = "lg",
    AlişFiyati = 1200,
    SatişFiyati = 1210,
    KanpanyalıFiyat = 1201,
    EkranBoyutu = "101 inç",
    barkod = "afsf12324",
    HDMI = true,
    SmartTv = true,
};

SanalDatBase.ÜrünEkle(q);

Console.WriteLine("-----w------");

Televizyon w = new Televizyon()
{
    Model = "lqwe1",
    Marka = "lg",
    AlişFiyati = 1200,
    SatişFiyati = 1210,
    KanpanyalıFiyat = 1201,
    EkranBoyutu = "101 inç",
    barkod = "afsf12324",
    HDMI = true,
    SmartTv = true,
};

SanalDatBase.ÜrünEkle(w);

Console.WriteLine("------r-------");

Bilgisayar r = new Bilgisayar()
{
    Marka = "msi",
    Model = "qwer3",
    AlişFiyati = 3200,
    SatişFiyati = 3300,
    KanpanyalıFiyat = 3210,
    EkranKartı = "msı rtx360",
    Ram = "msı 16 gb",
    barkod = "asfasfasfasg3245",
    İşlemci = "i7 1120h"
};

SanalDatBase.ÜrünEkle(r);


Console.ReadLine();


