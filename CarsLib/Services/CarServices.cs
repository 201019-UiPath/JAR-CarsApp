using CarsDB.Models;
using CarsDB;
using CarsDB.Interfaces;
using System.Collections.Generic;

namespace CarsLib.Services
{
    public class CarServices
    {
        private ICarRepoMethods repo;

        public CarServices(ICarRepoMethods repo)
        {
            this.repo = repo;
        }

        public List<Cars> GetAllCar()
        {
            List<Cars> cars = repo.GetAllCars();
            return cars;
        }

        public void AddCar(Cars car)
        {
            repo.AddCar(car);
        }
        public void UpdateCar(Cars car)
        {
            repo.UpdateCar(car);
        }
        public void DeleteCar(Cars car)
        {
            repo.DeleteCar(car);
        }
        public Cars GetCarByCarId(int carId)
        {
            Cars car = repo.GetCarByCarId(carId);
            return car;
        }
        Cars GetCarByYear(int yearId)
        {
            Cars car = repo.GetCarByYear(yearId);
            return car;
        }
        public Cars GetCarByBrand(int brandId)
        {
            Cars car = repo.GetCarByBrand(brandId);
            return car;
        }
    }
}