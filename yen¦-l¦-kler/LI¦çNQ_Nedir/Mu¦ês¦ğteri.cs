using System;
namespace LİNQ_Nedir
{
    public class Müşteri
    {
        public Müşteri()
        {
        }
        public int musterıNumarası { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumgunu { get; set; }
        public string ülke { get; set; }
        public string il { get; set; }
        public string ilçe { get; set; }
        public string telefonnumarası { get; set; }
        public string emaıladres { get; set; }

        public override string ToString()
        {
            return isim;
        }
    }
}

