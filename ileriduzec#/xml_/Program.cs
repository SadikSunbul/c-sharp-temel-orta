// See https://aka.ms/new-console-template for more information


using System.Xml;


string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "example.xml");
//burada dosyayı nereye kaydedıcegımız soyledık dekstopa example.xml adında bır dosya 
/*

XmlTextWriter xmlText = new XmlTextWriter(filePath,System.Text.Encoding.UTF8); //burada yenı dosyayı olustur dedık

xmlText.WriteComment("xml işlemleri"); //yorum

xmlText.WriteStartElement("Personellerim"); //bu elemntı yazmaya basla dedık

xmlText.WriteStartElement("Personel");//burada actık bır elemnt daha 
xmlText.WriteAttributeString("ID","1");
xmlText.WriteElementString("İsim", "Cengiz");
xmlText.WriteElementString("Soyisim", "Atilla");
xmlText.WriteElementString("Email", "Cengiz.atilla@gmail.com");
xmlText.WriteEndElement();//kapadık burada elemnti




xmlText.WriteStartElement("Personel"); //yenı bır element daha actık burada
xmlText.WriteAttributeString("ID", "2");
xmlText.WriteElementString("İsim", "sadık");
xmlText.WriteElementString("Soyisim", "sunbul");
xmlText.WriteElementString("Email", "sadık.sunbul@gmail.com");
xmlText.WriteEndElement();//kapadık burada elemnti


xmlText.WriteEndElement();//en uste acmıs oldugumuz olemenrtı kapadık


xmlText.Close(); */




XmlReader xred = XmlReader.Create(filePath);

while (xred.Read()) //okunacak kayıt varmı dıye bakıyoruz burada varsa 
{
    Console.WriteLine($"{xred.Name.ToString()}-{xred.Value.ToString()}");
}
Console.ReadLine();