// See https://aka.ms/new-console-template for more information


using Generic_Class;

Müşteri m1 = new();
m1.id = 1;
m1.İsim = "sadık";
m1.Soyİsim = "sünbül";
m1.TcNo = "12413432525";
m1.musteriNumarası = "ms123";
m1.DogumTarih = DateTime.Parse("08.29.2003"); //dogum tarıhı gırıs ornegı


MüşteriGeneric<int> MusteriCenerık1 = new();
MusteriCenerık1.id = 2;
MusteriCenerık1.musterinumarasıal();

MüşteriGeneric<Guid> Musterıgenerık2 = new();
Musterıgenerık2.musterinumarasıal();


Console.ReadLine();

