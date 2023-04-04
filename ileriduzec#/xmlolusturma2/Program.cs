// See https://aka.ms/new-console-template for more information


using System.Xml.Linq;
using xmlolusturma2;



string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "xmlolusturmafakedata.xml");

List<Ögrenci> ogrencilerim = new List<Ögrenci>();

for (int i = 0; i <100; i++) //burada fake datadan 100 adet ogrencı alıdk
{
    Ögrenci temp = new Ögrenci();
    temp.Id = Guid.NewGuid(); //benzersınz bır deger gelıcek
    temp.İsim = FakeData.NameData.GetFirstName();
    temp.Soyisim = FakeData.NameData.GetSurname();
    temp.Numara = FakeData.NumberData.GetNumber(100, 500);
    ogrencilerim.Add(temp);
}

XDocument Doc = new XDocument(new XDeclaration("1.1","UTF-8","yes"),
    new XElement("Ogrencilerim",
    ogrencilerim.Select(i=>new XElement("Öğrenci",new XElement("Id",i.Id),
    new XElement("İsim",i.İsim),
    new XElement("Soyisim",i.Soyisim),
    new XElement("Numaera",i.Numara)
    ))));
Doc.Save(filepath); 

List<Ögrenci> OkunanData = new List<Ögrenci>();

XDocument DocOku = XDocument.Load(filepath);
List<XElement> okunanxelement=DocOku.Descendants("Öğrenci").ToList();

foreach (var item in okunanxelement)
{
    Ögrenci temp = new Ögrenci();
    temp.Id = Guid.Parse(item.Element("Id").Value);//degerı cevırdık
    temp.İsim = item.Element("İsim").Value;
    temp.Soyisim = item.Element("Soyisim").Value;
    temp.Numara =int.Parse( item.Element("Numaera").Value);
    OkunanData.Add(temp);
}

Console.ReadLine();