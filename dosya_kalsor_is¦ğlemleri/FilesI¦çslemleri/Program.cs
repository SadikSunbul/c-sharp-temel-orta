// See https://aka.ms/new-console-template for more information


FileCreate("\\\\Mac\\Home\\Desktop\\dosya_kalsor_işlemleri\\merhaba.txt");//bulunan komua merhaba txt klasıoru olusturur 
bool kontrol = fileExists("/Users/sadiksunbul/Desktop/dosya_kalsor_işlemleri/Directoryİşlemleri/bin/Debug/net6.0/c:\\udemy");
if (kontrol)
{
    Console.WriteLine("belırtmıs oldugunuz dosya sistem içerisinde");
}
else //yoksa olustır dedık 
{
    FileCreate("\\\\Mac\\Home\\Desktop\\dosya_kalsor_işlemleri\\merhaba.txt");
}
fileDelete("\\\\Mac\\Home\\Desktop\\dosya_kalsor_işlemleri\\merhaba.txt"); //bu dosyayı sıl dedık

filemove("\\\\Mac\\Home\\Desktop\\dosya_kalsor_işlemleri\\merhaba.txt", "c:\\udemy");
filecopya("\\\\Mac\\Home\\Desktop\\dosya_kalsor_işlemleri\\merhaba.txt", "c:\\udemy"); //kopyalama yaptık aynı dosya varsa hedefte kopyalaam yapmaz zaten var der

fileAppendText("c:\\udemy\\merhaba.txt", "Merhaba Txt"); //c:\\udemy\\merhaba.txt gıder ve ıceerısıne Merhaba Txt yazar

string metındegerı=fileReadAllText("c:\\udemy\\merhaba.txt");//oku
Console.WriteLine(metındegerı);

static void FileCreate(string path)
{
   FileStream fs=File.Create(path);//path burda nereye dıye soruyır   buradakı gerı donus degerını kutulardan okuyoruz
    fs.Close();//bunu yazmazsak dosya ıcerısıne bısey yazdırmaz hata verir

}
static bool fileExists(string path)
{
  return File.Exists(path); //dosya varsa true yoksa false 
}

static void fileDelete(string path)
{
   File.Delete(path);
}
static void filemove(string kaynak,string hedef)
{
    File.Move(kaynak,hedef);
}

static void filecopya(string kaynak,string hedef)
{
    File.Copy(kaynak, hedef);
}

static void fileAppendText(string path,string deger)
{
    File.AppendAllText(path, deger);//ıstedıgımız klasor acılcak ve degerlerımız yazılcak
}

static string fileReadAllText(string path)
{
  string metındegerı = File.ReadAllText(path);
    return metındegerı;
}