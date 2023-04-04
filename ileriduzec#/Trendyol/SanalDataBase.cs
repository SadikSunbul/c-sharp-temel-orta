using System;
using System.Collections;

namespace Trendyol
{
    public class SanalDataBase
    {
        private static ArrayList db = new ArrayList();
        private SanalDataBase()
        {
            
        }
        public static void ürünEkle (Ürün x)
        {
            if (x!=null && !string.IsNullOrEmpty(x.barkod))
            {
                bool kontrol = BarkodKontrol(x._barkod);
                if (kontrol)
                {
                    Console.WriteLine("ürünün barkod numarası essız degıl " +
                        "kayıt yapılamadı....");
                }
                else
                {
                    db.Add(x);
                    Console.WriteLine("kayıt basarılı bır sekılde yapıldı");
                }
            }
            else
            {
                Console.WriteLine("eklentıler tam degıl kontrol edınız...");
            }

        }
         public static bool BarkodKontrol(string value)
        {
            bool kontrol = false;
            for (int i = 0; i < db.Count; i++)
            {
                Ürün temp = (Ürün)db[i];
                if (temp._barkod==value)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
    }
}

