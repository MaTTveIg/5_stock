using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_stock
{
    internal class Product
    {
        public string Name { get; set; } = "no_name";
        public int Price { get; set; }
        public int Weight { get; set; }
        public Product(string name, int price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
