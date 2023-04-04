using System;
namespace otel_resepsiyon
{
	public class Müsteri
	{
		public Müsteri()
		{
		}

		public string İsim { get; set; }
		public string Soyisim { get; set; }
		public int Yas { get; set; }
		public string Telefonnumarası { get; set; }

		private string _sifre;
		public string sifre
		{
			get
			{
				return _sifre;
			}
			set
			{
				this._sifre = value;
			}
		}

		private string _tcno;
		public string TcNo {
			get
			{
				return _tcno;
			}
			set
			{
				bool kontrol=DataBase.TcNoKontrol(value);
				if (kontrol)
				{
					Console.WriteLine("tc mkımlıgınız benzersız olmalı");
				}
				else
				{
					Console.WriteLine("Tc kımlık dogrulaması basarılı ...");
					this._tcno = value;
				}
			}
		}
		private string _kackısılık;
		public string Kaçkisilik
		{
			get
			{
				return _kackısılık;
			}
			set
			{
				this._kackısılık = value;
			}
		}
		public int Kalıcağıgün { get; set; }
		public DateTime giristarıhı { get; set; }
		public DateTime cıkıstarıhı { get; set; }
	}
}

