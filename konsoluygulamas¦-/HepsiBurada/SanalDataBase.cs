using System;
using System.Collections;

namespace HepsiBurada
{
	public  class SanalDataBase
	{
		public static ArrayList sanaldata;
		static SanalDataBase()
		{
			sanaldata = new ArrayList();
		}

		public static bool barkodkontrol(string _barkod)
		{
			bool kontrol = false;
			for (int i = 0; i < sanaldata.Count; i++)
			{
				Urun temp = (Urun)sanaldata[i];
				if (temp.barkod==_barkod)
				{
					kontrol = true;
					Console.WriteLine("bu barkod alınmıs...");
				}
			}
			return kontrol;
		}

		public static void Kayit(Urun x)
		{
			if (x != null && !string.IsNullOrEmpty(x.barkod) && x.satışFiyati!=null) 
			{
				bool kontrol1 = barkodkontrol(x.barkod);
				if (kontrol1)
				{
					Console.WriteLine("barkod alınmıs...");
				}
				else
				{
					Console.WriteLine("ürün basarılı bir sekilde eklendi...");
					sanaldata.Add(x);
				}
			}
			else
			{
				Console.WriteLine("kayıt değereriniz eksik lutfen kontrol edınız ozelıkle barkodunuzu...");
			}
		}

	}
}

