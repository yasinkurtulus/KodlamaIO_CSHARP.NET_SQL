using Business.Concrate;
using DataAccess.Concrate.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager1.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("--------------------");

        
        }
    }
}
