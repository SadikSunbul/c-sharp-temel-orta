using System;
namespace Kalıtım_Bolum_Sonu_Odevi
{
    public sealed class Televizyon: Ürün //sealed metodu baska bı clasa kalıtılamasın demek
    {
        public Televizyon()
        {
        }
        public bool SmartTv { get; set; }
        public bool HDMI { get; set; }
        public string EkranBoyutu { get; set; }


    }
}

