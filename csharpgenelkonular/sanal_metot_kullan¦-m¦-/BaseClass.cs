using System;
namespace sanal_metot_kullanımı
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("baseclass");
        }
        public virtual void EkranaYaz(string data)  //burada virtual sanal bır metot ollusturduk overide yazdıgımmızda artık bu metott gelıcek
        {
            Console.WriteLine(data);
        }
    }
}

