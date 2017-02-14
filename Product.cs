using System;
using System.Collections.Generic;

namespace DIDemo
{
    public class Product : IProductDomain
    {
        private readonly IRepository _repo;

        public Product(IRepository repo)
        {
            _repo = repo;
        }

        public void AddProduct(string productName)
        {
            Console.WriteLine("Passing product to add via Product Class");
            _repo.AddProduct(productName);
        }

        public void RemoveProduct(string productName)
        {
            Console.WriteLine("Passing product to remove via Product Class");
            _repo.RemoveProduct(productName);
        }

        public void UpdateProduct(string oldProductName, string newProductName)
        {
            Console.WriteLine("Passing product to update via Product Class");
            _repo.RemoveProduct(oldProductName);
            _repo.AddProduct(newProductName);
        }
        public ICollection<string> GetAllProducts()
        {
            Console.WriteLine("Getting all products via Product Class");
            return _repo.GetAllProducts();
        }
    }
}