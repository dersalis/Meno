using Meno.Core.ValueObjects;

namespace Meno.Core.Entities
{
    public class Menu : BaseEntity
    {
        public MenuName Name { get; private set; }
        public MenuDescription Description { get; private set; }
        public IEnumerable<MenuItem> MenuItems => _menuItems;

        private readonly HashSet<MenuItem> _menuItems = new();

        public Menu() : base(null, null, null, null)
        {
        }

        public Menu(MenuName name, MenuDescription description)
            : base(null, null, null, null)
        {
            Name = name;
            Description = description;
        }

        public void ChangeName(string name)
        {
            Name = new MenuName(name);
        }

        public void ChangeDescription(string description)
        {
            Description = new MenuDescription(description);
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _menuItems.Add(menuItem);
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            _menuItems.Remove(menuItem);
        }
    }
}