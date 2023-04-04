// See https://aka.ms/new-console-template for more information


Console.Write("bır sayı gırınız:");
int sayı = Convert.ToInt32(Console.ReadLine());

int geçici = sayı;

for (int i = 2; i < sayı; i++)
{
    if (geçici % i == 0)
    {
        Console.WriteLine("asla carpanı="+i);
        geçici /= i;
        i=1;
    }
}

