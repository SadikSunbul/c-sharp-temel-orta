// See https://aka.ms/new-console-template for more information



/*
 * database  | uygulama
 * mssql        c#
 * 
 * tblmusteri
 * id int
 * musteri nuamrası uniqueidentitfy(guid)
 * isim nvarchar(50) string 
 * soyisim nvarchar(50) string
 * dogumtarıhbılgısı datetime datetime
 * 
 * UnitofWorks=> generic class |generic ınterface 
 * 
 * 
 */


using Generic_class_Nedir;

GenericRepository<Müşteri> repositorymusteri = new(); //bır kere getır metodu yazıldı ve data baseden ıstedıgımız verılere erıstık

List<Müşteri> musterilerim= repositorymusteri.Getir();

repositorymusteri.yeniKayıt(null); //bana müşteri ver diyor

GenericRepository<Ürün> repositoryürün = new();
List<Ürün> ürünlerim = repositoryürün.Getir();
repositoryürün.yeniKayıt(null); //bana urun ver dıyor

