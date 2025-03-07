using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    public class YasKategorii
    {
        string isim, soyisim;
        int yas;

        public YasKategorii(string isim, string soyisim, int yas)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
        }

        public string YasKategorisi()
        {
            if (yas < 0 || yas > 99)
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            }
            else if (yas < 18)
            {
                return "Küçüksünüz";
            }
            else if (yas < 35)
            {
                return "Gençsiniz";
            }
            else if (yas < 55)
            {
                return "Yetişkinsiniz";
            }
            else if (yas < 75)
            {
                return "Yaşlısınız";
            }
            else
            {
                return "Çok yaşlısınız";
            }
        }
    }
}
