using System;
namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Algoritma1**********");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Lütfen bir n degeri giriniz:");
            int n = int.Parse(Console.ReadLine());

            while(pozitifMi(n)==0)
            {
                Console.WriteLine("Negatif deger girdiniz!!!");
                Console.WriteLine("Lütfen bir n degeri giriniz:");
                 n = int.Parse(Console.ReadLine());
            }

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. degeri girin",i+1);
                dizi[i]=int.Parse(Console.ReadLine());

                while(pozitifMi(n)==0)
                {
                    Console.WriteLine("Negatif deger girdiniz!!!");
                    Console.WriteLine("{0}. degeri girin",i+1);
                    dizi[i]=int.Parse(Console.ReadLine());
                }
                  
            }
            foreach(var sayi in dizi)
            {
                if(sayi%2==0)
                    Console.WriteLine(sayi);
            }
            Console.WriteLine("**********Algoritma2**********");
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            Console.WriteLine("Lutfen birinci pozitif tam sayiyi girin:");
            int sayi1=int.Parse(Console.ReadLine());

            while(pozitifMi(sayi1)==0)
            {
                Console.WriteLine("Negatif deger girdiniz!!!");
                Console.WriteLine("Lutfen birinci pozitif tam sayiyi girin:");
                sayi1=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lutfen ikinci pozitif tam sayiyi girin:");
            int sayi2=int.Parse(Console.ReadLine());

            while(pozitifMi(sayi2)==0)
            {
                Console.WriteLine("Negatif deger girdiniz!!!");
                Console.WriteLine("Lutfen ikinci pozitif tam sayiyi girin:");
                sayi2=int.Parse(Console.ReadLine());
            }
            int[] array = new int[sayi1];

            for (int j = 0; j < sayi1; j++)
            {
                Console.WriteLine("{0}. degeri girin",j+1);
                array[j]=int.Parse(Console.ReadLine());

                while(pozitifMi(n)==0)
                {
                    Console.WriteLine("Negatif deger girdiniz!!!");
                    Console.WriteLine("{0}. degeri girin",j+1);
                    array[j]=int.Parse(Console.ReadLine());
                }
                  
            }
            foreach (var number in array)
            {
                if(number % sayi2 == 0 || number == sayi2)
                    Console.WriteLine(number);

            }
            
            Console.WriteLine("**********Algoritma3**********");
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("Girilecek kelime sayisi:");
            int kelimeSayisi=int.Parse(Console.ReadLine());

            while(pozitifMi(kelimeSayisi)==0)
            {
                Console.WriteLine("Negatif deger girdiniz!!!");
                Console.WriteLine("Girilecek kelime sayisi:");
                kelimeSayisi=int.Parse(Console.ReadLine());
            }

            string[] kelimeler = new string[kelimeSayisi];

            for(int i = 0 ; i < kelimeSayisi; i++)
            {   
                Console.WriteLine("{0}. Kelime:",i+1);
                kelimeler[i]=Console.ReadLine();
            }

            kelimeler.Reverse();

            foreach (var m in kelimeler)
            {
               Console.WriteLine(m);
                
            }

            Console.WriteLine("**********Algoritma4**********");
           
            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine();

            string[] kelimeler2 = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int kelimeSayisi2 = kelimeler.Length;

    
            int harfSayisi = cumle.Length - cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length + 1;

            Console.WriteLine("Girilen cümledeki toplam kelime sayısı: " + kelimeSayisi2);
            Console.WriteLine("Girilen cümledeki toplam harf sayısı: " + harfSayisi);

             Console.ReadLine();


            





        }
        public static int pozitifMi(int sayi)
        {
            if(sayi>0)
                return 1;
            else 
                return 0;

        }
    }
}