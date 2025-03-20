using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public void carp(int x, int y)
        {
            Console.WriteLine("İşlem Sonucu: " + x*y);
        } 
        public void carp(double x, double y)
        {
            Console.WriteLine("İşlem Sonucu: " + x * y);
        }

        public void cıkart(int x, int y)
        {
            Console.WriteLine("İşlem Sonucu: " + (x - y));
        }
        public void cıkart(double x, double y)
        {
            Console.WriteLine("İşlem Sonucu: " + (x - y));
        }

        public void bol(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("İşlem Sonucu: DNE");
            }
            else
            {
                Console.WriteLine("İşlem Sonucu: " + (x / y));
            }
            
        }

        public void topla(int x, int y)
        {
            Console.WriteLine("İşlem Sonucu: " + (x + y));
        }
        public void topla(double x, double y)
        {
            Console.WriteLine("İşlem Sonucu: " + (x + y));
        }

    }
}
