using System.Collections.Generic;
using CarsDB.Models;
namespace CarsDB.Interfaces
{
    public interface ICarRepoMethods
    {
         List<Cars> GetAllCars();
         void AddCar(Cars car); 
         void UpdateCare(Cars car);
         void DeleteCar(Cars car);
         Cars GetCarByCarId(int carId);
         Cars GetCarByYear(int yearId);
         Cars GetCarByBrand(int brandId);
    }


}