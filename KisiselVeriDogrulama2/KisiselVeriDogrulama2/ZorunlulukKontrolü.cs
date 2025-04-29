using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriDogrulama2
{
    public static class ZorunlulukKontrolü
    {
        public static bool dogrula(object dogrulanacakObje, out List<string> hataMesajlari)
        {
            hataMesajlari = new List<string>();
            Type dogrulanacakType = dogrulanacakObje.GetType();
            //doğrulanacak tip içindeki tüm değişkenlere bakılıyor
            FieldInfo[] dogrulanacakTypeFields = dogrulanacakType.GetFields(
                                                  BindingFlags.Public |
                                                  BindingFlags.Instance);

            //ilgili objenin içindeki tüm alanlar kontrol ediliyor string mi o değişkenler custom yazılmış attribute lar var mı

            foreach (FieldInfo dogrulanacakTypeField in dogrulanacakTypeFields)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTypeField.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                foreach (ZorunluAlanAttribute attr in zorunluAlanOznitelikleri)
                {
                    string deger = dogrulanacakTypeField.GetValue(dogrulanacakObje) as string;
                    if (string.IsNullOrEmpty(deger))
                    {
                        hataMesajlari.Add(attr.HataMesaji);
                    }
                }
            }

            return hataMesajlari.Count == 0;
        }
    }
}
