// See https://aka.ms/new-console-template for more information

MyClass m1 = new();
MyClass.MyClas m2 = new MyClass.MyClas();


//acıklama satırının ekklenmesı

Random random = new Random();
random.Next();


MyClass R1 = new();

 
//burada 3 tane / koyarsak bu bızın acıklama satırımızdır hangı metotoda acıklama satırı eklemk ıstıyorsak onun bı ustune 3 / koyark
//acıklamasını ekleyebılırz
//acıklama satırları sonradan gerı ye dondugumuz zaman anlıya bılmemızı saglar
//


/// <summary>
/// Bu bir ornek klastır
/// </summary>
class MyClass
{
    int a;
    /// <summary>
    /// Bu bir propertdıy
    /// </summary>
    public int MyProperty { get; set; }
    public void x() { }

    public int this[int a]
    {
        get
        {
            return 0;
        }
    }

    public class MyClas
    {

    }
}

