// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
int[] dizi = new int[10];

int gecici;
int i, j,k;

for ( i = 0; i < 10; i++)
{
    dizi[i] = rnd.Next(100);
    Console.Write(dizi[i]+"    ");
}
Console.WriteLine("\n------------\n");

for ( i = 1; i < 10; i++)
{
    gecici = dizi[i];
    for ( j = i-1; j>=0 && gecici < dizi[j]; j--)
    {
        dizi[j + 1] = dizi[j];
        for (k = 0; k < 10; k++)
        {
            Console.Write(dizi[k] + "    ");
        }
        Console.WriteLine("\n-------------- \n");
    }
    dizi[j + 1] = gecici;
    
   
}

for ( i = 0; i < 10; i++)
{
    Console.Write(dizi[i]+ "    ");
}










Console.ReadLine();
Console.WriteLine("degerin sonucu"+fakt(5));


int fakt(int sayi)
{
    if (sayi<=1)
    {
        return 1;
    }
    return sayi * fakt(sayi - 1);
}

