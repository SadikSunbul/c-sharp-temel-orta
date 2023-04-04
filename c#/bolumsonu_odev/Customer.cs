using System;
using System.Collections;

namespace bolumsonu_odev
{
    public class Customer
    {
        static ArrayList database;

        static Customer()
        {
            database=new ArrayList();
        }
        public string FirstName;
        public string LastName;
        public string Email;
        private  string _UserName;
        

        public string UserName
        {
            get
            {
                return this._UserName;
            }

            set
            {
                bool kontrol1 = KullanıcıadıKontrol(value);

                if (kontrol1)
                {
                    Console.WriteLine("kullanıcı kayıtlı zaten");
                }
                else
                {
                    this._UserName = value;
                    
                }
            }
        }


        private bool KullanıcıadıKontrol(string kullanıcıadı)
        {
            bool kontrol = false;

            for (int i = 0; i < database.Count; i++)
            {
                Customer temp = (Customer)database[i];
                if (temp.UserName==_UserName)
                {
                    kontrol = true;
                    break;
                }
                
            }

            return kontrol;
        }

        public static void KullanıcıEkle(Customer c)
        {
            if (c != null && !string.IsNullOrEmpty(c.Email) && !string.IsNullOrEmpty(c.UserName))
            {
                bool kontrol3 = EmailAdresKontrol(c.Email);
                if (kontrol3)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı\"");
                }
                else
                {
                    database.Add(c);
                    Console.WriteLine("Yeni kayıt Başarılı");
                }
            }
        }


        static bool EmailAdresKontrol(string email)
        {
            bool kontrol = false;
            for (int i = 0; i < database.Count; i++)
            {
                Customer Temp = (Customer)database[i];
                if (Temp.Email == email)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
    }
}

