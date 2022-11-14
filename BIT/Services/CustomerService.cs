using BIT.Data;
using System.Collections.ObjectModel;

namespace BIT.Services
{
    public class CustomerService
    {
        public CustomerService()
        {
            if (Customers == null)
            {
                Customers = new ObservableCollection<CustomerItem>()
                {
                    new CustomerItem { Id = 1, Name = "InfraServ GmbH", City = "Burgkirchen", Street = "Teststraße 1", Zipcode = "85632", CustomerNumber = 1},
                    new CustomerItem { Id = 2, Name = "Otto Chemie GmbH", City = "Fridolfing", Street = "ABC Str. 23", Zipcode = "83531", CustomerNumber = 2},
                    new CustomerItem { Id = 3, Name = "Siloking GmbH", City = "Tittmoning", Street = "Baumstraße 31", Zipcode = "84529", CustomerNumber = 3},
                };
            }
        }

        public ObservableCollection<CustomerItem> Customers { get; set; }

        public IEnumerable<CustomerItem> ListCustomers()
        {
            return Customers;
        }

        public void AddCustomer(CustomerItem item)
        {
            Customers.Add(item);
        }

        public void UpdateCustomer(CustomerItem item)
        {
            var customer = Customers.Single(x => x.Id == item.Id);
            customer = item;
        }

        public CustomerItem GetCustomer(int id)
        {
            return Customers.Single(x => x.Id == id);
        }
    }
}
