// See https://aka.ms/new-console-template for more information


List<int> sayılarım = new();
sayılarım.Add(1);

int[] eklenecekdata1 = new int[3];
eklenecekdata1[0] = 2;
eklenecekdata1[1] = 3;
eklenecekdata1[2] = 4;
//1. yol uzun bır yol
for (int i = 0; i < eklenecekdata1.Length; i++)
{
    sayılarım.Add(eklenecekdata1[i]);
}

//2.yol
sayılarım.AddRange(eklenecekdata1); //ekelnecekdata1 ıcerısınde kendı verı tıpıne uygun verılerı ekler ıcerısıne

//-------------------------------------------------------------------

int capasıty= sayılarım.Capacity; //capasıteyı gosterır
int caount= sayılarım.Count;  //eleman sayısını gosterir
sayılarım.TrimExcess(); //bu kod caunt ve capasıteyı bır bırıne esıtler....

//sayılarım koleksıyonu ıcerıssınde bulunan datayı ekrana yazdırmak ıstıyorum bunu nasıl yaparım

sayılarım.ForEach(i => Console.WriteLine(i)); //i=koleksıyon ıcerısındeı her bır degere i ornegıyle ulasıcam => işareti
                                              //lamda ıfadesı forec dongusunde dondugunuzu dusunun ilgili koleksıyonnıcerısınde arama yap ....
                                              //sonra ekrana yazdırdık  lamda => linq konusu
int bulunandeger = sayılarım[3]; //ulasmak ıstedıgım degrın ındexi
Console.WriteLine("listcenerıg koleksıyonu ıcerısınde 3. indexte bulunan deger:{0}",bulunandeger);

Console.WriteLine("-------------");

sayılarım.Insert(3, 100); //3. indexin degerini 100 yapar 3. ındedekı degeerı sılmedı araya sıkıstırdı gıbı dıger alta kaydı ... 100 ,4 ....

int x = sayılarım[3]; //ulasmak ıstedıgım degrın ındexi
Console.WriteLine("listcenerıg koleksıyonu ıcerısınde 3. indexte bulunan deger:{0}", x);

bool kontrol1 = sayılarım.Any(); //bu rası ıcerıde deger varmı
bool kontrol2 = sayılarım.Any(i => i>5 ); //sayılarım lıst ıcerısındekı degerlerı dondur ve 5 den buyuk olan varsa bana true dondur demek


int enyuksekdeger= sayılarım.Max();//eleman sayısının en yuksek deger
int enkuukderer = sayılarım.Min();
int toplamdeger = sayılarım.Sum(); //tum elemanların toplamı



sayılarım.Sort(); //a dan z ye dogru 1-N dogru bır sıralama yapar

sayılarım.Reverse(); // z den a ya dogru sıralama n-1 e dogru sıralama

bool silmeslmeısonuc=sayılarım.Remove(100); //içeride 100 varsa siler   bool doner
int silinenadet=sayılarım.RemoveAll(i=>i>3);//3 ten buyuk degerlerı sıl demek
sayılarım.RemoveAt(2); //2. ındextekı degerı sıl dedık



sayılarım.Clear(); //dizi içerisinde deger kalmaz hepsını sıler

