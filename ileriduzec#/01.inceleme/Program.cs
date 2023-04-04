// See https://aka.ms/new-console-template for more information



using System.Reflection;
//buradakı ınceleme dedıgımız kısım udemylİBARY KISMINDA ALDIGIMIZ DLL ICIN DENEME KISMMI
//  REFLECTİON PROJESI

Assembly Libry = Assembly.LoadFile("/Users/sadiksunbul/Desktop/dll/UdemyLibary.dll");//burada gıt buradakı dosyayı okuı dedık

Type[] tp =Libry.GetTypes(); //burada dızı tanımladıgımız ıcın cogul ekını koymak gererkır

foreach (var item in tp)
{
    ConstructorInfo[] ctors=item.GetConstructors(); // ctor kısımlarına ulastık 
    for (int i = 0; i < ctors.Length; i++) //yapıcı metot uzunlugu kadar doner
    {
        Console.WriteLine(ctors[i].ToString()); 
    }
    Console.WriteLine("------------------");
    //property ınceleme

    PropertyInfo[] prp=item.GetProperties();
    for (int i = 0; i < prp.Length; i++)
    {
        Console.WriteLine($"name:{prp[i].Name} namespace:{item.Namespace} publicmi:{item.IsPublic} tam adı:{item.FullName}");
    }
    Console.WriteLine("-------------------");
    //method kullanımı

    MethodInfo[] mtm=item.GetMethods();
    for (int i = 0; i < mtm.Length; i++)
    {
        Console.WriteLine($"metotadı:{mtm[i].Name}");
    }
    Console.WriteLine("--------------------");
}







Console.ReadLine();
