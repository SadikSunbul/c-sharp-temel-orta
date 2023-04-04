using System;
namespace Yenilikler
{
    public class Araba
    {
        
        private string plaka;
        public string Plaka
        {
            get
            {
                return plaka;
            }
            set
            {
                plaka = value;
            }
        }                           //atamalar yapabılırız basına calısır yıne 
        public string Narka { get; private set; } //ustekının daha basıt yontemı ıcerıde kontrol vb bı ıslem yapmıycaksank prop de tabt tab de 
        public Araba()
        {
            
        }

    }
}

