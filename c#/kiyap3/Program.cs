// See https://aka.ms/new-console-template for more information



using System.Drawing;
using kiyap3;

Motor motor = new();
Console.WriteLine("özelliklere henuz deger atanmadıgından varsayılan degerler goruntulenir");
Console.WriteLine("renk ozelllıgı"+motor.Renk);
Console.WriteLine("vites sayısı ozellıgı"+motor.VitesSayısı);
Console.WriteLine("yakıt cınsı ozellıgı"+motor.YakıtCinsi);
Console.WriteLine("------------------------------");

Console.WriteLine("özelikler atandıktan sonra ");

motor.Renk = Color.White;
Console.WriteLine("renk ozellıgı:"+motor.Renk);

motor.VitesSayısı = 6;
Console.WriteLine("vıtes ozellıgı"+motor.VitesSayısı);

motor.YakıtCinsi = "elektrıklı motor";
Console.WriteLine("yakıt cınsı:"+motor.YakıtCinsi);

Console.WriteLine("---------------------");

Console.WriteLine("metotlar");

motor.Git();
motor.Dur();
motor.FarYak();
Console.ReadLine();
