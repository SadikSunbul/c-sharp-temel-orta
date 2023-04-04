using System;
namespace LİNQ_Nedir
{
    public class dataSource
    {
        public dataSource()
        {
            musteriler = new List<Müşteri>();
        }
        List<Müşteri> musteriler;

        public List<Müşteri> musterılıstesı()
        {
            for (int i = 0; i < 1000; i++)
            {
                Müşteri m = new();
                m.musterıNumarası = i;
                m.isim = FakeData.NameData.GetFirstName();
                m.soyisim = FakeData.NameData.GetSurname();                 //burda belırtıgımız ıkı tarıh arasında bır tarıh verıcek
                m.dogumgunu = FakeData.DateTimeData.GetDatetime(new DateTime(1984, 01, 01), new DateTime(1999, 01, 01));
                m.ülke = FakeData.PlaceData.GetCountry();
                m.il = FakeData.PlaceData.GetCity();
                m.ilçe = FakeData.PlaceData.GetCountry();

                m.emaıladres=$"{m.isim.ToLower()}.{m.soyisim.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                m.telefonnumarası = FakeData.PhoneNumberData.GetPhoneNumber();
                musteriler.Add(m);

            }
            return musteriler;
        }
    }
}

