// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Numerics;

string seçim = string.Empty;
Hashtable kayıt = new Hashtable();
do
{
    Console.Clear();
    
Console.WriteLine("1-kayıt ol");
Console.WriteLine("2-kayıt sil");
Console.WriteLine("3-kayıt olanları göster.");
Console.WriteLine("4-giriş yap");
Console.WriteLine("5-şifre değiştir");
Console.WriteLine("6-çıkış.");

Console.WriteLine("işlem seçiniz:");
 seçim = Console.ReadLine();

switch (seçim)
{
    case "3":
            Console.WriteLine("kayıtlı kısılerın ısımleri");
            foreach (var item in kayıt.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Geçmek için entr yapınız");
            Console.ReadLine();
       break;
    case "1":
            Console.WriteLine("Kayıt sayfası.");
            Console.WriteLine("Epostanızı gırınız (@hmail.com yazmayınız):");
            string eposta = Console.ReadLine();
            Console.WriteLine("Şifre giriniz (8 karakterden büyük olmalı şifreniz).");
            string şifre = Console.ReadLine();
            bool kontrol = kayıt.Contains(eposta);
            if (kontrol)
            {
                Console.WriteLine("Bu e postayla daha önce kayıt yapılmış giriş yapmayı deneyin.");
                System.Threading.Thread.Sleep(1200);
            }
            else
            {
                if (şifre.Length >= 8)
                {
                    kayıt.Add(eposta, şifre);
                    Console.WriteLine("Kayıt başarılı bir şekilde yapıldı");
                    Console.WriteLine("geçmek için entr yapınız.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Şifreniz 8 karakterden az lütfen yeniden deneyiniz");

                    System.Threading.Thread.Sleep(1200);
                }
                
            }
            
        break;
    case "2":
            Console.WriteLine("kayıdını silmek istediğiniz epostayı giriniz: ");
            string deleposta = Console.ReadLine();
            Console.WriteLine("kayıdını silmek istediğiniz epostanın şifresini giriniz: ");
            string delpasword = Console.ReadLine();
            bool kontrol1 = kayıt.Contains(deleposta);
            int ctr = 1;
            if (kontrol1==true)
            {
                if (kayıt.ContainsKey(deleposta))
                {
                    if (kayıt[deleposta].ToString()==delpasword)
                    {
                        kayıt.Remove(deleposta);

                        Console.WriteLine("Kayıt başarılı bir şekilde silindi");
                        Console.WriteLine("geçmek için entr basınız");
                        Console.ReadLine();
                        ctr = 0;
                    }
                   
                }

                if (ctr==1)
                {
                    Console.WriteLine("Kullanıcı şifresi veya epostası yanlış.");
                    System.Threading.Thread.Sleep(1200);
                }
               
            }
            else
            {
                Console.WriteLine("böyle bir kayıt yok zaten");
                System.Threading.Thread.Sleep(1200);
            }   
        break;
    
    case "4":
            Console.WriteLine("Giriş sayfasına hoşgeldiniz.");
            Console.Write("Epostanızı giriniz (@gmailsiz):");
            string epostagırıs = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            string sıfregırıs = Console.ReadLine();
            bool kontrolgırıs = kayıt.Contains(epostagırıs);
            if (kontrolgırıs==true)
            {
                if (kayıt[epostagırıs].ToString() == sıfregırıs)
                {
                    Console.WriteLine("Giriş Başarılı bir şekilde yapıldı .");
                    Console.WriteLine("Buraya daha fazla ozelıkler eklenebılcek.");







                    Console.WriteLine("geçmek için bir rusa basınız.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("girdiğiniz şifree yanlış");
                    System.Threading.Thread.Sleep(800);
                }

            }
            else
            {
                Console.WriteLine("Böyle bir kullabıcı yok..");
                System.Threading.Thread.Sleep(800);
            }
        break;
    case "5":
            Console.WriteLine("Şifre değiştirme sayfasına hoşgeldiniz.");
            Console.Write("Epostanızı giriniz(@gmail siz):");
            string eposta1 = Console.ReadLine();
            Console.Write("Şifrenizi giriniz:");
            string sifre1 = Console.ReadLine();
            bool kontrol4 = kayıt.Contains(eposta1);

            if (kontrol4 == true)
            {
                if (kayıt[eposta1].ToString() == sifre1)
                {
                    Console.WriteLine("Yeni şifre giriniz");
                    string sıfre2 = Console.ReadLine();
                    Console.WriteLine("Yeni şifrenizi bi daha giriniz:");
                    string sıfre3 = Console.ReadLine();
                    if (sıfre2 != kayıt[eposta1].ToString())
                    {
                        if (sıfre2 == sıfre3)
                        {
                            kayıt[eposta1] = sıfre2;
                            Console.WriteLine("Şifreniz değiştirildi");

                            Console.WriteLine("geçmek için entr yapınız.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Şifreler uyuşmuyor");
                            Console.WriteLine("tekrar yenı sıfre gırmeyı deneyınız.");
                            Console.WriteLine("Gecmek ıcın entra basınız.");
                            Console.ReadLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Girilen şifre önceki şifreyle aynı Lütfen farklı bir şifre deneyiniz");
                        System.Threading.Thread.Sleep(2200);
                    }
                    
                }

            }
            break;
    default:
            Console.WriteLine("böyle bir işlem yok tekrar deneyiniz.");
        break;
}


} while (seçim!="6");