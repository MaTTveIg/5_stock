using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_stock
{
    internal static class Stock
    {
        public static int space = 100;
        private static readonly List<Product> products = new(space);
        public static List<Product> Products { get => products; }
        public static int Space { get => space; set => space = value; }
        public static int FreeSpace { get => FreeSpace = Space; set => Space = value; }
        public static void AddProduct(Product product)
        {
            products.Add(product);
            FreeSpace = Space - product.Weight;
        }
        public static void DeleteProduct(int index) => products.RemoveAt(index);
        public static void ShowProducts()
        {
            for (int i = 0; i < products.Count; ++i)
            {
                Console.WriteLine(products[i].Name + " (Вес: " + products[i].Price + " Цена: " + products[i].Weight + ')');
            }
        }
    }
}