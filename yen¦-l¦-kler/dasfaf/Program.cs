using System;

namespace dasfaf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            matematikselislemler m1 = new matematikselislemler(topla); //aynı sayılar ıcın farklı ıslemlerı dondurceksek boyle kullana bılırz
            m1 += cıkarma; //metotları tanıttık 
            m1 += carpma;
            m1 += bölme;
            m1 -= cıkarma;//metotatn cıkardık

            m1.Invoke(30, 2); //burda cagırdık
            Console.WriteLine("------------");

            Delegate[] isaretedilenmetotlar= m1.GetInvocationList();

            foreach (var item in isaretedilenmetotlar)
            {
                Console.WriteLine(item.Method.Name);
                Console.WriteLine(item.Method.ReturnParameter.Name);
            }
            Console.ReadLine();
        }
        delegate void matematikselislemler(int sayı1, int sayı2);

        static void topla(int sayı1, int sayı2)
        {
            int sonuc = sayı1 + sayı2;
            Console.WriteLine("toplama ıslemı" + sonuc);

        }

        static void cıkarma(int sayı1, int sayı2)
        {
            int sonuc = sayı1 - sayı2;
            Console.WriteLine("cıkarma ıslemı" + sonuc);
        }

        static void carpma(int sayı1, int sayı2)
        {
            int sonuc = sayı2 * sayı1;
            Console.WriteLine("carpma ıslemı" + sonuc);
        }

        static void bölme(int sayı1, int sayı2)
        {
            int sonuc = sayı1 / sayı2;
            Console.WriteLine("bolme ıslemı" + sonuc);
        }


    }
}

