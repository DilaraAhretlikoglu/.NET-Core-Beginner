namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        // Soru - 2: 
        // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan
        // her iki grubun kendi içerisinde ortalamalarını alan ve 
        // bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        int[] sayilar = new int[20];

        for(int i=0;i<20;i++)
        {
            Console.WriteLine("{0}. Sayiyi giriniz:",i+1);
            sayilar[i]=int.Parse(Console.ReadLine());
        }
        Array.Sort(sayilar);
        int[] max= new int [3];
        int[] min = new int[3];
        for(int k =0;k<3;k++)
        {
            min[k]=sayilar[k];
            max[k] = sayilar[sayilar.Length - 1 - k];
        }
        double minOrt=ortHesapla(min);
        Console.WriteLine("********************************");
        Console.WriteLine("En küçük 3 sayi");
        foreach (var item in min)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Ortalama:{0}",minOrt);
        double maxOrt=ortHesapla(max);
        Console.WriteLine("********************************");
        Console.WriteLine("En büyük 3 sayi");
        foreach (var item in max)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Ortalama:{0}",maxOrt);
        Console.WriteLine("********************************");
        Console.WriteLine("Ortalama Toplamları:{0}",minOrt+maxOrt);

    }
    static double ortHesapla(int[] dizi)
    {
        int elemanSayisi=dizi.Length;
        int toplam=0;
        for (int i = 0; i < elemanSayisi; i++)
            {
                toplam += (int)dizi[i];
            }
            return (double)toplam / elemanSayisi;
        
    }
}
