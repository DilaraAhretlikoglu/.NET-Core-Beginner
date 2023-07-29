namespace inheritance;

public class Hayvanlar:Canlilar
{
  protected void Adaptasyon()
  {
    Console.WriteLine("Hayvanlar adaptasyon yapabilir.");
  }
}
public class Surungenler:Hayvanlar
{
    public Surungenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
       
    }
    public void SurunerekHareketEderler()
  {
    Console.WriteLine("Surungenler Surunerek Hareket Ederler");
  }
}
public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
       
    }
    public void Ucmak()
  {
    Console.WriteLine("Kuslar ucarlar");
  }
}