using Business.Concrate;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
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
            InMemoryCarDal ınMemoryDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(ınMemoryDal);
            carManager.Add(new Car { CarId = 4, ColorId = 3, BrandId = 5, DailyPrice = 2000, Desciription = "orange car", ModelYear = 2009 });
            Console.WriteLine(carManager.GetById(4).Desciription);
            Car newCar = new Car { CarId = 4, ColorId = 3, BrandId = 5, DailyPrice = 3000, Desciription = "orange car new", ModelYear = 2009 };
            carManager.Update(newCar);
            Console.WriteLine("after update-----------");
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Desciription);
            }
            
         



        }
    }
}
