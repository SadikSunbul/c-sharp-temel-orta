// See https://aka.ms/new-console-template for more information


using System.Collections;

Hashtable sozlukVeriTabanı = new Hashtable();


do
{
    Console.Clear();
    Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız.");
    Console.Write("EN:");
    string eng = Console.ReadLine().ToLower();

   bool kontrol= sozlukVeriTabanı.ContainsKey(eng);  //yenı gırılcek deger lısteye onceden gırıldımı kontrol 
    if (kontrol)
    {
        Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmakadır. " +
            "{1} değerin türkçe karşılığıdır ", eng, sozlukVeriTabanı[eng].ToString());//,2 eng karsılıgı strıng seklınde yazdırır
    }
    else
    {
        Console.Write("İngilizce değerin türkçe karşılığını yazınız:");
        string tr = Console.ReadLine();
        sozlukVeriTabanı.Add(eng,tr);
        Console.WriteLine("Değer ekleme işlemi başarılı");
    }
    Console.WriteLine("yeni değer eklemek istiyormusunuz? ( E/H )...");
    

} while (Console.ReadLine().ToUpper()=="E"); //kullanıcıdan gelen degerı buyuk harfe dondurduk 

foreach (var item in sozlukVeriTabanı.Keys)
{
    Console.WriteLine("ENG:{0} = TR:{1}", item, sozlukVeriTabanı[item].ToString());
                                            //burda value cıktısı alırız.

}
foreach (DictionaryEntry item in sozlukVeriTabanı)
{
    Console.WriteLine("ENG:{0} = TR:{1}",item.Key,item.Value);
}
Console.WriteLine("Cıkmak için entr basınız...");
Console.ReadLine();