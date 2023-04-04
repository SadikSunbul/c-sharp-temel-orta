// See https://aka.ms/new-console-template for more information



Console.Write("lutfen bir sayı gırınız:");
int sayı = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
int gecici = sayı;
while (!(gecici<1))
{
    int mod;
    mod = gecici%10;
    gecici = gecici / 10;
    toplam = mod + toplam;
}

Console.WriteLine("--------------");
Console.WriteLine("rakamların toplamı:"+toplam);

int geçici1 = sayı;
int toplam1 = 0;

for (int i = 2; i < sayı; i++)
{
    if (geçici1 % i == 0)
    {
        Console.WriteLine("asla carpanı=" + i);
        toplam = toplam + i;
        geçici1 /= i;
        i = 2;
    }
}
Console.WriteLine(toplam);
