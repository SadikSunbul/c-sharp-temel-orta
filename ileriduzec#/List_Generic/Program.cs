// See https://aka.ms/new-console-template for more information


//array lıstın generıc versıyonu

using System.Collections;
using System.Collections.Generic;
using List_Generic;

ArrayList list = new();
list.Add(1);
list.Add("bir");

//<T> tipi demek .net freamwork içerisinde olan veya bizim olusturduğumuz herhangibir tip demek
//

List<int> listeGeneric = new();
listeGeneric.Add(1);//ben sadece ınt deger kabul ederım dıyor strıng yaazamayız ...
listeGeneric.Add(2);
//listeGeneric.Add("uc");  hata verır

for (int i = 0; i < listeGeneric.Count; i++)
{
    Console.WriteLine(listeGeneric[i]);
}
Console.WriteLine("-----------");
List<string> isimler = new();
isimler.Add("sadık");
isimler.Add("osman");

for (int i = 0; i < isimler.Count; i++)
{
    Console.WriteLine(isimler[i]);
}
Console.WriteLine("-------------");


List<Müşteri> musteriliste = new();

musteriliste.Add(new Müşteri()  //yazım seklıne cok dikkat (){id=1,isim="sadık",...}); seklınde de yazılabılır
{
    Id = 1,
    İsim="sadık",
    Soyİsim="sünbül"
    
});

foreach (var item in musteriliste)
{
    Console.WriteLine(item.İsim+"/"+item.Soyİsim);
}

Console.ReadLine();