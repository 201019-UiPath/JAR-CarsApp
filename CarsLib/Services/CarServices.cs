using CarsDB.Models;
using CarsDB;
using CarsDB.Interfaces;

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
            List<Cars> cars = repo.GetAllCar();
            return cars; 
        }
    }
}