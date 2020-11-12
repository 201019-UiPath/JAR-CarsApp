using CarsDB.Interfaces;
using System;



namespace CarsLib.Services

{
    public class BrandServices
    {
        private IBrandRepo repo;

        public BrandServices(IBrandRepo repo)
        {
            this.repo = repo;
        }
    }
}