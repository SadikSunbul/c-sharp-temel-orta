// See https://aka.ms/new-console-template for more information

//107 asalsa terside asal olmalı 701


Console.WriteLine("bır sayı gırınız:");
int gırılen = Convert.ToInt32(Console.ReadLine());
int ctr = 1;
for (int i = 2; i < gırılen; i++)
{
    if (gırılen % i == 0)
    {
        ctr = 0;
    }
}
if (ctr == 1)
{
    Console.WriteLine("girilen sayı asal sayıdır=" + gırılen);

}
int gecici1 = gırılen;
int gecici = gırılen;
double terssayı = 0;
int sayac = 0;

while (gecici1 >=1)
{
    gecici1 = gecici1 / 10;
    sayac++;
}

Console.WriteLine(sayac);

while (gecici > 1)
{
    int mod;
    mod = gecici % 10;
    gecici = gecici / 10;

    if (sayac > 0)
    {
        double t = (Math.Pow(10, sayac));
        terssayı = terssayı + (mod * t);
        sayac--;
    }
}

Console.WriteLine("ters donmus sayı=" + terssayı);

Console.ReadLine();
