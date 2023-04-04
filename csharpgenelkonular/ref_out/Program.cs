// See https://aka.ms/new-console-template for more information


//Ref Out anahtar sozcuklerınde eskı .net freamwork versiyonlarında 1 fark vardı.
//mevcut freamvork versıyonu 7.0 olanlar bu farktan etkılenmıycekler
//

int sayı1 = 0;
DegerAta(ref sayı1);  //deger tıpı referans tıpe atar

topla(5, 9, 20, 45,11,22,56);

Console.ReadLine();


static void DegerAta(ref int gelenDeger)
{
    gelenDeger = 10;


}

         //********Params*******

static void topla(params int [] sayılar) //ıstedıgın kadar deger gırmenızı saglar ve degerlerı bır dızıye atar sonra ıslemlerı yaptırabılırız
{               //params ıfadeler parametrelerın son parametresı olmalıdır değilse sonrasına deger atıyamazsınız.
    int toplam = 0;
    for (int i = 0; i < sayılar.Length; i++)
    {
        toplam += sayılar[i];
    }
    Console.WriteLine("Toplam={0}",toplam);
}