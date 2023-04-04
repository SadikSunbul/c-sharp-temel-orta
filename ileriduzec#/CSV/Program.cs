// See https://aka.ms/new-console-template for more information


using CsvHelper;

using CSVVV;

List<Müşter> müşters = new List<Müşter>();

for (int i = 0; i < 50; i++)
{
    Müşter temp = new Müşter();
    temp.Id = i.ToString();
    temp.İsim = FakeData.NameData.GetFirstName();
    temp.Soyisim = FakeData.NameData.GetSurname();
    temp.Email = $"{temp.İsim}.{temp.Soyisim}@{FakeData.NetworkData.GetDomain()}";
    temp.Email=FakeData.PhoneNumberData.GetPhoneNumber();

    müşters.Add(temp);
}

StreamReader SR = new StreamReader(@"/Users/sadiksunbul/Desktop/musteriler.csv");//bu dosyayı oku dedık
CsvHelper.CsvReader read = new CsvHelper.CsvReader(SR);
List<Müşter>okunandata=read.GetRecords<Müşter>().ToList();

Console.WriteLine("okuma ıslemı tamamlandı");


StreamWriter sw = new StreamWriter(@"/Users/sadiksunbul/Desktop/musteriler.csv"); //dosya olusturduk
CsvHelper.CsvWriter writer = new CsvHelper.CsvWriter(sw); //yukarıdakı dosyaya yazcaz 
writer.WriteHeader(typeof(Müşter)); //musterı klasını fildlarını csv kolonları olarab belırtık

foreach (var item in müşters)
{
    writer.WriteRecord(item); //verılerı ekledık csv dosyasının ıcerısne

}
sw.Close(); //burada dosya kapandı bunalr arkda olur
Console.WriteLine("csv kayıt ıslemı tamamlandı");


Console.ReadLine();
