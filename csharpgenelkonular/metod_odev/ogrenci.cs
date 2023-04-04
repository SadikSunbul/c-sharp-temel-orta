using System;
namespace metod_odev
{
    public class Ogrenci
    {
                                                                        //not 3 un degerı gırılmezse 45 alsın demek bunuda metot ıstedıgı ıcın yapıyoruz
        public void Hesapla(string ad,string soyad,decimal not1,decimal not2,decimal not3=45) //buranın snuna yenı bır para metre eklersem hata alırım
                                                                    //yenı ekledıgım parametrenıdnde  not4=54 gıbı bısey olması lazım veya degılsede not3 un onune eklenmelidir
        {

            Console.WriteLine("Ogrencı bılgıları asagıdakı gıbıdır");
            Console.WriteLine("Ad Soyad:{0},{1} ",ad,soyad);
            
            OrtalamaNotDeğerlendir(OrtalamaHesapla(not1, not2, not3)); //2 metodu ıc ıce kullandık 
            
        }

        void OrtalamaNotDeğerlendir(decimal ogrencıortalama)  //burda gorunum ataması yapmadıgımız zaman prıvate dıyerek atar onu yanı sadece bu clasta kullana bılırız burayıı
        {
            if (ogrencıortalama < 45)
            {
                Console.WriteLine("Ortalama değeriniz={0} - kaldınız", ogrencıortalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz={0} - geçtiniz", ogrencıortalama);
            }
        }

        private decimal OrtalamaHesapla(decimal ogrencınot1,decimal ogrencınot2, decimal ogrencınot3)  //prıvatededıgımız sadece bu kılasta gorunur bu metot
        {
            decimal ort = (ogrencınot1 + ogrencınot2 + ogrencınot3) / 3;
            return ort;
        }
    }
}

