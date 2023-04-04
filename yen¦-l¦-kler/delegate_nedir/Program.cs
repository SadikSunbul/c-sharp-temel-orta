// See https://aka.ms/new-console-template for more information

topla(10, 20);
cıkarma(20, 2);
carpma(2, 4);
bölme(10, 2);

matematikselislemler m1 = new matematikselislemler(topla);
m1.Invoke(10, 20); //burda cagırdık 
Console.ReadLine();


delegate void matematikselislemler(int sayı1, int sayı2);

static void topla(int sayı1,int sayı2)
{
    int sonuc = sayı1 + sayı2;
    Console.WriteLine("toplama ıslemı"+sonuc);

}

static void cıkarma(int sayı1, int sayı2)
{
    int sonuc = sayı1 - sayı2;
    Console.WriteLine("cıkarma ıslemı"+sonuc);
}

static void carpma(int sayı1, int sayı2)
{
    int sonuc = sayı2 * sayı1;
    Console.WriteLine("carpma ıslemı"+sonuc);
}

static void bölme(int sayı1, int sayı2)
{
    int sonuc = sayı1 / sayı2;
    Console.WriteLine("bolme ıslemı"+sonuc);
}


