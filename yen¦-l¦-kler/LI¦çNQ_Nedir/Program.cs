// See https://aka.ms/new-console-template for more information
using LİNQ_Nedir;
dataSource ds = new dataSource();
List<Müşteri> musterılıste = ds.musterılıstesı();

static bool funcdelegatekullanım1(Müşteri m)
{
    if (m.isim[0] == 'A')
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool predicateDelegateMetot(Müşteri m)
{
    if (m.dogumgunu.Year>1990)
    {
        return true;
    }
    return false;
}

static void musterılıstele(Müşteri m)
{
    Console.WriteLine(m.isim+" "+m.soyisim);
}

#region ara odevler
//ismi a ile baslıyan soy ısımde e olan ve dogum yılı 1985 den buyuk olan kayıtları getırın.

var odevalıstırma1 = from I in musterılıste
                     where
                     I.isim.StartsWith("A") && I.soyisim.Contains("e") && I.dogumgunu.Year > 1985
                     select I;
                                                                                                                    //musterı lıstesı don demek 
var odevalıstırma2 = musterılıste.Where(I => I.isim.StartsWith("A") && I.soyisim.Contains("e") && I.dogumgunu.Year > 1985).Select(I=>I);

#endregion
#region action delegate

Action<Müşteri> actionMuster = new Action<Müşteri>(musterılıstele);

musterılıste.ForEach(actionMuster);

musterılıste.ForEach(new Action<Müşteri>(musterılıstele));

musterılıste.ForEach(delegate (Müşteri m) { Console.WriteLine(m.isim+" "+m.soyisim); });

musterılıste.ForEach((Müşteri m) => { Console.WriteLine(m.isim + " " + m.soyisim); );
musterılıste.ForEach(m => Console.WriteLine(m.isim+" "+m.soyisim););
#endregion

#region linq sorgularında delegate kullanımı predıcate delegate
Predicate<Müşteri> predicate = new Predicate<Müşteri>(predicateDelegateMetot);

//findall==vermıs oldugumuz krıterlere uyan tum dataları bır lıste olaarak gerı doner 
var DeleGateKullanımıPredicate1 = musterılıste.FindAll(predicate);
var DeleGateKullanımıPredicate2 = musterılıste.FindAll(new Predicate<Müşteri>(predicateDelegateMetot)); //2.kullanım

var DeleGateKullanımıPredicate3 = musterılıste.FindAll(delegate (Müşteri m) { return m.dogumgunu.Year > 1990; });

var DeleGateKullanımıPredicate4=musterılıste.FindAll((Müşteri m)=>{ return m.dogumgunu.Year > 1990;  });

var DeleGateKullanımıPredicate5 = musterılıste.FindAll(m => m.dogumgunu.Year > 1990); //son kullanımı 
#endregion


#region linq sorgularından delegate kullanıması  =>
var delegatekullanımı1 =musterılıste.Where(I => I.isim.StartsWith("A"));
        //musterı alıcak bool doncek
Func<Müşteri, bool> funcdelete = new Func<Müşteri, bool>(funcdelegatekullanım1);
var delegatekullanımı2=musterılıste.Where(funcdelete);

var delegatekullanımı3 = musterılıste.Where(new Func<Müşteri, bool>(funcdelegatekullanım1));
var delegatekullanımı4 = musterılıste.Where( delegate (Müşteri m) { return m.isim[0] == 'A' ? true : false; });
var delegatekullanımı5 = musterılıste.Where((Müşteri M) => { return M.isim[0] == 'A' ? true : false; });
var delegatekullanımı6 = musterılıste.Where((m) => { return m.isim[0] == 'A' ? true : false; });
var delegatekullanımı7 = musterılıste.Where(m => m.isim[0] == 'A'); //lamdaya  gecıs surecı

#endregion

#region Alistırmalar

// ulke degerlerı a ıle baslıyanları bul

IEnumerable<Müşteri> musterılıstealıstırma1 = musterılıste.Where(i => i.ülke.StartsWith("A"));

int adet1 = musterılıstealıstırma1.Count();
Console.WriteLine("A ıle baslıyan ulke adet sayısı"+adet1);
//ismın ıcerısınde b harfı gecen ve ulke degerı ıcınde a harfı gen musterılerın lıstesınıgetırın
List<Müşteri> musterılıstealıstırma2 = musterılıste.Where(i => i.ülke.Contains("a")&&i.isim.Contains("b")).ToList();

Console.WriteLine("sartları saglıyan kısılerın sayısı"+musterılıstealıstırma2.Count());
foreach (var item in musterılıstealıstırma2)
{
    Console.WriteLine(item.isim+"   /   "+item.ülke);
}
//dogum yılı 1990 dan buyuk ve ismin icerısınde a harfı olanı bulunuz
var musterılıstealıstırma3 = from I in musterılıste
                            where
                           I.dogumgunu.Year > 1990 &&
                           I.isim.Contains("a")
                            select I;
Console.WriteLine(musterılıstealıstırma3.Count());

//4:dogum yılı 1990 buyuk olan veya isim içerisinde a olan

var musterılıstealıstırma4= from I in musterılıste
                            where I.dogumgunu.Year > 1990 || I.isim.Contains("a")
                            select I;

Console.WriteLine(musterılıstealıstırma4.Count());
                               #endregion


#region LİNQ sorgulama cesıtlerı

//1.yol   //=> içerisinde ara demek burdakı  i her bır eleman gecıcı bır nesne
//startswith başlarken ilk karakter a le başlıyormu
int toplammusterıadet =musterılıste.Where(i => i.isim.StartsWith("A")).Count();

                        
var toplammusterıbulunan = from I in musterılıste //müşteri listesinde ı olarak gezınmek ıstıyorum 
                          where I.isim.StartsWith("A") //where bır krıterım var her ı nın ısmı baslarken A ise 
                          select I; //o musterıyı ver bana 
//burda daha farklı yazılabılır
int adet = toplammusterıbulunan.Count(); 



#endregion


#region baslarken




Console.WriteLine(musterılıste.Count);
int bulunantoplam = 0;

//ismın bas harfı a ıle baslayan musterılerın adedını ıstıyoruz
for (int i = 0; i < musterılıste.Count; i++)
{
    if (musterılıste[i].isim[0] == 'A') //burada dedıkkı musterı lıstesının i. elemanın isim degerının 0. ındeksı a ıse 
    {
        bulunantoplam++;
    }
}

Console.WriteLine("liste ıcerısınde ısım A ıle baslayan kayıt sayıs"+bulunantoplam);

bulunantoplam = 0;
bulunantoplam = musterılıste.Where(i => i.isim.StartsWith('A')).Count();
Console.WriteLine("liste LİNQ ile ıcerısınde ısım A ıle baslayan kayıt sayıs" + bulunantoplam);
Console.ReadLine();
#endregion

