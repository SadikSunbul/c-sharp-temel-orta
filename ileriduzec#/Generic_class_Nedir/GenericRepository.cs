using System;
namespace Generic_class_Nedir
{
    public class GenericRepository<T> where T:class  //burada t tıpının clas olmasını soyledık ınt yazarsak musterı yerıne
                                                     //program.cs de hata verıcektır
    {
        public GenericRepository()
        {
            //context.EF DBFirst
        }

        public virtual List<T> Getir()
        {
            //gelene t tıpıni data base uzerınden sorgulamak ve elde etmıs oldugumuz kayıtları generıc koleksıyon olarak bır ust katmana donmek..
            return null;
        }
        
        public virtual void yeniKayıt(T data)
        {
            //bize gelen t tıpı ıcerısındekı bılgıyı t tıpınınn ısaret etmıs oldugu tabloya eklıyoruz.
        }
    }
}

