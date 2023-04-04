// See https://aka.ms/new-console-template for more information

int sayac = 0;

for(; ; ) //kosula baglı kalmadan sonsuz kere doner
{
    sayac++;
    //break anahtar kelımesı //burdakı tamamen foru kırar ve cıkar 
    //contiune anahtar kelimesi //contınueden sorakı kodları calıstırmaz forun basına atar
    if(sayac==2)
        break; //
    Console.WriteLine("merhaba ben bır sonsuz donguyum");
}

Console.ReadLine();