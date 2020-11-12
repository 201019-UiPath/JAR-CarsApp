using System;

namespace CarsDB.Models
{
    public class Order
    {
        public int Id {get; set;}
        public int customerId {get; set;}
        public int locationId {get; set;}
        public DateTime date {get; set;}
        public int price {get; set;}
    }
}