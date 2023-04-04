using System;
namespace Kalıtım_Nedir
{
    public sealed class Eğitmen : Personel  //sealed orneklenemez demek mıras edılemz demek
    {       //burada egıtmen -->personele personeldende --> temel tipe baglandı

        public Eğitmen()
        {
            Console.WriteLine("egıtmen nesnesının yapıcı metodu calıstı");
        }
        public string Branş { get; set; }
        public int bransseviye { get; set; }
       


        //public TemelTip _temelTip { get; set; } //kalıtım goreınıde yapar ama asla boyle kullanma burasını burda ınner typ  apmıs olduk 
        //egıtmen. dedıgımde ıd sıne vb seylere ulasmak ıstıyorum  ınner typ ıstemıyıorusz burada ınner typte egıtmen.temeltip.ıd gıbı bır yapı oluyordu onu burada ıstemıyoruz
    }
}


