
using System;
using System.Collections;

namespace deneme
{
    public class Customer
    {
        private static ArrayList kulanıcıDataBase;
        private static ArrayList EmailDataBase;
        static Customer()
        {
            kulanıcıDataBase = new ArrayList();
            EmailDataBase = new ArrayList();
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
        private string _kullanıcıAdı { get; set; }

        public string KullanıcıAdı
        { get
            {
                return this._kullanıcıAdı;
            }
            set
            {
                bool kontrol1 = KullanıcıAdıKontrol(value);
                if (kontrol1)
                {
                    Console.WriteLine("Kullanıcı adı alınmıs baska bır kullanıcı adı secınız...");
                }
                else
                {
                    this._kullanıcıAdı = value;
                    kulanıcıDataBase.Add(value);
                    Console.WriteLine("Kullanıcı adı basarılı bır sekılde kaydedıldı...");
                }
            }
        }

        private bool KullanıcıAdıKontrol(string kullanıcıadı)
        {
            bool kontrol = kulanıcıDataBase.Contains(kullanıcıadı);
            
            return kontrol;
        }

        public static void KullanıcıEkle(Customer c)
        {
            if (c!=null && !string.IsNullOrEmpty(c.Email) && !string.IsNullOrEmpty(c.KullanıcıAdı))
            {
                bool kontrol4 = EmailKontrol(c.Email);
                if (kontrol4)
                {
                    Console.WriteLine("Bu email ile daha önce hesap açılmış....");
                }
                else
                {
                    EmailDataBase.Add(c.Email);
                    Console.WriteLine("Email adresı basarılı bır sekılde kaydedıldı...");
                }
            }

        }

         static bool EmailKontrol(string email)
        {
            bool kontrol3 = EmailDataBase.Contains(email);
            

            return kontrol3;
        }
    }
}

