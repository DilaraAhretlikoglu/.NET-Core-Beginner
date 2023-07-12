using System;
namespace While_Foreach
{
     class Program
     {
        static void Main(string[] args)
        {
             //while
             Console.WriteLine("Bir sayi giriniz:");
             int sayi=int.Parse(Console.ReadLine());
             int sayac=1;
             int toplam=0;
             while (sayac<=sayi)
             {
                toplam+=sayac;
                sayac ++;
             }
             Console.WriteLine(toplam/sayi);

             char karakter='a';
             while(karakter<'z')
             {
                 Console.WriteLine(karakter);
                 karakter++;
             }
             //Foreach
             string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
             foreach (var i in arabalar)
             {
                 Console.WriteLine(i);
             }
            
        }
    }
}
