// See https://aka.ms/new-console-template for more information

static void Main(string[] args)
{

    Console.WriteLine("sadık");
    Console.WriteLine(true);  //burada bır metot cerısınde 19 farklı tur var bizde bunun gıbı metotlar yaza biliriz


    topla(2.6534,2.2);


}



static void topla(int sayı1,int sayı2)
{

    int toplam = sayı1 + sayı2;
    Console.WriteLine(toplam);
}
 static void topla(decimal sayı1,decimal sayı2)
{
    decimal toplam = sayı2 + sayı1;
    Console.WriteLine(toplam);
}

 static void topla(string metin1,string metin2)
{
    Console.WriteLine(metin1+" "+metin2);
}