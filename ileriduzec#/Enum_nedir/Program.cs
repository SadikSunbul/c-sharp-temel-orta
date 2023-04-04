// See https://aka.ms/new-console-template for more information


using Enum_nedir;

Müşteri m1 = new();

m1.id = 1;
m1.MusterıId = "MSN001";
m1.İsim = "sadık";
m1.Soyİsim = "sadık";
m1.Email = "sadık.sunbul@gmail.com";

SanalDataBase sb = new();
MusteriReturnValue musterıkayıtsonuc= sb.MüşteriYeniKayıt(m1);

int enumInt=(int) MusteriReturnValue.kayıtBasarısız;
Console.WriteLine(enumInt);

if (musterıkayıtsonuc== MusteriReturnValue.kayıtBasarılı) //burda gelen degre kayıt basarılıysa gır ıcerı demek
{
    Console.WriteLine("kayıt basarılı");
}
Console.ReadLine();



