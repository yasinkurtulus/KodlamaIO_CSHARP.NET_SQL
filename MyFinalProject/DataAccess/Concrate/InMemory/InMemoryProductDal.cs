using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Unipluss.Sign.ExternalContract.Entities;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
      
          List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {  new Product {CategoryID = 1, ProductID = 1, ProductName = "Car", Price = 15, UnitInStocks = 65},
        new Product {CategoryID = 1, ProductID = 2, ProductName = "Glass", Price = 534, UnitInStocks = 45},
        new Product {CategoryID = 2, ProductID = 3, ProductName = "Mouse", Price = 234, UnitInStocks = 678},
        new Product {CategoryID = 2, ProductID = 4, ProductName = "Hat", Price = 5, UnitInStocks = 9},
        new Product {CategoryID = 2, ProductID = 5, ProductName = "Jar", Price = 16, UnitInStocks = 7}};
        }
        public void add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            /*foreach (var item in _products)
            {
                if (item.ProductID==product.ProductID)
                {
                    productToDelete = item;
                }
            }
            MANUEL
            */
            productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategories(int categoryId)
        {
            /*  List<Product> returnlist=new List<Product>();
              foreach (var item in _products)
              {
                  if (item.CategoryID==categoryId)
                  {
                      returnlist.Add(item);
                  }
              }
              return returnlist;*/
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.Price = product.Price;
            productToUpdate.UnitInStocks = product.UnitInStocks;
        }
    }
}
