using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    class Product
    {
        public Product(double price,int count)
        {
            this.Price = price;
            this.Count = count;
        }
        public double Price;
        public int Count;
    }
}
