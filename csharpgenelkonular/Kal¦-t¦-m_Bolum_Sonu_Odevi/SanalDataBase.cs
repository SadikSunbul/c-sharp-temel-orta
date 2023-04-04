using System;
using System.Collections;

namespace Kalıtım_Bolum_Sonu_Odevi
{
    public static class SanalDataBase
    {
        private static ArrayList db;
        static SanalDataBase()
        {
            db = new();

        }

        public static void yeniUrunEkle(BaseClass data)
        {
            if (data !=null && !string.IsNullOrEmpty (data.Barkod))
            {
                db.Add(data);
                Console.WriteLine("data ya eklendı barkodunuz");
            }
            else
            {
                Console.WriteLine("data ya ekelenemedı barkodunuz");
            }
        }

        public static bool dbBarkodKontrol(string barkod)
        {

            if (db!=null && db.Count>0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    BaseClass bc = (BaseClass)db[i];
                    if (bc.Barkod==barkod)
                    {
                        return true; //girerse true doner cıkar burdan 
                    }
                }

            }
            return false; //gırmezse yukarıya false doner ve cıkar 
        }
    }
}

