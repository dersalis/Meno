using FizzWare.NBuilder;
using Meno.Core.Entities;
using Meno.Core.ValueObjects;

namespace Meno.Infrastructure.DAL
{
    public class FakeDataGenerator
    {
        private static List<User> _users = null;
        private static List<Place> _places = null;
        private static List<Category> _categories = null;
        private static List<Menu> _menus = null;
        private static List<MenuItem> _menuItems = null;

        

        public static User CreateSystemUser()
        {
            User user = new User(
                new UserName("System"),
                new Login("system"),
                new Email("system@system.pl"),
                new Password("P@$$w0rd"));

            _users.Add(user);

            return user;
        }

        public static List<Category> GenerateCategories()
        {
            if (_categories == null)
            {
                User user = CreateSystemUser();

                _categories = Builder<Category>
                .CreateListOfSize(10)
                .All()
                .WithFactory(() => new Category(
                    new CategoryName(Faker.Company.CatchPhrase()),
                    new CategoryDescription(Faker.Company.CatchPhrase())
                ))
                .Do(w => w.ChangeCreateDate(new TimeStamp(DateTime.Now)))
                .Do(w => w.ChangeCreatedBy(user))
                .Build()
                .ToList();
            }

            return _categories;
        }

        public static List<MenuItem> GenerateMenuItems()
        {
            if (_menuItems == null)
            {
                User user = CreateSystemUser();
                List<Category> categories = GenerateCategories();
                Random rand = new Random();

                _menuItems = Builder<MenuItem>
                .CreateListOfSize(30)
                .All()
                .WithFactory(() => new MenuItem(
                    new MenuItemName(Faker.Company.CatchPhrase()),
                    new MenuItemDescription(Faker.Company.CatchPhrase()),
                    new MenuItemPrice(Faker.RandomNumber.Next(1, 100)),
                    categories[rand.Next(0, categories.Count)]
                ))
                .Do(w => w.ChangeCreateDate(new TimeStamp(DateTime.Now)))
                .Do(w => w.ChangeCreatedBy(user))
                .Build()
                .ToList();
            }

            return _menuItems;
        }

        public static List<Menu> GenerateMenus()
        {
            if (_menus == null)
            {
                User user = CreateSystemUser();
                List<MenuItem> menuItems = GenerateMenuItems();
                Random rand = new Random();

                _menus = Builder<Menu>
                .CreateListOfSize(3)
                .All()
                .WithFactory(() => new Menu(
                    new MenuName(Faker.Company.CatchPhrase()),
                    new MenuDescription(Faker.Company.CatchPhrase())
                ))
                .Do(w => w.AddMenuItem(menuItems[rand.Next(0, menuItems.Count)]))
                .Do(w => w.AddMenuItem(menuItems[rand.Next(0, menuItems.Count)]))
                .Do(w => w.AddMenuItem(menuItems[rand.Next(0, menuItems.Count)]))
                .Do(w => w.AddMenuItem(menuItems[rand.Next(0, menuItems.Count)]))
                .Do(w => w.ChangeCreateDate(new TimeStamp(DateTime.Now)))
                .Do(w => w.ChangeCreatedBy(user))
                .Build()
                .ToList();
            }

            return _menus;
        }

        public static List<Place> GeneratePlaces()
        {
            if (_places == null)
            {
                User user = CreateSystemUser();
                Random rand = new Random();

                _places = Builder<Place>
                .CreateListOfSize(3)
                .All()
                .WithFactory(() => new Place(
                    new PlaceName(Faker.Company.Name()),
                    new PlaceDescription(Faker.Company.CatchPhrase()),
                    new Address(Faker.Address.StreetAddress()),
                    new City(Faker.Address.City()),
                    new PostalCode(Faker.Address.ZipCode()),
                    new Country(Faker.Address.Country()),
                    new Phone(Faker.Phone.Number()),
                    new Email(Faker.Internet.Email())
                ))
                .Do(w => w.AddMenu(GenerateMenus()[rand.Next(0, GenerateMenus().Count)]))
                .Do(w => w.ChangeCreateDate(new TimeStamp(DateTime.Now)))
                .Do(w => w.ChangeCreatedBy(user))
                .Build()
                .ToList();
            }

            return _places;
        }

        public static List<User> GenerateUsers()
        {
            if (_users == null)
            {
                User user = CreateSystemUser();
                Random rand = new Random();

                _users = Builder<User>
                .CreateListOfSize(3)
                .All()
                .WithFactory(() => new User(
                    new UserName(Faker.Name.FullName()),
                    new Login(Faker.Internet.Email()),
                    new Email(Faker.Internet.Email()),
                    new Password("P@$$w0rd")
                ))
                .Do(w => w.AddPlace(GeneratePlaces()[rand.Next(0, GeneratePlaces().Count)]))
                .Do(w => w.ChangeCreateDate(new TimeStamp(DateTime.Now)))
                .Do(w => w.ChangeCreatedBy(user))
                .Build()
                .ToList();
            }

            return _users;
        }
        
    }

}