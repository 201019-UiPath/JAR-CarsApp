using System.Collections.Generic;
using CarsDB.Models;

namespace CarsDB.Interfaces
{
    public interface ICustomerRepo
    {
       void AddCustomer(Customer customer);
       void UpdateCustomer(Customer customer);
       void DeleteCustomer(Customer customer);
       List<Customer> GetAllCustomers();
       Customer GetCustomerById(int custId);
    }
}