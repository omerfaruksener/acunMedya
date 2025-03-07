using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    public class Araba
    {
        int yakitTuketimi;
        String model;
        int arabaYas;

        public Araba(String model, int arabaYas, int yakitTuketimi)
        {
            this.model = model;
            this.yakitTuketimi = yakitTuketimi;
            this.arabaYas = arabaYas;
            
        }
        public void yakitTuketimiNedir()
        {
            Console.WriteLine($"{model} aracının yakıt tüketimi: {yakitTuketimi} litre/100km");
        }

        public String durum()
        {
            if (arabaYas < 0 || arabaYas > 30)
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
            else if (arabaYas < 10)
            {
                return "Arabanız yeni";
            }
            else if (arabaYas < 20)
            {
                return "Servise götürmeniz gerekebilir";
            }
            else
            {
                return "Arabanız hurdaya çıkabilir";
            }

        }
          public String durumSwitch()
        { switch (arabaYas)
            {
                case int n when(n >= 0 && n <= 10) :
                    return "Arabanız yeni";
                case int n when(n > 10 && n <= 20) :
                    return "Servise götürmeniz gerekebilir";
                case int n when(n > 20 && n <= 30) :
                    return "Arabanız hurdaya çıkabilir";
                default:
                    return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        }
         


}
}
