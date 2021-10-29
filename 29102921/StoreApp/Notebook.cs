using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    class Notebook:Product
    {
        public Notebook(double price,int count,string model) : base(price, count)
        {
            this.Model = model;
        }
        public Notebook(double price, int count, string model,string brand) : base(price, count)
        {
            this.Model = model;
            this.Brand = brand;
        }
        public Notebook(double price, int count, string model, string brand,int ram,int storage) : base(price, count)
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

        public string GetInfo()
        {
            return $"Brand: {this.Brand} - Model: {this.Model} - Price: {this.Price} - RAM: {this.Ram} - Storage: {this.Storage} - Count: {this.Count}";
        }
    }
}
