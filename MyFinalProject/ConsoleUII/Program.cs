using Business.Concrate;
using DataAccess.Concrate.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryProductDal ınMemory = new InMemoryProductDal();
              ProductManager proman = new ProductManager(ınMemory);
            foreach (var product in proman.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
          
        }
    }
}
