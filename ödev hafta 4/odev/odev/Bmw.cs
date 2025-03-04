using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class Bmw : IOzellikler
    {
        public void Drive()
        {
            Console.WriteLine("BMW çok hızlı gider");
        }

        public void Float()
        {
            Console.WriteLine("BMW denizde yüzer");
        }

        public void Fly()
        {
            Console.WriteLine("BMW havada uçar");
        }
    }
}
