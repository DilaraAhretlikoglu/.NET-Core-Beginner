using System;
using System.Collections;
namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add("A");

            //icerisindeki verilere erismek
            Console.WriteLine(liste[1]);

            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }

            //AddRange
            Console.WriteLine("**********Add Range********");
            string[] renkler ={"kirmizi","sari","yesil"};
            List<int> sayilar=new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }

            //Sort
            Console.WriteLine("************Sort**********");
            ArrayList newListe = new ArrayList();
            newListe.AddRange(sayilar);
             Console.WriteLine("Siralanmamis liste");

            foreach (var i in newListe)
            {
                Console.WriteLine(i);
            }
            newListe.Sort();
            Console.WriteLine("Siralanmis liste");
            foreach (var i in newListe)
            {
                Console.WriteLine(i);
            }

            //Reverse
            newListe.Reverse();
            foreach (var i in newListe)
            {
                Console.WriteLine(i);
            }

            //Clear
            newListe.Clear();


            


        }
    }
}

