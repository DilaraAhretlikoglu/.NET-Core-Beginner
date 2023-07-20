namespace dateTime_and_Math;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //Datetime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));

        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy"));

        //Math
        Console.WriteLine(Math.Abs(-25)); //mutlak deger
        Console.WriteLine(Math.Sin(10)); //sin değerini yazar
        Console.WriteLine(Math.Cos(10)); //cos degerini yazar
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(22.3)); //yukarı yuvarlar
        Console.WriteLine(Math.Round(22.3)); //hangisine yakınsa ona yuvarlar
        Console.WriteLine(Math.Floor(22.7)); //aşağı yuvarlar

        Console.WriteLine(Math.Max(22,3));
        Console.WriteLine(Math.Min(22,3));

        Console.WriteLine(Math.Pow(3,4));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Log(9)); //e tabanında logaritmik karışılığını verir
        Console.WriteLine(Math.Exp(3));//extern üzeri 3 ü verir
        Console.WriteLine(Math.Log10(10));// 10 tabanındaki kaşılı


        


        
        
    }   
}
