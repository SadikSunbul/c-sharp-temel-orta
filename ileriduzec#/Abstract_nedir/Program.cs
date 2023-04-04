// See https://aka.ms/new-console-template for more information


using Abstract_nedir;

// TemelSınıf T1 = new();  abstract dedıgımız ıcın ornekleneemdı

Müşteri m1 = new();
// m1.GuncellemeTarıhı 
m1.Test();
m1.testAbstract();

Console.WriteLine("------------");
SuperMüşteri sp1 = new();
sp1.testAbstract(); //burdakı overrıde edılen clastan aldı



Console.ReadLine();

