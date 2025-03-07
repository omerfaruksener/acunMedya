using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    public class Calisan:ICalisan
    {
        public String isim;
        public String soyisim;
        public int maas;

        public void bilgiYazdır()
        {
            Console.WriteLine($"{isim} {soyisim}, Maaş: {maas}");
        }

        public int maasHesapla()
        {
            return maas;
        }
    }
}
