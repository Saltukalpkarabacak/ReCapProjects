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
        public List<CarDetailDto> GetProductDetails()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors 
                             on p.ColorId equals c.Id
                             join b in context.Brands
                             on c.Id equals b.Id
                             select new CarDetailDto
                             {
                                Id = p.Id,
                                BrandName=b.Name,
                                ColorName=c.Name,
                                DailyPrice=p.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
