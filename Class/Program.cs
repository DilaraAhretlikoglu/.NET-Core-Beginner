namespace Class;

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
        Calisan calisan1 = new Calisan();
        calisan1.Ad="Ayse";
        calisan1.Soyad="Kara";
        calisan1.No=12345;
        calisan1.Departman="İK";

        calisan1.CalisanBilgileri();

        Console.WriteLine("******************************************");

        Calisan calisan2 = new Calisan();
        calisan2.Ad="Deniz";
        calisan2.Soyad="Arda";
        calisan2.No=54321;
        calisan2.Departman="Satin Alma";
        
        calisan2.CalisanBilgileri();



    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisanin Adi:{0}",Ad);
        Console.WriteLine("Calisanin Soyadi:{0}",Soyad);
        Console.WriteLine("Calisanin Numarasi:{0}",No);
        Console.WriteLine("Calisanin Departmani:{0}",Departman);

    }
}
