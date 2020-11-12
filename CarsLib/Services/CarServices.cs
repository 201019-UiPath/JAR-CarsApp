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
    }
}