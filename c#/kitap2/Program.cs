// See https://aka.ms/new-console-template for more information



Personel personel = new Personel()
{
    Ad = "sülo",
    SoyAd = "yılmaz",
    DoğumTarihi = new DateTime(2003, 08, 29),
    İşeGirişTarihi = new DateTime(1995, 2, 16),
    SGK_No = 231245667


};  //$ isaretı ıcerıdekı suslu parantezı ayırmak ıcın ullanılır 

Console.WriteLine("hesaplama:"+personel.safa(1,2));

Console.WriteLine("----------");
personel.Hesapla(2, 3);


Console.WriteLine($"Ad:{personel.Ad}");
Console.WriteLine("---------------");
Console.WriteLine("adı:"+personel.Ad);
Console.WriteLine("---------------");
Console.WriteLine($"soyad:{personel.SoyAd}"  );
Console.WriteLine("-------------");
Console.WriteLine("doğum tarihi");
Console.WriteLine(personel.DoğumTarihi.ToShortDateString());
Console.WriteLine("----------------");
Console.WriteLine("işe giriş tarihi:");
Console.WriteLine(personel.İşeGirişTarihi.ToShortDateString());
Console.WriteLine("-----------------");
Console.WriteLine($"sgk no:{personel.SGK_No}");
Console.WriteLine($"yaşı:{personel.Yaş(personel.DoğumTarihi)}");

Console.WriteLine("---------------");
Console.WriteLine($"{nameof(personel.VucutKitleEndeksi)}");
Console.WriteLine($"{typeof(float)}");
Console.WriteLine($"{personel.VucutKitleEndeksi(1.78f,99.5f)}");

Console.WriteLine($"{nameof(personel.VucutKitleEndeksi)}");
Console.WriteLine($"{typeof(decimal)}");
Console.WriteLine($"{personel.VucutKitleEndeksi(1.78m,99.5m)}");

Console.WriteLine($"{nameof(personel.VucutKitleEndeksi)}");
Console.WriteLine($"{typeof(double)}");
Console.WriteLine($"{personel.VucutKitleEndeksi(1.78d,99.5d)}");


Console.WriteLine($"Girdiğiniz sayıların toplamı :{personel.Hesapla(2, 5)}");


public abstract class Kisi
{
    public string  Ad { get; set; }
    public string SoyAd { get; set; }
    public DateTime DoğumTarihi { get; set; }
    private float Boy;   // ğrıvate ona ozel demek gondermez 
    private float Kilo;
    public abstract int Yaş(DateTime DogTar);
    private float VucutKitleEndeksi(float Boy, float Kilo) => Kilo / (Boy * Boy);

    public decimal VucutKitleEndeksi(decimal Boy, decimal Kilo) => Kilo / (Boy * Boy);
    public   double VucutKitleEndeksi(double Boy, double Kilo) => Kilo / (Boy * Boy);

    public double safa(double sayı1, double sayı2)=> sayı1 / (sayı2 * sayı2);

    public int Hesapla(int s, int q)    //return donmek demek yazmayınca hata verır 
    {
        int toplam = s + q;
        return toplam;
    }
}

class Personel : Kisi
{
    public override int Yaş(DateTime DogTar) => DateTime.Today.Year - DogTar.Year;
    
    public DateTime İşeGirişTarihi { get; set; }
    public long SGK_No { get; set; }

}