// See https://aka.ms/new-console-template for more information



Matematik mat = new();




//kurallar
//bu metotlar içerisinde belli farklar olması gerekmektedir
//bu fark bızzat metot imzalarında olmalıdır
//metotların ısımlerının aynı olması gerekir
//metotlar arsında farkı yaratırken erişim belirleyicileri ve geri dönüş değerleri aktif rol oynamamaktadır
//para metre sayıları yada parametre turlerı farklı olmalıdır
//metotlar claslar ıcerıne yazılır




class Matematik
{
    //bir sinif içerisine aynı ısımlı 1 den fazla metot tanımlanamaz
    //belırlı kurallar dısında
    


    public int Topla(int sayı1,int sayı2)  //burada toplaya overloadıng yapmıs olduk
    {
        return sayı1 + sayı2;
    }
    public int Topla(int sayı1, int sayı2,int sayı3)  //hata vermedı
    {
        return sayı1 + sayı2;
    }
    public double Topla(double sayı1, double sayı2)  //hata vermedı
    {
        double sonuc = sayı1 + sayı2;
        return sonuc;
    }
}

