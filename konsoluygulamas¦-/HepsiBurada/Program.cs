// See https://aka.ms/new-console-template for more information



using HepsiBurada;

Urun u1 = new Bilgisayar()
{
    alışFiyatı = 10,
    satışFiyati = 15,
    kanpanyalıFiyati = 11,
    barkod = "qfw23425",
    Marka = "msi",
    Model = "ctr",
    ekranKartı = "rtx3060",
    işlemci = "i7",
    ram = "15",
};

SanalDataBase.Kayit(u1);

Console.WriteLine("----------------");

Urun u2 = new Bilgisayar()
{
    alışFiyatı = 10,
    satışFiyati = 9,
    kanpanyalıFiyati = 22,
    barkod = "qf23425",
    Marka = "msi",
    Model = "ctr",
    ekranKartı = "rtx3060",
    işlemci = "i7",
    ram = "15",
};

SanalDataBase.Kayit(u2);

Console.WriteLine("-------------");
Urun u3= new Bilgisayar()
{
    alışFiyatı = 10,
    satışFiyati = 9,
    kanpanyalıFiyati = 22,
    barkod = "qf2325",
    Marka = "msi",
    Model = "ctr",
    ekranKartı = "rtx3060",
    işlemci = "i7",
    ram = "15",
};

SanalDataBase.Kayit(u3);



Console.ReadLine();