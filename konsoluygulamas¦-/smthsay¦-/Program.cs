// See https://aka.ms/new-console-template for more information


Console.Write("bır sayı gırınız:");
int sayı = Convert.ToInt32(Console.ReadLine());
int gecici1 = sayı;
int geçici = sayı;
int toplambasmak = 0;
int toplamasal = 0;


for (int i = 2; i < sayı; i++)
{
    if (geçici % i == 0)
    {
        Console.WriteLine("asla carpanı=" + i);
        geçici /= i;
        int x = i;
        if (i>9)
        {
            do
            {
                int mod1;
                mod1 = x % 10;
                x = x / 10;
                toplamasal = toplamasal + mod1;

            } while (!(x < 1));



        }
        else
        {
            toplamasal= toplamasal + i;
        }
        i = 1;
    }
}
Console.WriteLine(toplamasal);


while (!(gecici1<1))
{
    int mod;
    mod = gecici1 % 10;
    gecici1 = gecici1 / 10;
    toplambasmak = toplambasmak + mod;
}

Console.WriteLine(toplambasmak);
if (toplamasal == toplambasmak)
{
    Console.WriteLine("gırılen sayı sımıth sayı,");
}
else
{
    Console.WriteLine("gırılen sayı sımth sayı degıl");
}
Console.ReadKey();