using System;
namespace Trendyol
{
	public class Ürün:BaseClass
	{
		public Ürün()
		{
		}
		public string Marka { get; set; }
		public string Model { get; set; }
		private int _alışfiyati;
		public int AlişFiyati
		{
			get { return _alışfiyati; }
			set
			{
				if (value>0)
				{
					this._alışfiyati = value;
					Console.WriteLine("aliş fıyatı eklendı..");
				}
				else
				{
					Console.WriteLine("alış fiyatı 0 danbuyuk olmalıdır...");
				}
			}
		}
		private int _satışfiyatı;
		public int SatişFiyati
		{
			get { return _satışfiyatı; }
			set
			{
				if (_alışfiyati<value)
				{
					this._satışfiyatı = value;
					Console.WriteLine("satış fıyatınız eklendi...");
				}
				else
				{
					Console.WriteLine("satıs fıyatınız alış fıyatınızdan fazla olmalı...");
				}
			}
		}
		private int _kanpanyalıFıyat;
		public int KanpanyalıFiyat
		{
			get { return _kanpanyalıFıyat; }
			set
			{
				if (value>_alışfiyati)
				{
					this._kanpanyalıFıyat = value;
					Console.WriteLine("kanpanya fıyatınız kaydedildi");
				}
				else
				{
					Console.WriteLine("Kanpanyalı fıaytınızın alıs fıyatından fazla olması gerekir...");
				}
			}
		}
	}
}

