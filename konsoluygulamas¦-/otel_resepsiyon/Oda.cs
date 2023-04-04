using System;
namespace otel_resepsiyon
{
	public class Oda
	{
		public Oda()
		{
		}
		private static int _tekkısıılık = 1000;
		public int tekkisilik {
			get
			{
				return _tekkısıılık;
			}
			private set {
			}
		}
        private static int _ikisilik = 2000;
        public int ikikisilik
        {
            get
            {
                return _ikisilik;
            }
            private set
            {
            }
        }
        private static int _üçkisilik = 3000;
        public int üçkisilik
        {
            get
            {
                return _üçkisilik;
            }
            private set
            {
            }
        }
        public static int kackısılık(int sayı)
        {
            if (sayı==1)
            {
                return _tekkısıılık;
            }
            else if (sayı==2)
            {
                return _ikisilik;
            }
            else if (sayı==3)
            {
                return _üçkisilik;
            }
            return 0;
        }

    }
}

