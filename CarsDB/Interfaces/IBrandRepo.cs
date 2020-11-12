using System.Collections.Generic;
using CarsDB.Models;

namespace CarsDB.Interfaces
{
    public interface IBrandRepo
    {
        void AddBrand(Brands brand);
        void UpdateBrand(Brands brands);
        void DeleteBrand(Brands brand);
        List<Brands> GetAllBrands();
        Brands GetBrandById(int brandId);
        
    }
}