// See https://aka.ms/new-console-template for more information

using Kapsülleme;

Musteri musteri = new();

//musteri.İsim = "cengiz";
//musteri.Soyİsim = "atilla";

/*
 * Field deger ataması yapılamasın ama deger okunabilsin
 * Field deger ataması yapılsın ama okunmasın
 * Field deger ataması yapsın ama ilk 4 hanesini okusun
 * Field deger ataması ve okuma ıslemlerı yapılsın ama bu iki işlemde bizim 
 * elirlediğimiz bir süreçtegeçsin veri daha sonra gösterilsin.
 */


//clas
//Field
//Property
//get & set

//musteri.emailAdres = "shsjs@gmail.com";

// musteri.EmailAdres = "asfaf@gmail.com";

Console.WriteLine(musteri.EmailAdres);
Console.WriteLine("--------------------");

// Field deger ataması yapılamasın ama deger okunabilsin


Console.WriteLine(musteri.ID.ToString());
// musteri.ID = 10;  hata gosterır burası cınku setı bız prıvate yaptık burası ulasamaz ıstegımızde buydu zaten.


musteri.TckimlikNo = "12345678901";
Console.WriteLine(musteri.TckimlikNo);

//isim ve soyisim [soy isim ]=set
//email adresi...
//email get afsasf@gmail.com
//set : private olcak
//

musteri.İsim = "sadık";
musteri.Soyisi = "sünbül";
Console.WriteLine(musteri.EmailAdres);



Console.ReadLine();