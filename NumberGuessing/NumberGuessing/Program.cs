

Console.WriteLine("1 İle 100 arasında bir sayı tutuldu");

Random rnd = new Random();
int rndNumber = rnd.Next(1,101);

int guess = 0;
while (true)
{
    Console.WriteLine("Lütfen Tahmin Ediniz.");
    int sayi = int.Parse(Console.ReadLine());
    Console.WriteLine("Tutulan sayıyı bulamadınız tekrar deneyin");
    guess++;
    if (sayi < rndNumber)
    {
        Console.WriteLine("Daha büyük bir sayı girin.");
    }
    else if (sayi > rndNumber)
    {
        Console.WriteLine("Daha küçük bir sayı girin.");
    }
    else
    {
        Console.WriteLine("Tebrikler! " + guess + " tahminde doğru cevabı buldunuz: " + rndNumber);
        break;
    }
}
