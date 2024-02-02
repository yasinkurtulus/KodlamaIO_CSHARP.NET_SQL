using DataAccess.Absract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal

    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car { CarId = 1, BrandId = 2, ColorId = 3, ModelYear = 2010, DailyPrice = 1000, Desciription = "Red Car" } ,
                                    new Car { CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 2000, Desciription = "Black Car" },
                                    new Car { CarId = 3, BrandId = 3, ColorId = 2, ModelYear = 2023, DailyPrice = 6000, Desciription = "Blue Car" }};
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int ıd)
        {
            return  _cars.SingleOrDefault(c => c.CarId == ıd);
        }

        public void Update(Car car)
        {
           Car carToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Desciription = car.Desciription;

        }
    }
}
