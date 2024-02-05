using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİnqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> _categories = new List<Category>() { new Category { CategoryId=1,CategoryName="Bilgisayar"},
                                         new Category { CategoryId=2,CategoryName="Telefon"} };

            List<Product> _products = new List<Product>() {
                new Product { Name="Asus Laptop",ProductId=1,CategoryId=1,UnitPrice=2000},
                new Product { Name = "HP Laptop", ProductId = 2, CategoryId = 1, UnitPrice = 2000 },
                 new Product { Name="Monster Laptop",ProductId=4,CategoryId=1,UnitPrice=5000},
                new Product { Name="Iphone",ProductId=3,CategoryId=2,UnitPrice=3000}};


            /*  var result = _products.Where(p => p.UnitPrice > 2000).ToList();
              Console.WriteLine( result[0]);
              var resultany = _products.Any(p => p.ProductId == 1);

              Product resultfin = _products.Find(p => p.ProductId > 2);
              Console.WriteLine(resultfin.Name);
              var resultFindall = _products.FindAll(p => p.CategoryId == 1);
              var resultOrderny = _products.Where(p => p.CategoryId==1).OrderByDescending(p=>p.UnitPrice).ThenBy(p=>p.Name);
              Console.WriteLine("--------------------");
              foreach (var item in resultOrderny)
              {
                  Console.WriteLine(item.Name);
              }
            */
            var result = from p in _products 
                         join c in _categories on 
                         p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 1000
                         orderby p.UnitPrice, p.Name descending
                         select new ProductDto { ProductId = p.ProductId, Name = p.Name, CategoryName = c.CategoryName };
            foreach (var item in result)
            {
                Console.WriteLine(item.Name+" "+item.CategoryName);
            }
            Console.ReadLine();


        }
    }
    class Product
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }

    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
    class ProductDto
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
    }

}
