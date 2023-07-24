using System;
using System.Collections.Generic;
namespace Generic_Koleksiyonlar_ve_List;

class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        //T-> object türündedir.

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kirmizi");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sari");
        renkListesi.Add("Yesil");

        //Count -> eleman sayisi
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //Foreach ve List.Foreach ile elemanlara erişme
        foreach (var i in sayiListesi)
        {
            Console.WriteLine(i);
        }
        foreach (var j in renkListesi)
        {
            Console.WriteLine(j);
        }

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //Remove ->Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yesil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //Contains -> Liste icinde arama
        if(sayiListesi.Contains(10))
            Console.WriteLine("10 Liste içinde bulundu");
        //BinarySearch-> Eleman ile indexe erişme
        Console.WriteLine(renkListesi.BinarySearch("Sari"));

        //Diziyi List'e çevirme
        string[] hayvanlar={"Kedi","Kopek","Kus"};
        List <string> hayvanListesi = new List<string>(hayvanlar);
        //Clear -> Listeyi temizleme
        hayvanListesi.Clear();
        //List icinde nesne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

        Kullanicilar kullanici1=new Kullanicilar();
        kullanici1.Isim="Ayse";
        kullanici1.Soyisim="Yilmaz";
        kullanici1.Yas=26;

        Kullanicilar kullanici2= new Kullanicilar();
        kullanici2.Isim="Ozcan";
        kullanici2.Soyisim="Caliskan";
        kullanici2.Yas=22;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniListe=new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar()
        {
            Isim="Deniz",
            Soyisim="Arda",
            Yas=24

        });
        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adi:"+kullanici.Isim);
            Console.WriteLine("Kullanici Soyadi:"+kullanici.Soyisim);
            Console.WriteLine("Kullanici Yasi:"+kullanici.Yas);
        }
        yeniListe.Clear();







    }
}
public class Kullanicilar
{   
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value;}
    public string Soyisim { get => soyisim; set => soyisim = value;}
    public int Yas { get => yas; set => yas = value;}

    
}
