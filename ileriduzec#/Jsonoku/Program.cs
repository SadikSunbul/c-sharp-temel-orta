// See https://aka.ms/new-console-template for more information




using Jsonoku;

string okunandata=File.ReadAllText("/Users/sadiksunbul/Desktop/jsonişlemlerim/personelerim.json"); //bu dosyayı acıp okuycak strıng doncek

List<Xobject> data=Newtonsoft.Json.JsonConvert.DeserializeObject<List<Xobject>>(okunandata);

for (int i = 0; i < data.Count; i++)
{
    Console.WriteLine(data[i].ToString());
}


Console.ReadLine();