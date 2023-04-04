// See https://aka.ms/new-console-template for more information

Console.Write("lutfen bir sayı gırınız:");
int sayı = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
int gecici = sayı;
while (!(gecici < 1))
{
    int mod;
    mod = gecici % 10;
    gecici = gecici / 10;
    toplam = mod + toplam;
}

Console.WriteLine("--------------");
Console.WriteLine("rakamların toplamı:" + toplam);

int geçici1 = sayı;
int toplam1 = 0;
int toplam2 = 0;

for (int i = 2; i < sayı; i++)
{
    if (geçici1 % i == 0)
    {
        Console.WriteLine("asla carpanı=" + i);
        
        geçici1 /= i;

        if (i > 9)
        {
            int gecici2 = i;
            while (!(gecici2 < 1))
            {

                int mod;
                mod = gecici2 % 10;
                gecici = gecici2 / 10;
                toplam2 = mod + toplam;
            }
            toplam1 = toplam1 + toplam2;
        }
        else
        {
            toplam1 = toplam1 + i;
        }
        
        i = 2;
    }
}
if (toplam1 == toplam2)
{
    Console.WriteLine("gırdıgınız sayı smıth sayı");
}
else
{
    Console.WriteLine("gırdıgınız sayı smıth say degıldır");
}
Console.ReadLine();
Console.ReadKey();

