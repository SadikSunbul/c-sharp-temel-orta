using System;
using System.Collections;

namespace Trendyol
{
    public class SanalDataBase
    {
        public static ArrayList database = new ArrayList();
        

        public static bool BarkodKontrol(string barkod)
        {
            bool kontrol = false;
            for (int i = 0; i < database.Count; i++)
            {
                Ürün temp = (Ürün)database[i];
                if (temp._barkod==barkod)
                {
                    kontrol = true;
                    
                }
               
            }
            return kontrol;
        }

        public static void ÜrünEkle(Ürün ü)
        {
            if (ü!=null && !string.IsNullOrEmpty(ü._barkod))
            {
                bool kontrol3 = BarkodKontrol(ü._barkod);
                if (kontrol3)
                {
                    Console.WriteLine("Barkodunuz aynı olmaz ");
                    Console.WriteLine("kayıt yapılamadı");
                    
                }
                else
                {
                    database.Add(ü);
                    Console.WriteLine("ürününüz basarılı bır sekılde kaydedıldı...");
                }
            }
        }
    }
}

