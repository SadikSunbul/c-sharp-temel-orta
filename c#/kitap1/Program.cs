// See https://aka.ms/new-console-template for more information

Console.WriteLine("-------------");

Console.WriteLine($"C# egıtıme hosgeldiniz. Şuan: {DateTime.Now}") ;

Console.ReadLine();   //bekletıyo altakı readkey ı engellıyor

Console.WriteLine("--------------");


Console.WriteLine($"bugun gunlerden:{DateTime.Now.DayOfWeek}");
Console.ReadKey(); //entra basınca okuyor



ConsoleKeyInfo tus = Console.ReadKey(true);
Console.WriteLine($"{tus.Key}tusuna bastını." );
Console.ReadKey();

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"arkaplan ve yazı rengıne atama yapıldı");
Console.WriteLine("sadık sunbul");
Console.ReadKey();
Console.ReadLine();
Console.WriteLine("SADIK SÜNBÜL");
Console.ReadKey();

Console.WriteLine(DateTime.Now.DayOfWeek); //bugunun tarıhtekı adını yazdırıyor mesela 12/10/2022 dıyelım pazartesıye gelıyo pzarterssı yazar ekrnda
Console.ReadLine();


MyClass myClass = new();
Console.WriteLine(myClass.Hesapla(2, 7));
Console.ReadLine();

class MyClass
{
    public int Hesapla(int a,int b)
    {
        int toplam = a + b;
        int çıkarma = toplam - 5;
        return çıkarma;
    }
}