using System;
using System.Collections;
namespace tekrarrrrrrrrrr
{
    public class Müşteri
    {
        static ArrayList müsteridatabase;
        static Müşteri()
        {
            müsteridatabase = new ArrayList();
        }
        public string isim;
        public string soyİsim;
        public int musteriId;
        public string email;
        public string sifre;


        private string _kullanıcıadı;

        public string Kullanıcıadı
        {
            get
            {
                return this._kullanıcıadı;
            }
            set
            {
                bool kontrol = müşterikullanıcıadıkontrol(value);

                if (kontrol)
                {
                    Console.WriteLine("eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    this._kullanıcıadı = value;
                }

            }
        }

        private bool müşterikullanıcıadıkontrol(string email)
        {
            bool kontrol2 = false;
            for (int i = 0; i < müsteridatabase.Count; i++)
            {
                Müşteri Temp = (Müşteri)müsteridatabase[i];
                if (Temp.Kullanıcıadı == _kullanıcıadı)
                {
                    kontrol2 = true;
                    break;
                }
            }
            return kontrol2;
        }

        public static void MüsteriEkle(Müşteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.Kullanıcıadı) && !string.IsNullOrEmpty(M.email))
            {
                bool kontrol3 = EmailAdresKontrol(M.email);
                if (kontrol3)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    müsteridatabase.Add(M);
                    Console.WriteLine("Yeni kayıt Başarılı");
                }
            }

        }

        static bool EmailAdresKontrol(string _email)
        {

            bool kontrol = false;
            for (int i = 0; i < müsteridatabase.Count; i++)
            {
                Müşteri Temp = (Müşteri)müsteridatabase[i];
                if (Temp.email == _email)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
    }
}


