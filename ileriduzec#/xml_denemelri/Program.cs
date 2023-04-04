// See https://aka.ms/new-console-template for more information






using System.Xml;
using System.Xml.Linq;
using xml_denemelri;



string uzantı = Path.Combine(@"/Users/sadiksunbul/Desktop/kodlama klasoru/c#/ileriduzec#/xml_denemelri", "EmptyXmlFile.xml");

List<Üyeler> kullanıcılar = new List<Üyeler>();
burası:
Console.WriteLine("1-kullanıcı ekle");
Console.WriteLine("2-kullanıcı sil");
Console.WriteLine("3-kulllanıcı sıfresını degıstır");
Console.WriteLine("4-kullanıcı ları lıstele");
Console.WriteLine("5-giriş yap");
switch (Console.ReadLine())
{
    case "1":
        Üyeler temp = new();
        Console.WriteLine("lütfen isim giriniz:");
        temp.İsim = Console.ReadLine();
        Console.WriteLine("lütfen soyisim giriniz:");
        temp.Soyisim = Console.ReadLine();
        Console.WriteLine("lütfen yaş giriniz:");
        temp.Yaş = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("lütfen email giriniz:");
        temp.Email = Console.ReadLine();
        Console.WriteLine("lütfen şifre giriniz:");
        temp.Şifre = Console.ReadLine();



       
        
        XDocument doc;
        if (File.Exists(uzantı))
        {
            doc = XDocument.Load(uzantı);
        }
        else
        {
            doc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Ogrencilerim"));
        }

        doc.Root.Add(new XElement("Öğrenci",
            new XElement("İsim", temp.İsim),
            new XElement("Email", temp.Email),
            new XElement("Soyisim", temp.Soyisim),
            new XElement("Şifre", temp.Şifre),
            new XElement("Yaş", temp.Yaş)
        ));
        doc.Save(uzantı);

        Console.WriteLine("başarılı bir şekilde kaydınız yapıldı");

        goto burası;
        break;
    case "2":
        break;
    case "3":
        break;
    case "4":
        break;
    case "5":
        List<Üyeler> OkunanData = new List<Üyeler>();
        XDocument DocOku = XDocument.Load(uzantı);
        List<XElement> okunanxelement = DocOku.Descendants("Öğrenci").ToList();

        foreach (var item in okunanxelement)
        {
            Üyeler üyeler = new Üyeler();
           üyeler.Yaş = int.Parse(item.Element("Yaş").Value);//degerı cevırdık
            üyeler.İsim = item.Element("İsim").Value;
            üyeler.Soyisim = item.Element("Soyisim").Value;
            üyeler.Email = (item.Element("Email").Value);
            üyeler.Şifre = (item.Element("Şifre").Value);
            OkunanData.Add(üyeler);
        }

        Console.WriteLine("Giriş sayfasın hoşgeldniz");
        Console.WriteLine("Email girizin:");
        string emal = Console.ReadLine();
        Console.WriteLine("şifre giriniz");
        string şifre = Console.ReadLine();

        for (int i = 0; i < OkunanData.Count; i++)
        {
            Üyeler eq = (Üyeler)OkunanData[i];
            if (eq.Email==emal && eq.Şifre==şifre)
            {
                Console.WriteLine(" başarı ");
            }
            else
            {
                Console.WriteLine("hata");
            }
        }
        goto burası;
        break;
    default:
        break;
}
