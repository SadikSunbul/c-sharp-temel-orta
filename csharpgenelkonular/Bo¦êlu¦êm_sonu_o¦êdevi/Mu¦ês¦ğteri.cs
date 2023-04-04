using System;
using System.Collections;

namespace Bölüm_sonu_ödevi
{
    public class Müşteri
    {
        public Müşteri()
        {
        }
        #region sanal Database
        static ArrayList müsteridatabase;
        
        #endregion

        #region static yapıcı metot
        static Müşteri()
        {//burası 1 kere çalışacagı ıcın nevlemeyı burda yaptık gırıs olmasaydı yer tutmuycaktı
            müsteridatabase = new ArrayList();
            
        }
        #endregion

        #region Field
        public int musteriId { get; set; }

        public string İsim { get; set; }
        public string Soyism { get; set; }
        public string EmailAdres { get; set; }
        public string Şifre { get; set; }
        #endregion

        #region Kapsulleme
        private string _KullanıcıAdı;
        public string KullanıcıAdı
        {
            get { return this._KullanıcıAdı; }
            set
            {
                bool kullanıcıkontrol = müşterikullanıcıadıkontrol(value);
                if (kullanıcıkontrol)
                {
                    Console.WriteLine("eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    this._KullanıcıAdı = value;
                }
            }
        }
        #endregion

        #region statıc metotlar
        static bool müşterikullanıcıadıkontrol(string _kullanıcıadı)
        {
            bool kontrol = false;
            for (int i = 0; i < müsteridatabase.Count; i++)
            {
                Müşteri temp = (Müşteri)müsteridatabase[i]; //un boxing yaparak statıc degerı ler ıcın bu kullanımı kulanırız
                if (temp.KullanıcıAdı==_kullanıcıadı)
                {
                    kontrol = true;
                    break;
                    
                }
            }
            return kontrol;
        }

        public static void MüşteriEkle(Müşteri M)
        {
            #region parametre kontrol
            if(M!=null && !string.IsNullOrEmpty(M.KullanıcıAdı) && !string.IsNullOrEmpty(M.EmailAdres)) //bunların boş olmaması lazım
            {
              bool emailadreskontrol=  müşteriEmailadreskontrol(M.EmailAdres);
                if (emailadreskontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    müsteridatabase.Add(M);
                    Console.WriteLine("Yeni kayıt Başarılı");
                }
            }
            #endregion
            static bool müşteriEmailadreskontrol(string _email)
            {
                bool kontrol = false;
                for (int i = 0; i <müsteridatabase.Count; i++)
                {
                    Müşteri Temp = (Müşteri)müsteridatabase[i];
                    if (Temp.EmailAdres==_email)
                    {
                        kontrol = true;
                        break;
                    }
                }
                return kontrol;
            }
        }
        #endregion
    }
}

