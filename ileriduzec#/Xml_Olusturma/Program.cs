// See https://aka.ms/new-console-template for more information



/*

           <?xml version="1.0" standalone="yes"?>
<VeriTabanim>
+ Yorum eklendi. 
 <Personellerim +ID="102">
   <Isim>Daniel</Isim>
   <Soyisim>Perkins</Soyisim>
 </Personellerim>
</VeriTabanim>

           */

using System.Xml.Linq;

string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "xmlolusturma2.xml");



XDocument XDoc = new XDocument(
    new XDeclaration("1.0", "UTF-8", "yes"),
    new XElement("VeriTabanim", //element olusturduk
    new XComment("Personellerim Bilgilerini Taşır"),//yorum
    new XElement("Personellerim", new XAttribute("ID", "102"), //XAttribute ıcerısıne bır ozellık katmak ıcın
    new XElement("Isim", "Cengiz"),
    new XElement("Soyisim", "Atilla"),
    new XElement("EmailAdres", "cengiz.atilla@hotmail.com")
    )
    )
    );
XDoc.Save(filePath); //kaydetık burada 

