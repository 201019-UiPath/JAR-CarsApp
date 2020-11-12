using CarsDB.Models;
using CarsDB;

namespace CarsLib.Services
{
    public class CarServices
    {
        private ICarRepoMethod repo; 

        public CarServices(ICarRepoMethod repo)
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