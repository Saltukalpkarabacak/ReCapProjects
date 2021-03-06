using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetProductDetails();
            

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + "\t" + item.BrandName + "\t" + item.ColorName + "\t" + item.DailyPrice);
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.Id + "\t" + item.Name);
                Console.WriteLine(" ");
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.Id + "\t" + item.Name);
                Console.WriteLine(" ");
            }
        }


        private static void CarTest()
        {
            //CarManager CarManager = new CarManager(new InMemoryCarDal());
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.Write(car.Id + "\t");
                Console.Write(car.BrandId + "\t");
                Console.Write(car.ColorId + "\t");
                Console.Write(car.DailyPrice + "\t");
                Console.Write(car.ModelYear + "\t");
                Console.Write(car.Description + "\t");
                Console.WriteLine(" ");

            }
        }
    }

        

    
}
