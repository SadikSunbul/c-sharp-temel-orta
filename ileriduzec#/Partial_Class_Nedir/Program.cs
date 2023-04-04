// See https://aka.ms/new-console-template for more information

using Partial_Class_Nedir;

Müşteri m1 = new();

m1.Id = 1;
m1.İsim = "sadık";
m1.Soyİsim = "sünbül";
m1.Email = "sadık@gmail.com";

int sonuc=m1.yeniKayıt(m1);
if (sonuc>0)
{
    Console.WriteLine("ata baseye yeı kayıt eklendı");
}

Öğrenci o1 = new();
o1.Id = 1;
o1.yenıKayıt(o1);
