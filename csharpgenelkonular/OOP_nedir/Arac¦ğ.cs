using System;
namespace OOP_nedir
{
    public class Araç
    {
        public Araç()
        {
        }

        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public int YakıtTip;
        public int Vites;
        public decimal AlisFıaytı;
        public decimal SatısFıyatı;
        public decimal MaxİndirimTutari;
        public decimal Fiyat;



        public Araç(string _marka,string _model)
        {
            Marka = _marka;
            Model = _model;
        }
        public Araç(string _marka, string _model, int _modelyıl)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyıl;
        }
        public Araç(string _marka, string _model, int _modelyıl,decimal km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelyıl;
            this.Km = km; //karısıklıgı engelemek amaclı
        }

        public void BilgileriGörüntüle()
        {
            Console.WriteLine("Marka {0} -Model {1} - model yıl {2}",Marka,Model,ModelYil);
        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatısFıyatı - MaxİndirimTutari;
            if (_fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi yaptınız...");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi");
            }
        }
    }
}

