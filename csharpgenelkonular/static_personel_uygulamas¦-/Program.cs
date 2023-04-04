// See https://aka.ms/new-console-template for more information



using static_personel_uygulaması;

Personel personel = new();  //ilk once statıc yapıcı metot calısır sonra normal yapıcı metotlar calısır 
personel.Isim = "sadık";
personel.SoyIsim = "sünbül";
personel.EmailAdresi = "cengiz.atilla";
personel.cinsiyet = 717770001; //bay


Personel personel1 = new();
personel1.Isim = "sadık";
personel1.SoyIsim = "sünbül";
personel1.EmailAdresi = "cengiz.atilla";
personel1.cinsiyet = 717770001; //bay

// Helper h1 = new Helper();  hata verır cunku statıc yaptık bu metodu sttatıc metotların orneklerı alınmaz


Helper.emailGönder("ika@fırmam.com", "yeni personel", personel.Isim + personel.SoyIsim);
Helper.emailGönder("ika@fırmam.com", "yeni personel", personel.Isim + personel.SoyIsim);
Helper.emailGönder("ika@fırmam.com", "yeni personel", personel.Isim + personel.SoyIsim);

Console.ReadLine();