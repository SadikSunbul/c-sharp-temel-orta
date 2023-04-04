using System;
namespace Trendyol
{
	public class BaseClass
	{
		int saayc = 100;
		public BaseClass()
		{
			olusturulmaTarihi = DateTime.Now;
			guncellemeTarihi = DateTime.Now;
		}
		public int _id;
		private int id
		{
			get { return this._id; }
			set
			{
				this._id=SanalDatBase.idÜret(saayc);
			}
		}
		public string _barkod;
		public string barkod
		{
			get { return _barkod; }
			set
			{
				bool kontrol = SanalDatBase.BarkodKontrol(value);
				if (kontrol)
				{
					Console.WriteLine("bu barkod önceden alınmış...");
				}
				else
				{
					this._barkod = value;
					Console.WriteLine("Barkod değeriniz kaydedildi...");
				}
			}
		}
		public DateTime olusturulmaTarihi { get; private set; }
		public DateTime guncellemeTarihi { get; private set; }
		public bool silindi { get; set; }
	}
}

