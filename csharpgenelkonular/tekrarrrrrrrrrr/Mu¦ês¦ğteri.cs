using System;
using System.Collections;
namespace tekrarrrrrrrrrr
{
    public class Müşteri
    {
        static ArrayList database;
        static ArrayList kadıdatabase;
        static Müşteri()
        {
            database = new ArrayList();
            kadıdatabase = new ArrayList();
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int MusteriId { get; set; }
        public string Email { get; set; }
        private string _KullanıcıAdı;

        public string KullsnıcıAdı
        { get
            {
                return this._KullanıcıAdı;

            }
            set
            {
                bool kontrol5 = KullanıcıAdıKontrol(value);
                if (kontrol5)
                {
                    Console.WriteLine("Kullanıcı adını kullanılıyor");
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız Basarılı bır sekılde kaydedıldı");
                    database.Add(value);
                    this._KullanıcıAdı = value;
                }

            }

        }

        private bool KullanıcıAdıKontrol(string k_adı)
        {
            bool kontrol3 = false;
            for (int i = 0; i < kadıdatabase.Count; i++)
            {
                Müşteri temp = (Müşteri)kadıdatabase[i];
                if (temp._KullanıcıAdı==k_adı)
                {
                    
                    kontrol3 = true;
                    break;
                }
            }


            return kontrol3;
        }

        public static void KullanıcıEkle(Müşteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.Email) && !string.IsNullOrEmpty(M.KullsnıcıAdı))
            {


                bool kontrol1 = EmailKontrol(M.Email);
                if (kontrol1)
                {
                    Console.WriteLine("Kullanıcı eKLI ZATNE");
                }
                else
                {
                    database.Add(M);
                    Console.WriteLine("Kullanıcı basarılı bır sekılde eklendı");
                }
            }
        }


        private static bool EmailKontrol(string email)
        {
            bool kontrol = false;
            for (int i = 0; i < database.Count; i++)
            {
                Müşteri temp =(Müşteri)database[i];
                if (temp.Email==email)
                {
                    Console.WriteLine("Email kullanılıyor");
                    kontrol = true;
                    break;
                }

            }


            return kontrol;

        }
    }
}


