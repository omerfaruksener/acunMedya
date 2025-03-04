using odev3;


{
    double toplamYakit = new BMW().YakitHesapla() +
                         new Mercedes().YakitHesapla() +
                         new Porsche().YakitHesapla();

    Console.WriteLine("Toplam Yakıt Tüketimi: " + toplamYakit + " L");
}