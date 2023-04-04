using System;
using System.Collections;

namespace Generik_Oncesı_İşlemler
{
    public class SanalDataBase
    {
        private ArrayList listem;
        public SanalDataBase()
        {
            listem = new ArrayList();
        }

        public void YenıKayıt(int data)  //burda arraylıstımız sadece ınt degerındekı verılerı ala bılır hale dondu
        {
            listem.Add(data);
        }
        
    }
}

