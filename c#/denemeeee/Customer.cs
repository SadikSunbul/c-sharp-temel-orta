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
                    Console.WriteLine("kayıt yapıldı");
                }
            }
        }
        

        private bool KullanıcıAdıKontrol(string c)
        {
            bool kontrol = false;
            for (int i = 0; i <database.Count; i++)
            {
                Customer temp = (Customer)database[i];
                if (temp.UserName==c)
                {
                    kontrol = true;
                    break;
                }
                

            }

            return kontrol;
        }
        public static void kullanıcıekle(Customer customer)
        {
            if (customer!=null&& !string.IsNullOrEmpty(customer.UserName) && !string.IsNullOrEmpty(customer.Email))
            {
                bool kontrol5 = EpostaKontrol(customer.Email);
                if (kontrol5)
                {
                    Console.WriteLine("kullanıcı eklı zatne");
                }
                else
                {
                    database.Add(customer);
                    Console.WriteLine("kullanıcı eklendı");
                }
            }
            else
            {
                Console.WriteLine(".......---------");
            }
            
        }
        private static bool EpostaKontrol(string email)
        {
            bool kontrol4 = false;
            for (int i = 0; i < database.Count; i++)
            {
                Customer temp1 = (Customer)database[i];
                if (temp1.Email==email)
                {
                    kontrol4 = true;
                    break;

                }
            }
            return kontrol4;
        }

    }
}

