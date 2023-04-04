using System;
namespace Kapsülleme
{
    public class Musteri
    {
        public Musteri() //yapıcı metot 
        {
            this.Id = IDuret();  //burada her newleme yapıldıgında yenı bır ıd uretr program ve atar onu
        }
        //clas -->Field alanları
        private int Id; //field
        public int ID //property burası
        {
            get //okuma
            {
                return this.Id;  //buradakı field den degerı okuyor
            }
            private set  //Diş dunyaya kapamış olduk dısarıdan deger gırılemıycek artık ıcerıden kendı atamalrı yapılıyor random seklınde 
            {
                this.Id = value; //burayı sıledebılırız
            }
        }
        public string İsim;
        private string _Soyİsim;
        public string Soyisi
        {
            get
            {
                return this._Soyİsim;
            }
            set //soy isimi alır almaz email adresini olusturdu
            {
                this._Soyİsim = value;
                this.emailAdres = String.Format("{0}.{1}@hotmail.com", İsim, _Soyİsim);
            }
        }

        private string emailAdres; //Fieid burası


        //clas ıcerısındekı ozelıkler

        public string EmailAdres  //property burası
        {
            //  get; //data base veya farklı bır verı kaynagı... clası cagıran programcıya datayı gosterdıgımız kısımdır
            //  set;// dıs dunyadan alınan datanın ıcerıde prıvate olarak saklanan field içerisine değer atandığı kısımdır


            private set
            {                   //burda valuede bızım degerımız saklanır
               this.emailAdres= value;  //burada ıcerıde prıvate olarak sakladıgımz yere degerlerı atamasını yaptık
            }
            get
            {
                return this.emailAdres;  //cıktıyıda buradan alıyoruz
            }
        }





        private string _tckimlikno;
        public string TckimlikNo
        {                           //burda o. ındex ten basla ve 3 karakter al dedık
             get {
                string x = "********";
                return _tckimlikno.Substring(0,3)+x; } //başına bişey yazmazsak public olur 
            set {
                if (value.Length==11)  //burada string ı char gıbı kabul edıp elemanları sayıyor 11 basamaklımı dıye 
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]); //value nın i. degerı sayımı degılmı onu soylıycek
                        if (karakterkontrol==true)
                        {
                            //sayısal demektır ıslme yapmıyoruz
                        }
                        else
                        {
                            bayrak = true;
                            break; //for dongusunu kırıyoruz
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("Tc no ıcındekı degerler sayısal olmalıdır");
                    }
                    else
                    {
                        this._tckimlikno = value; //girilen değer şartlara uyuyorsa atama yaptık
                    }
                }
                else
                {
                    Console.WriteLine("11 hanelı olmalı tc no");
                }
            }
        }



        private int IDuret()
        {
            Random rndm = new Random();
           return rndm.Next(10000, 90000); //random sayı urtırdık burada 
        }





    }
}

