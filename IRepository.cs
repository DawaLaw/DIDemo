using System.Collections.Generic;

namespace DIDemo
{
    public interface IRepository
    {
        void AddProduct(string productName);
        void RemoveProduct(string productName);
        ICollection<string> GetAllProducts();
    }
}