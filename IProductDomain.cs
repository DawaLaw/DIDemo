using System.Collections.Generic;

namespace DIDemo
{
    public interface IProductDomain
    {
        void AddProduct(string productName);
        void RemoveProduct(string productName);
        void UpdateProduct(string oldProductName, string newProductName);
        ICollection<string> GetAllProducts();
    }
}