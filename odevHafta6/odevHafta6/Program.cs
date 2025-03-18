using odevHafta6;

Kapi kapi1 = new Kapi(4);
Kasa kasa1 = new Kasa("Sedan");
Marka marka1 = new Marka("BMW", "X5");
Pencere pencere1 = new Pencere(4);


Araba araba1 = new Araba(marka1,kasa1, pencere1, kapi1,15000);
araba1.ShowInfo();

MathOperations m = new MathOperations();
Console.WriteLine(m.cıkart(10, 5));
Console.WriteLine(m.cıkart(10.2, 5.2 , 2.5)); 
Console.WriteLine(m.topla(10, 5)); 
Console.WriteLine(m.topla(10.2 , 5.3, 8.6));