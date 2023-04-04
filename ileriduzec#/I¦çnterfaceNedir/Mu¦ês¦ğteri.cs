using System;
namespace İnterfaceNedir
{
    public class Müşteri:Imusteri
    {
        public Müşteri()
        {
        }

        int _id;
        string _isim;
        string _soyisim;

        public int Id { get { return this._id; } set { _id = value; } }
        public string isim { get { return this._isim; } set { _isim = value; } }
        public string Soyİsim { get { return this._soyisim; } set { _soyisim = value; } }

        public int kayıtduzenle(int ıd, string isim, string soyisim)
        {
            Console.WriteLine("kayıt duzenlendi");
            return 1;
        }

        public int kayıtsil(int ıd)
        {
            Console.WriteLine("kayıt silindi");
            return 1;
        }

        public int yenikayıt(string isim, string soyisim)
        {
            Console.WriteLine("kayıt eklendi");
            return 1;
        }
    }
}

