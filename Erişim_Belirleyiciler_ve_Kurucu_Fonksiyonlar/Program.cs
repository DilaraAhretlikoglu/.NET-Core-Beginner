namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar;

class Program
{
    static void Main(string[] args)
    {
        // Söz Dizimi
        // class SinifAdi
        // {
        //     [Erisim Belirleyici] [Veri Tipi] ÖzellikAdi;
        //     [Erisim Belirleyici] [Geri Dönüs Tipi] MetotAdi([Parametre Listesi])
        //     {
        //         //Metot Komutları
        //     }

        // }

        //Erisim Belirleyiciler

        // * Public : Her yerden erişilebilir
        // * Private : Sadece tanımlandığı sınıf içerisinden erişilebilir
        // * Internal : Sadece kendi bulunduğu proje içerisinden erişilebilir
        // * Protected : Sadece tanımlandığı sınıftan ya da o sınıftan kalıtılmış sınıflardan erişilebilir.
        Calisan calisan1 = new Calisan("Ayşe","Kara",12345,"İK");
        calisan1.CalisanBilgileri();

        Console.WriteLine("******************************************");

        Calisan calisan2 = new Calisan("Deniz","Arda",54321,"Satin Alma");
        calisan2.CalisanBilgileri();

        Console.WriteLine("******************************************");

        Calisan calisan3 = new Calisan("Dilara","Ahretlikoglu");
        calisan3.CalisanBilgileri();

    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad,int no,string departman)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.Departman=departman;
        this.No=no;
    }
      public Calisan(string ad, string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;
    }
    public Calisan(){}
    

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisanin Adi:{0}", Ad);
        Console.WriteLine("Calisanin Soyadi:{0}", Soyad);
        Console.WriteLine("Calisanin Numarasi:{0}", No);
        Console.WriteLine("Calisanin Departmani:{0}", Departman);

    }
}