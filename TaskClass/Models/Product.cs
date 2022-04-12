using System;
using System.Collections.Generic;
using System.Text;

namespace TaskClass.Models
{
    class Product
    {
        public string ProductName;
        public int ProductPrice;
        public int ProductCount;
        public int ProductTotallnCome;

      

        public Product(string Productname)
        {

        }
        public void Sell()
        {
            int total = ProductTotallnCome;
            while (ProductCount > 0)
            {
                
                int result = 0;
                int a = 1;
                int b = ProductPrice;

                result = (a * b);
                total+=result;

                ProductCount--;
            }
            Console.WriteLine(total);
        }
    }
}
