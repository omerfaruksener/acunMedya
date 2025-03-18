using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevHafta6
{
    public class Araba
    {
        public Marka Marka;
        public Kapi Kapi;
        public Kasa Kasa;
        public Pencere Pencere;
        public int Price;

        public Araba(Marka Marka, Kasa Kasa, Pencere Pencere, Kapi Kapi, int Price)
        {
            this.Marka = Marka;
            this.Kapi = Kapi;
            this.Kasa = Kasa;
            this.Pencere = Pencere;
            this.Price = Price;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine("Markası : " + Marka.adi + " Modeli : " + Marka.model + " Kapı Sayısı: " + Kapi.sayisi + " Pencere sayısı: " + Pencere.sayisi + " Kasası: " + Kasa.tipi + " Fiyatı: " + Price + "$");
        }

    }

}