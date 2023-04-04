// See https://aka.ms/new-console-template for more information
//System.Collections.Generic

int[] dizi = new int[5];
int toplam = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("dizi["+i+"] elemanı gırınız:");
    dizi[i] = Convert.ToInt32(Console.ReadLine());
    toplam = toplam + dizi[i];
}
int ort = toplam / 5;

int ortustu = 0;
int ortaltı = 0;
int ortaes = 0;
for (int i = 0; i < 5; i++)
{
    if (dizi[i] > ort)
    {
        ortustu++;
    }
    else if (dizi[i]<ort)
    {
        ortaltı++;
    }
    else
    {
        ortaes++;
    }

}
Console.WriteLine("sayıoalrın ortalaması:"+ort);
Console.WriteLine("ortalamanın ustunde olan sayı :"+ortustu);
Console.WriteLine("ortalamanın altında olan sayı:"+ortaltı);
Console.WriteLine("ortalamaya esıt olan sayı :"+ortaes);
