using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal ıproductdal;
        public ProductManager(IProductDal ıp)
        {
            ıproductdal = ıp;
        }
      
        public List<Product> GetAll()
        {
            //iş
            return ıproductdal.GetAll();

        }
    }
}
