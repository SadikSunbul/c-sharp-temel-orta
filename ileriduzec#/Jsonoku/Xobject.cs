using System;
namespace Jsonoku
{
	public class Xobject
	{
		public Xobject()
		{
		}
		public Guid İd { get; set; }
		public string İsim { get; set; }
		public string Soyisim { get; set; }
		public string Email { get; set; }
		public string MyProperty { get; set; }
		public string Telefon { get; set; }
		public string Şehir { get; set; }


        public override string ToString()
        {
			return İsim +" " +Soyisim+".";
        }
    }
}

