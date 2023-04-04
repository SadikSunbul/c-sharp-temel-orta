
using System;
namespace Abstract_nedir
{
    public class Müşteri:TemelSınıf 
    {
        public Müşteri()
        {
            MüşteriId = 1;
        }
        public int MüşteriId { get; set; }

        public override void testAbstract() //burayı acmazsak hata verıcektır  implament et dıyoruz lanbadan kulanmazsak
                                            //hata vermesının sebebı abstract bır clas cunku kesınlıkle her seyıyle kulanmak zorunda 
        {
            Console.WriteLine("müşteri sınıfının ıcerısındeki testabstract sınıfı");
        }
    }
}

