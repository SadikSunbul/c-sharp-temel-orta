// See https://aka.ms/new-console-template for more information


//MerhabaHataYonetimi(); //buraya a dedıgımız zaman hata verıcektır bunun hata vermemesı ıcın ne yapmamız gerekır onu arastırcaz 

using tryCatch_nedir;

ahatyonetımıınceleme();


static void MerhabaHataYonetimi()
{
    Console.WriteLine("Bir sayı giriniz:");
    int sayı = int.Parse(Console.ReadLine());
}

static void ahatyonetımıınceleme()
{
    try //try tab tab yap
        //standart uygulama ıcınyazmıs oldugumuz kod blokları
    {
        Console.WriteLine("Bir sayı giriniz:");
        int sayı = int.Parse(Console.ReadLine());
        if (sayı==10)
        {// yenı bır hata sınıfı olusturduk trow fırlat demek 
            throw new ÖzelHataSınıfı();
        }
    }      //tip demek format
    catch(ÖzelHataSınıfı fx) //burayı yazamıs olsaydık bulamadıgı ıcın en baseye gıder ordakı hatayı calıstırrdı
    {
        Console.WriteLine("ozel hata sınıfı chac ıcerısınde yakalandı");
    }
    catch(FormatException fx) 
    {
        Console.WriteLine("Sizden beklene deger sayısal bır degerdır");
        Console.WriteLine(fx.Message);
    }
    catch (Exception ex) //buraya hata alınca duserız  //en altta olması lazım en base cunku bu uste olursa altakılerı zaten gormıycek bosuna yazmıs oluruz 
    //catch blokları sıstem ıcerısınde calısma zamanında alınan hataların loglanmasına ve kullanıcıya daha acık hata mesajı vermemıze yarayan
    //bloklardır
    {
        Console.WriteLine("hergangı bır hata olustu");
        Console.WriteLine(ex.Message);
    }
    finally//data base de ıslem yaparken acıyoruz bunları kaparız bu blokta hata alsakta almasakta calısır burası
    {
        //try kısmında bıım kodlarımız calısır ,
        //catch => .....,
        //finally=> kod tarafında herhangı bır hta almasakta bızım fınally kısmız calısmaya devam eder.
        Console.WriteLine("fınally kod blogu calıstı");
    }
    Console.WriteLine("uygulama bıttı");
    Console.ReadLine();
}

