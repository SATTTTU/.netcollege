using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project1
{
    internal class Product
    {
        public int Qnt { get; set; }
        public int rate { get; set; }
        public void run()
        {
            Product momo = new Product();
            momo.rate = 300;
            momo.Qnt  = 5;
            var totalPrice =momo.getTotalPrice();
            Console.WriteLine(totalPrice);
        }
        public void print()
        {
            Product Car = new Product();
            Car.Qnt = 5;
            Car.rate = 1000000;
            var Price =Car.getTotalPrice();
            Console.WriteLine(Price);
        }
        decimal  getTotalPrice()
        {
            var totalPrice = rate * Qnt;
            return totalPrice;
        }
    }
  
}
