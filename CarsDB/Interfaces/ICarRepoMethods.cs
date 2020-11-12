using System.Collections.Generic;
using CarsDB.Models;
namespace CarsDB.Interfaces
{
    public interface ICarRepoMethods
    {
         List<Cars> GetAllCars();
    }
}