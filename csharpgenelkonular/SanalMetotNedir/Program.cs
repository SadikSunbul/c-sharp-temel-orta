// See https://aka.ms/new-console-template for more information



//object => ToString();
/*
 * Musterı M1=new ();
 * object => Musteri
 *     M1.ToString();
 *     
 * Namespace.Musteri    
 */

using SanalMetotNedir;

Müşteri m1 = new();
m1.İsim = "sadık";
m1.Soyİsim = "sünbül";
string toStringMesaj= m1.ToString();
Console.WriteLine(toStringMesaj); //burada :SanalMetotNedir.Müşteri yazıcaktır yanı bu da //Namespace.class yazdırr

Console.ReadLine();