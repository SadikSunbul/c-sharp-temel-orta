// See https://aka.ms/new-console-template for more information


//MD5
//bu sıfrelemede darkwebde cozule bılıyor bunu bu yuzdenkullanmak mantıklı degıl 
using System.Security.Cryptography;



string şifrelenecekMetin = "Sadık1";

MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();

byte[] şifreleencekMetinByts = System.Text.Encoding.UTF8.GetBytes(şifrelenecekMetin); //burada bayt cevırme ıslemı yaptık



byte[] md5şifrelenmıshalıBytes =Md5.ComputeHash(şifreleencekMetinByts); //şifreleme tMAMLANDI


string şifrelenenDeger=Convert.ToBase64String(md5şifrelenmıshalıBytes); //şifreyı yenı bır strıngın ıcerısıne atadık burada 

//Base64 Encoding binary verileri metne dönüştürerek saklamaya veya iletmeye yarayan
//tekniklerden en yaygın olarak kullanılanıdır. Bu teknik ile temel olarak 8 bitlik
//baytlardan oluşan binary veri 6 bitlik (2^6 = 64) parçalara bölünür.

Console.WriteLine(şifrelenenDeger); //buadakı sıfre gerı dondurulemez tek yonlu bır sıfrelemedır 

Console.ReadLine();
