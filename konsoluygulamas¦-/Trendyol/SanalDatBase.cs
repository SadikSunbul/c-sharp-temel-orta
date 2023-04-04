using System;
using System.Collections;

namespace Trendyol
{
	public class SanalDatBase
	{
		public static ArrayList listem = new ArrayList();
		public SanalDatBase()
		{
		}

		public static void ÜrünEkle(Ürün ürün)
		{
			if (ürün!=null && !string.IsNullOrEmpty(ürün._barkod) )
			{
				bool kontrol2 = BarkodKontrol(ürün._barkod);
				if (kontrol2)
				{
					Console.WriteLine("ürün  kaydedilemedi Barkod eşsiz olmalı...");
				}
				else
				{
					listem.Add(ürün);
					Console.WriteLine("ürün kaydedildi ...");
				}

			}
			else
			{
				Console.WriteLine("girdiğiniz değerler dolu değil...");
			}
		}

		public static bool BarkodKontrol(string _barkod)
		{	
			for (int i = 0; i < listem.Count; i++)
			{
				Ürün temp = (Ürün)listem[i];
				if (temp._barkod==_barkod)
				{
					return true;
				}
			}
			return false;
		}
		public static int idÜret(int sayac)
		{
			sayac++;
			return sayac;
		}
	}
}

