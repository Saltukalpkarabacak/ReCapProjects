using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car>_cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=120000,ModelYear=2020,Description="Awesome car"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=130000,ModelYear=2020,Description="Awesome car"},
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=110000,ModelYear=2020,Description="Awesome car"},
                new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=150000,ModelYear=2020,Description="Awesome car"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ USING 
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            Car carToFind = _cars.SingleOrDefault(c => c.Id == Id);

            return carToFind;
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //LINQ USING 
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
