using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle girin:");
        string cumle = Console.ReadLine();

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };

        // Sesli harfleri içeren bir dizi oluşturuyoruz
        char[] sesliHarfDizi = cumle.Where(c => sesliHarfler.Contains(c)).ToArray();

        // Diziyi sıralıyoruz
        Array.Sort(sesliHarfDizi);

        Console.WriteLine("Cümledeki sesli harfler:");
        foreach (char harf in sesliHarfDizi)
        {
            Console.Write(harf + " ");
        }

        Console.ReadLine();
    }
}