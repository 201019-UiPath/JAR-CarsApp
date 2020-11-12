using CarsDB.Interfaces;
using CarsDB.Models;
using System;
using System.Collections.Generic;

namespace CarsLib.Services

{
    public class BrandServices
    {
        private IBrandRepo repo;

        public BrandServices(IBrandRepo repo)
        {
            this.repo = repo;
        }

        public void AddBrand(Brands brand)
        {
            repo.AddBrand(brand);
        }
        public void UpdateBrand(Brands brands)
        {
            repo.UpdateBrand(brands);
        }
        public void DeleteBrand(Brands brand)
        {
            repo.DeleteBrand(brand);
        }
        public List<Brands> GetAllBrands()
        {
            List<Brands> brands = repo.GetAllBrands();
            return brands;
        }
        public Brands GetBrandById(int brandId)
        {
            Brands brand = repo.GetBrandById(brandId);
            return brand;
        }  


    }
}