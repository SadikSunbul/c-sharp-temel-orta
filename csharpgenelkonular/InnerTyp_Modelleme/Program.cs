// See https://aka.ms/new-console-template for more information

using InnerTyp_Modelleme;

Müşteri m1 = new();
m1.MusteriId = 1;
m1.TcKimlikno = "1241241";
m1.İsim = "sadık";
m1.Soyİsim = "sünbül";
m1.Olusturmatarihi = DateTime.Now;

// m1.müşteriAdresleri = new MüşteriAdres[5]; //yenı 5 eleamanlı bır dızı yaptık yapmazsak hata alırız  baska yontemını denee yapıcı metot ıle

m1.müşteriAdresleri[0] = new MüşteriAdres()
{
    İl = "konya",
    İlce = "meram",
    Adres = "adres...",
    AdresTipi = "işyeri"
};
m1.müşteriAdresleri[1] = new MüşteriAdres()
{
    İl = "konya",
    İlce = "meram",
    Adres = "adres...",
    AdresTipi = "işyeri"
};

m1.müşteriAdresleri[0].MşteriAdresTestMetot(); //inner typ ın ıcerısındekı metotda ulastık 

m1.müşteriSiparişBilgileri[0] = new MüşteriSiparişBilgisi()//burayı yazmasaydık altakı hata verırdı 
{
    SiparişNumarası = "sıparıs001"
};

m1.müşteriSiparişBilgileri[0].ürüns[0] = new Ürün()
{
    UrunId = 1,
    Tanım = "telefon",
    Fiyat = 1500
};


Console.ReadLine();

