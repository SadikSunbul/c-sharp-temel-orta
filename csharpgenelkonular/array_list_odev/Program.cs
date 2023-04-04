// See https://aka.ms/new-console-template for more information

using System.Collections;

//Null bellekte karsılıgı yok demek yer bıle tutmuyor
//deger turlu yerlere nul dıyemeyız mesela " int a=null;" yanlıstır int? a=null; boyle calısır

// string a=null; calısır burası


//Empty ise bu değişkenin değeri yok analamına gelir alan tahsıs eder burası
//alta empty kullanmanın amacı do whıle ıcerısıne dede kullanacağımız ıcın voyle atadık
//tüm degerlere emmty ataana bilir
//defoult degerlerın bulundugu durumlar empty olarak gecer 

//en onemlı olan stringe "" bu ıfadenın gelmesı gelsın aklımıza baska bı yerde pek kullanılmaz

// string a="";
// string a=string.Empty;

//ustekı ıkısıde aynı anlama gelir
 


string kullanıcısecimi = string.Empty;
ArrayList arrayList = new ArrayList(); //iceriye yazsaydık her dondugunde newlencektı verıler gıtcektı 

do
{
    Console.Clear();
    Console.WriteLine("Menü");
    Console.WriteLine("1- Değer ekle");
    Console.WriteLine("2- Değerlistele");
    Console.WriteLine("3- Değer ara");
    Console.WriteLine("4- Değer düzenle");
    Console.WriteLine("5- Değer sil");
    Console.WriteLine("6- Çıkış");
    Console.WriteLine("Seçiniz:");
    kullanıcısecimi = Console.ReadLine();
    

    switch (kullanıcısecimi)
    {
        case "1":
            Console.Write("Lütfen eklemek istediğiniz değeri giriniz:");
            arrayList.Add(Console.ReadLine());
            Console.WriteLine("Değer başarıyla eklendi");
            System.Threading.Thread.Sleep(700); //2 sn surelıgıne bekler

            break;
        case "2":
            Console.WriteLine("Değerleriniz listeleniyor....");
            System.Threading.Thread.Sleep(500);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("arrayList[" + i + "]=" + arrayList[i]);
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadLine();

            break;
        case "3":
            Console.Write("Aramak istediğiniz kelimeyi giriniz:");
            string ara = Console.ReadLine();
            bool kontrol1 = arrayList.Contains(ara);
            if (kontrol1==true)

            {
                int bulunanındex = arrayList.IndexOf(ara);
                Console.WriteLine("Aradığınız kelime dizinin elemanı... "+bulunanındex+"...");
                Console.WriteLine("Devam etmek için bir tuşa basınız...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aradığınız kelime dizide yok...");
                Console.WriteLine("Devam etmek için bir tuşa basınız...");
                Console.ReadLine();
            }

            break;
        case "4":
            arrayList.Sort();
            Console.WriteLine("Değerler alfabetik sıraya göre düzenlendi.");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("arrayList[" + i + "]=" + arrayList[i]);
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadLine();


            break;
        case "5":
            Console.WriteLine("Silinecek değeri giriniz.");
            string sil = Console.ReadLine();
            arrayList.Remove(sil);
            Console.WriteLine("İstenilen değer silindi.");
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadLine();
            break;

        default:
            break;
    }


} while (kullanıcısecimi!="6");

