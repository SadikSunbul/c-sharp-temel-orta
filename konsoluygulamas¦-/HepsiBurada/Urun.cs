using System;
namespace HepsiBurada
{
	public class Urun:BaseClass
	{
		public Urun()
		{
		}

		public string Marka { get; set; }
		public string Model { get; set; }

		private int _alışfiyati;
		public int alışFiyatı {
			get
			{
				return _alışfiyati;
			}
			set
			{
				try
				{
                    if (value > 0)
                    {
                        Console.WriteLine("alış fiyatı uygun...");
                        this._alışfiyati = value;
                    }
                    else
                    {
						throw new özelhata();
                    }
                }
				catch(özelhata ef)
				{
					Console.WriteLine("hatalı fiyat 0 ın ustunde olmalı");
					Console.WriteLine(ef.Message);
				}
				catch (Exception ex)
				{

				}
				
			}
		}
		private int _satışFıyatı;
		public int  satışFiyati
		{
			get
			{
				return this._satışFıyatı;
			}
			set
			{
				if (_alışfiyati<value)
				{
					this._satışFıyatı = value;
					Console.WriteLine("satıs fıyatınız uygun");
				}
				else
				{
					Console.WriteLine("hatalı değer alış fıyatından fazla olmalı...");
				}
			}
		}
		public int kanpanyalıFiyati { get; set; }
	}
}

