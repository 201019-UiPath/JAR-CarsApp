using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using CarsDB.Models;

namespace CarsDB
{
    public class CarsContext : DbContext
    {
        public DbSet<Brands> Brands {get; set;}
        public DbSet<Cars> Cars {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            //if no connection to database configure one 
            if(!optionsBuilder.IsConfigured)
            {
                //look for json file to configure 
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


                var connectionString = configuration.GetConnectionString("CarsDB");

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // code here
        }
    }

}