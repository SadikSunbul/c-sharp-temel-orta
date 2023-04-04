// See https://aka.ms/new-console-template for more information


string cumle;
Console.Write("Cumleyi Girin : ");
cumle = Console.ReadLine();
string[] kelimeler = cumle.Split('a'); //string değişkeninin içindeki verileri kelimelere, cümlelere ve benzerlerine ayırmayı sağlar
                                       //' ' arasındakını almaz basını ve sonunu ayrı bı dızıye aktartırız
Console.WriteLine(kelimeler.Length);
Console.ReadKey(); //kullanıcı bir tuşa basana ve uygulama sonlandırana veya ek bir bilgi penceresi
                   //görüntüleyene kadar pro
                   //gram yürütmeyi durdurmaktır.