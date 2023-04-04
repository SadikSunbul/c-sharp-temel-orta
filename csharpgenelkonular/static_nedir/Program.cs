// See https://aka.ms/new-console-template for more information


//static: nesne örneği alınmadan ulaşabildiğimiz metot ,field ,sınıf ...
//Tip M1 = new Tip();



using static_nedir;

Ögrenci o1;  //stack bolgede pointer olustu
//stac bolgede poınter olustugu zaman static olan bir yapıcı metot calıstı ve yine clas içerisinde tanımlı olan tatic field ,metot static dediğimiz bolgede olusturuldu

Ögrenci.Test2();  //test2 yı statıc dıye tanımladıgımız ıcın statıc bolgeden gelmelı verıler ogrencı statıce ulasabılır ama o1 ulasamaz

o1 = new Ögrenci();
//static bolgede olusan pointer=> kendısını heap bolgede tamamladı... statıc olmayan tanımlarını tamamladı...

o1.Test1(); //nesne ornegı alındıktan sonra test1 adındakı metodumuza ulasabildik

Console.ReadLine();
