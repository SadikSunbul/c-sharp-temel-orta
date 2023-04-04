// See https://aka.ms/new-console-template for more information


for (int i = 998001; i >0; i--)
{
    int sayi = i;
int temp = sayi;
    int mod;
    int sayinintersi = 0;
    while (temp != 0)
    {
        mod = temp % 10;
        temp = temp / 10;

        sayinintersi = sayinintersi * 10 + mod;
    }

    if (sayi == sayinintersi)
    {
        Console.WriteLine("aradıgınız polındromık sayı :"+sayinintersi);
        break;
    }

}



Console.ReadLine();