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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, NorthWindContext>, IRentalDal
    {
        

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from rental in context.Rentals 
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join user in context.UsersR 
                             on rental.CustomerId equals user.Id 
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 BrandName = brand.Name,
                                 Name=user.FirstName+" "+user.LastName,
                                 RentDate=rental.RentDate,
                                 ReturnDate=rental.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
