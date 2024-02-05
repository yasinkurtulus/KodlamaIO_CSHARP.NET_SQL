using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            _products = new List<Product> {  new Product {CategoryID = 1, ProductID = 1, ProductName = "Car", UnitPrice = 15, UnitsInStock  = 65},
        new Product {CategoryID = 1, ProductID = 2, ProductName = "Glass", UnitPrice = 534, UnitsInStock  = 45},
        new Product {CategoryID = 2, ProductID = 3, ProductName = "Mouse", UnitPrice = 234, UnitsInStock  = 678},
        new Product {CategoryID = 2, ProductID = 4, ProductName = "Hat", UnitPrice = 5, UnitsInStock   = 9},
        new Product {CategoryID = 2, ProductID = 5, ProductName = "Jar", UnitPrice = 16, UnitsInStock  = 7}};
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

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
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
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
