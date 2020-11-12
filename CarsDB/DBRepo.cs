using System.Threading;
using System;
using System.Collections.Generic;
using CarsDB.Interfaces;
using CarsDB.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarsDB
{
    public class DBRepo : ICarRepoMethods
    {   
        private CarsContext context = new CarsContext();
        
        public DBRepo(CarsContext context){

            this.context = context;

        }

        public List<Cars> GetAllCars(){

            return context.Cars.Select(x=> x).ToList();
        }
    }
}