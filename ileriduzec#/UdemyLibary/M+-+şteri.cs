namespace UdemyLibary;
public class Müşteri
{
    //REFLECTİON PROJESI
    public Guid Id { get; set; }
    public int CariNumarasi { get; set; }
    public string İsim { get; set; }
    public string Soyisim { get; set; }
    public string Email { get; set; }

    public Müşteri()
    {

    }
    public Müşteri(Guid id,int carinumara)
    {
        this.Id = id;
        this.CariNumarasi = carinumara;

    }
    public Müşteri(Guid id, int carinumara,string isim,string soyisim)
    {
        this.Id = id;
        this.CariNumarasi = carinumara;
        this.İsim = isim;
        this.Soyisim = soyisim;
    }

    public void Ekranayaz()
    {
        Console.Write($"{Id.ToString()}-cari numarası:{CariNumarasi.ToString()} isim-soyisim{İsim}{Soyisim}");
    }

    public void carinoguncelle(int carino)
    {
        this.CariNumarasi = carino;
    }
    }

