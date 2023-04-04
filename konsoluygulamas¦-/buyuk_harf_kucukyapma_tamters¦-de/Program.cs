// See https://aka.ms/new-console-template for more information




Console.Write("Metni Giriniz: ");
string metin = Console.ReadLine();
string yeniMetin = "";
foreach (char karakter in metin)
    if (char.IsLower(karakter)) //Belirtilen Unicode karakterinin küçük harf olarak kategorilere ayrılmadığını gösterir.
        yeniMetin += char.ToUpper(karakter); //YENI METIN ICERISINE atama yapıyoruz buyuk harf ataması
    else
        yeniMetin += char.ToLower(karakter); //bosluguda burası yaptı boslugu bılgısayar tanıyor ve kendısı koyuyuor
Console.WriteLine("foreach döngüsü kullanarak yeni metin: " + yeniMetin);