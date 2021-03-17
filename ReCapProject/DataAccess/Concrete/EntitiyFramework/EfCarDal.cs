using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthWindContext>, ICarDal
    {
        

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join brand in context.Brands 
                             on car.BrandId equals brand.Id
                             join ımage in context.CarImages
                             on car.Id equals ımage.CarId
                             
                             select new CarDetailDto()
                             {
                                 Id = car.Id,
                                 BrandId = brand.Id,
                                 BrandName = brand.Name,
                                 ColorId = color.Id,
                                 ColorName = color.Name,
                                 DailyPrice = car.DailyPrice,
                                 Image=ımage.ImagePath
                              };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        
    }
}
