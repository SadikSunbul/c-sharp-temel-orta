using System;
namespace Abstract_nedir
{                                     //abstract   öz demek.... //selead yapamazsın hata verır hem sablon yapıp hem mıraslanamazmaz yapamazsın
    public  abstract class TemelSınıf //abstract dedık kural kutuphanesı gıbı sablon olarak kulanılacagım sınıf bundn
      //new lenmez                    //kalıtılan sınıflar burda yapılan kurallar uysunlar ıstoyorum
                                     //madem bır sabol newlenıp orneklenemez
                                     //new lenmesede baska bır clastan kalıtılınca ctor calısır
                                     //burayı kalıtıldıgı musterı kendı ıcerısınde ornekler bız gormeyız
                                     //drekt cagrıldıgında dırekt cagrıldıgında newlenmez 
    {
        public TemelSınıf()
        {
            KayıtTarıhı = DateTime.Now;
            GuncellemeTarıhı = DateTime.Now;
        }
        public DateTime KayıtTarıhı { get; set; }
        public DateTime GuncellemeTarıhı { get; set; }

        public void Test()
        {
            Console.WriteLine("temel sınıfın ıcerısındekı test metodu");
        }
        public abstract void testAbstract();  //hata verır ---> abstrac olarak ısaretledıgımız metotların metot badılerı olmaz
                                             //zaten sablon metot badısı olmaz  metot imzası olur sadece 
        
    }
}

