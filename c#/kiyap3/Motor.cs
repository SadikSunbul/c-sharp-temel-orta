using System;
using System.Drawing;
namespace kiyap3
{
    public class Motor
    {
        public Motor()
        {
            Renk = Color.Bisque;
            VitesSayısı = 5;
            YakıtCinsi = "benzin";


        }

        public Color Renk { get; set; }
        public byte VitesSayısı { get; set; }
        public string YakıtCinsi { get; set; }
        public void Git() => Console.WriteLine("gidiyorum");
        public void Dur() => Console.WriteLine("durdum");
        public void VitesDegıs() => Console.WriteLine("vites degıstırdım");
        public void FarYak() => Console.WriteLine("farları yaktım");
    }
}

