using Business.Abstract;
using DataAccess.Absract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal ıCarDal;
        public CarManager(ICarDal ıcd)
        {
            ıCarDal = ıcd;
        }
        public void Add(Car car)
        {
            //Businnes Code
            ıCarDal.Add(car);

        }

        public void Delete(Car car)
        {
            //BusinnesCode
            ıCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //BusinesCode
           return ıCarDal.GetAll();
        }

        public Car GetById(int id)
        {
            //BusinessCode
            return ıCarDal.GetById(id);
        }
        

        public void Update(Car car)
        {
            //BUsinenssCode
            
            ıCarDal.Update(car);
        }
    }
}
