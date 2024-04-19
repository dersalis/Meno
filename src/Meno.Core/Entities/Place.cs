using Meno.Core.ValueObjects;

namespace Meno.Core.Entities
{
    public class Place : BaseEntity
    {
        public PlaceName Name { get; private set; }
        public PlaceDescription Description { get; private set; }
        public Address Address { get; private set; }
        public City City { get; private set; }
        public PostalCode PostalCode { get; private set; }
        public Country Country { get; private set; }
        public Phone Phone { get; private set; }
        public Email Email { get; private set; }
        public IEnumerable<Menu> Menus => _menus;

        private readonly HashSet<Menu> _menus = new();

        public Place(PlaceName name, PlaceDescription description, Address address, City city, PostalCode postalCode, Country country, Phone phone, Email email)
            : base(null, null, null, null)
        {
            Name = name;
            Description = description;
            Address = address;
            City = city;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Email = email;
        }

        public void ChangeName(string name)
        {
            Name = new PlaceName(name);
        }

        public void ChangeDescription(string description)
        {
            Description = new PlaceDescription(description);
        }

        public void ChangeAddress(string address)
        {
            Address = new Address(address);
        }

        public void ChangeCity(string city)
        {
            City = new City(city);
        }

        public void ChangePostalCode(string postalCode)
        {
            PostalCode = new PostalCode(postalCode);
        }   

        public void ChangeCountry(string country)
        {
            Country = new Country(country);
        }   

        public void ChangePhone(string phone)
        {
            Phone = new Phone(phone);
        }

        public void ChangeEmail(string email)
        {
            Email = new Email(email);
        }

        public void AddMenu(Menu menu)
        {
            _menus.Add(menu);
        }

        public void RemoveMenu(Menu menu)
        {
            _menus.Remove(menu);
        }
    }
}