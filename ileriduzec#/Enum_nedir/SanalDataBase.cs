using System;
using System.Collections;

namespace Enum_nedir
{
    public class SanalDataBase
    {
        public SanalDataBase()
        {
        }
         ArrayList sanalData = new();
        public MusteriReturnValue MüşteriYeniKayıt(Müşteri c)
        {
            //parametre kontrol
            //kayıt kontrol 
            sanalData.Add(c);
            return MusteriReturnValue.kayıtBasarılı;//basarılı
        }
    }
}

