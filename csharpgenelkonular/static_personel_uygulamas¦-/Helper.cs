using System;
namespace static_personel_uygulaması
{
    public static class Helper
    {
        static Helper() //yapıcı metotdu da statıc dememız gerekır 
        {
            //uygulama ıcerısınde ıstedıgı zaman cagırılsınlar sadece ılk kez calısırlar sonra calısmazlar normal yapıcılar gıbıdefıl her cagırıldıgında
                    //burası calısmaz ılk cagırılmada calısır sonra bıdaha calısmaz
            Console.WriteLine("helper =>statıc clas =>static CTOR ");
        }
        // statıc claslar ıcerısınde statıc metotlar yazmamız gerekır degılse hataverıcektır 
        public static void emailGönder(string aliciemailAdresi,string konu,string içerik)
        {
            //email gonderme işlemleri devam edicek
            Console.WriteLine("mail gonderim islemı basarılı");

        }

        // public void test()   hata verır cunku burası statıc degıl standart olanlar kullanılamaz 
        //  {

        //}

        // public static ısım { get; set; } buradada hata verır cunkı statıc degıl field tanımımızında statıc olması gerekır 

    }
}

