// See https://aka.ms/new-console-template for more information


string metin1 = "100";

//int s1 = (int)metin1  hatalı farklı turler;
int s2 = int.Parse(metin1);
int s3 = Convert.ToInt32(metin1);

Console.WriteLine(s2);
Console.WriteLine(s3);

string metin2 = "true";

bool b1 = bool.Parse(metin2);
bool b2 = Convert.ToBoolean(metin2);


string metin3 = null;//ıcerıde bısey yok demek

//decimal d1 = decimal.Parse(metin3);  //parsede null alamaz deger almalı ıcerısıne 
decimal d2 = Convert.ToDecimal(metin3); //null alabılır ıcerısne

bool b3 = Convert.ToBoolean(metin3);



Console.ReadKey();

//VAR ANAHTAR KELIMESI ilk elemanı kendısı turunu atıyor 

int t1 = 10;
var t2 = "cengiz";  //burda strıng olarak ayarladı
var t3 = 100;  //burada ınt olarak tanıdı

//t2 = 100;  burda haat verır cunku t2 strıng oluyor ınt atama yapamayız

