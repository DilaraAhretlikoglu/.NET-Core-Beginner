using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


            ArrayList asalListe = new ArrayList();
            ArrayList asalOlmayanListe = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
                if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
                {
                    if (asalMi(sayi))
                        asalListe.Add(sayi);
                    else
                        asalOlmayanListe.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı giriniz.");
                    i--; // Tekrar denemesi için döngü değişkenini azaltıyoruz.
                }
            }
            Console.WriteLine("******************************");
            Console.WriteLine("Asal Sayılar:");
            asalListe.Sort();
            asalListe.Reverse();
            int asalElemanSayisi=asalListe.Count;
            double asalOrt =CalculateAverage(asalListe);
            foreach (var i in asalListe)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Eleman Sayısı:{0}",asalElemanSayisi);
            Console.WriteLine("Ortalama:{0}",asalOrt);

            Console.WriteLine("******************************");

            Console.WriteLine("Asal Olmayan Sayılar:");
            asalOlmayanListe.Sort();
            asalOlmayanListe.Reverse();
            int asalOlmayanElemanSayisi=asalOlmayanListe.Count;
            double asalOlmayanOrt =CalculateAverage(asalOlmayanListe);
            foreach (var i in asalOlmayanListe)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Eleman Sayısı:{0}",asalOlmayanElemanSayisi);
            Console.WriteLine("Ortalama:{0}",asalOlmayanOrt);
        }

        static bool asalMi(int deger)
        {
            int sayac = 0;
            for (int k = 1; k <= deger; k++)
            {
                if (deger % k == 0)
                    sayac++;
            }
            if (sayac == 2)
                return true;
            else
                return false;
        }
        static double CalculateAverage(ArrayList list)
        {
            if (list.Count == 0)
                return 0;

            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }

            return (double)sum / list.Count;
        }

    }
}
