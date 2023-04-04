// See https://aka.ms/new-console-template for more information


using metotlar._1.matamatıkselişlemler;

Matematik matematik = new();
YenidenIslemyap:
matematik.Menü();
int kullanıcısecımı = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen sayı1 değerini giriniz.");
decimal sayı1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Lütfen sayı2 değerini giriniz.");
decimal sayı2 = decimal.Parse(Console.ReadLine());

decimal sonuc = 0;

switch (kullanıcısecımı)
{
    case 1: //toplama
       sonuc= matematik.ToplamaIslemi(sayı1, sayı2);
        matematik.sonucuekranayazdır(sayı1, sayı2, sonuc, "+");
        break;
    case 2: //cıkarma
        sonuc = matematik.CıkarmaIslemi(sayı1, sayı2);
        matematik.sonucuekranayazdır(sayı1, sayı2, sonuc, "-");
        break;
    case 3://carpma
        sonuc = matematik.Carpmaslemi(sayı1, sayı2);
        matematik.sonucuekranayazdır(sayı1, sayı2, sonuc, "*");
        break;
    case 4://bolme
        sonuc = matematik.BolmeIslemi(sayı1, sayı2);
        matematik.sonucuekranayazdır(sayı1, sayı2, sonuc, "/");
        break;
    default:
        Console.WriteLine("belırmıs oldugunuz deger gecerız");
        Console.WriteLine("lutfen tekrr deneyınız");
        System.Threading.Thread.Sleep(1000);
        goto YenidenIslemyap;
        
}

Console.WriteLine("Yeni işlem yapmak istiyormusunuz[E/H]:");
string EH = Console.ReadLine().ToUpper();
if (EH=="E")
{
    goto YenidenIslemyap;
}



