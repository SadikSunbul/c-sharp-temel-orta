// See https://aka.ms/new-console-template for more information
using OOP_nedir;
#region
using OOP_nedir;

Araç araç = new("opel", "corsa", 2010, 56000);
araç.AlisFıaytı = 28000;
araç.SatısFıyatı = 32000;
araç.MaxİndirimTutari = 1500;
//araç.Fiyat=   kapsulleme konusu....

araç.FiyatAta(31000);
araç.BilgileriGörüntüle();


Console.ReadLine();
#endregion







Müşteri M1 = new(); //ezmezsenız dıfuld degerlerı alır ezersenız atadıgınız degerlerı alır

Müşteri M3 = new("123454523","murat");//buraya 4 metot tanımladık ıstedıgını kullanabiliriz

M1.TcKimlikno = "124235425";
M1.İsim = "sadık";
M1.soyisim = "sünbül";
M1.cinsiyet = 717770001;

Müşteri M2 = M1; //burada referans degerlerını esıtmeıs olduk


M2.İsim = "Murat";  //buradaki değişiklık m1 de etkılıyor 
M1.TcKimlikno = "1111111111";  //buradakıde m2 yı etkılıyor cunkı ıkısınınde referanc adresı aynı

//M2 = null;
//M1 = null;
//hıp bolede bır yapı pointer sız kalırsa bu deger remden duser ve arkdakı datamız sılınır pointerla tutarsak sılınmez

//string isim = M1.İsim;  //deger acılmaıs bana dıyor new demedıgımız ıcın oldu

bool MusteriKontrol = M1.Musterikontrol(); //parametre almıyoruz oıcerıde ztn m1 tcnosunu tutyor orda donuyor m1.---- yazdıgımız ıcın 


Console.ReadLine();