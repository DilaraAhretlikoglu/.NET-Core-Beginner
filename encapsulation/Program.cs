namespace encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim="Ayse";
        ogrenci.Soyisim="Yılmaz";
        ogrenci.OgrenciNo=293;
        ogrenci.Sinif=3;

        ogrenci.BilgileriGetir();

        ogrenci.sinifAtlat();
        ogrenci.BilgileriGetir();

        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim="Deniz";
        ogrenci1.Soyisim="Arda";
        ogrenci1.OgrenciNo=292;
        ogrenci1.Sinif=1;

        ogrenci1.BilgileriGetir();

        ogrenci1.sinifDusur();

        ogrenci1.BilgileriGetir();

    }
}
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { 
        get => sinif; 
        set
         {
            if (value < 1)
            {
                Console.WriteLine("Sinif en az 1 olabilir !");
                sinif=1;
            }
            else
                 sinif = value;
         }
     }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci()
    {

    }

    public void BilgileriGetir()
    {
        Console.WriteLine("*********Ogrenci Bilgileri*********");
        Console.WriteLine("Ogrenci Adı            :{0}",this.Isim);
        Console.WriteLine("Ogrenci Soyadı         :{0}",this.Soyisim);
        Console.WriteLine("Ogrenci Numarası       :{0}",this.OgrenciNo);
        Console.WriteLine("Ogrenci Sınıfı         :{0}",this.Sinif);



    }
    public void sinifAtlat()
    {
        this.Sinif=this.Sinif+1;
    }

    public void sinifDusur()
    {
        this.Sinif=this.Sinif-1;
    }

}
