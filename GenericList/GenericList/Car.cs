using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Car
    {
        public string marka;
        public string model;
        public double fuelConsumption;
        public double totalDistance;

        public Car (string marka, string model, double fuelConsumption, double totalDistance)
        {
            this.marka = marka;
            this.model = model;
            this.fuelConsumption = fuelConsumption;
            this.totalDistance = totalDistance;
        }
            
        public void Listele()
        {
            double toplamYakit = (totalDistance / 100) * fuelConsumption;

            Console.WriteLine($"Marka:{marka} , Model: {model}, 100 km'de Yaktığı Yakıt: {fuelConsumption}, Toplam Yakıt Tüketimi: {toplamYakit}");
        }
    }
}
