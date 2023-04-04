
using System;
namespace Kalıtım_Nedir
{
    public sealed class Ögrenci:TemelTip  //inner type yapılabılır ama ornekelenemez mıras edılemez
    {
        public string bolum { get; set; }
        public int  seviye { get; set; }
        public Ögrenci()
        {                     //protected olarak ısaretlendıgı ıcın 
            temelTipMetot2(); //burada da cagırılabılır cunku burası temel tıp ten kalıtılmıs zaten
        }

    }
}

