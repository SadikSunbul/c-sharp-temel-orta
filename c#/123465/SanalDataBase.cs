using System;
using System.Collections;

namespace _123465
{
    public class SanalDataBase
    {
        public static ArrayList db;
        static SanalDataBase()
        {
            db = new ArrayList();
        }
        
        public static void ÜrünEkle(Ürün x)
        {
            bool kontrol1 = BarkodKontrol(x.Barkod);
            if (x!=null&& !string.IsNullOrEmpty(x._barkod))
            {
                if (kontrol1 == true)
                {

                    Console.WriteLine("Bu barkkod kullanılıyor... ürün eklenemedi...");
                }
                else
                {
                    db.Add(x);
                    Console.WriteLine("ürün basarılı bır sekılde eklendi...");
                }
            }
            else
            {
                Console.WriteLine("girilen degerler eksık lutfen kontrol edeerek tekrar deneyınız...");
            }
            
        }

        public static bool BarkodKontrol(string _bArkod)
        {
            bool kontrol = false;
            for (int i = 0; i < db.Count; i++)
            {
                Ürün temp = (Ürün)db[i];
                if (temp._barkod==_bArkod)
                {
                    kontrol = true;
                }
            }
            return kontrol;
        }
    }
}

