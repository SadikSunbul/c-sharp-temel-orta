// See https://aka.ms/new-console-template for more information
using System.IO;


YenıKlasorOlustur("c:\\udemy"); //olusturulacak dosyanın adresi
//lasorVarlıkKontrol("/Users/sadiksunbul/Documents/c#deneleri"); //klasoru bulursa true doner bulamazsa false doner
//klasorsılmeislmelerı("\\\\Mac\\Home\\Desktop\\dosya_kalsor_işlemleri"); //dosyayı bulcak ve sılıcek 
//KlasorTasıma("c:\\udemy", "c:\\tasımaıslemı"); //ıudemıyı tasımaıslemı klasorune tası dedık

static void YenıKlasorOlustur(string path)
{
   DirectoryInfo dı= Directory.CreateDirectory(path); //dosya olusturur ve ozelıklerını tutar nezaman olusturuldu vb 

}

static void lasorVarlıkKontrol(string path)
{
    bool kontrol=Directory.Exists(path);
}

static void klasorsılmeislmelerı(string path)
{
    Directory.Delete(path,true);//ıcerısı bos ıse sıler guvenlık kontrolu gecmek ıcın true veya false ver cez true dersek ıcındekılerle beraber sıl demek 

}

static void KlasorTasıma(string kaynak,string hedef)
{
    Directory.Move(kaynak, hedef); //tasıma ıslemını yapar
}