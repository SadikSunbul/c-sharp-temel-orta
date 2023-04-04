using System;
using System.Collections;

namespace denemeeee
{
    public class Customer
    {
        static ArrayList database;
        static ArrayList Usernamekontrol1;
        static Customer()
        {
            database = new ArrayList();
            Usernamekontrol1 = new ArrayList();
        }

        public string LastName;
        public string FirstName;
        public string Email;
        private string _UserName;

        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                bool kontrol1 = KullanıcıAdıKontrol(value);
                if (kontrol1)
                {
                    Console.WriteLine("boyle bir kayıt var");
                }
                else
                {

                    this._UserName = value;
                    Console.WriteLine("User name girildi");
                }
            }
        }


        private bool KullanıcıAdıKontrol(string c)
        {
            bool kontrol = false;
            for (int i = 0; i < database.Count; i++)
            {
                Customer temp = (Customer)database[i];
                if (temp.UserName == c)
                {
                    kontrol = true;
                    break;
                }


            }

            return kontrol;
        }

        public static void KullanıcıEkle(Customer c)
        {
           
            if (c!=null && !string.IsNullOrEmpty(c.Email) && !string.IsNullOrEmpty(c._UserName))
            {
                bool kontrol3 = EpostaKOntrol(c.Email);
                if (kontrol3)
                {
                    Console.WriteLine("Kullanıcı eklı zaten...");
                }
                else
                {
                    database.Add(c);
                    Console.WriteLine("Kullanıcı basarılı bır sekıle eklendı..");
                }
            }
            else
            {
                Console.WriteLine("kullanıcının bılgılerı eksık kayıt yapılamıyor.");
            }

        }



        private static bool EpostaKOntrol(string eposta)
        {
            bool kontrol2 = false;
            for (int i = 0; i < database.Count; i++)
            {
                Customer temp = (Customer)database[i];
                if (temp.Email==eposta)
                {
                    kontrol2 = true;
                    break;
                }
            }


            return kontrol2;
        }
        

    }
}

