// See https://aka.ms/new-console-template for more information


//operatorler

// toplama operatoru +


//int + int(toplama ıslemı yapar)
int s1 = 50;
int s2 = 100;
int toplamint = s1 + s2;

byte s3 = 225;
byte s4 = 10;
var toplambyte = s3 + s4;

//string + strıng  == strıng cevap
//int + string  ===strıng cevap
//string + int ==string cevap



//çıkartma operatoru

//byt ınt double float decımal larda kllanılır

int sa1 = 100;
int sa2 = 50;
int sonuc = sa1 - sa2;

//çarpma operatoru *

//byt ınt double float decımal larda kllanılır

double d1 = 10.4;
double d2 = 10.6;

int sonucınt = (int)(d1 * d2); //double yı ınte dondurduk

//bolme
//byt ınt double float decımal larda kllanılır

//mod alma operatoru %

int r1 = 10;
int r2 = 2;
int sonucumod = r1 % r2;

//++  operatoru
int t1 = 10;
int operatorsonucu3 = (t1++);//parantezin bir onemı yok  bı altakıyle aynı degerı verır
int operatorsonucu1 = t1++; //ılk atar sonra toplar
int operatorsonuc2 = ++t1; //ılk toplar sonra ata
int operatorsonucu4 = t1 + 2;//bu farklı bır operator burda 12 atar drekt ılk atama yapmadı


int mevcutyıl = DateTime.Now.Year; //burada suankı zamanda yılı getırr now sımdı demek

Console.WriteLine(mevcutyıl);


//is operatoru  bu bumu soruyor

object o1 = s1;
Console.WriteLine(o1);
s1 = (int)o1;
//s1 = (byte)o1; olamadı burası

bool iskontrol = o1 is int;  //o1 ıcerısındekı int mı soruyoruz
bool iskontrol2 = o1 is byte; //o1 byte tıpındenmı geldı


//As operatoru

string isimsoyısım = "cengız atılla";
object objctstrıng = isimsoyısım;
string sonucstr = objctstrıng as string; //objctstrıng ıcındekı deger strıngmi ozmn ıcerısındekı degerı strınge cevır ve gonder