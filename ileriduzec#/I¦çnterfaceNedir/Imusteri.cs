using System;
namespace İnterfaceNedir
{
    public interface Imusteri
    {
        //ctor yapamazsınız burası tamamen bır sablon abstract tarafı yarı sablondu metot olustura bılıyorduk

        //tum tanımları sablondur kural dır  nesne ornegı alınmaz

        //inter face ıcerısınde
        //fıeld
         int Id { get; set; }
         string isim { get; set; }
         string Soyİsim { get; set; }

        //metot
        int yenikayıt(string isim, string soyisim); //badısı olmaz sablon bunlar
        int kayıtduzenle(int ıd, string isim, string soyisim);
        int kayıtsil(int ıd);



    }
}

