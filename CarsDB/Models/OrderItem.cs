namespace CarsDB.Models
{
    public class OrderItem
    {
        public int Id {get; set;}
        public int carId {get; set;}
        public int orderId {get; set;}
        public int totalItems {get; set;}
    }
}