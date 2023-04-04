using System;
namespace OOP_nedir
{
    public class Müşteri   //internal belırtecı bu clası cagır bılen herkes ıcın acıktır demek
    {
        /*tc no
         * isim
         * soyisim
         * cinsiyet
         * 
         */


        //yapıcı metot  ctor tab tab

        public Müşteri()
        {
            //TcKimlikno = "12345678"; //defaolt degr ataması yaptık

        }
        public Müşteri(string tckimlikno) //burada overlodıng yaptık
        {
            TcKimlikno = tckimlikno;

        }
        public Müşteri(string tckimlikno,string isim)
        {
            TcKimlikno = tckimlikno;
            İsim = isim;
        }
        public Müşteri(string tckimlikno, string isim,string _soyisim)
        {
            TcKimlikno = tckimlikno;
            İsim = isim;
            soyisim = _soyisim;
        }

        public string TcKimlikno;
        public string İsim;
        public string soyisim;
        public int cinsiyet; //717770001=bay  717770002=bayan
        public bool Musterikontrol()
        {
            bool kontrol = MusteriKontrolDataBase(TcKimlikno);
            
            return kontrol; //sıstemde bulundugunu var sayalım
        }
        private bool MusteriKontrolDataBase(string tckimlikno)  //programcs de gozukmez boyle bır metodun oldugu bu metot buranın  ır fonksıyonu
        {
            //data baseye gıdılır musterının tc kımlık numarasına gore daha once kayıt edilip edilmediğine bakılır
            //
            return true;
        }

    }
}

