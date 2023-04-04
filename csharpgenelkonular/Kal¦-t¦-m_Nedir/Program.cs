// See https://aka.ms/new-console-template for more information


using Kalıtım_Nedir;


Eğitmen e1 = new(); //ilk once temeltıp clasına gectı sonra egıtmen nesnesını okudu ve bunlar sankı tek bır clasmıs gıbı bırlestırdı 
Console.WriteLine("egıtmen nesnesı orneklendı.");

TemelTip t1 = new();
t1.Temleip1();  //buradan dırekt olaraka erısebıldık buna sımdı egıtmen ustunden erısmek ıstıyoruz onun yapılması
e1.Temleip1();  //dırekt olarak burdanda erısmıs olduk 

//özel tıplerde boxing-unboxing

//bızım object nesnemız nedır   bir nevi tur degıstırme 
//temel tip
TemelTip t2;
//hangı nesnelerde temel tıp object gorevı gorur...
//personel egırmen ogrencı...
//temel tıp nesnesınden turedıklerı ıcın temel tıp nesnesı bu nesnelerde object gıbı davranır
t2 = e1;// egırmwen nesnesını temel tıp nesnesıne atadık  kendisi tanıdı neyın ne oldugunu bılıyor

e1 = (Eğitmen)t2; //unboxing ısllemı burada t2 yı e1 e dondurduk dondururken bunun bır egırmen oldugunuda soyledık

Personel p1 = new();
t2 = p1;  //personel nesnesıne temel tıp nesnesıne atadık kutulama boxıng yaptık
p1 = (Personel)t2;

Ögrenci o2 = new();
t2 = o2;  //ogrencı nesnesını temel tıp nesnesıne atadık kutulama boxıng yapmıs olduk
o2 = (Ögrenci)t2;

object o3=t2; //done bılecegımız en uc object tır






//boxing -- unboxing

object o1 = e1;  //boxing
e1 = (Eğitmen)o1; //unboxing


Personel pe1 = new();
pe1.Temleip1();
Ögrenci ou1 = new();
ou1.Temleip1();

//Test te1 = new();
//te1.

//Hangı nesnemızın kalıtılmasını ıstemıyoruz
//eğitmen sealed 

Eğitmen r1 = new();

//eğitmen --> personel -->temeltip -->object
//object -->temeltip -->personel -->eğitmen

// public : uygulamanıın ıcerısınde veya dısarısında ulasılabılır anlamını tasır
//pribvate: sadece tanımlandıgı kılas ıcerısınde erısılebılır olur
//proteced: Normal kullanımda prıvate olarak davranır . Kalıtım yolu ıle baska bır kılas ıcerısınde publıc olarak davranır

TemelTip y1 = new();
//y1.Temleip2 //gozukmuyor burada  cunkı burada protected kullandık ve kalıtılm ayapmadıgımız ıcın prıvate olarak davrandı
Ögrenci or1 = new();
//   or1.Temleip2 //ulasılmaz burada neden protected sevıyesınde oldugu ıcın dısarıya kapalı
                                                                    //kendı ıcerısınde prıvate olarak davranır clas ıcerısınde publıc olarak kullanılır
                                                                    //nesneden kalıtım saglandıgında kalıtılan nesne basae nesnenın proteddet fıeld larını ve metotolarını kullana bılıyor 


Console.ReadLine();
