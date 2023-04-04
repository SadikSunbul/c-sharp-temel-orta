using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5_şifrelemeTeknikkleri
{
	static public class SHA
	{
	
		
		public static string SHA256Şifrele(string deger)
		{
			SHA256 sha256 = SHA256Managed.Create();
			byte[] değerbyt = Encoding.UTF8.GetBytes(deger);
			byte[] sha256byte = sha256.ComputeHash(değerbyt);
			return HashToByte(sha256byte);
		}
        public static string SHA512Şifrele(string deger)
        {


            return string.Empty;
        }
		private static string HashToByte(byte[] hash)
		{
			StringBuilder sonuc = new StringBuilder();
			for (int i = 0; i < sonuc.Length; i++)
			{
				sonuc.Append(hash[i].ToString("X2")); //append eklemek demek x2 format demek 
			}
			return sonuc.ToString();
		}
    }
}

