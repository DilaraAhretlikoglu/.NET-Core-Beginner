using System;
namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";
            bool sonuc=int.TryParse(sayi,out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Basarili!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Basarisiz!");

            }

            Metotlar instance =new Metotlar();
            instance.Toplam(4,5,out int toplamSonucu); 
            Console.WriteLine(toplamSonucu); 

            //Overloading
            int ifade=999;
            instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);
            instance.ekranaYazdir("Dilara","Ahretikoğlu");


            //METOT İMZASİ
            //metotAdi+ parametreSayisi+parametre
        }
    }
    class Metotlar
    {
        public void Toplam(int a,int b,out int toplam)
        {
            toplam=a+b;
        }
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}