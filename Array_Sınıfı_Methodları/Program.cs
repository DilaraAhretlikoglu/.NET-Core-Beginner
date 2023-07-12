using System;
namespace Array_Sınıfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi={23,13,4,86,72,3,11,17};
            Console.WriteLine("******Sirasiz Dizi*****");
            foreach( var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******Kucukten Buyuge Sirali Dizi*****");
            Array.Sort(sayiDizisi);
            foreach( var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }
            //Clear()(verilen dizide ilk girilen sayidaki indeksten başlayıp,ikinci girilen deger kadar elemanı sıfır yapar.)
            Console.WriteLine("******Array.Clear*****");
            Array.Clear(sayiDizisi,2,2);
            foreach( var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }
            //Reverse(diziyi ortadan terse döndürür)
            Console.WriteLine("******Array.Reverse*****");
            Array.Reverse(sayiDizisi);
            foreach( var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }
            //IndexOf(girilen değerin indexini döner.dizide yoksa -1 döner)
            Console.WriteLine("******Array.IndexOf*****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            //Resize(yeniden boyutlandırma)
            Console.WriteLine("******Array.Resize*****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;

            foreach (var i in sayiDizisi)
            {
                Console.WriteLine(i);
            }


        }
    }
}
