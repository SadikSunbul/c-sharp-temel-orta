using System;
namespace SanalMetotNedir
{
    public class Müşteri //: object yazmayız .net freamvork standar olarak tum nesnelerı objec den turetıyor
    {
        public Müşteri()
        {
        }
        public int  MüşteriId { get; set; }
        public string İsim { get; set; }
        public string Soyİsim { get; set; }

        
        public override string ToString()  //override yazdıktan sonra ıcerıgını degıstırmek ıstedıgımız moetodu secıyoruz
                                           //ıstedıgımız ıslemlerı yapabılıyoruz
        {
            return İsim + " " + Soyİsim; //ToString metodunu degıstırmıs olduk onceden burda base.tostring vardı
                                         //burdakı base bır oncekı kalıtıldıgı clası gosterır 
        }

    }
}

