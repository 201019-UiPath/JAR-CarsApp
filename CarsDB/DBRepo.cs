using System.Threading;
using System;
using System.Collections.Generic;
using CarsDB.Interfaces;
using CarsDB.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarsDB
{
    public class DBRepo : ICarRepoMethods
    {   
        private CarsContext context = new CarsContext();
        
        public DBRepo(CarsContext context){

            this.context = context;

        }

        public void AddCar(Cars car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public void DeleteCar(Cars car)
        {
            context.Cars.Remove(car);
            context.SaveChanges();
        }

        public List<Cars> GetAllCars()
        {
            List<Cars> car = context.Cars.Select(c => c).ToList();
            return car;
        }

        public Cars GetCarByBrand(int brandId)
        {
            Cars car = context.Cars.Single(c => c.brandId == brandId);
            return car;
        }

        public Cars GetCarByCarId(int carId)
        {
            Cars car = context.Cars.Single(c => c.Id == carId);
            return car;
        }

        public Cars GetCarByYear(int yearId)
        {
            Cars car = context.Cars.Single(c => c.yearId == yearId);
            return car;
        }

        public void UpdateCare(Cars car)
        {
            context.Cars.Update(car);
            context.SaveChanges();
        }
    }
}