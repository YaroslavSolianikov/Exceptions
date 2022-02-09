using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] price = new Price[2];
            for (int i = 0; i < price.Length; i++)
            {
                price[i] = new Price();
                Console.WriteLine("Enter the product");
                price[i].Product = Console.ReadLine();
                Console.WriteLine("Enter the Name of shop");
                price[i].NameShop = Console.ReadLine();
                Console.WriteLine("Enter the price of product");
                price[i].Cost = decimal.Parse(Console.ReadLine());
            }
            var res = from p in price
                      orderby p.NameShop
                      select p;
            foreach (var item in res)
            {
                Console.WriteLine($"{item.NameShop} - {item.Product} - {item.Cost}");
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine("Choose the shop");
                string shop = Console.ReadLine();
                bool exist = false;
                foreach (var item in res)
                {
                    if (item.NameShop != shop)
                    {
                        continue;
                    }
                    else if (item.NameShop == shop)
                    {
                        exist = true;
                        Console.WriteLine($"{item.NameShop} - {item.Product} - {item.Cost}");
                    }
                }
                if(exist == false)
                {
                    throw new Exception("the shop does not exist!!");
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
    struct Price
    {
        public string Product { get; set; }
        public string NameShop { get; set; }
        public decimal Cost { get; set; }
    }
}
