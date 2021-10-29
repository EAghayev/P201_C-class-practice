using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    class Notebook:Product
    {
        Notebook(double price,int count,string model) : base(price, count)
        {
            this.Model = model;
        }
        Notebook(double price, int count, string model,string brand) : base(price, count)
        {
            this.Model = model;
            this.Brand = brand;
        }
        Notebook(double price, int count, string model, string brand,int ram,int storage) : base(price, count)
        {
            this.Model = model;
            this.Brand = brand;
            this.Ram = ram;
            this.Storage = storage;
        }

        public string Brand;
        public string Model;
        public int Ram;
        public int Storage;
    }
}
