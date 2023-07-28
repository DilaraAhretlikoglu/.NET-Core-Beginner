namespace Static_Sınıf_ve_Üyeler;

class Program
{
    static void Main(string[] args)
    {
        //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.


        Console.WriteLine("Calisan Sayisi:{0}",Calisan.CalisanSayisi);
        Calisan calisan = new Calisan("Ayse","Yılmaz","İK");
        Console.WriteLine("Calisan Sayisi:{0}",Calisan.CalisanSayisi);
        Calisan calisan1 = new Calisan("Deniz","Arda","İK");
        Calisan calisan2 = new Calisan("Dilara","Ahretlikoglu","İK");
        Console.WriteLine("Calisan Sayisi:{0}",Calisan.CalisanSayisi);

        Console.WriteLine("Toplama Islemi Sonucu:{0}",Islemler.Topla(100,200));
        Console.WriteLine("Cikarma Islemi Sonucu:{0}",Islemler.Cikar(200,100));
    }
}
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soyisim;

    private string Departman;
    static Calisan()
    {
        calisanSayisi=0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}
static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1-sayi2;
    }
}
