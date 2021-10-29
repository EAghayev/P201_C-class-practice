using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    class Store
    {
        public Notebook[] Notebooks;
        public double TotalIncome;

        public void AddNotebook(Notebook notebook)
        {
            var temp = this.Notebooks;
            Notebook[] newNotebooks = new Notebook[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                newNotebooks[i] = temp[i];
            }
            newNotebooks[newNotebooks.Length - 1] = notebook;

            this.Notebooks = newNotebooks;
        }

        //public Notebook[] GetFiltered(string brand)
        //{

        //}
        //public Notebook[] GetFiltered(double minPrice,double maxPrice)
        //{

        //}
    }
}
