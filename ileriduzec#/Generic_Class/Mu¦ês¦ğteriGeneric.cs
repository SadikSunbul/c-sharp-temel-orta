using System;
namespace Generic_Class
{
    public class MüşteriGeneric<T>  //burada <t,k> yapamazsınız kullanılmaz hata olmaz ama gerek yok 
    {
        public MüşteriGeneric()
        {
        }
        public T id { get; set; }
        public T musteriNumarası { get; set; }
        public string TcNo { get; set; }
        public string İsim { get; set; }
        public string Soyİsim { get; set; }

        public DateTime DogumTarih { get; set; }


        public T musterinumarasıal()
        {
            return musteriNumarası;
        }
    }
}

