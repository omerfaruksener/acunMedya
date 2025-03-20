using Calculator;

Calculate calculate = new Calculate();
Console.WriteLine("Lütfen Bir sayı giriniz: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
int b = int.Parse(Console.ReadLine());

calculate.topla(a, b);
calculate.cıkart(a, b);
calculate.carp(a, b);
calculate.bol(a, b);