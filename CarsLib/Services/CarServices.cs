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
    //      public void UpdateCar(Cars car);
    //      void DeleteCar(Cars car);
    //      Cars GetCarByCarId(int carId);
    //      Cars GetCarByYear(int yearId);
    //      Cars GetCarByBrand(int brandId);
    // }
}