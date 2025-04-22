using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeYontemleri
{
    public class Eft : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL EFT ile ödendi";
        }
    }
}
