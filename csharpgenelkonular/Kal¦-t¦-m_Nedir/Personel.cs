using System;
namespace Kalıtım_Nedir
{
    public class Personel:TemelTip
    {
        public Personel()
        {
            Console.WriteLine("personel nesnesı yapıcı metodu calıstı");
        }
        public DateTime İsBaslangıcTarıhı { get; set; }
        public DateTime IsBıtısTarıhı { get; set; }  //bunların egıtmen nesnesındede olması lazım aslında
        public int IzınGunuSayısı { get; set; }
    }
}

