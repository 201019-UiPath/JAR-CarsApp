using System.Collections.Generic;
using CarsDB.Interfaces;
using CarsDB.Models;

namespace CarsLib.Services
{
    public class CustomerServices
    {

        private ICustomerRepo repo;

        public CustomerServices(ICustomerRepo repo)
        {
            this.repo = repo;
        }

        public void AddCustomer(Customer customer)
        {
            repo.AddCustomer(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            repo.UpdateCustomer(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            repo.DeleteCustomer(customer);
        }
        public List<Customer> GetAllCustomers()
        {
            List<Customer> custs = repo.GetAllCustomers();
            return custs;
        }
        public Customer GetCustomerById(int custId)
        {
            Customer cust = repo.GetCustomerById(custId);
            return cust;
        }
    }
}