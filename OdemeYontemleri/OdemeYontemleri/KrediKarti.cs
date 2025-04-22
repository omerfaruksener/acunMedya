using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeYontemleri
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"{tutar} TL Kredi  kartı ile ödendi";
        }
    }
}
