using System;
namespace metotlar
{
    public class Ögrenci  //buradakı publıc bu clas herhangıbı bır clastan kullanılabilir
    {
        public Ögrenci()
        {
        }

        public void selamlaogrencıadı()  //burda voıd yazmamızın amacı return kullanmamamız voıd donmez cunkı 
        {
            Console.WriteLine("merhaba ogrenci");
        }
        private void ogrencımetot1(string ogrencıadı, string ogrencısoyadı) //prıvate yapmıs olsaydım burayı program.cs de goremıyceketım burdakı metodu
        {
            Console.WriteLine("Öğrenci bilgileri :{0} ,{1} ", ogrencıadı, ogrencısoyadı);
        }
        public void ogrencımetod2()
        {
            ogrencımetot1("sadık", "sünbül");
        }

    }
}

