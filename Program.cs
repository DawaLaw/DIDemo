using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIDemo
{
    class Program
    {
        private static IServiceProvider _serviceprovider;
        private static IProductDomain _product;
        static void Main(string[] args)
        {
            BuildServiceProvider();

            _product.AddProduct("Pencil");
            _product.AddProduct("Pen");
            _product.AddProduct("Book");
            _product.AddProduct("Rubber");

            Console.ReadLine();

            Console.WriteLine("Products added:");
            foreach(var product in _product.GetAllProducts())
            {
                Console.WriteLine($"{product}");
            }
            Console.ReadLine();

            _product.RemoveProduct("Pen");
            Console.ReadLine();

            Console.WriteLine("Products left:");
            foreach (var product in _product.GetAllProducts())
            {
                Console.WriteLine($"{product}");
            }
            Console.ReadLine();

            _product.UpdateProduct("Rubber", "Eraser");
            Console.ReadLine();

            Console.WriteLine("Products left:");
            foreach (var product in _product.GetAllProducts())
            {
                Console.WriteLine($"{product}");
            }
            Console.ReadLine();
        }

        private static void BuildServiceProvider()
        {
            var services = new ServiceCollection();
            // Add your Dependency here.
            services.AddSingleton<IRepository, Repository>();
            services.AddSingleton<IProductDomain, Product>();
            _serviceprovider = services.BuildServiceProvider();
            // Instantiate service
            _product = _serviceprovider.GetService<IProductDomain>();
        }
    }
}
