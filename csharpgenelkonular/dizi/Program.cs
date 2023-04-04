// See https://aka.ms/new-console-template for more information

string[] ogrencılıstesı = new string[5]; //5 eleman olucak ıcerısınde dıyoruz
//buraya dıkat dızının ıcerısndekı 1. eleamanı almak ıcın [0] dememız gerekıyor 0. ındıs 1. elemanı tutar

ogrencılıstesı[0] = "sadık";
ogrencılıstesı[1] = "osman";
ogrencılıstesı[2] = "safa";
ogrencılıstesı[3] = "taha";
ogrencılıstesı[4] = "tayfun";

Console.WriteLine(ogrencılıstesı[1]);
Console.WriteLine("------------");
foreach (var ısım in ogrencılıstesı)
{
    Console.WriteLine(ısım);
}
int a = 10;
Console.WriteLine("{0}. sadık sünbül",a);

Console.ReadLine();