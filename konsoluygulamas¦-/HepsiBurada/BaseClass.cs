using System;
namespace HepsiBurada
{
	public class BaseClass
	{
		static int sayac;
		 static BaseClass()
		{
			 sayac = 1;
		}
		public BaseClass()
		{
			
			this._id = sayac;
			olusturmTarihi = DateTime.Now;
            sayac++;
        }
		private int _id;
		public int id {
			get
			{
				return _id;
			}
			private set
			{
				//bos kalıcak 
			}
		}
		private string _Barkod;
		public string barkod
		{
			get
			{
				return _Barkod;
			}
			set
			{
				bool kontrol =SanalDataBase.barkodkontrol(value);
				if (kontrol)
				{
					Console.WriteLine("Barkod kaydeilemedi...");
				}
				else
				{
					Console.WriteLine("barkod kullanılabilir...");
					this._Barkod = value;
				}
			}
		}

		private DateTime olusturmTarihi { get; set; }
		private DateTime güncellemeTarihi { get; set; }
		public bool silindi { get; set; }
	}
}

