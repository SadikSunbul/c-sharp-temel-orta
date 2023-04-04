using System;
namespace Kalıtım_Nedir
{
    public class TemelTip
    {
        public TemelTip()
        {
            Console.WriteLine("temle tıp ın yapıcı metotdu calıstı");
            ıdAtaması();
        }
        private int Id { get; set; }
        public string ReferansKod { get; set; }
        public string TCno { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public string KayıtKullanıcı { get; set; }
        public DateTime GüncellemeTarih { get; set; }
        public int  GüncellemeKullanıcı { get; set; }
        public bool Silindi { get; set; }


        private void ıdAtaması()
        {
            Random rnd = new Random();
            this.Id=rnd.Next(1000, 9000);
        }
        public void Temleip1()
        {
            Console.WriteLine("temel tip içerisindeki => metot1");
            temelTipMetot2(); //burada kullanıla bılır cunkı ıcerısınde prıvate olarak davranıyordu
        }

        protected void temelTipMetot2()
        {
            Console.WriteLine("protected metot ");
        }
    }
}

