using System;
namespace Trendyol
{
    public sealed class Televizyon:Ürün
    {
        public Televizyon()
        {
        }
        public bool SmartTv { get; set; }
        public bool HDMI { get; set; }
        public string ekranBoyutu { get; set; }
    }
}

