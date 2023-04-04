// See https://aka.ms/new-console-template for more information

using System.Collections;

//generık olmayan koleksıyon davranısı

Hashtable h1 = new();
h1.Add(1,"bir");
h1.Add(2, "iki");
h1.Add(3, true);



//h1.Add(1, false);   hata verır cunkı key degerının farklı olması gerekır



//dictionery <Tkey,Tvalue>

Dictionary<int, string> dictoneryList = new();
dictoneryList.Add(1, "bir");
dictoneryList.Add(2, "iki");
dictoneryList.Add(3, "üç");
// dictoneryList.Add(1, "test"); hata verır aynı key e sabıt 


bool sılmesonuc = dictoneryList.Remove(1);
if (sılmesonuc == true)
{
    Console.WriteLine("silindi");
}
else
{
    Console.WriteLine("aranana deger lıste ıcerısınde bulunamadı" +
        "silme işlemi başarısız....");
}

bool aranandegersonuc=dictoneryList.ContainsKey(1); //vermıs oldugumuz keyın lıstenın ıcerısınde varmı yokmu ona bakar...
bool arananasonuc = dictoneryList.ContainsValue("sadık"); //icerideki deger varmı yokmu dıye kontrol eder... ustekıyle aynı
if (aranandegersonuc==true)
{//deger degıstırme...
    string gelendeger = dictoneryList[1]; //boyle bır key yoksa kod hata verır 

    gelendeger = "yenilenen değer";

    dictoneryList[1] = gelendeger;

}
else
{
    Console.WriteLine("araa-nana deger koleksıyon ıcerısınde bulunamadı..");
}

if (arananasonuc)
{
    Console.WriteLine("aranan deger bulundu");
}
else
{
    Console.WriteLine("aranan deger bulunamadı...");
}

//farklı bır yol
dictoneryList[2] = "sadık sünbül";

foreach (KeyValuePair<int,string> item in dictoneryList)
{
    Console.WriteLine("anahtar: "+item.Key+" değer:"+item.Value);
}

dictoneryList.Clear(); //herseyı sıler



//sortedList  ---> kendısıne atanan key ustunden sıralama yapar int ise kucukten buyuge  kadar sıralar
//diger tum ozellıklerı Dictionary ile aynı 

SortedList<int, string> sortedlistKoleksıyon = new();
sortedlistKoleksıyon.Add(100, "yüz");
sortedlistKoleksıyon.Add(50, "elli");
sortedlistKoleksıyon.Add(1, "bir");
sortedlistKoleksıyon.Add(1000, "bin");


Console.ReadLine();