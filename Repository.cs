using System;
using System.Collections.Generic;

namespace DIDemo
{
    public class Repository : IRepository
    {
        private static ICollection<string> _product = new List<string>();
        
        public void AddProduct(string productName)
        {
            Console.WriteLine($"Adding {productName} via Repository Class");
            _product.Add(productName);
        }

        public void RemoveProduct(string productName)
        {
            Console.WriteLine($"Removing {productName} via Repository Class");
            _product.Remove(productName);
        }

        public ICollection<string> GetAllProducts()
        {
            Console.WriteLine("Getting all products via Repository Class");
            return _product;
        }
    }
}