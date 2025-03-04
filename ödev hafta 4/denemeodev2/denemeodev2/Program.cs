using System;

abstract class Calisan
{
    public abstract int maasHesapla();
}

class GenelMudur : Calisan
{
    public override int maasHesapla()
    {
        return 80000;
    }
}

class Mudur : Calisan
{
    public override int maasHesapla()
    {
        return 60000;
    }
}

class Programci : Calisan
{
    public override int maasHesapla()
    {
        return 40000;
    }
}

class Stajyer : Calisan
{
    public override int maasHesapla()
    {
        return 5000;
    }
}

class Program
{
    static void Main()
    {
        int toplamMaas = new GenelMudur().maasHesapla() +
                         new Mudur().maasHesapla() +
                         new Programci().maasHesapla() +
                         new Stajyer().maasHesapla();

        Console.WriteLine("Toplam Maaş: " + toplamMaas);
    }
}
