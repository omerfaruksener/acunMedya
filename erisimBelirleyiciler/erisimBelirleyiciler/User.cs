using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisimBelirleyiciler
{
    public class User
    {
        private string adSoyad;
        private int yas;
        public string email;

        public User(string email)
        {
            this.email = email;
        }

        public string getAdSoyad()
        {
            return adSoyad;
        }
        public void setAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }

        public int getYas() 
        {
             return yas;
        }
        public void setYas(int yas)
        {
            this.yas = yas;
        }



        public void BilgileriGoster()
        {
            Console.WriteLine("Ad Soyad: " + this.adSoyad);
            Console.WriteLine("Yaş: " + this.yas);
            Console.WriteLine("Email: " + this.email);
        }
    }
}
