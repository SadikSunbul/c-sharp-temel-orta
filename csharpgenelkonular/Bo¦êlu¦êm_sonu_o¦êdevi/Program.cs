// See https://aka.ms/new-console-template for more information

using Bölüm_sonu_ödevi;
tahiri t=new();
t.MyProperty="asas";

Müşteri m1 = new();
m1.musteriId = 1;
m1.İsim = "sadık";
m1.Soyism = "sünbül";
m1.EmailAdres = "sadık.sunbul@gmail.com";
m1.KullanıcıAdı = "art_redline";
m1.Şifre = "1";

Müşteri.MüşteriEkle(m1);

Müşteri m2 = new()
{
    musteriId = 2,
    İsim = "0sman",
    Soyism = "boyraz",
    KullanıcıAdı = "osmanbyrz",
    EmailAdres = "osmnbyrz@gmail.com",
    Şifre = "2"

};

Müşteri.MüşteriEkle(m2);

Müşteri m3 = new()
{
    musteriId = 2,
    İsim = "0sman",
    Soyism = "boyraz",
    KullanıcıAdı = "osmanbyrz",
    EmailAdres = "osmnbyrz@gmail.com",
    Şifre = "2"

};
Müşteri.MüşteriEkle(m3);






Console.ReadLine();