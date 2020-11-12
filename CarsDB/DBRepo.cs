using System.Threading;
using System;
using System.Collections.Generic;
using CarsDB.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CarsDB.Interfaces;

namespace CarsDB
{
    public class DBRepo : ICarRepoMethods, IBrandRepo, ICustomerRepo
    {   
        private CarsContext context = new CarsContext();
        
        public DBRepo(CarsContext context){

            this.context = context;

        }

        public void AddBrand(Brands brand)
        {
            context.Brands.Add(brand);
            context.SaveChanges();
        }

        public void AddCar(Cars car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            context.Customer.Add(customer);
            context.SaveChanges();
        }

        public void DeleteBrand(Brands brand)
        {
            context.Brands.Add(brand);
            context.SaveChanges();
        }

        public void DeleteCar(Cars car)
        {
            context.Cars.Remove(car);
            context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            context.Customer.Remove(customer);
            context.SaveChanges();
        }

        public List<Brands> GetAllBrands()
        {
            List<Brands> brands = context.Brands.Select(b => b).ToList();
            return brands;
        }

        public List<Cars> GetAllCars()
        {
            List<Cars> car = context.Cars.Select(c => c).ToList();
            return car;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> cust = context.Customer.Select(c => c).ToList();
            return cust;
        }

        public Brands GetBrandById(int brandId)
        {
            Brands brands = context.Brands.Single(b => b.Id == brandId);
            return brands;
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

        public Customer GetCustomerById(int custId)
        {
            Customer cust = context.Customer.Single(c => c.Id == custId);
            return cust;
        }

        public void UpdateBrand(Brands brands)
        {
            context.Brands.Update(brands);
            context.SaveChanges();
        }

        public void UpdateCar(Cars car)
        {
            context.Cars.Update(car);
            context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Customer.Update(customer);
            context.SaveChanges();
        }

    }
}