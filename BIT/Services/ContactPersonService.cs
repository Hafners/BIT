using BIT.Data;
using System.Collections.ObjectModel;

namespace BIT.Services
{
    public class ContactPersonService
    {
        public ContactPersonService()
        {
            if (ContactPersons == null)
            {
                ContactPersons = new ObservableCollection<ContactPersonItem>()
                {
                    new ContactPersonItem { Id = 1, FirstName = "Stefan", LastName = "Herrbert", City = "Burgkirchen", Street = "Teststraße 1", Zipcode = "85632", Country = "Deutschland"},
                    new ContactPersonItem { Id = 2, FirstName = "Sepp", LastName = "Hatzenbühler", City = "Fridolfing", Street = "ABC Str. 23", Zipcode = "83531", Country = "Frankreich"},
                    new ContactPersonItem { Id = 3, FirstName = "Paul", LastName = "Baumgartl", City = "Tittmoning", Street = "Baumstraße 31", Zipcode = "84529", Country = "Spanien"},
                };
            }
        }

        public ObservableCollection<ContactPersonItem> ContactPersons { get; set; }

        public IEnumerable<ContactPersonItem> ListContactPersons()
        {
            return ContactPersons;
        }

        public void AddContactPerson(ContactPersonItem item)
        {
            ContactPersons.Add(item);
        }

        public void UpdateContactPerson(ContactPersonItem item)
        {
            var ContactPerson = ContactPersons.Single(x => x.Id == item.Id);
            ContactPerson = item;
        }

        public ContactPersonItem GetContactPerson(int id)
        {
            return ContactPersons.Single(x => x.Id == id);
        }
    }
}

