// See https://aka.ms/new-console-template for more information

int[] dizi1 = new int[10];
int[] dizi2 = new int[10];
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    dizi1[i] = 1;
    dizi2[i] = 2;

}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("dizi1["+i+"]"+dizi1[i]);
}
Console.WriteLine("-------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("dizi2[" + i + "]" + dizi2[i]);
}
Console.WriteLine("-------------");

for (int i = 0; i < 10; i=i+2)
{
    for (int j = i+1; j <=i+1; j=j+2)
    {
        if (j != 10)
        {
            dizi1[i] = dizi2[j];
        }
        else
        {
            break;
        }

    }
    
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("dizi1[" + i + "]" + dizi1[i]);
}
Console.WriteLine("-------------");


