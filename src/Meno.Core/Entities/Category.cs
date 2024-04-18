using Meno.Core.ValueObjects;

namespace Meno.Core.Entities
{
    public class Category : BaseEntity
    {
        public CategoryName Name { get; set; }
        public CategoryDescription Description { get; set; }

        public Category(CategoryName name, CategoryDescription description)
            : base(null, null, null, null)
        {
            Name = name;
            Description = description;
        }

        public void ChangeName(string name)
        {
            Name = new CategoryName(name);
        }

        public void ChangeDescription(string description)
        {
            Description = new CategoryDescription(description);
        }
    }
}