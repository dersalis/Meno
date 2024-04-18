using Meno.Core.ValueObjects;

namespace Meno.Core.Entities
{
    public class MenuItem : BaseEntity
    {
        public MenuItemName Name { get; private set; }
        public MenuItemDescription Description { get; private set; }
        public MenuItemPrice Price { get; private set; }
        public Category? Category { get; private set; }
        public ID? CategoryId { get; private set; }

        public MenuItem(MenuItemName name, MenuItemDescription description, MenuItemPrice price, Category category)
            : base(null, null, null, null)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            CategoryId = category.Id;
        }

        public void ChangeName(string name)
        {
            Name = new MenuItemName(name);
        }

        public void ChangeDescription(string description)
        {
            Description = new MenuItemDescription(description);
        }

        public void ChangePrice(decimal price)
        {
            Price = new MenuItemPrice(price);
        }

        public void ChangeCategory(Category category)
        {
            Category = category;
            CategoryId = category.Id;
        }
    }
}