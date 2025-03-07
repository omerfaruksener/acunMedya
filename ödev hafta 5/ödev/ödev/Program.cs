using ödev;

YasKategorii a = new YasKategorii("Ahmet", "Memiş", 40);
Console.WriteLine(a.YasKategorisi());
Araba Mercedes = new Araba("Mercedes", 35, 10);
Console.WriteLine(Mercedes.durum());
Araba Opel = new Araba("Opel", 12,8);
Console.WriteLine(Opel.durumSwitch());
Araba Porsche = new Araba("Porsche", 25, 15);
Araba Audi = new Araba("Audi", 12, 8);
Araba[] arabas  = new Araba[] { Mercedes, Opel, Porsche, Audi };

for (int i = 0; i < arabas.Length; i++)
{
    arabas[i].yakitTuketimiNedir();
}



int sayi = 6;

while (sayi <= 5)
{
    Console.WriteLine("Sayı: " + sayi);
    sayi++;
}
Console.WriteLine("Döngü sona erdi.");

sayi = 6;

do
{
    Console.WriteLine("Sayı: " + sayi);
    sayi++;
}
while (sayi <= 5);

Console.WriteLine("Döngü sona erdi.");

GenelMudur genelmudur = new GenelMudur();
genelmudur.isim = "Ahmet";
genelmudur.soyisim = "Akın";
genelmudur.maas = 200000;
Mudur mudur = new Mudur();
mudur.isim = "Muallim";
mudur.soyisim = "Naci";
mudur.maas = 100000;
Programci programci = new Programci();
programci.isim = "Müşerref";
programci.soyisim = "Mur";
programci.maas = 45000;
Stajyer stajyer = new Stajyer();
stajyer.isim = "Hale";
stajyer.soyisim = "Nur";
stajyer.maas = 5000;

Calisan[] calisans = new Calisan[] {genelmudur, mudur, programci, stajyer};

for(int i =0; i<calisans.Length; i++)
{
    calisans[i].bilgiYazdır();
}

for (int i = 0; i < calisans.Length; i++)
{
    Console.WriteLine(calisans[i].maasHesapla());
}

