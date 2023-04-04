// See https://aka.ms/new-console-template for more information



using JSON;



string uzantı = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "jsonişlemlerim"); //burada dosya ıcın uzantı aldık

List<Personel> yenipersonle = new List<Personel>();

Personel p2 = new Personel
{
    Email = "sadık@gmail.com",
    Soyisim = "sünbül",
    İsim = "sadık",
    Telefon = "253454757",
    Şehir = "konya",
    Id = Guid.NewGuid()
};

string JsonnPersonelerim = Newtonsoft.Json.JsonConvert.SerializeObject(p2); //burada lısteyıde dırekt vere bılırım 
File.WriteAllText("/Users/sadiksunbul/Desktop/jsonişlemlerim/kısıler.json", JsonnPersonelerim);


Console.WriteLine("buırdan sonrası fake datadan verı cekerek json dosyasının dolmasını saglar");

if (Directory.Exists(uzantı)) //varsa bısey yapmasın yoksa olustursun
{

}
else
{
    Directory.CreateDirectory(uzantı); //yoksa dosya olustur dedık
}

List<Personel> Personelerim = new List<Personel>();



for (int i = 0; i < 1000; i++)
{
    Personel p1 = new Personel();
    p1.Id = Guid.NewGuid();
    p1.İsim = FakeData.NameData.GetFirstName(); //fake datatdan verılerı personele ekledık 
    p1.Soyisim = FakeData.NameData.GetSurname();
    p1.Email = $"{p1.İsim}.{p1.Soyisim}@{FakeData.NetworkData.GetDomain()}";
    p1.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
    Personelerim.Add(p1);
   
}
if (Directory.Exists(uzantı)) //varsa bısey yapmasın yoksa olustursun
{

}
else
{
    Directory.CreateDirectory(uzantı); //yoksa dosya olustur dedık
}
string JsonPersonelerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personelerim);//json formatına donduruk strıng sekılde

File.WriteAllText(  "/Users/sadiksunbul/Desktop/jsonişlemlerim/personelerim.json", JsonPersonelerim); //burada dosyaya kaydetmıs olduk klasorleri textide yazdık ıcerısıne



Console.ReadLine();