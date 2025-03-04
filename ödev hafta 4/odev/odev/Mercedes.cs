using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class Mercedes : IOzellikler
    {
        public void Drive()
        {
       
        }

        public void Float()
        {
            Console.WriteLine("Mercedes Denizde Yüzer");
        }

        public void Fly()
        {
            Console.WriteLine("Mercedes havada uçar");
        }
    }
}
