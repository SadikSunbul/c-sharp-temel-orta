using System;
using System.Collections;

namespace otel_resepsiyon
{
	public static class DataBase
	{
		public static ArrayList database;
		static DataBase()
		{
			database = new ArrayList();
		}


		public static bool TcNoKontrol(string _tcno)
		{
			bool kontrol = false;
			for (int i = 0; i < database.Count; i++)
			{
				Müsteri temp = (Müsteri)database[i];
				if (temp.TcNo==_tcno)
				{
					kontrol = true;
				}
			}
			return kontrol;
		}

		public static void kayıt(Müsteri müsteri)
		{
			bool kontrol1 = TcNoKontrol(müsteri.TcNo);
			if (kontrol1==true)
			{
				Console.WriteLine("Kullanıcı kaydedilemedi tc numarası kullanılmıs");
			}
			else
			{
				Console.WriteLine("kullanici basariili bir sekiilde kaydedildi...");
				database.Add(müsteri);
			}
		}

		public static void Menü()
		{
			Console.WriteLine("1-kayit sayfasi");
			Console.WriteLine("2-bos oda varmi sorgusu");
			Console.WriteLine("3-kayit silme sayfasi");
			Console.WriteLine("4-oda fiyat listesi");
			Console.WriteLine("5-yemek fiyati");
			Console.WriteLine("6-giriş");
			Console.WriteLine("Lütfen birini seçiniz....");
			int sayı =Convert.ToInt32( Console.ReadLine());
			switch (sayı)
			{

				case 1:
					Müsteri m1 = new Müsteri();
					Console.WriteLine("Kullanici kayit sayfasi");
					Console.WriteLine("kullanicin adini giriniz:");
					m1.İsim = Console.ReadLine();
					Console.WriteLine("kullanicin soyadini giriniz:");
					m1.Soyisim = Console.ReadLine();
					Console.WriteLine("kullanicin yasini giriniz");
					m1.Yas = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("kullanicin TcNo su:");
					m1.TcNo = Console.ReadLine();
					Console.WriteLine("sirenizi giriniz...");
					m1.sifre = Console.ReadLine();
					Console.WriteLine("sıfreyı tekrar gırınız...");
					string sifre1 = Console.ReadLine();
					if (sifre1==m1.sifre)
					{
						if (m1.TcNo!=null)
						{
                            kayıt(m1);
						}
						else
						{
							Console.WriteLine("tc nız yazılmaıs kontrol edınız...");
						}
                        
					}
					else
					{
						Console.WriteLine("girilen şifreler uyuşmuyor...");
					}
					
					break;
				case 2:
					Console.WriteLine("boş oda var..");
					break;
				case 3:
					Console.WriteLine("kayıt sılme sayfası");
					Console.WriteLine("tc no giriniz");
					string tc = Console.ReadLine();
					for (int i = 0; i < database.Count; i++)
					{
						Müsteri temp = (Müsteri)database[i];
						if (temp.TcNo==tc)
						{
							Console.WriteLine("Şifrenizi giriniz..");
							string sifre = Console.ReadLine();
							if (temp.sifre==sifre)
							{
								database.Remove(temp);
								Console.WriteLine("basarılı bır sekılde sılındı...");
							}
						}
						else
						{
							Console.WriteLine("boyle bir kullanici yok...");
						}
					}
					break;
				case 4:
					Oda o = new Oda();
					Console.WriteLine("1 kisilik ofa fiyati:"+o.tekkisilik);
					Console.WriteLine("2 kisilik oda fiyati:"+o.ikikisilik);
					Console.WriteLine("3 kisilik oda fiyati"+o.üçkisilik);
					break;
				case 5:
					Yemek y = new Yemek();
					Console.WriteLine("Yemek ıstersenız günlük olarak +"+y.YemekVar);
					break;
				case 6:
					Console.WriteLine("Giriş sayfasi");
					Console.WriteLine("Tcno nusu gırınız:");
					string tc_ = Console.ReadLine();
					Console.WriteLine("sifrenizi giriniz:");
					string sıfre1 = Console.ReadLine();
                    for (int i = 0; i < database.Count; i++)
                    {
                        Müsteri temp1 = (Müsteri)database[i];
                        if (temp1.TcNo == tc_)
                        {
                            Console.WriteLine("Şifrenizi giriniz..");
                            string sifre = Console.ReadLine();
                            if (temp1.sifre == sıfre1)
                            {
								Console.Clear();
								Console.WriteLine("giriş başarili");

								Console.WriteLine("1-Oda kiralama işlemleri");
								Console.WriteLine("işlem seciniz...");
								int sayı4 = Convert.ToInt32(Console.ReadLine());
								switch (sayı4)
								{
									case 1:
										Oda o2 = new Oda();
										Yemek y2 = new Yemek();
										Console.WriteLine("kaç kisilik oda istiyorsunuz");
										int oda = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine("yemek istiyormusunuz evet=1 hayır=0");
										int yemek = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine("kac gece kalicaksiniz:");
										int gece = Convert.ToInt32(Console.ReadLine());

										Console.WriteLine("Kiralama işelmi başarılı...");
										Console.WriteLine("Müşteri ismi-soyisim:"+temp1.İsim+temp1.Soyisim+"Yaş:"+temp1.Yas);
										
										if (oda==1)
										{
											if (yemek==1)
											{
												int top = (o2.tekkisilik + y2.YemekVar)*gece;
												Console.WriteLine("Toplam borcunuz:"+top);
											}
											else
											{
												Console.WriteLine("Toplam borcunuz:"+o2.tekkisilik*gece);
											}
										}
										else if (oda==2)
										{
                                            if (yemek == 1)
                                            {
                                                int top = (o2.ikikisilik + y2.YemekVar)*gece;
                                                Console.WriteLine("Toplam borcunuz:" + top);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Toplam borcunuz:" + o2.ikikisilik*gece);
                                            }
                                        }
										else if (oda==3)
										{
                                            if (yemek == 1)
                                            {
                                                int top = (o2.üçkisilik + y2.YemekVar)*gece;
                                                Console.WriteLine("Toplam borcunuz:" + top);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Toplam borcunuz:" + o2.üçkisilik*gece);
                                            }
                                        }
                                        Console.WriteLine("Faturaniz mail olarak gonderildi...");

                                        break;
									default:
										break;
								}
							}
						}
						else
						{
							Console.WriteLine("boyle bir kullanici yok...");
						}
                        
                    }
                    break;
				default:
					Console.WriteLine("hatalı kod girdiniz");
					break;
			}
		}

	}
}

