// See https://aka.ms/new-console-template for more information


byte sayi1 = 100;
byte byteMin = byte.MinValue;//0
byte byteMax = byte.MaxValue;//255

//sayi1 = 256; hata veriyor
int sayi2 = 256;

int intMax = int.MaxValue;
int intMin = int.MinValue;

//bilinçli tür dönüşümüd

int sayı3 = sayi1; //hata almadıkk  int byten buyuk oldugu ıcın aldı 


//bilinçsiz tür dönüşümü 

int sayi4 = 100;

byte sayi3 = (byte)sayi4; //soldakı degere garantı verıyoruz bunun degerlerı bytın dısındaysa hata verır(hata degerı ıcerı alamz 0 verır) ıçındeyse byte dondurru



//objectTipi

// içerisinde int decimal bool float double class ,custom class tum tıplerın en buyugu herseyı kapsar

//kutulama (boxing)
//genelde claslarda kullancaz 
object o1 = 100;
object o2 = 10.90;
object o3 = true;




