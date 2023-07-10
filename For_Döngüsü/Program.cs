using System;
namespace For_Döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Bir sayi girin:");
            // int sayi=int.Parse(Console.ReadLine());
            // for (int i = 1; i <= sayi; i++)
            // {
            //     if(i%2==1)
            //         Console.WriteLine(i);
            // }
            int ciftToplam=0,tekToplam=0;
            for (int i = 1; i < 1000; i++)
            {
                if(i%2==0)
                {
                    ciftToplam+=i;
                }
                else{
                    tekToplam+=i;
                }
            }
            Console.WriteLine("Tek sayilarin toplami:"+tekToplam);
            Console.WriteLine("Cift sayilarin toplami:"+ciftToplam);

        }
    }
}
