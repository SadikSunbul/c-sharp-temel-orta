// See https://aka.ms/new-console-template for more information


localFunctionKUllanımı(12,24);

Console.ReadLine();


 static void localFunctionKUllanımı(int sayı1,int sayı2)  //metotların ıcerısınde metotlar acılır
{
    int toplam = sayı1 + sayı2;
    int topla(int gelensayı1,int gelensayı2) //bu metoda sadece bu metodun ıcerısınde ulasıla bılır...
                                             //erişebilirlık tanımlanmaz
                                             //ıc ıce metotların adının farklı olması gerekir hata vermez kendını cagırır
                                             //localFunctionKUllanımı.topla dıyemeyız gelmez
                                             //metodun ıcerısınde her yerde erısebılırız onden arkdan erısıle  bılır
                                             //amaç metot ıcerısınde tekrar tekrar kulanmamızı saglar

    {
        return gelensayı1 + gelensayı2;
    }
    int toplamdeger = topla(sayı1, sayı2);
    Console.WriteLine(toplamdeger);

 
}

