using System;

namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notebook sayini daxil edin:");
            string countStr = Console.ReadLine();

            int count = Convert.ToInt32(countStr);

            Store store = new Store();
            if (count > 0)
            {
                store.Notebooks = new Notebook[0];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine($"{i+1}. notebookun melumatlarini daxil edin");
                    Console.WriteLine("==========================================\n");

                    string brand = GetInputStr("Brand", 3, 30);
                    string model = GetInputStr("Model", 3, 30);
                    int productCount = GetInputInt("Count", 0);
                    int ram = GetInputInt("RAM", 0, 128);
                    int storage = GetInputInt("Storage", 0);
                    double price = GetInputDbl("Price", 0);

                    Notebook notebook = new Notebook(price, count, model, brand, ram, storage);

                    store.AddNotebook(notebook);
                }

                Console.WriteLine("/n Notebook siyahisi:");
                foreach (var item in store.Notebooks)
                {
                    Console.WriteLine(item.GetInfo());
                }
            }
        }

        static string GetInputStr(string inputName,int minLength=0,int maxLength=int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin:");
                input = Console.ReadLine();
            } while (input.Length < minLength || input.Length>maxLength);

            return input;
        }
        static int GetInputInt(string inputName, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            string inputStr;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin");
                inputStr = Console.ReadLine();
                input = Convert.ToInt32(inputStr);

            } while (input<min || input>max);

            return input;
        }
        static double GetInputDbl (string inputName, double min = double.MinValue, double max = double.MaxValue)
        {
            double input;
            string inputStr;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin");
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);

            } while (input < min || input > max);

            return input;
        }
    }
}
