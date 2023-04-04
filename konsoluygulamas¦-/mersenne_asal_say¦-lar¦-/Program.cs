// See https://aka.ms/new-console-template for more information


Console.Write("bır sayı gırınız:");
int gırıleceksayı = Convert.ToInt32(Console.ReadLine());

int geçici = gırıleceksayı;
int ctr = 1;
int ty = 1;
for (int i = 2; i < gırıleceksayı; i++)
{
    if (geçici % i == 0)
    {
        ctr = 0;
    }
    if (ctr==1)
    {
        double hesap = Math.Pow(2, gırıleceksayı);
        double sonuc = hesap - 1;
        for (int k = 2; k < sonuc; k++)
        {
            if (sonuc % k == 0)
            {
                ty = 0;
            }   
        }   
    }
}
if (ty == 1)
{
    Console.WriteLine("girilen asal sayı mersenne sayıdır=" + gırıleceksayı);
}
else
{
    Console.WriteLine("gırdıgınız sayı asal sayı ama mersenne sayı değildir" + gırıleceksayı);
}
if (ctr==0)
{
    Console.WriteLine("gırılen sayı asal sayı degıldır.");
}
