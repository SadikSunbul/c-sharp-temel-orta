// See https://aka.ms/new-console-template for more information




using Kalıtım_Bolum_Sonu_Odevi;

Bilgisayar b1 = new() //ılgılı ıslemlerı baseclasta yaptıgımız halde neden ıd degerımız degısmedı nedenı private set dedıgımız ıcın ordan bır degeer gelemez
{
   // Id = 1,  //gırmek ıstemıyorsak uygulamanın bu alanı set edılebılır sekılde brakmsınıda ıstemıyorum kendısı ıd degerı ataması yapsın 
    Marka = "Lenova",
    Model = "z50",
    İşlemci = "i5",
    AlisFıyat = 1000,
    SatısFıyatı = 1500,
    KanpanyaFıyat = 1000,
    Barkod = "2131242325", // => sanal bır data olusturcaz ve kontrol edıcez genelde arraylıst ıle yapıcaz 

};

SanalDataBase.yeniUrunEkle(b1);

Console.WriteLine("--------");
Bilgisayar b3 = new() //ılgılı ıslemlerı baseclasta yaptıgımız halde neden ıd degerımız degısmedı nedenı private set dedıgımız ıcın ordan bır degeer gelemez
{
    // Id = 1,  //gırmek ıstemıyorsak uygulamanın bu alanı set edılebılır sekılde brakmsınıda ıstemıyorum kendısı ıd degerı ataması yapsın 
    Marka = "Lenova",
    Model = "z50",
    İşlemci = "i5",
    AlisFıyat = 1000,
    SatısFıyatı = 1500,
    KanpanyaFıyat = 1000,
    Barkod = "2131242325", // => sanal bır data olusturcaz ve kontrol edıcez genelde arraylıst ıle yapıcaz 

};
SanalDataBase.yeniUrunEkle(b3);

Console.ReadLine();

Bilgisayar b2 = new();
Console.WriteLine("Lütfen Bilgisayaraın Markasını Giriniz");
b2.Marka = Console.ReadLine();
Console.WriteLine("Lütfen modelini giriniz...");
b2.Model = Console.ReadLine();
Console.WriteLine("İşlemci:");
b2.İşlemci = Console.ReadLine();
Console.WriteLine("alıs fıyatı");
b2.AlisFıyat =Convert.ToDecimal( Console.ReadLine());
Console.WriteLine("satıs fıyatı");
b2.SatısFıyatı = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("kanpanya fıyatı");
b2.KanpanyaFıyat = Convert.ToDecimal(Console.ReadLine());


Console.ReadLine();


