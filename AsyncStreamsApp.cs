using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreamsApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            foreach (var message in GetProducts())
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("-----");

            await foreach (var message in GetProductsAsync())
            {
                Console.WriteLine(message);
            }

        }

        static IEnumerable<string> GetProducts()
        {
            yield return "Getting Products";
            yield return "Product 1";
            yield return "Product 2";
            yield return "Product 3";

        }
        static async IAsyncEnumerable<string> GetProductsAsync()
        {
            yield return "Getting Products";
            await Task.Delay(2000);
            yield return "Product 1";
            await Task.Delay(2000);
            yield return "Product 2";
            await Task.Delay(2000);
            yield return "Product 3";
        }
    }
}
