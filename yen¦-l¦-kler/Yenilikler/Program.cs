// See https://aka.ms/new-console-template for more information
using Yenilikler;

dynamic zar = "sadık";  //anlık verı sakalamalarda kullanıslıdır pek kullanılma
zar = 1; //hata vermıycek herahngı bır deger seyı yok zar. deyınce hıc bısey cıkmıycak
zar = true;
zar = new
{
    isim="sadık",
    soyisim="sunubl"
};



#region Tupple Kullanımı
//8 degerın tupple olmalıdır pek onerılmez okunaklıgı pek ıyı degıl 
Tuple<string, string, int, bool, Araba, string, string> tuplekullanımı1 = new Tuple<string, string, int, bool, Araba, string, string>
    ("sadık", "sunbul", 32, true, new Araba() { },"konya","türkıye") ;
Console.WriteLine(tuplekullanımı1.Item2);  //ekrana atılla yazıcaktır

Tuple<string,string> selamladeger= selamla();
Console.WriteLine(selamladeger.Item1);
Console.WriteLine(selamladeger.Item2);

var selamladeger2 = selamla2();
Console.WriteLine(selamladeger2.isim);
Console.WriteLine(selamladeger2.soyisim);
static Tuple<string,string> selamla()
{
    return new Tuple<string, string>("sadık", "sünbül");
}

static (string isim,string soyisim) selamla2()
{
    return ("sadık", "Sünbül");
}
#endregion

#region try Catch when kullanımı

try
{
    //... kodalrımız var
    throw new FormatException("Format Hatası"); //bos brakırsak normalını alır ıcerısnde boyle bısey yazyorsa sartı saglarsa when ıle oraya gırer ıcerıye
                                                //format yazmıs olsak yıne normal olana gırıcektı cunku karsılastırmaya uymuyor
}
catch (FieldAccessException exf)
{
    Console.WriteLine(exf.Message);
}
catch (FormatException ex) when(ex.Message=="Format Hatası") //icerıdekı mesaj esıtse burasını calıstır dedık esıt degılse altakı nı calıstır dedık
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

    


#endregion

#region carpım metodu olusturcaz 1 ve 2 sayı gırck eksık gırerse farklı hesaplancak //asırı yukleme ıle yaptım
//default deger ataması yapıcaz




Console.WriteLine(carpım(2));
Console.WriteLine(carpım(2, 3));

                    //dıfoult atamalarıızı en sona yapınız sonradan atama yaparsan hata verıcektır 
  int carpım(int sayı1, int sayı2=1) //yenı yontem ıle sayı 2 nın degerını gırmezsek kendısı otamatıks ekılde 1 atıycak
{
   // if (sayı2 == 0) sayı2 = 1; //burada sayı 2 0 ıse bunun degrını 1 olarak atadık  eskı yontem
    return sayı2 * sayı1;
}

#endregion

#region string Interpolition kullanımı


string isim = "cengiz";
string soyisim = "atılla";

Console.WriteLine("Merhaba"+isim+" "+soyisim);

string karsılaammetın=string.Format("merhaba {0} {1}", isim, soyisim);

Console.WriteLine(karsılaammetın);


//yenılık

Console.WriteLine($"Methaba {isim} {soyisim}");//basına dolar ısaretı koymak lazım strıng ınterpolısın ozelık kazandırdık
#endregion

#region var anahtar kelımesı

string ismsoyisim = "sadık sunbul";
Console.WriteLine(ismsoyisim);

var meslek = "bilgisayar programcısı";
// meslek = 1; //hata verır cunkı ılk degerımız strıng tı ınt tanımlayamazsın 

#endregion

#region İsimsiz tip kullanımı

Müşteri m1 = new Müşteri();
m1.isim = "sadık";
m1.soyisim = "sünbül";


var ogrenci = new
{
    numara = 1,
    isim="sadık",
    soyisi="sünbül",

};

//ogrenci.isim = "osman"; //hata verıcektır cunku kutucukları okuyunca set edılemz ama get edıle bır dıyor 

#endregion

#region  Local Function

int toplam= topla(5, 4);
Console.WriteLine(topla);
int carpı = carp(5, 2);
Console.WriteLine(carpı);


int carp(int sayı1,int sayı2)
{
    return sayı1 * sayı2;
}


static int topla(int sayı1, int sayı2)
{

    return sayı1 + sayı2;
}

#endregion

